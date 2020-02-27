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
    /// Defines values for FolderDtoProvisionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FolderDtoProvisionType
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Automatic")]
        Automatic
    }
    internal static class FolderDtoProvisionTypeEnumExtension
    {
        internal static string ToSerializedValue(this FolderDtoProvisionType? value)
        {
            return value == null ? null : ((FolderDtoProvisionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FolderDtoProvisionType value)
        {
            switch( value )
            {
                case FolderDtoProvisionType.Manual:
                    return "Manual";
                case FolderDtoProvisionType.Automatic:
                    return "Automatic";
            }
            return null;
        }

        internal static FolderDtoProvisionType? ParseFolderDtoProvisionType(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return FolderDtoProvisionType.Manual;
                case "Automatic":
                    return FolderDtoProvisionType.Automatic;
            }
            return null;
        }
    }
}
