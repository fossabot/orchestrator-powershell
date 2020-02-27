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
    /// Defines values for RobotDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RobotDtoType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Development")]
        Development
    }
    internal static class RobotDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this RobotDtoType? value)
        {
            return value == null ? null : ((RobotDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RobotDtoType value)
        {
            switch( value )
            {
                case RobotDtoType.NonProduction:
                    return "NonProduction";
                case RobotDtoType.Attended:
                    return "Attended";
                case RobotDtoType.Unattended:
                    return "Unattended";
                case RobotDtoType.Development:
                    return "Development";
            }
            return null;
        }

        internal static RobotDtoType? ParseRobotDtoType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return RobotDtoType.NonProduction;
                case "Attended":
                    return RobotDtoType.Attended;
                case "Unattended":
                    return RobotDtoType.Unattended;
                case "Development":
                    return RobotDtoType.Development;
            }
            return null;
        }
    }
}
