// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IEdmNavigationPropertyPropertyKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmNavigationPropertyPropertyKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Structural")]
        Structural,
        [EnumMember(Value = "Navigation")]
        Navigation
    }
    internal static class IEdmNavigationPropertyPropertyKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmNavigationPropertyPropertyKind? value)
        {
            return value == null ? null : ((IEdmNavigationPropertyPropertyKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmNavigationPropertyPropertyKind value)
        {
            switch( value )
            {
                case IEdmNavigationPropertyPropertyKind.None:
                    return "None";
                case IEdmNavigationPropertyPropertyKind.Structural:
                    return "Structural";
                case IEdmNavigationPropertyPropertyKind.Navigation:
                    return "Navigation";
            }
            return null;
        }

        internal static IEdmNavigationPropertyPropertyKind? ParseIEdmNavigationPropertyPropertyKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmNavigationPropertyPropertyKind.None;
                case "Structural":
                    return IEdmNavigationPropertyPropertyKind.Structural;
                case "Navigation":
                    return IEdmNavigationPropertyPropertyKind.Navigation;
            }
            return null;
        }
    }
}
