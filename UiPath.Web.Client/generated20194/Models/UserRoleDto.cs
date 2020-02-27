// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores information about the association between a user and a role.
    /// </summary>
    public partial class UserRoleDto
    {
        /// <summary>
        /// Initializes a new instance of the UserRoleDto class.
        /// </summary>
        public UserRoleDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserRoleDto class.
        /// </summary>
        /// <param name="userId">The Id of the associated user.</param>
        /// <param name="roleId">The Id of the associated role.</param>
        /// <param name="userName">The name of the associated user</param>
        /// <param name="roleName">The name of the associated role</param>
        public UserRoleDto(long? userId = default(long?), int? roleId = default(int?), string userName = default(string), string roleName = default(string), long? id = default(long?))
        {
            UserId = userId;
            RoleId = roleId;
            UserName = userName;
            RoleName = roleName;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Id of the associated user.
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the associated role.
        /// </summary>
        [JsonProperty(PropertyName = "RoleId")]
        public int? RoleId { get; set; }

        /// <summary>
        /// Gets or sets the name of the associated user
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the name of the associated role
        /// </summary>
        [JsonProperty(PropertyName = "RoleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
