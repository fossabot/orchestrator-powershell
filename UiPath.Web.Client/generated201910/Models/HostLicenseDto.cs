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

    /// <summary>
    /// Stores information about the host license used to activate one or more
    /// tenants.
    /// </summary>
    public partial class HostLicenseDto
    {
        /// <summary>
        /// Initializes a new instance of the HostLicenseDto class.
        /// </summary>
        public HostLicenseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostLicenseDto class.
        /// </summary>
        /// <param name="tenantsCount">The number of tenants licensed from this
        /// license file</param>
        /// <param name="id">License Id</param>
        /// <param name="expireDate">License expiration date in Epoch
        /// format</param>
        /// <param name="gracePeriodEndDate">License grace period end date in
        /// Epoch format</param>
        /// <param name="gracePeriod">Number of grace period days</param>
        /// <param name="allowed">Contains the number of allowed licenses for
        /// each type</param>
        /// <param name="used">Contains the number of used licenses for each
        /// type</param>
        /// <param name="attendedConcurrent">States whether the license is
        /// Attended Concurrent</param>
        /// <param name="developmentConcurrent">States whether the license is
        /// Development Concurrent</param>
        /// <param name="studioXConcurrent">States whether the license is
        /// Studio Business Concurrent</param>
        /// <param name="licensedFeatures">What features are licensed (valid
        /// for individually-licensed features, like Analytics)</param>
        /// <param name="isRegistered">True if the current tenant is registered
        /// with a license. False otherwise.</param>
        /// <param name="isExpired">States whether the license is still valid
        /// or not.</param>
        /// <param name="creationTime">The date when the license was
        /// uploaded.</param>
        /// <param name="code">The license code.</param>
        public HostLicenseDto(int? tenantsCount = default(int?), long? id = default(long?), long? expireDate = default(long?), long? gracePeriodEndDate = default(long?), long? gracePeriod = default(long?), LicenseFields allowed = default(LicenseFields), LicenseFields used = default(LicenseFields), bool? attendedConcurrent = default(bool?), bool? developmentConcurrent = default(bool?), bool? studioXConcurrent = default(bool?), IList<string> licensedFeatures = default(IList<string>), bool? isRegistered = default(bool?), bool? isExpired = default(bool?), System.DateTime? creationTime = default(System.DateTime?), string code = default(string))
        {
            TenantsCount = tenantsCount;
            Id = id;
            ExpireDate = expireDate;
            GracePeriodEndDate = gracePeriodEndDate;
            GracePeriod = gracePeriod;
            Allowed = allowed;
            Used = used;
            AttendedConcurrent = attendedConcurrent;
            DevelopmentConcurrent = developmentConcurrent;
            StudioXConcurrent = studioXConcurrent;
            LicensedFeatures = licensedFeatures;
            IsRegistered = isRegistered;
            IsExpired = isExpired;
            CreationTime = creationTime;
            Code = code;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of tenants licensed from this license file
        /// </summary>
        [JsonProperty(PropertyName = "TenantsCount")]
        public int? TenantsCount { get; set; }

        /// <summary>
        /// Gets or sets license Id
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets license expiration date in Epoch format
        /// </summary>
        [JsonProperty(PropertyName = "ExpireDate")]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// Gets or sets license grace period end date in Epoch format
        /// </summary>
        [JsonProperty(PropertyName = "GracePeriodEndDate")]
        public long? GracePeriodEndDate { get; set; }

        /// <summary>
        /// Gets or sets number of grace period days
        /// </summary>
        [JsonProperty(PropertyName = "GracePeriod")]
        public long? GracePeriod { get; set; }

        /// <summary>
        /// Gets or sets contains the number of allowed licenses for each type
        /// </summary>
        [JsonProperty(PropertyName = "Allowed")]
        public LicenseFields Allowed { get; set; }

        /// <summary>
        /// Gets or sets contains the number of used licenses for each type
        /// </summary>
        [JsonProperty(PropertyName = "Used")]
        public LicenseFields Used { get; set; }

        /// <summary>
        /// Gets or sets states whether the license is Attended Concurrent
        /// </summary>
        [JsonProperty(PropertyName = "AttendedConcurrent")]
        public bool? AttendedConcurrent { get; set; }

        /// <summary>
        /// Gets or sets states whether the license is Development Concurrent
        /// </summary>
        [JsonProperty(PropertyName = "DevelopmentConcurrent")]
        public bool? DevelopmentConcurrent { get; set; }

        /// <summary>
        /// Gets or sets states whether the license is Studio Business
        /// Concurrent
        /// </summary>
        [JsonProperty(PropertyName = "StudioXConcurrent")]
        public bool? StudioXConcurrent { get; set; }

        /// <summary>
        /// Gets or sets what features are licensed (valid for
        /// individually-licensed features, like Analytics)
        /// </summary>
        [JsonProperty(PropertyName = "LicensedFeatures")]
        public IList<string> LicensedFeatures { get; set; }

        /// <summary>
        /// Gets or sets true if the current tenant is registered with a
        /// license. False otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "IsRegistered")]
        public bool? IsRegistered { get; set; }

        /// <summary>
        /// Gets or sets states whether the license is still valid or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsExpired")]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Gets or sets the date when the license was uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the license code.
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

    }
}
