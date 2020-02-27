// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TransformationNode
    {
        /// <summary>
        /// Initializes a new instance of the TransformationNode class.
        /// </summary>
        public TransformationNode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransformationNode class.
        /// </summary>
        /// <param name="kind">Possible values include: 'Aggregate', 'GroupBy',
        /// 'Filter'</param>
        public TransformationNode(TransformationNodeKind? kind = default(TransformationNodeKind?))
        {
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'Aggregate', 'GroupBy', 'Filter'
        /// </summary>
        [JsonProperty(PropertyName = "Kind")]
        public TransformationNodeKind? Kind { get; private set; }

    }
}
