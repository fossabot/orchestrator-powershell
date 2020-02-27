// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BulkItemDtoString
    {
        /// <summary>
        /// Initializes a new instance of the BulkItemDtoString class.
        /// </summary>
        public BulkItemDtoString()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BulkItemDtoString class.
        /// </summary>
        /// <param name="status">Possible values include: 'Continue',
        /// 'SwitchingProtocols', 'OK', 'Created', 'Accepted',
        /// 'NonAuthoritativeInformation', 'NoContent', 'ResetContent',
        /// 'PartialContent', 'MultipleChoices', 'Ambiguous',
        /// 'MovedPermanently', 'Moved', 'Found', 'Redirect', 'SeeOther',
        /// 'RedirectMethod', 'NotModified', 'UseProxy', 'Unused',
        /// 'TemporaryRedirect', 'RedirectKeepVerb', 'BadRequest',
        /// 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable', 'ProxyAuthenticationRequired',
        /// 'RequestTimeout', 'Conflict', 'Gone', 'LengthRequired',
        /// 'PreconditionFailed', 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'UpgradeRequired', 'InternalServerError',
        /// 'NotImplemented', 'BadGateway', 'ServiceUnavailable',
        /// 'GatewayTimeout', 'HttpVersionNotSupported'</param>
        public BulkItemDtoString(string key = default(string), BulkItemDto1Status? status = default(BulkItemDto1Status?), string body = default(string))
        {
            Key = key;
            Status = status;
            Body = body;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Continue',
        /// 'SwitchingProtocols', 'OK', 'Created', 'Accepted',
        /// 'NonAuthoritativeInformation', 'NoContent', 'ResetContent',
        /// 'PartialContent', 'MultipleChoices', 'Ambiguous',
        /// 'MovedPermanently', 'Moved', 'Found', 'Redirect', 'SeeOther',
        /// 'RedirectMethod', 'NotModified', 'UseProxy', 'Unused',
        /// 'TemporaryRedirect', 'RedirectKeepVerb', 'BadRequest',
        /// 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable', 'ProxyAuthenticationRequired',
        /// 'RequestTimeout', 'Conflict', 'Gone', 'LengthRequired',
        /// 'PreconditionFailed', 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'UpgradeRequired', 'InternalServerError',
        /// 'NotImplemented', 'BadGateway', 'ServiceUnavailable',
        /// 'GatewayTimeout', 'HttpVersionNotSupported'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public BulkItemDto1Status? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

    }
}
