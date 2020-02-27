// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmNavigationProperty
    {
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationProperty class.
        /// </summary>
        public IEdmNavigationProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmNavigationProperty class.
        /// </summary>
        /// <param name="onDelete">Possible values include: 'None',
        /// 'Cascade'</param>
        /// <param name="propertyKind">Possible values include: 'None',
        /// 'Structural', 'Navigation'</param>
        public IEdmNavigationProperty(IEdmNavigationProperty partner = default(IEdmNavigationProperty), IEdmNavigationPropertyOnDelete? onDelete = default(IEdmNavigationPropertyOnDelete?), bool? containsTarget = default(bool?), IEdmReferentialConstraint referentialConstraint = default(IEdmReferentialConstraint), IEdmNavigationPropertyPropertyKind? propertyKind = default(IEdmNavigationPropertyPropertyKind?), IEdmTypeReference type = default(IEdmTypeReference), IEdmStructuredType declaringType = default(IEdmStructuredType), string name = default(string))
        {
            Partner = partner;
            OnDelete = onDelete;
            ContainsTarget = containsTarget;
            ReferentialConstraint = referentialConstraint;
            PropertyKind = propertyKind;
            Type = type;
            DeclaringType = declaringType;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Partner")]
        public IEdmNavigationProperty Partner { get; private set; }

        /// <summary>
        /// Gets possible values include: 'None', 'Cascade'
        /// </summary>
        [JsonProperty(PropertyName = "OnDelete")]
        public IEdmNavigationPropertyOnDelete? OnDelete { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContainsTarget")]
        public bool? ContainsTarget { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferentialConstraint")]
        public IEdmReferentialConstraint ReferentialConstraint { get; private set; }

        /// <summary>
        /// Gets possible values include: 'None', 'Structural', 'Navigation'
        /// </summary>
        [JsonProperty(PropertyName = "PropertyKind")]
        public IEdmNavigationPropertyPropertyKind? PropertyKind { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public IEdmTypeReference Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeclaringType")]
        public IEdmStructuredType DeclaringType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

    }
}
