// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Parameters
    {
        /// <summary>
        /// Initializes a new instance of the Parameters class.
        /// </summary>
        public Parameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Parameters class.
        /// </summary>
        public Parameters(ProcessAlertDto processAlert = default(ProcessAlertDto))
        {
            ProcessAlert = processAlert;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processAlert")]
        public ProcessAlertDto ProcessAlert { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProcessAlert != null)
            {
                ProcessAlert.Validate();
            }
        }
    }
}
