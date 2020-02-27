// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the ErrorInfo class.
        /// </summary>
        public ErrorInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorInfo class.
        /// </summary>
        public ErrorInfo(int? code = default(int?), string message = default(string), string details = default(string), IList<ValidationErrorInfo> validationErrors = default(IList<ValidationErrorInfo>))
        {
            Code = code;
            Message = message;
            Details = details;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ValidationErrorInfo> ValidationErrors { get; set; }

    }
}
