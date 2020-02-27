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
    /// Defines values for SimpleRobotDtoHostingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SimpleRobotDtoHostingType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Floating")]
        Floating
    }
    internal static class SimpleRobotDtoHostingTypeEnumExtension
    {
        internal static string ToSerializedValue(this SimpleRobotDtoHostingType? value)
        {
            return value == null ? null : ((SimpleRobotDtoHostingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SimpleRobotDtoHostingType value)
        {
            switch( value )
            {
                case SimpleRobotDtoHostingType.Standard:
                    return "Standard";
                case SimpleRobotDtoHostingType.Floating:
                    return "Floating";
            }
            return null;
        }

        internal static SimpleRobotDtoHostingType? ParseSimpleRobotDtoHostingType(this string value)
        {
            switch( value )
            {
                case "Standard":
                    return SimpleRobotDtoHostingType.Standard;
                case "Floating":
                    return SimpleRobotDtoHostingType.Floating;
            }
            return null;
        }
    }
}
