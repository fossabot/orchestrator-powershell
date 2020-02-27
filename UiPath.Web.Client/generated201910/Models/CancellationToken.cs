// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CancellationToken
    {
        /// <summary>
        /// Initializes a new instance of the CancellationToken class.
        /// </summary>
        public CancellationToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CancellationToken class.
        /// </summary>
        public CancellationToken(bool? isCancellationRequested = default(bool?), bool? canBeCanceled = default(bool?), WaitHandle waitHandle = default(WaitHandle))
        {
            IsCancellationRequested = isCancellationRequested;
            CanBeCanceled = canBeCanceled;
            WaitHandle = waitHandle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isCancellationRequested")]
        public bool? IsCancellationRequested { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canBeCanceled")]
        public bool? CanBeCanceled { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "waitHandle")]
        public WaitHandle WaitHandle { get; private set; }

    }
}
