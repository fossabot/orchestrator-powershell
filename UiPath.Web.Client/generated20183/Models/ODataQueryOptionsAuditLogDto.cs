// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ODataQueryOptionsAuditLogDto
    {
        /// <summary>
        /// Initializes a new instance of the ODataQueryOptionsAuditLogDto
        /// class.
        /// </summary>
        public ODataQueryOptionsAuditLogDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataQueryOptionsAuditLogDto
        /// class.
        /// </summary>
        public ODataQueryOptionsAuditLogDto(object ifMatch = default(object), object ifNoneMatch = default(object), ODataQueryContext context = default(ODataQueryContext), object request = default(object), ODataRawQueryOptions rawValues = default(ODataRawQueryOptions), SelectExpandQueryOption selectExpand = default(SelectExpandQueryOption), ApplyQueryOption apply = default(ApplyQueryOption), FilterQueryOption filter = default(FilterQueryOption), OrderByQueryOption orderBy = default(OrderByQueryOption), SkipQueryOption skip = default(SkipQueryOption), TopQueryOption top = default(TopQueryOption), CountQueryOption count = default(CountQueryOption), object validator = default(object))
        {
            IfMatch = ifMatch;
            IfNoneMatch = ifNoneMatch;
            Context = context;
            Request = request;
            RawValues = rawValues;
            SelectExpand = selectExpand;
            Apply = apply;
            Filter = filter;
            OrderBy = orderBy;
            Skip = skip;
            Top = top;
            Count = count;
            Validator = validator;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IfMatch")]
        public object IfMatch { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IfNoneMatch")]
        public object IfNoneMatch { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Request")]
        public object Request { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RawValues")]
        public ODataRawQueryOptions RawValues { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SelectExpand")]
        public SelectExpandQueryOption SelectExpand { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Apply")]
        public ApplyQueryOption Apply { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Filter")]
        public FilterQueryOption Filter { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderBy")]
        public OrderByQueryOption OrderBy { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Skip")]
        public SkipQueryOption Skip { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Top")]
        public TopQueryOption Top { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public CountQueryOption Count { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Validator")]
        public object Validator { get; set; }

    }
}
