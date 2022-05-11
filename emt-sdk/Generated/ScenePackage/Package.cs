﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace emt_sdk.Generated.ScenePackage
{
    public partial class PackageDescriptor
    {
        [JsonProperty("$schema")]
        public string Schema { get; set; }

        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Action> Inputs { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("package")]
        public Package Package { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Parameters Parameters { get; set; }

        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public Sync Sync { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public partial class Action
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("mapping")]
        public Mapping Mapping { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }

    public partial class Mapping
    {
        [JsonProperty("eventName", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Condition? Condition { get; set; }

        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string Threshold { get; set; }

        [JsonProperty("thresholdType", NullValueHandling = NullValueHandling.Ignore)]
        public ThresholdType? ThresholdType { get; set; }

        [JsonProperty("inMax", NullValueHandling = NullValueHandling.Ignore)]
        public double? InMax { get; set; }

        [JsonProperty("inMin", NullValueHandling = NullValueHandling.Ignore)]
        public double? InMin { get; set; }

        [JsonProperty("outMax", NullValueHandling = NullValueHandling.Ignore)]
        public double? OutMax { get; set; }

        [JsonProperty("outMin", NullValueHandling = NullValueHandling.Ignore)]
        public double? OutMin { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("exposition")]
        public string Exposition { get; set; }

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public List<Other> Other { get; set; }

        [JsonProperty("packageName", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }
    }

    public partial class Other
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Package
    {
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Parameters
    {
        [JsonProperty("displayType", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayType { get; set; }

        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        public Settings Settings { get; set; }
    }

    public partial class Settings
    {
        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }

        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public Layout Layout { get; set; }

        [JsonProperty("layoutType", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutType? LayoutType { get; set; }

        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public Vector2 Padding { get; set; }

        [JsonProperty("scrollDelay", NullValueHandling = NullValueHandling.Ignore)]
        public double? ScrollDelay { get; set; }

        [JsonProperty("slideAnimationLength", NullValueHandling = NullValueHandling.Ignore)]
        public double? SlideAnimationLength { get; set; }

        [JsonProperty("cameraAnimation", NullValueHandling = NullValueHandling.Ignore)]
        public CameraAnimation CameraAnimation { get; set; }

        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("flagInteraction", NullValueHandling = NullValueHandling.Ignore)]
        public FlagInteraction? FlagInteraction { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModelFlag> Flags { get; set; }

        [JsonProperty("skybox", NullValueHandling = NullValueHandling.Ignore)]
        public string Skybox { get; set; }

        [JsonProperty("skyboxTint", NullValueHandling = NullValueHandling.Ignore)]
        public string SkyboxTint { get; set; }

        [JsonProperty("aspectRatio", NullValueHandling = NullValueHandling.Ignore)]
        public AspectRatio? AspectRatio { get; set; }

        [JsonProperty("autoStart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoStart { get; set; }

        [JsonProperty("loop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loop { get; set; }

        [JsonProperty("videoEvents", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoEvent> VideoEvents { get; set; }

        [JsonProperty("rotationSpeed", NullValueHandling = NullValueHandling.Ignore)]
        public double? RotationSpeed { get; set; }

        [JsonProperty("cameraVerticalAngle", NullValueHandling = NullValueHandling.Ignore)]
        public double? CameraVerticalAngle { get; set; }
    }

    public partial class CameraAnimation
    {
        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Distance { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        [JsonProperty("lookAt", NullValueHandling = NullValueHandling.Ignore)]
        public ModelCameraTarget LookAt { get; set; }

        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public ModelCameraTarget Origin { get; set; }

        [JsonProperty("revolutionTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? RevolutionTime { get; set; }
    }

    public partial class ModelCameraTarget
    {
        [JsonProperty("objectName", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public Vector3 Offset { get; set; }
    }

    public partial class Vector3
    {
        [JsonProperty("X", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }

        [JsonProperty("Y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }

        [JsonProperty("Z", NullValueHandling = NullValueHandling.Ignore)]
        public double? Z { get; set; }
    }

    public partial class ModelFlag
    {
        [JsonProperty("activatedAction", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivatedAction { get; set; }

        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }

        [JsonProperty("canSelect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanSelect { get; set; }

        [JsonProperty("foregroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string ForegroundColor { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Vector3 Location { get; set; }

        [JsonProperty("selectedAction", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedAction { get; set; }

        [JsonProperty("stalkColor", NullValueHandling = NullValueHandling.Ignore)]
        public string StalkColor { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }

    public partial class Layout
    {
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        [JsonProperty("horizontalSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? HorizontalSpacing { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public List<GalleryImage> Images { get; set; }

        [JsonProperty("verticalSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? VerticalSpacing { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public double? Spacing { get; set; }

        [JsonProperty("visibleImages", NullValueHandling = NullValueHandling.Ignore)]
        public double? VisibleImages { get; set; }
    }

    public partial class GalleryImage
    {
        [JsonProperty("activatedEvent", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivatedEvent { get; set; }

        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("selectedEvent", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedEvent { get; set; }
    }

    public partial class Vector2
    {
        [JsonProperty("X", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }

        [JsonProperty("Y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }
    }

    public partial class VideoEvent
    {
        [JsonProperty("eventName", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }

    public partial class Sync
    {
        [JsonProperty("canvasDimensions")]
        public CanvasDimensions CanvasDimensions { get; set; }

        [JsonProperty("elements")]
        public List<Element> Elements { get; set; }

        [JsonProperty("selfIndex")]
        public long SelfIndex { get; set; }
    }

    public partial class CanvasDimensions
    {
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }
    }

    public partial class Element
    {
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("viewportTransform")]
        public string ViewportTransform { get; set; }
    }

    public enum Condition { Above, AboveOrEquals, Below, BelowOrEquals, Equals };

    public enum ThresholdType { Float, Integer };

    public enum TypeEnum { Event, Value, ValueTrigger };

    public enum AspectRatio { FitInside, FitOutside, Stretch };

    public enum FlagInteraction { Point, Swipe };

    public enum LayoutType { Grid, List };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ConditionConverter.Singleton,
                ThresholdTypeConverter.Singleton,
                TypeEnumConverter.Singleton,
                AspectRatioConverter.Singleton,
                FlagInteractionConverter.Singleton,
                LayoutTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ConditionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Condition) || t == typeof(Condition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "above":
                    return Condition.Above;
                case "aboveOrEquals":
                    return Condition.AboveOrEquals;
                case "below":
                    return Condition.Below;
                case "belowOrEquals":
                    return Condition.BelowOrEquals;
                case "equals":
                    return Condition.Equals;
            }
            throw new Exception("Cannot unmarshal type Condition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Condition)untypedValue;
            switch (value)
            {
                case Condition.Above:
                    serializer.Serialize(writer, "above");
                    return;
                case Condition.AboveOrEquals:
                    serializer.Serialize(writer, "aboveOrEquals");
                    return;
                case Condition.Below:
                    serializer.Serialize(writer, "below");
                    return;
                case Condition.BelowOrEquals:
                    serializer.Serialize(writer, "belowOrEquals");
                    return;
                case Condition.Equals:
                    serializer.Serialize(writer, "equals");
                    return;
            }
            throw new Exception("Cannot marshal type Condition");
        }

        public static readonly ConditionConverter Singleton = new ConditionConverter();
    }

    internal class ThresholdTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ThresholdType) || t == typeof(ThresholdType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "float":
                    return ThresholdType.Float;
                case "integer":
                    return ThresholdType.Integer;
            }
            throw new Exception("Cannot unmarshal type ThresholdType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ThresholdType)untypedValue;
            switch (value)
            {
                case ThresholdType.Float:
                    serializer.Serialize(writer, "float");
                    return;
                case ThresholdType.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
            }
            throw new Exception("Cannot marshal type ThresholdType");
        }

        public static readonly ThresholdTypeConverter Singleton = new ThresholdTypeConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "event":
                    return TypeEnum.Event;
                case "value":
                    return TypeEnum.Value;
                case "valueTrigger":
                    return TypeEnum.ValueTrigger;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Event:
                    serializer.Serialize(writer, "event");
                    return;
                case TypeEnum.Value:
                    serializer.Serialize(writer, "value");
                    return;
                case TypeEnum.ValueTrigger:
                    serializer.Serialize(writer, "valueTrigger");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class AspectRatioConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AspectRatio) || t == typeof(AspectRatio?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "fitInside":
                    return AspectRatio.FitInside;
                case "fitOutside":
                    return AspectRatio.FitOutside;
                case "stretch":
                    return AspectRatio.Stretch;
            }
            throw new Exception("Cannot unmarshal type AspectRatio");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AspectRatio)untypedValue;
            switch (value)
            {
                case AspectRatio.FitInside:
                    serializer.Serialize(writer, "fitInside");
                    return;
                case AspectRatio.FitOutside:
                    serializer.Serialize(writer, "fitOutside");
                    return;
                case AspectRatio.Stretch:
                    serializer.Serialize(writer, "stretch");
                    return;
            }
            throw new Exception("Cannot marshal type AspectRatio");
        }

        public static readonly AspectRatioConverter Singleton = new AspectRatioConverter();
    }

    internal class FlagInteractionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FlagInteraction) || t == typeof(FlagInteraction?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "point":
                    return FlagInteraction.Point;
                case "swipe":
                    return FlagInteraction.Swipe;
            }
            throw new Exception("Cannot unmarshal type FlagInteraction");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FlagInteraction)untypedValue;
            switch (value)
            {
                case FlagInteraction.Point:
                    serializer.Serialize(writer, "point");
                    return;
                case FlagInteraction.Swipe:
                    serializer.Serialize(writer, "swipe");
                    return;
            }
            throw new Exception("Cannot marshal type FlagInteraction");
        }

        public static readonly FlagInteractionConverter Singleton = new FlagInteractionConverter();
    }

    internal class LayoutTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutType) || t == typeof(LayoutType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "grid":
                    return LayoutType.Grid;
                case "list":
                    return LayoutType.List;
            }
            throw new Exception("Cannot unmarshal type LayoutType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LayoutType)untypedValue;
            switch (value)
            {
                case LayoutType.Grid:
                    serializer.Serialize(writer, "grid");
                    return;
                case LayoutType.List:
                    serializer.Serialize(writer, "list");
                    return;
            }
            throw new Exception("Cannot marshal type LayoutType");
        }

        public static readonly LayoutTypeConverter Singleton = new LayoutTypeConverter();
    }
}
