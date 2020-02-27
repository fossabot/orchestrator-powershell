// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Stats operations.
    /// </summary>
    public partial interface IStats
    {
        /// <summary>
        /// Gets the total number of various entities registered in
        /// Orchestrator
        /// </summary>
        /// <remarks>
        /// Requires authentication.
        ///
        /// Returns the name and the total number of entities registered in
        /// Orchestrator for a set of entities.
        /// All the counted entity types can be seen in the result below.
        /// [
        /// {
        /// "title": "Processes",
        /// "count": 1
        /// },
        /// {
        /// "title": "Assets",
        /// "count": 0
        /// },
        /// {
        /// "title": "Queues",
        /// "count": 0
        /// },
        /// {
        /// "title": "Schedules",
        /// "count": 0
        /// }
        /// ]
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<CountStats>>> GetCountStatsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the total number of robots aggregated by Robot State
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.View.
        ///
        /// Returns the total number of Available, Busy, Disconnected and
        /// Unresponsive robots respectively.
        /// Example of returned result:
        /// [
        /// {
        /// "title": "Available",
        /// "count": 1
        /// },
        /// {
        /// "title": "Busy",
        /// "count": 0
        /// },
        /// {
        /// "title": "Disconnected",
        /// "count": 1
        /// },
        /// {
        /// "title": "Unresponsive",
        /// "count": 0
        /// }
        /// ]
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<CountStats>>> GetSessionsStatsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the total number of jobs aggregated by Job State
        /// </summary>
        /// <remarks>
        /// Required permissions: Jobs.View.
        ///
        /// Returns the total number of Successful, Faulted and Canceled jobs
        /// respectively.
        /// Example of returned result:
        /// [
        /// {
        /// "title": "Successful",
        /// "count": 0
        /// },
        /// {
        /// "title": "Faulted",
        /// "count": 0
        /// },
        /// {
        /// "title": "Canceled",
        /// "count": 0
        /// }
        /// ]
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<CountStats>>> GetJobsStatsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the licensing usage statistics
        /// </summary>
        /// <remarks>
        /// Required permissions: License.View.
        /// </remarks>
        /// <param name='tenantId'>
        /// The Tenant's Id - can be used when authenticated as Host
        /// </param>
        /// <param name='days'>
        /// Number of reported license usage days
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<LicenseStatsModel>>> GetLicenseStatsWithHttpMessagesAsync(int tenantId, int days, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
