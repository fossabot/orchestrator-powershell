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
    /// Defines values for OrderByNodeDirection.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderByNodeDirection
    {
        [EnumMember(Value = "Ascending")]
        Ascending,
        [EnumMember(Value = "Descending")]
        Descending
    }
    internal static class OrderByNodeDirectionEnumExtension
    {
        internal static string ToSerializedValue(this OrderByNodeDirection? value)
        {
            return value == null ? null : ((OrderByNodeDirection)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OrderByNodeDirection value)
        {
            switch( value )
            {
                case OrderByNodeDirection.Ascending:
                    return "Ascending";
                case OrderByNodeDirection.Descending:
                    return "Descending";
            }
            return null;
        }

        internal static OrderByNodeDirection? ParseOrderByNodeDirection(this string value)
        {
            switch( value )
            {
                case "Ascending":
                    return OrderByNodeDirection.Ascending;
                case "Descending":
                    return OrderByNodeDirection.Descending;
            }
            return null;
        }
    }
}
