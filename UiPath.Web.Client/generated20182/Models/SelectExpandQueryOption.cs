// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SelectExpandQueryOption
    {
        /// <summary>
        /// Initializes a new instance of the SelectExpandQueryOption class.
        /// </summary>
        public SelectExpandQueryOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SelectExpandQueryOption class.
        /// </summary>
        public SelectExpandQueryOption(ODataQueryContext context = default(ODataQueryContext), string rawSelect = default(string), string rawExpand = default(string), object validator = default(object), SelectExpandClause selectExpandClause = default(SelectExpandClause), int? levelsMaxLiteralExpansionDepth = default(int?))
        {
            Context = context;
            RawSelect = rawSelect;
            RawExpand = rawExpand;
            Validator = validator;
            SelectExpandClause = selectExpandClause;
            LevelsMaxLiteralExpansionDepth = levelsMaxLiteralExpansionDepth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RawSelect")]
        public string RawSelect { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RawExpand")]
        public string RawExpand { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Validator")]
        public object Validator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SelectExpandClause")]
        public SelectExpandClause SelectExpandClause { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LevelsMaxLiteralExpansionDepth")]
        public int? LevelsMaxLiteralExpansionDepth { get; set; }

    }
}
