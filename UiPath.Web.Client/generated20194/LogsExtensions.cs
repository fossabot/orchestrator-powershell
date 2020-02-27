// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Logs.
    /// </summary>
    public static partial class LogsExtensions
    {
            /// <summary>
            /// Inserts a log entry with a specified message in JSON format.
            /// </summary>
            /// <remarks>
            /// Required permissions: Logs.Create.
            ///
            /// Example of jMessage parameter.
            ///
            /// {
            /// "message": "TTT execution started",
            /// "level": "Information",
            /// "timeStamp": "2017-01-18T14:46:07.4152893+02:00",
            /// "windowsIdentity": "DESKTOP-1L50L0P\\WindowsUser",
            /// "agentSessionId": "00000000-0000-0000-0000-000000000000",
            /// "processName": "TTT",
            /// "fileName": "Main",
            /// "jobId": "8066c309-cef8-4b47-9163-b273fc14cc43"
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jMessage'>
            /// </param>
            public static void Post(this ILogs operations, object jMessage)
            {
                operations.PostAsync(jMessage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Inserts a log entry with a specified message in JSON format.
            /// </summary>
            /// <remarks>
            /// Required permissions: Logs.Create.
            ///
            /// Example of jMessage parameter.
            ///
            /// {
            /// "message": "TTT execution started",
            /// "level": "Information",
            /// "timeStamp": "2017-01-18T14:46:07.4152893+02:00",
            /// "windowsIdentity": "DESKTOP-1L50L0P\\WindowsUser",
            /// "agentSessionId": "00000000-0000-0000-0000-000000000000",
            /// "processName": "TTT",
            /// "fileName": "Main",
            /// "jobId": "8066c309-cef8-4b47-9163-b273fc14cc43"
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jMessage'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostAsync(this ILogs operations, object jMessage, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PostWithHttpMessagesAsync(jMessage, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Inserts a collection of log entries, each in a specific JSON format.
            /// </summary>
            /// <remarks>
            /// Required permissions: Logs.Create.
            ///
            /// Example of log entry:
            /// {
            /// "message": "TTT execution started",
            /// "level": "Information",
            /// "timeStamp": "2017-01-18T14:46:07.4152893+02:00",
            /// "windowsIdentity": "DESKTOP-1L50L0P\\WindowsUser",
            /// "agentSessionId": "00000000-0000-0000-0000-000000000000",
            /// "processName": "TTT",
            /// "fileName": "Main",
            /// "jobId": "8066c309-cef8-4b47-9163-b273fc14cc43"
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logEntries'>
            /// Collection of string representations of JSON objects
            /// </param>
            public static object SubmitLogs(this ILogs operations, IList<string> logEntries)
            {
                return operations.SubmitLogsAsync(logEntries).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Inserts a collection of log entries, each in a specific JSON format.
            /// </summary>
            /// <remarks>
            /// Required permissions: Logs.Create.
            ///
            /// Example of log entry:
            /// {
            /// "message": "TTT execution started",
            /// "level": "Information",
            /// "timeStamp": "2017-01-18T14:46:07.4152893+02:00",
            /// "windowsIdentity": "DESKTOP-1L50L0P\\WindowsUser",
            /// "agentSessionId": "00000000-0000-0000-0000-000000000000",
            /// "processName": "TTT",
            /// "fileName": "Main",
            /// "jobId": "8066c309-cef8-4b47-9163-b273fc14cc43"
            /// }
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='logEntries'>
            /// Collection of string representations of JSON objects
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SubmitLogsAsync(this ILogs operations, IList<string> logEntries, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.SubmitLogsWithHttpMessagesAsync(logEntries, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
