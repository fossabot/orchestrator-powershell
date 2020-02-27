// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IEdmNavigationPropertyOnDelete.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmNavigationPropertyOnDelete
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Cascade")]
        Cascade
    }
    internal static class IEdmNavigationPropertyOnDeleteEnumExtension
    {
        internal static string ToSerializedValue(this IEdmNavigationPropertyOnDelete? value)
        {
            return value == null ? null : ((IEdmNavigationPropertyOnDelete)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmNavigationPropertyOnDelete value)
        {
            switch( value )
            {
                case IEdmNavigationPropertyOnDelete.None:
                    return "None";
                case IEdmNavigationPropertyOnDelete.Cascade:
                    return "Cascade";
            }
            return null;
        }

        internal static IEdmNavigationPropertyOnDelete? ParseIEdmNavigationPropertyOnDelete(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmNavigationPropertyOnDelete.None;
                case "Cascade":
                    return IEdmNavigationPropertyOnDelete.Cascade;
            }
            return null;
        }
    }
}
