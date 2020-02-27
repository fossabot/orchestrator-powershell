// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrderByNode
    {
        /// <summary>
        /// Initializes a new instance of the OrderByNode class.
        /// </summary>
        public OrderByNode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderByNode class.
        /// </summary>
        /// <param name="direction">Possible values include: 'Ascending',
        /// 'Descending'</param>
        public OrderByNode(OrderByNodeDirection? direction = default(OrderByNodeDirection?))
        {
            Direction = direction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'Ascending', 'Descending'
        /// </summary>
        [JsonProperty(PropertyName = "Direction")]
        public OrderByNodeDirection? Direction { get; private set; }

    }
}
