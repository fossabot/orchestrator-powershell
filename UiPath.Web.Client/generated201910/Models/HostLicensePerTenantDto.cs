// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HostLicensePerTenantDto
    {
        /// <summary>
        /// Initializes a new instance of the HostLicensePerTenantDto class.
        /// </summary>
        public HostLicensePerTenantDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostLicensePerTenantDto class.
        /// </summary>
        /// <param name="tenantId">The tenant's Id</param>
        /// <param name="hostLicenseId">The host license's Id</param>
        /// <param name="attended">Number of allowed attended robots</param>
        /// <param name="unattended">Number of allowed unattended
        /// robots</param>
        /// <param name="nonProduction">Number of allowed non-production
        /// robots</param>
        /// <param name="development">Number of allowed Studio development
        /// robots</param>
        /// <param name="studioX">Number of allowed StudioX development
        /// robots</param>
        public HostLicensePerTenantDto(int? tenantId = default(int?), long? hostLicenseId = default(long?), long? attended = default(long?), long? unattended = default(long?), long? nonProduction = default(long?), long? development = default(long?), long? studioX = default(long?))
        {
            TenantId = tenantId;
            HostLicenseId = hostLicenseId;
            Attended = attended;
            Unattended = unattended;
            NonProduction = nonProduction;
            Development = development;
            StudioX = studioX;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tenant's Id
        /// </summary>
        [JsonProperty(PropertyName = "TenantId")]
        public int? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the host license's Id
        /// </summary>
        [JsonProperty(PropertyName = "HostLicenseId")]
        public long? HostLicenseId { get; set; }

        /// <summary>
        /// Gets or sets number of allowed attended robots
        /// </summary>
        [JsonProperty(PropertyName = "Attended")]
        public long? Attended { get; set; }

        /// <summary>
        /// Gets or sets number of allowed unattended robots
        /// </summary>
        [JsonProperty(PropertyName = "Unattended")]
        public long? Unattended { get; set; }

        /// <summary>
        /// Gets or sets number of allowed non-production robots
        /// </summary>
        [JsonProperty(PropertyName = "NonProduction")]
        public long? NonProduction { get; set; }

        /// <summary>
        /// Gets or sets number of allowed Studio development robots
        /// </summary>
        [JsonProperty(PropertyName = "Development")]
        public long? Development { get; set; }

        /// <summary>
        /// Gets or sets number of allowed StudioX development robots
        /// </summary>
        [JsonProperty(PropertyName = "StudioX")]
        public long? StudioX { get; set; }

    }
}
