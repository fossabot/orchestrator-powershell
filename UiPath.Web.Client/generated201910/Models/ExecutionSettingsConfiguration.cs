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

    public partial class ExecutionSettingsConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the ExecutionSettingsConfiguration
        /// class.
        /// </summary>
        public ExecutionSettingsConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionSettingsConfiguration
        /// class.
        /// </summary>
        /// <param name="scope">Possible values include: 'Global',
        /// 'Robot'</param>
        public ExecutionSettingsConfiguration(ExecutionSettingsConfigurationScope? scope = default(ExecutionSettingsConfigurationScope?), IList<ExecutionSettingDefinition> configuration = default(IList<ExecutionSettingDefinition>))
        {
            Scope = scope;
            Configuration = configuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Global', 'Robot'
        /// </summary>
        [JsonProperty(PropertyName = "Scope")]
        public ExecutionSettingsConfigurationScope? Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Configuration")]
        public IList<ExecutionSettingDefinition> Configuration { get; set; }

    }
}
