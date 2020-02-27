// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Users.
    /// </summary>
    public static partial class UsersExtensions
    {
            /// <summary>
            /// Gets users.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            public static ODataResponseListUserDto GetUsers(this IUsers operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetUsersAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets users.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListUserDto> GetUsersAsync(this IUsers operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetUsersWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new user.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userDto'>
            /// </param>
            public static UserDto Post(this IUsers operations, UserDto userDto)
            {
                return operations.PostAsync(userDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new user.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userDto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserDto> PostAsync(this IUsers operations, UserDto userDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(userDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a user based on its id.
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
            public static UserDto GetById(this IUsers operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a user based on its id.
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
            public static async Task<UserDto> GetByIdAsync(this IUsers operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edits a user.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='userDto'>
            /// </param>
            public static UserDto PutById(this IUsers operations, long id, UserDto userDto)
            {
                return operations.PutByIdAsync(id, userDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edits a user.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='userDto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserDto> PutByIdAsync(this IUsers operations, long id, UserDto userDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(id, userDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a user.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            public static void DeleteById(this IUsers operations, long id, string ifMatch = default(string))
            {
                operations.DeleteByIdAsync(id, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a user.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IUsers operations, long id, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Partially updates a user.
            /// Cannot update roles or organization units via this endpoint.
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
            /// <param name='userDto'>
            /// </param>
            public static void PatchById(this IUsers operations, long id, UserDto userDto)
            {
                operations.PatchByIdAsync(id, userDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Partially updates a user.
            /// Cannot update roles or organization units via this endpoint.
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
            /// <param name='userDto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchByIdAsync(this IUsers operations, long id, UserDto userDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PatchByIdWithHttpMessagesAsync(id, userDto, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a user permission collection containing data about the current user
            /// and all the permissions it has.
            /// </summary>
            /// <remarks>
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static UserPermissionsCollection GetCurrentPermissions(this IUsers operations)
            {
                return operations.GetCurrentPermissionsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a user permission collection containing data about the current user
            /// and all the permissions it has.
            /// </summary>
            /// <remarks>
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserPermissionsCollection> GetCurrentPermissionsAsync(this IUsers operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetCurrentPermissionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns details about the user currently logged into Orchestrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            public static UserDto GetCurrentUser(this IUsers operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetCurrentUserAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns details about the user currently logged into Orchestrator.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserDto> GetCurrentUserAsync(this IUsers operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetCurrentUserWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Associates/dissociates the given user with/from a role based on toggle
            /// parameter.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='toggleRoleParameters'>
            /// &lt;para /&gt;Toggle - States whether to associate or to dissociate the
            /// role with/from the user.
            /// &lt;para /&gt;Role - The name of the role to be associated/dissociated.
            /// </param>
            public static void ToggleRoleById(this IUsers operations, long id, ToggleRoleParameters toggleRoleParameters)
            {
                operations.ToggleRoleByIdAsync(id, toggleRoleParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates/dissociates the given user with/from a role based on toggle
            /// parameter.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='toggleRoleParameters'>
            /// &lt;para /&gt;Toggle - States whether to associate or to dissociate the
            /// role with/from the user.
            /// &lt;para /&gt;Role - The name of the role to be associated/dissociated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ToggleRoleByIdAsync(this IUsers operations, long id, ToggleRoleParameters toggleRoleParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.ToggleRoleByIdWithHttpMessagesAsync(id, toggleRoleParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Imports from AD all users from the given group and associates them with
            /// given roles.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='importUsersParameters'>
            /// &lt;para /&gt;Group - The name of the AD group whose users are to be
            /// imported.
            /// &lt;para /&gt;RolesList - The collection of roles the imported users will
            /// be associated with.
            /// &lt;para /&gt;OrganizationUnitIds - The collection of ids of the
            /// organization units the imported users will be associated with.
            /// </param>
            public static void ImportUsers(this IUsers operations, ImportUsersParameters importUsersParameters = default(ImportUsersParameters))
            {
                operations.ImportUsersAsync(importUsersParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Imports from AD all users from the given group and associates them with
            /// given roles.
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='importUsersParameters'>
            /// &lt;para /&gt;Group - The name of the AD group whose users are to be
            /// imported.
            /// &lt;para /&gt;RolesList - The collection of roles the imported users will
            /// be associated with.
            /// &lt;para /&gt;OrganizationUnitIds - The collection of ids of the
            /// organization units the imported users will be associated with.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ImportUsersAsync(this IUsers operations, ImportUsersParameters importUsersParameters = default(ImportUsersParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.ImportUsersWithHttpMessagesAsync(importUsersParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Changes the password of the user. This method can be called only by host
            /// users.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='changePasswordParameters'>
            /// &lt;para /&gt;CurrentPassword - The current password of the user.
            /// &lt;para /&gt;NewPassword - Then new password of the user.
            /// </param>
            public static void ChangePasswordById(this IUsers operations, long id, ChangePasswordDto changePasswordParameters)
            {
                operations.ChangePasswordByIdAsync(id, changePasswordParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the password of the user. This method can be called only by host
            /// users.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='changePasswordParameters'>
            /// &lt;para /&gt;CurrentPassword - The current password of the user.
            /// &lt;para /&gt;NewPassword - Then new password of the user.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ChangePasswordByIdAsync(this IUsers operations, long id, ChangePasswordDto changePasswordParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.ChangePasswordByIdWithHttpMessagesAsync(id, changePasswordParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Activate or deactivate a user
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='setUserActiveParameters'>
            /// </param>
            public static void SetActiveById(this IUsers operations, long id, SetUserActiveParameters setUserActiveParameters)
            {
                operations.SetActiveByIdAsync(id, setUserActiveParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Activate or deactivate a user
            /// </summary>
            /// <remarks>
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='setUserActiveParameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetActiveByIdAsync(this IUsers operations, long id, SetUserActiveParameters setUserActiveParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.SetActiveByIdWithHttpMessagesAsync(id, setUserActiveParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Changes the culture for the current user
            /// </summary>
            /// <remarks>
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='changeCultureParameters'>
            /// </param>
            public static void ChangeCulture(this IUsers operations, ChangeCultureParameters changeCultureParameters = default(ChangeCultureParameters))
            {
                operations.ChangeCultureAsync(changeCultureParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the culture for the current user
            /// </summary>
            /// <remarks>
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='changeCultureParameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ChangeCultureAsync(this IUsers operations, ChangeCultureParameters changeCultureParameters = default(ChangeCultureParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.ChangeCultureWithHttpMessagesAsync(changeCultureParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the user password for the provided Username and Tenancy Name.
            /// This endpoint is intended to be used via API to update the first login
            /// password.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updatePasswordParameters'>
            /// </param>
            public static void UpdatePassword(this IUsers operations, UpdateUserPasswordDto updatePasswordParameters)
            {
                operations.UpdatePasswordAsync(updatePasswordParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the user password for the provided Username and Tenancy Name.
            /// This endpoint is intended to be used via API to update the first login
            /// password.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updatePasswordParameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePasswordAsync(this IUsers operations, UpdateUserPasswordDto updatePasswordParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.UpdatePasswordWithHttpMessagesAsync(updatePasswordParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
