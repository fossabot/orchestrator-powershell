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
    /// Defines values for AlertDtoState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertDtoState
    {
        [EnumMember(Value = "Unread")]
        Unread,
        [EnumMember(Value = "Read")]
        Read
    }
    internal static class AlertDtoStateEnumExtension
    {
        internal static string ToSerializedValue(this AlertDtoState? value)
        {
            return value == null ? null : ((AlertDtoState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertDtoState value)
        {
            switch( value )
            {
                case AlertDtoState.Unread:
                    return "Unread";
                case AlertDtoState.Read:
                    return "Read";
            }
            return null;
        }

        internal static AlertDtoState? ParseAlertDtoState(this string value)
        {
            switch( value )
            {
                case "Unread":
                    return AlertDtoState.Unread;
                case "Read":
                    return AlertDtoState.Read;
            }
            return null;
        }
    }
}
