// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookSimpleReleaseDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookSimpleReleaseDto class.
        /// </summary>
        public WebhookSimpleReleaseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookSimpleReleaseDto class.
        /// </summary>
        /// <param name="id">The Id of the process</param>
        /// <param name="key">The unique key of the process</param>
        /// <param name="processKey">The name of the process</param>
        public WebhookSimpleReleaseDto(long? id = default(long?), string key = default(string), string processKey = default(string))
        {
            Id = id;
            Key = key;
            ProcessKey = processKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Id of the process
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets the unique key of the process
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the name of the process
        /// </summary>
        [JsonProperty(PropertyName = "ProcessKey")]
        public string ProcessKey { get; set; }

    }
}
