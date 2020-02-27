// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CalendarDto
    {
        /// <summary>
        /// Initializes a new instance of the CalendarDto class.
        /// </summary>
        public CalendarDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CalendarDto class.
        /// </summary>
        public CalendarDto(string timeZoneId = default(string), IList<System.DateTime?> excludedDates = default(IList<System.DateTime?>))
        {
            TimeZoneId = timeZoneId;
            ExcludedDates = excludedDates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeZoneId")]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExcludedDates")]
        public IList<System.DateTime?> ExcludedDates { get; set; }

    }
}
