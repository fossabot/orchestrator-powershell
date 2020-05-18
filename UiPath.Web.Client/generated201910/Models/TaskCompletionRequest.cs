// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TaskCompletionRequest
    {
        /// <summary>
        /// Initializes a new instance of the TaskCompletionRequest class.
        /// </summary>
        public TaskCompletionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskCompletionRequest class.
        /// </summary>
        /// <param name="taskId">TaskId to retrieve form</param>
        /// <param name="data">Task form data json</param>
        /// <param name="action">Form action</param>
        public TaskCompletionRequest(long taskId, object data, string action = default(string))
        {
            TaskId = taskId;
            Data = data;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets taskId to retrieve form
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public long TaskId { get; set; }

        /// <summary>
        /// Gets or sets task form data json
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets form action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Data == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Data");
            }
        }
    }
}