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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RobotsService operations.
    /// </summary>
    public partial interface IRobotsService
    {
        /// <summary>
        /// Post to the server a collection of heartbeat messages generated by
        /// the Robots from a Machine
        /// </summary>
        /// <remarks>
        /// Every 30 seconds the UiPath service running on a Robot Machine
        /// posts a collection of heartbeat messages (one for each Robot hosted
        /// on the Machine).
        /// The response is a collection of commands specific to all the Robots
        /// defined on that Machine, including the ones that were added in the
        /// meanwhile.
        /// </remarks>
        /// <param name='payload'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<HeartbeatResponse>> HeartbeatWithHttpMessagesAsync(HeartbeatPayload payload, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Post to the server a heartbeat collection with jobs information
        /// </summary>
        /// <param name='heartbeats'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> SubmitJobStateWithHttpMessagesAsync(IList<HeartbeatDto> heartbeats, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets from the server all the processes associated with a Robot.
        /// </summary>
        /// <remarks>
        /// Gets from the server all the processes associated with a Robot
        /// </remarks>
        /// <param name='identifier'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<PublishedProcess>>> GetProcessesWithHttpMessagesAsync(RobotIdentifier identifier, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets from the server all the Robots associated with a Machine and
        /// having the specified licenseKey.
        /// If the received payload contains the ServiceUserName, it returns
        /// only the Robot with that specific UserName.
        /// </summary>
        /// <remarks>
        /// Gets from the server all the Robots associated with a Machine and
        /// having the specified licenseKey.
        /// </remarks>
        /// <param name='payload'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<RobotServiceResponse>> StartServiceWithHttpMessagesAsync(RobotServicePayload payload, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Called by RobotSvc to disconnect all Robots.
        /// </summary>
        /// <param name='payload'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> StopServiceWithHttpMessagesAsync(HeartbeatPayload payload, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Begins a front-office session.
        /// </summary>
        /// <param name='identifier'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<RobotDetailsDto>> BeginSessionWithHttpMessagesAsync(RobotIdentifier identifier, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Ends the front-office session.
        /// </summary>
        /// <param name='identifier'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> EndSessionWithHttpMessagesAsync(RobotIdentifier identifier, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Called by RobotSvc to connect the Robots on the machine it is
        /// running on to Orchestrator (under automatic deployment).
        /// </summary>
        /// <remarks>
        /// This is the initial handshake between the robot service and
        /// Orchestrator, the equivalent of configuring the connection
        /// info from Robot tray (manual deployment). It is supported only for
        /// authorized machines, i.e. the robot machine is part of the
        /// same AD as Orchestrator. To enforce this, the request must contain
        /// the machine identity. The robots must be already provisioned
        /// in Orchestrator before this step, otherwise RobotSvc will continue
        /// to call this method until they are.
        /// </remarks>
        /// <param name='tenantId'>
        /// The tenant under which already defined robots are searched for.
        /// </param>
        /// <param name='domainName'>
        /// Domain name for the machine where robot is installed. If it's not
        /// provided, we'll use the one specified in web.config
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
        Task<HttpOperationResponse<ConnectionData>> GetConnectionDataWithHttpMessagesAsync(int tenantId, string domainName = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Uploads a screenshot for the given jobKey and robotKey.
        /// </summary>
        /// <param name='file'>
        /// </param>
        /// <param name='robotKey'>
        /// </param>
        /// <param name='jobKey'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UploadScreenshotWithHttpMessagesAsync(Stream file, string robotKey, string jobKey, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Post to the server a collection of heartbeat messages generated by
        /// the Robots from a Machine
        /// </summary>
        /// <remarks>
        /// Every 30 seconds the UiPath service running on a Robot Machine
        /// posts a collection of heartbeat messages (one for each Robot hosted
        /// on the Machine).
        /// The response is a collection of commands specific to all robots
        /// defined on that Machine, including the ones that were added in the
        /// meanwhile.
        /// DEPRECATED. Used for Robots with version lower or equal to 18.2
        /// </remarks>
        /// <param name='hbts'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<IList<RobotCommand>>> SubmitHeartbeatWithHttpMessagesAsync(IList<HeartbeatDto> hbts, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets from the server all the processes associated with a Robot.
        /// </summary>
        /// <remarks>
        /// DEPRECATED. Gets from the server all the processes associated with
        /// a Robot
        /// </remarks>
        /// <param name='robotKey'>
        /// The unique key identifying the Robot.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<IList<PublishedProcess>>> GetAssociatedProcessesWithHttpMessagesAsync(string robotKey, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets from the server all the Robots associated with a Machine and
        /// having the specified licenseKey
        /// </summary>
        /// <remarks>
        /// Gets from the server all the Robots associated with a Machine and
        /// having the specified licenseKey.
        /// DEPRECATED. Used for Robots with version lower or equal to 18.2
        /// </remarks>
        /// <param name='licenseKey'>
        /// The licenseKey that the returned Robots must have.
        /// </param>
        /// <param name='machineName'>
        /// The name of the Machine that the returned Robots must be associated
        /// with
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<IList<RobotDetailsDto>>> GetRobotMappingsWithHttpMessagesAsync(string licenseKey, string machineName, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Acquire a license.
        /// </summary>
        /// <param name='identifier'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse> AcquireLicenseWithHttpMessagesAsync(RobotIdentifier identifier, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Release active license.
        /// </summary>
        /// <param name='identifier'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse> ReleaseLicenseWithHttpMessagesAsync(RobotIdentifier identifier, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
