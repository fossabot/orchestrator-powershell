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
    /// Extension methods for Folders.
    /// </summary>
    public static partial class FoldersExtensions
    {
            /// <summary>
            /// Gets folders.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View - Gets all folders) and (SubFolders.View
            /// - Gets only folders where user has SubFoldersView permission).
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
            public static ODataResponseListFolderDto GetFolders(this IFolders operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetFoldersAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets folders.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View - Gets all folders) and (SubFolders.View
            /// - Gets only folders where user has SubFoldersView permission).
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
            public static async Task<ODataResponseListFolderDto> GetFoldersAsync(this IFolders operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetFoldersWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Create - Creates root or subfolder) and
            /// (SubFolders.Create - Creates subfolder if user has SubFoldersCreate
            /// permission on parent).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='folderDto'>
            /// </param>
            public static FolderDto Post(this IFolders operations, FolderDto folderDto)
            {
                return operations.PostAsync(folderDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Create - Creates root or subfolder) and
            /// (SubFolders.Create - Creates subfolder if user has SubFoldersCreate
            /// permission on parent).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='folderDto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FolderDto> PostAsync(this IFolders operations, FolderDto folderDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(folderDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single folder, based on its Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View - Gets any folder) and (SubFolders.View -
            /// Gets folder only if user has SubFoldersView permission on it).
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
            public static FolderDto GetById(this IFolders operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single folder, based on its Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View - Gets any folder) and (SubFolders.View -
            /// Gets folder only if user has SubFoldersView permission on it).
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
            public static async Task<FolderDto> GetByIdAsync(this IFolders operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edits a folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Edit - Edits any folder) and (SubFolders.Edit
            /// - Edits folder only if user has SubFoldersEdit permission on it).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='folderDto'>
            /// The entity to put
            /// </param>
            public static FolderDto PutById(this IFolders operations, long id, FolderDto folderDto)
            {
                return operations.PutByIdAsync(id, folderDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edits a folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Edit - Edits any folder) and (SubFolders.Edit
            /// - Edits folder only if user has SubFoldersEdit permission on it).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='folderDto'>
            /// The entity to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FolderDto> PutByIdAsync(this IFolders operations, long id, FolderDto folderDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(id, folderDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a folder. Succeeds only if no entities or user associations
            /// exist in this folder or any of its descendants.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Delete - Deletes any folder) and
            /// (SubFolders.Delete - Deletes folder only if user has SubFoldersDelete
            /// permission on it).
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
            public static void DeleteById(this IFolders operations, long id, string ifMatch = default(string))
            {
                operations.DeleteByIdAsync(id, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a folder. Succeeds only if no entities or user associations
            /// exist in this folder or any of its descendants.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Delete - Deletes any folder) and
            /// (SubFolders.Delete - Deletes folder only if user has SubFoldersDelete
            /// permission on it).
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
            public static async Task DeleteByIdAsync(this IFolders operations, long id, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Assigns one or more users to a set of folders with an optional set of roles
            /// per folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Edit or SubFolders.Edit) and (Users.View and
            /// Roles.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='assignUsersActionParameters'>
            /// </param>
            public static void AssignUsers(this IFolders operations, AssignUsersActionParameters assignUsersActionParameters = default(AssignUsersActionParameters))
            {
                operations.AssignUsersAsync(assignUsersActionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Assigns one or more users to a set of folders with an optional set of roles
            /// per folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Edit or SubFolders.Edit) and (Users.View and
            /// Roles.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='assignUsersActionParameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AssignUsersAsync(this IFolders operations, AssignUsersActionParameters assignUsersActionParameters = default(AssignUsersActionParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.AssignUsersWithHttpMessagesAsync(assignUsersActionParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the users who have access to a folder and optionally the
            /// fine-grained roles each one
            /// has on that folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View or SubFolders.View) and (Users.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='includeInherited'>
            /// If true, the response will include users inherited from ancestors
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
            public static ODataResponseListUserRolesDto GetUsersForFolderByKeyAndIncludeinherited(this IFolders operations, long key, bool includeInherited, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetUsersForFolderByKeyAndIncludeinheritedAsync(key, includeInherited, expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the users who have access to a folder and optionally the
            /// fine-grained roles each one
            /// has on that folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View or SubFolders.View) and (Users.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='includeInherited'>
            /// If true, the response will include users inherited from ancestors
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
            public static async Task<ODataResponseListUserRolesDto> GetUsersForFolderByKeyAndIncludeinheritedAsync(this IFolders operations, long key, bool includeInherited, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetUsersForFolderByKeyAndIncludeinheritedWithHttpMessagesAsync(key, includeInherited, expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove user assignment from a folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Edit or SubFolders.Edit) and (Users.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='removeUserFromFolderParameters'>
            /// userId - The Id of the user to remove from the folder
            /// </param>
            public static void RemoveUserFromFolderById(this IFolders operations, long id, RemoveUserFromFolderParameters removeUserFromFolderParameters)
            {
                operations.RemoveUserFromFolderByIdAsync(id, removeUserFromFolderParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove user assignment from a folder.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.Edit or SubFolders.Edit) and (Users.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='removeUserFromFolderParameters'>
            /// userId - The Id of the user to remove from the folder
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RemoveUserFromFolderByIdAsync(this IFolders operations, long id, RemoveUserFromFolderParameters removeUserFromFolderParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.RemoveUserFromFolderByIdWithHttpMessagesAsync(id, removeUserFromFolderParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a page of the user-folder assignments for the input user, including
            /// the roles for each folder.
            /// The response also includes the folders assigned to the directory groups of
            /// the user.
            /// The distinction between the folders assigned directly to the user and the
            /// ones assigned to one of his groups
            /// can be made via the User field of the response.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View or SubFolders.View) and (Users.View and
            /// Roles.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// User name
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            public static UserRoleAssignmentsDto GetAllRolesForUserByUsernameAndSkipAndTake(this IFolders operations, string username, int skip, int take)
            {
                return operations.GetAllRolesForUserByUsernameAndSkipAndTakeAsync(username, skip, take).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a page of the user-folder assignments for the input user, including
            /// the roles for each folder.
            /// The response also includes the folders assigned to the directory groups of
            /// the user.
            /// The distinction between the folders assigned directly to the user and the
            /// ones assigned to one of his groups
            /// can be made via the User field of the response.
            /// </summary>
            /// <remarks>
            /// Required permissions: (Units.View or SubFolders.View) and (Users.View and
            /// Roles.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// User name
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserRoleAssignmentsDto> GetAllRolesForUserByUsernameAndSkipAndTakeAsync(this IFolders operations, string username, int skip, int take, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAllRolesForUserByUsernameAndSkipAndTakeWithHttpMessagesAsync(username, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
