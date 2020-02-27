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

    /// <summary>
    /// Stores information about all the permissions a user is associated with
    /// in Orchestrator.
    /// </summary>
    public partial class UserPermissionsCollection
    {
        /// <summary>
        /// Initializes a new instance of the UserPermissionsCollection class.
        /// </summary>
        public UserPermissionsCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserPermissionsCollection class.
        /// </summary>
        /// <param name="userId">The Id of the user associated with the
        /// permissions.</param>
        /// <param name="permissions">The collection of names of the
        /// permissions the user is associated with.</param>
        public UserPermissionsCollection(long? userId = default(long?), IList<string> permissions = default(IList<string>))
        {
            UserId = userId;
            Permissions = permissions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Id of the user associated with the permissions.
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or sets the collection of names of the permissions the user is
        /// associated with.
        /// </summary>
        [JsonProperty(PropertyName = "Permissions")]
        public IList<string> Permissions { get; set; }

    }
}
