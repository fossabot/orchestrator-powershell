// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for BulkAddQueueItemsParametersEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BulkAddQueueItemsParametersEnum
    {
        [EnumMember(Value = "AllOrNothing")]
        AllOrNothing,
        [EnumMember(Value = "StopOnFirstFailure")]
        StopOnFirstFailure,
        [EnumMember(Value = "ProcessAllIndependently")]
        ProcessAllIndependently
    }
    internal static class BulkAddQueueItemsParametersEnumEnumExtension
    {
        internal static string ToSerializedValue(this BulkAddQueueItemsParametersEnum? value)
        {
            return value == null ? null : ((BulkAddQueueItemsParametersEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this BulkAddQueueItemsParametersEnum value)
        {
            switch( value )
            {
                case BulkAddQueueItemsParametersEnum.AllOrNothing:
                    return "AllOrNothing";
                case BulkAddQueueItemsParametersEnum.StopOnFirstFailure:
                    return "StopOnFirstFailure";
                case BulkAddQueueItemsParametersEnum.ProcessAllIndependently:
                    return "ProcessAllIndependently";
            }
            return null;
        }

        internal static BulkAddQueueItemsParametersEnum? ParseBulkAddQueueItemsParametersEnum(this string value)
        {
            switch( value )
            {
                case "AllOrNothing":
                    return BulkAddQueueItemsParametersEnum.AllOrNothing;
                case "StopOnFirstFailure":
                    return BulkAddQueueItemsParametersEnum.StopOnFirstFailure;
                case "ProcessAllIndependently":
                    return BulkAddQueueItemsParametersEnum.ProcessAllIndependently;
            }
            return null;
        }
    }
}
