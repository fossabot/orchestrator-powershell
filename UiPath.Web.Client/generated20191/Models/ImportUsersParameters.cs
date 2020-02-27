// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ImportUsersParameters
    {
        /// <summary>
        /// Initializes a new instance of the ImportUsersParameters class.
        /// </summary>
        public ImportUsersParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportUsersParameters class.
        /// </summary>
        public ImportUsersParameters(string group = default(string), string domain = default(string), IList<string> rolesList = default(IList<string>))
        {
            Group = group;
            Domain = domain;
            RolesList = rolesList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rolesList")]
        public IList<string> RolesList { get; set; }

    }
}
