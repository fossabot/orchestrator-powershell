// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RobotDtoProvisionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RobotDtoProvisionType
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Automatic")]
        Automatic
    }
    internal static class RobotDtoProvisionTypeEnumExtension
    {
        internal static string ToSerializedValue(this RobotDtoProvisionType? value)
        {
            return value == null ? null : ((RobotDtoProvisionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RobotDtoProvisionType value)
        {
            switch( value )
            {
                case RobotDtoProvisionType.Manual:
                    return "Manual";
                case RobotDtoProvisionType.Automatic:
                    return "Automatic";
            }
            return null;
        }

        internal static RobotDtoProvisionType? ParseRobotDtoProvisionType(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return RobotDtoProvisionType.Manual;
                case "Automatic":
                    return RobotDtoProvisionType.Automatic;
            }
            return null;
        }
    }
}
