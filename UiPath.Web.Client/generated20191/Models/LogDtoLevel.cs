// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LogDtoLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LogDtoLevel
    {
        [EnumMember(Value = "Trace")]
        Trace,
        [EnumMember(Value = "Debug")]
        Debug,
        [EnumMember(Value = "Info")]
        Info,
        [EnumMember(Value = "Warn")]
        Warn,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "Fatal")]
        Fatal
    }
    internal static class LogDtoLevelEnumExtension
    {
        internal static string ToSerializedValue(this LogDtoLevel? value)
        {
            return value == null ? null : ((LogDtoLevel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LogDtoLevel value)
        {
            switch( value )
            {
                case LogDtoLevel.Trace:
                    return "Trace";
                case LogDtoLevel.Debug:
                    return "Debug";
                case LogDtoLevel.Info:
                    return "Info";
                case LogDtoLevel.Warn:
                    return "Warn";
                case LogDtoLevel.Error:
                    return "Error";
                case LogDtoLevel.Fatal:
                    return "Fatal";
            }
            return null;
        }

        internal static LogDtoLevel? ParseLogDtoLevel(this string value)
        {
            switch( value )
            {
                case "Trace":
                    return LogDtoLevel.Trace;
                case "Debug":
                    return LogDtoLevel.Debug;
                case "Info":
                    return LogDtoLevel.Info;
                case "Warn":
                    return LogDtoLevel.Warn;
                case "Error":
                    return LogDtoLevel.Error;
                case "Fatal":
                    return LogDtoLevel.Fatal;
            }
            return null;
        }
    }
}
