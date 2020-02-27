// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores information about exceptions thrown while processing failed
    /// queue items.
    /// </summary>
    public partial class ProcessingExceptionDto
    {
        /// <summary>
        /// Initializes a new instance of the ProcessingExceptionDto class.
        /// </summary>
        public ProcessingExceptionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessingExceptionDto class.
        /// </summary>
        /// <param name="reason">The reason the processing failed.</param>
        /// <param name="details">Stores additional details about the
        /// exception.</param>
        /// <param name="type">The processing exception type, if any. Possible
        /// values include: 'ApplicationException', 'BusinessException'</param>
        /// <param name="associatedImageFilePath">A path on the robot running
        /// computer to an image file that stores relevant information about
        /// the exception - e.g. a system print screen.</param>
        /// <param name="creationTime">Time when the exception occurred</param>
        public ProcessingExceptionDto(string reason = default(string), string details = default(string), ProcessingExceptionDtoType? type = default(ProcessingExceptionDtoType?), string associatedImageFilePath = default(string), System.DateTime? creationTime = default(System.DateTime?))
        {
            Reason = reason;
            Details = details;
            Type = type;
            AssociatedImageFilePath = associatedImageFilePath;
            CreationTime = creationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reason the processing failed.
        /// </summary>
        [JsonProperty(PropertyName = "Reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets stores additional details about the exception.
        /// </summary>
        [JsonProperty(PropertyName = "Details")]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the processing exception type, if any. Possible values
        /// include: 'ApplicationException', 'BusinessException'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public ProcessingExceptionDtoType? Type { get; set; }

        /// <summary>
        /// Gets or sets a path on the robot running computer to an image file
        /// that stores relevant information about the exception - e.g. a
        /// system print screen.
        /// </summary>
        [JsonProperty(PropertyName = "AssociatedImageFilePath")]
        public string AssociatedImageFilePath { get; set; }

        /// <summary>
        /// Gets or sets time when the exception occurred
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

    }
}
