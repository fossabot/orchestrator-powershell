// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UserLoginAttempts.
    /// </summary>
    public static partial class UserLoginAttemptsExtensions
    {
            /// <summary>
            /// Gets the user's login attempts
            /// </summary>
            /// <remarks>
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            public static ODataResponseListUserLoginAttemptDto GetById(this IUserLoginAttempts operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the user's login attempts
            /// </summary>
            /// <remarks>
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListUserLoginAttemptDto> GetByIdAsync(this IUserLoginAttempts operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
