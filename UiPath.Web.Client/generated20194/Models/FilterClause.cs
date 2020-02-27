// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class FilterClause
    {
        /// <summary>
        /// Initializes a new instance of the FilterClause class.
        /// </summary>
        public FilterClause()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FilterClause class.
        /// </summary>
        public FilterClause(SingleValueNode expression = default(SingleValueNode), RangeVariable rangeVariable = default(RangeVariable), IEdmTypeReference itemType = default(IEdmTypeReference))
        {
            Expression = expression;
            RangeVariable = rangeVariable;
            ItemType = itemType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Expression")]
        public SingleValueNode Expression { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RangeVariable")]
        public RangeVariable RangeVariable { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemType")]
        public IEdmTypeReference ItemType { get; private set; }

    }
}
