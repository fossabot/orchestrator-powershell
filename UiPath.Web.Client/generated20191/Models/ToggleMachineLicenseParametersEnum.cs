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
    /// Defines values for ToggleMachineLicenseParametersEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ToggleMachineLicenseParametersEnum
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Development")]
        Development
    }
    internal static class ToggleMachineLicenseParametersEnumEnumExtension
    {
        internal static string ToSerializedValue(this ToggleMachineLicenseParametersEnum? value)
        {
            return value == null ? null : ((ToggleMachineLicenseParametersEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ToggleMachineLicenseParametersEnum value)
        {
            switch( value )
            {
                case ToggleMachineLicenseParametersEnum.NonProduction:
                    return "NonProduction";
                case ToggleMachineLicenseParametersEnum.Attended:
                    return "Attended";
                case ToggleMachineLicenseParametersEnum.Unattended:
                    return "Unattended";
                case ToggleMachineLicenseParametersEnum.Development:
                    return "Development";
            }
            return null;
        }

        internal static ToggleMachineLicenseParametersEnum? ParseToggleMachineLicenseParametersEnum(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return ToggleMachineLicenseParametersEnum.NonProduction;
                case "Attended":
                    return ToggleMachineLicenseParametersEnum.Attended;
                case "Unattended":
                    return ToggleMachineLicenseParametersEnum.Unattended;
                case "Development":
                    return ToggleMachineLicenseParametersEnum.Development;
            }
            return null;
        }
    }
}
