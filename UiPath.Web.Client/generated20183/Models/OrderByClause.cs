// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrderByClause
    {
        /// <summary>
        /// Initializes a new instance of the OrderByClause class.
        /// </summary>
        public OrderByClause()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderByClause class.
        /// </summary>
        /// <param name="direction">Possible values include: 'Ascending',
        /// 'Descending'</param>
        public OrderByClause(OrderByClause thenBy = default(OrderByClause), SingleValueNode expression = default(SingleValueNode), OrderByClauseDirection? direction = default(OrderByClauseDirection?), RangeVariable rangeVariable = default(RangeVariable), IEdmTypeReference itemType = default(IEdmTypeReference))
        {
            ThenBy = thenBy;
            Expression = expression;
            Direction = direction;
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
        [JsonProperty(PropertyName = "ThenBy")]
        public OrderByClause ThenBy { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Expression")]
        public SingleValueNode Expression { get; private set; }

        /// <summary>
        /// Gets possible values include: 'Ascending', 'Descending'
        /// </summary>
        [JsonProperty(PropertyName = "Direction")]
        public OrderByClauseDirection? Direction { get; private set; }

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
