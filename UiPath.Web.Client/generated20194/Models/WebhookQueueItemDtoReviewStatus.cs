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
    /// Defines values for WebhookQueueItemDtoReviewStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookQueueItemDtoReviewStatus
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "InReview")]
        InReview,
        [EnumMember(Value = "Verified")]
        Verified,
        [EnumMember(Value = "Retried")]
        Retried
    }
    internal static class WebhookQueueItemDtoReviewStatusEnumExtension
    {
        internal static string ToSerializedValue(this WebhookQueueItemDtoReviewStatus? value)
        {
            return value == null ? null : ((WebhookQueueItemDtoReviewStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookQueueItemDtoReviewStatus value)
        {
            switch( value )
            {
                case WebhookQueueItemDtoReviewStatus.None:
                    return "None";
                case WebhookQueueItemDtoReviewStatus.InReview:
                    return "InReview";
                case WebhookQueueItemDtoReviewStatus.Verified:
                    return "Verified";
                case WebhookQueueItemDtoReviewStatus.Retried:
                    return "Retried";
            }
            return null;
        }

        internal static WebhookQueueItemDtoReviewStatus? ParseWebhookQueueItemDtoReviewStatus(this string value)
        {
            switch( value )
            {
                case "None":
                    return WebhookQueueItemDtoReviewStatus.None;
                case "InReview":
                    return WebhookQueueItemDtoReviewStatus.InReview;
                case "Verified":
                    return WebhookQueueItemDtoReviewStatus.Verified;
                case "Retried":
                    return WebhookQueueItemDtoReviewStatus.Retried;
            }
            return null;
        }
    }
}
