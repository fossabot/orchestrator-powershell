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
    /// Defines values for PermissionDtoScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionDtoScope
    {
        [EnumMember(Value = "Global")]
        Global,
        [EnumMember(Value = "Folder")]
        Folder
    }
    internal static class PermissionDtoScopeEnumExtension
    {
        internal static string ToSerializedValue(this PermissionDtoScope? value)
        {
            return value == null ? null : ((PermissionDtoScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PermissionDtoScope value)
        {
            switch( value )
            {
                case PermissionDtoScope.Global:
                    return "Global";
                case PermissionDtoScope.Folder:
                    return "Folder";
            }
            return null;
        }

        internal static PermissionDtoScope? ParsePermissionDtoScope(this string value)
        {
            switch( value )
            {
                case "Global":
                    return PermissionDtoScope.Global;
                case "Folder":
                    return PermissionDtoScope.Folder;
            }
            return null;
        }
    }
}
