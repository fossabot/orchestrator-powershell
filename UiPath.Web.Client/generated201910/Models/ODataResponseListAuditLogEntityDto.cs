// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataResponseListAuditLogEntityDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListAuditLogEntityDto class.
        /// </summary>
        public ODataResponseListAuditLogEntityDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListAuditLogEntityDto class.
        /// </summary>
        public ODataResponseListAuditLogEntityDto(string odatacontext = default(string), IList<AuditLogEntityDto> value = default(IList<AuditLogEntityDto>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AuditLogEntityDto> Value { get; set; }

    }
}
