// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IEdmTermSchemaElementKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmTermSchemaElementKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "TypeDefinition")]
        TypeDefinition,
        [EnumMember(Value = "Term")]
        Term,
        [EnumMember(Value = "Action")]
        Action,
        [EnumMember(Value = "EntityContainer")]
        EntityContainer,
        [EnumMember(Value = "Function")]
        Function
    }
    internal static class IEdmTermSchemaElementKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmTermSchemaElementKind? value)
        {
            return value == null ? null : ((IEdmTermSchemaElementKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmTermSchemaElementKind value)
        {
            switch( value )
            {
                case IEdmTermSchemaElementKind.None:
                    return "None";
                case IEdmTermSchemaElementKind.TypeDefinition:
                    return "TypeDefinition";
                case IEdmTermSchemaElementKind.Term:
                    return "Term";
                case IEdmTermSchemaElementKind.Action:
                    return "Action";
                case IEdmTermSchemaElementKind.EntityContainer:
                    return "EntityContainer";
                case IEdmTermSchemaElementKind.Function:
                    return "Function";
            }
            return null;
        }

        internal static IEdmTermSchemaElementKind? ParseIEdmTermSchemaElementKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmTermSchemaElementKind.None;
                case "TypeDefinition":
                    return IEdmTermSchemaElementKind.TypeDefinition;
                case "Term":
                    return IEdmTermSchemaElementKind.Term;
                case "Action":
                    return IEdmTermSchemaElementKind.Action;
                case "EntityContainer":
                    return IEdmTermSchemaElementKind.EntityContainer;
                case "Function":
                    return IEdmTermSchemaElementKind.Function;
            }
            return null;
        }
    }
}
