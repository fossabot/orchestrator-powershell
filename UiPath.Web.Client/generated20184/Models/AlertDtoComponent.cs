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
    /// Defines values for AlertDtoComponent.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertDtoComponent
    {
        [EnumMember(Value = "Robots")]
        Robots,
        [EnumMember(Value = "Transactions")]
        Transactions,
        [EnumMember(Value = "Schedules")]
        Schedules,
        [EnumMember(Value = "Jobs")]
        Jobs,
        [EnumMember(Value = "Process")]
        Process
    }
    internal static class AlertDtoComponentEnumExtension
    {
        internal static string ToSerializedValue(this AlertDtoComponent? value)
        {
            return value == null ? null : ((AlertDtoComponent)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertDtoComponent value)
        {
            switch( value )
            {
                case AlertDtoComponent.Robots:
                    return "Robots";
                case AlertDtoComponent.Transactions:
                    return "Transactions";
                case AlertDtoComponent.Schedules:
                    return "Schedules";
                case AlertDtoComponent.Jobs:
                    return "Jobs";
                case AlertDtoComponent.Process:
                    return "Process";
            }
            return null;
        }

        internal static AlertDtoComponent? ParseAlertDtoComponent(this string value)
        {
            switch( value )
            {
                case "Robots":
                    return AlertDtoComponent.Robots;
                case "Transactions":
                    return AlertDtoComponent.Transactions;
                case "Schedules":
                    return AlertDtoComponent.Schedules;
                case "Jobs":
                    return AlertDtoComponent.Jobs;
                case "Process":
                    return AlertDtoComponent.Process;
            }
            return null;
        }
    }
}
