// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobDtoType
    {
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Attended")]
        Attended
    }
    internal static class JobDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this JobDtoType? value)
        {
            return value == null ? null : ((JobDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobDtoType value)
        {
            switch( value )
            {
                case JobDtoType.Unattended:
                    return "Unattended";
                case JobDtoType.Attended:
                    return "Attended";
            }
            return null;
        }

        internal static JobDtoType? ParseJobDtoType(this string value)
        {
            switch( value )
            {
                case "Unattended":
                    return JobDtoType.Unattended;
                case "Attended":
                    return JobDtoType.Attended;
            }
            return null;
        }
    }
}
