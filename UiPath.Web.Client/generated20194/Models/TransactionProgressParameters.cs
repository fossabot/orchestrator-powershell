// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TransactionProgressParameters
    {
        /// <summary>
        /// Initializes a new instance of the TransactionProgressParameters
        /// class.
        /// </summary>
        public TransactionProgressParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransactionProgressParameters
        /// class.
        /// </summary>
        public TransactionProgressParameters(string progress = default(string))
        {
            Progress = progress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public string Progress { get; set; }

    }
}
