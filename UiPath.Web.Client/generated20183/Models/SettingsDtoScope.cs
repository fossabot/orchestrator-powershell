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
    /// Defines values for SettingsDtoScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SettingsDtoScope
    {
        [EnumMember(Value = "Application")]
        Application,
        [EnumMember(Value = "Tenant")]
        Tenant,
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "All")]
        All
    }
    internal static class SettingsDtoScopeEnumExtension
    {
        internal static string ToSerializedValue(this SettingsDtoScope? value)
        {
            return value == null ? null : ((SettingsDtoScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SettingsDtoScope value)
        {
            switch( value )
            {
                case SettingsDtoScope.Application:
                    return "Application";
                case SettingsDtoScope.Tenant:
                    return "Tenant";
                case SettingsDtoScope.User:
                    return "User";
                case SettingsDtoScope.All:
                    return "All";
            }
            return null;
        }

        internal static SettingsDtoScope? ParseSettingsDtoScope(this string value)
        {
            switch( value )
            {
                case "Application":
                    return SettingsDtoScope.Application;
                case "Tenant":
                    return SettingsDtoScope.Tenant;
                case "User":
                    return SettingsDtoScope.User;
                case "All":
                    return SettingsDtoScope.All;
            }
            return null;
        }
    }
}
