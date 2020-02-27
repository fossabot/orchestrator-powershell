// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IEdmPathExpressionExpressionKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmPathExpressionExpressionKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "BinaryConstant")]
        BinaryConstant,
        [EnumMember(Value = "BooleanConstant")]
        BooleanConstant,
        [EnumMember(Value = "DateTimeOffsetConstant")]
        DateTimeOffsetConstant,
        [EnumMember(Value = "DecimalConstant")]
        DecimalConstant,
        [EnumMember(Value = "FloatingConstant")]
        FloatingConstant,
        [EnumMember(Value = "GuidConstant")]
        GuidConstant,
        [EnumMember(Value = "IntegerConstant")]
        IntegerConstant,
        [EnumMember(Value = "StringConstant")]
        StringConstant,
        [EnumMember(Value = "DurationConstant")]
        DurationConstant,
        [EnumMember(Value = "Null")]
        Null,
        [EnumMember(Value = "Record")]
        Record,
        [EnumMember(Value = "Collection")]
        Collection,
        [EnumMember(Value = "Path")]
        Path,
        [EnumMember(Value = "If")]
        If,
        [EnumMember(Value = "Cast")]
        Cast,
        [EnumMember(Value = "IsType")]
        IsType,
        [EnumMember(Value = "FunctionApplication")]
        FunctionApplication,
        [EnumMember(Value = "LabeledExpressionReference")]
        LabeledExpressionReference,
        [EnumMember(Value = "Labeled")]
        Labeled,
        [EnumMember(Value = "PropertyPath")]
        PropertyPath,
        [EnumMember(Value = "NavigationPropertyPath")]
        NavigationPropertyPath,
        [EnumMember(Value = "DateConstant")]
        DateConstant,
        [EnumMember(Value = "TimeOfDayConstant")]
        TimeOfDayConstant,
        [EnumMember(Value = "EnumMember")]
        EnumMember,
        [EnumMember(Value = "AnnotationPath")]
        AnnotationPath
    }
    internal static class IEdmPathExpressionExpressionKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmPathExpressionExpressionKind? value)
        {
            return value == null ? null : ((IEdmPathExpressionExpressionKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmPathExpressionExpressionKind value)
        {
            switch( value )
            {
                case IEdmPathExpressionExpressionKind.None:
                    return "None";
                case IEdmPathExpressionExpressionKind.BinaryConstant:
                    return "BinaryConstant";
                case IEdmPathExpressionExpressionKind.BooleanConstant:
                    return "BooleanConstant";
                case IEdmPathExpressionExpressionKind.DateTimeOffsetConstant:
                    return "DateTimeOffsetConstant";
                case IEdmPathExpressionExpressionKind.DecimalConstant:
                    return "DecimalConstant";
                case IEdmPathExpressionExpressionKind.FloatingConstant:
                    return "FloatingConstant";
                case IEdmPathExpressionExpressionKind.GuidConstant:
                    return "GuidConstant";
                case IEdmPathExpressionExpressionKind.IntegerConstant:
                    return "IntegerConstant";
                case IEdmPathExpressionExpressionKind.StringConstant:
                    return "StringConstant";
                case IEdmPathExpressionExpressionKind.DurationConstant:
                    return "DurationConstant";
                case IEdmPathExpressionExpressionKind.Null:
                    return "Null";
                case IEdmPathExpressionExpressionKind.Record:
                    return "Record";
                case IEdmPathExpressionExpressionKind.Collection:
                    return "Collection";
                case IEdmPathExpressionExpressionKind.Path:
                    return "Path";
                case IEdmPathExpressionExpressionKind.If:
                    return "If";
                case IEdmPathExpressionExpressionKind.Cast:
                    return "Cast";
                case IEdmPathExpressionExpressionKind.IsType:
                    return "IsType";
                case IEdmPathExpressionExpressionKind.FunctionApplication:
                    return "FunctionApplication";
                case IEdmPathExpressionExpressionKind.LabeledExpressionReference:
                    return "LabeledExpressionReference";
                case IEdmPathExpressionExpressionKind.Labeled:
                    return "Labeled";
                case IEdmPathExpressionExpressionKind.PropertyPath:
                    return "PropertyPath";
                case IEdmPathExpressionExpressionKind.NavigationPropertyPath:
                    return "NavigationPropertyPath";
                case IEdmPathExpressionExpressionKind.DateConstant:
                    return "DateConstant";
                case IEdmPathExpressionExpressionKind.TimeOfDayConstant:
                    return "TimeOfDayConstant";
                case IEdmPathExpressionExpressionKind.EnumMember:
                    return "EnumMember";
                case IEdmPathExpressionExpressionKind.AnnotationPath:
                    return "AnnotationPath";
            }
            return null;
        }

        internal static IEdmPathExpressionExpressionKind? ParseIEdmPathExpressionExpressionKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmPathExpressionExpressionKind.None;
                case "BinaryConstant":
                    return IEdmPathExpressionExpressionKind.BinaryConstant;
                case "BooleanConstant":
                    return IEdmPathExpressionExpressionKind.BooleanConstant;
                case "DateTimeOffsetConstant":
                    return IEdmPathExpressionExpressionKind.DateTimeOffsetConstant;
                case "DecimalConstant":
                    return IEdmPathExpressionExpressionKind.DecimalConstant;
                case "FloatingConstant":
                    return IEdmPathExpressionExpressionKind.FloatingConstant;
                case "GuidConstant":
                    return IEdmPathExpressionExpressionKind.GuidConstant;
                case "IntegerConstant":
                    return IEdmPathExpressionExpressionKind.IntegerConstant;
                case "StringConstant":
                    return IEdmPathExpressionExpressionKind.StringConstant;
                case "DurationConstant":
                    return IEdmPathExpressionExpressionKind.DurationConstant;
                case "Null":
                    return IEdmPathExpressionExpressionKind.Null;
                case "Record":
                    return IEdmPathExpressionExpressionKind.Record;
                case "Collection":
                    return IEdmPathExpressionExpressionKind.Collection;
                case "Path":
                    return IEdmPathExpressionExpressionKind.Path;
                case "If":
                    return IEdmPathExpressionExpressionKind.If;
                case "Cast":
                    return IEdmPathExpressionExpressionKind.Cast;
                case "IsType":
                    return IEdmPathExpressionExpressionKind.IsType;
                case "FunctionApplication":
                    return IEdmPathExpressionExpressionKind.FunctionApplication;
                case "LabeledExpressionReference":
                    return IEdmPathExpressionExpressionKind.LabeledExpressionReference;
                case "Labeled":
                    return IEdmPathExpressionExpressionKind.Labeled;
                case "PropertyPath":
                    return IEdmPathExpressionExpressionKind.PropertyPath;
                case "NavigationPropertyPath":
                    return IEdmPathExpressionExpressionKind.NavigationPropertyPath;
                case "DateConstant":
                    return IEdmPathExpressionExpressionKind.DateConstant;
                case "TimeOfDayConstant":
                    return IEdmPathExpressionExpressionKind.TimeOfDayConstant;
                case "EnumMember":
                    return IEdmPathExpressionExpressionKind.EnumMember;
                case "AnnotationPath":
                    return IEdmPathExpressionExpressionKind.AnnotationPath;
            }
            return null;
        }
    }
}
