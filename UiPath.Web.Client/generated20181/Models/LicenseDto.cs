// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores information about the license used to activate a tenant.
    /// </summary>
    public partial class LicenseDto
    {
        /// <summary>
        /// Initializes a new instance of the LicenseDto class.
        /// </summary>
        public LicenseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseDto class.
        /// </summary>
        /// <param name="expireDate">License expiration date in Epoch
        /// format</param>
        /// <param name="allowedRobots">Contains the number of allowed robots
        /// for each type</param>
        /// <param name="definedRobots">Contains the number of already defined
        /// robots for each type</param>
        /// <param name="concurrentRobots">Contains the number of concurrently
        /// running robots for each type</param>
        /// <param name="isRegistered">True if the current tenant is registered
        /// with a license. False otherwise.</param>
        /// <param name="concurrent">True if the license is concurrent
        /// False if the license is provisioned</param>
        /// <param name="isExpired">States whether the license is still valid
        /// or not.</param>
        public LicenseDto(long? expireDate = default(long?), LicenseFields allowedRobots = default(LicenseFields), LicenseFields definedRobots = default(LicenseFields), LicenseFields concurrentRobots = default(LicenseFields), bool? isRegistered = default(bool?), bool? concurrent = default(bool?), bool? isExpired = default(bool?))
        {
            ExpireDate = expireDate;
            AllowedRobots = allowedRobots;
            DefinedRobots = definedRobots;
            ConcurrentRobots = concurrentRobots;
            IsRegistered = isRegistered;
            Concurrent = concurrent;
            IsExpired = isExpired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets license expiration date in Epoch format
        /// </summary>
        [JsonProperty(PropertyName = "ExpireDate")]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// Gets or sets contains the number of allowed robots for each type
        /// </summary>
        [JsonProperty(PropertyName = "AllowedRobots")]
        public LicenseFields AllowedRobots { get; set; }

        /// <summary>
        /// Gets or sets contains the number of already defined robots for each
        /// type
        /// </summary>
        [JsonProperty(PropertyName = "DefinedRobots")]
        public LicenseFields DefinedRobots { get; set; }

        /// <summary>
        /// Gets or sets contains the number of concurrently running robots for
        /// each type
        /// </summary>
        [JsonProperty(PropertyName = "ConcurrentRobots")]
        public LicenseFields ConcurrentRobots { get; set; }

        /// <summary>
        /// Gets or sets true if the current tenant is registered with a
        /// license. False otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "IsRegistered")]
        public bool? IsRegistered { get; set; }

        /// <summary>
        /// Gets or sets true if the license is concurrent
        /// False if the license is provisioned
        /// </summary>
        [JsonProperty(PropertyName = "Concurrent")]
        public bool? Concurrent { get; set; }

        /// <summary>
        /// Gets or sets states whether the license is still valid or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsExpired")]
        public bool? IsExpired { get; set; }

    }
}
