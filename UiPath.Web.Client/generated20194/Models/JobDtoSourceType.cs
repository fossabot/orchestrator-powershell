// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobDtoSourceType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobDtoSourceType
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Schedule")]
        Schedule,
        [EnumMember(Value = "Agent")]
        Agent
    }
    internal static class JobDtoSourceTypeEnumExtension
    {
        internal static string ToSerializedValue(this JobDtoSourceType? value)
        {
            return value == null ? null : ((JobDtoSourceType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobDtoSourceType value)
        {
            switch( value )
            {
                case JobDtoSourceType.Manual:
                    return "Manual";
                case JobDtoSourceType.Schedule:
                    return "Schedule";
                case JobDtoSourceType.Agent:
                    return "Agent";
            }
            return null;
        }

        internal static JobDtoSourceType? ParseJobDtoSourceType(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return JobDtoSourceType.Manual;
                case "Schedule":
                    return JobDtoSourceType.Schedule;
                case "Agent":
                    return JobDtoSourceType.Agent;
            }
            return null;
        }
    }
}
