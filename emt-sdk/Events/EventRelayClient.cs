﻿using Google.Protobuf;
using Naki3D.Common.Protocol;
using System;
using System.Net.Sockets;
using System.Threading;
using static emt_sdk.Events.EventManager;

namespace emt_sdk.Events
{
    /// <summary>
    /// Client event relaying connection for any external applications using emt_sdk events.
    /// Receives master local, remote and events sent through this client.
    /// </summary>
    public class EventRelayClient
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Whether the client is currently connected to a server. Verify this before sending any events
        /// </summary>
        public bool IsConnected { get; private set; }

        /// <summary>
        /// Token for closing socket connection, may be closed after receiving one more event
        /// </summary>
        public CancellationToken CancellationToken => _tokenSource.Token;

        /// <summary>
        /// Called whenever a <see cref="SensorMessage"/> is received from relay server
        /// </summary>
        public event SensorMessageHandler OnEventReceived;

        private CancellationTokenSource _tokenSource;
        private NetworkStream _stream;

        /// <summary>
        /// Connects to a master server for sending and receiving events, only tries the loopback interface.
        /// Blocking call, run this in a separate thread/task.
        /// </summary>
        /// <exception cref="SocketException">Thrown on any socket related problem</exception>
        /// <param name="port">Target server port</param>
        public void Connect(int port = EventRelayServer.RELAY_PORT)
        {
            var client = new TcpClient("localhost", port);

            _tokenSource = new CancellationTokenSource();
            using (_tokenSource.Token.Register(() => client.Close()))
            {
                try
                {
                    _stream = client.GetStream();
                    Logger.Info($"Connected to relay server on port {port}");
                    IsConnected = true;

                    while (true)
                    {
                        var sensorEvent = SensorMessage.Parser.ParseDelimitedFrom(_stream);
                        if (sensorEvent.DataCase == SensorMessage.DataOneofCase.None) continue;
                        OnEventReceived?.Invoke(this, sensorEvent);
                    }
                }
                catch (SocketException e)
                {
                    Logger.Warn(e, "Exception during relay client shutdown");
                    throw e;
                }
                finally
                {
                    if (client.Connected) client.Close();
                    IsConnected = false;
                }
            }
        }

        /// <summary>
        /// Broadcasts an event to the master relay server which will send it to all other connected devices.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when passed event is null</exception>
        /// <exception cref="InvalidOperationException">Thrown when client is not connected</exception>
        /// <param name="message">Event to be sent</param>
        public void BroadcastEvent(SensorMessage message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (!IsConnected)
            {
                Logger.Error("Trying to send event despite not being connected, relay is in inconsistent state");
                throw new InvalidOperationException("Cannot relay event, no connection estabilished");
            }

            message.WriteDelimitedTo(_stream);
        }
    }
}
