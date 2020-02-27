// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ClearCacheModel
    {
        /// <summary>
        /// Initializes a new instance of the ClearCacheModel class.
        /// </summary>
        public ClearCacheModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClearCacheModel class.
        /// </summary>
        public ClearCacheModel(string password = default(string), IList<string> caches = default(IList<string>))
        {
            Password = password;
            Caches = caches;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "caches")]
        public IList<string> Caches { get; set; }

    }
}
