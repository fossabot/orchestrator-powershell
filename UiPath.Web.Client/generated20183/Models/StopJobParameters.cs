// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class StopJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the StopJobParameters class.
        /// </summary>
        public StopJobParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StopJobParameters class.
        /// </summary>
        /// <param name="strategy">Possible values include: 'SoftStop',
        /// 'Kill'</param>
        public StopJobParameters(StopJobParametersEnum strategy)
        {
            Strategy = strategy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'SoftStop', 'Kill'
        /// </summary>
        [JsonProperty(PropertyName = "strategy")]
        public StopJobParametersEnum Strategy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
