// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateUserPasswordDto
    {
        /// <summary>
        /// Initializes a new instance of the UpdateUserPasswordDto class.
        /// </summary>
        public UpdateUserPasswordDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateUserPasswordDto class.
        /// </summary>
        /// <param name="currentPassword">Existing user password</param>
        /// <param name="newPassword">The new user password</param>
        public UpdateUserPasswordDto(string username, string tenancyName = default(string), string currentPassword = default(string), string newPassword = default(string))
        {
            TenancyName = tenancyName;
            Username = username;
            CurrentPassword = currentPassword;
            NewPassword = newPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TenancyName")]
        public string TenancyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets existing user password
        /// </summary>
        [JsonProperty(PropertyName = "CurrentPassword")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Gets or sets the new user password
        /// </summary>
        [JsonProperty(PropertyName = "NewPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
        }
    }
}
