// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Folders operations.
    /// </summary>
    public partial interface IFolders
    {
        /// <summary>
        /// Gets folders.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.View - Gets all folders) and
        /// (SubFolders.View - Gets only folders where user has SubFoldersView
        /// permission).
        /// </remarks>
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
        Task<HttpOperationResponse<ODataResponseListFolderDto>> GetFoldersWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates a new folder.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.Create - Creates root or subfolder)
        /// and (SubFolders.Create - Creates subfolder if user has
        /// SubFoldersCreate permission on parent).
        /// </remarks>
        /// <param name='folderDto'>
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
        Task<HttpOperationResponse<FolderDto>> PostWithHttpMessagesAsync(FolderDto folderDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a single folder, based on its Id.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.View - Gets any folder) and
        /// (SubFolders.View - Gets folder only if user has SubFoldersView
        /// permission on it).
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
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
        Task<HttpOperationResponse<FolderDto>> GetByIdWithHttpMessagesAsync(long id, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Edits a folder.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.Edit - Edits any folder) and
        /// (SubFolders.Edit - Edits folder only if user has SubFoldersEdit
        /// permission on it).
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='folderDto'>
        /// The entity to put
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
        Task<HttpOperationResponse<FolderDto>> PutByIdWithHttpMessagesAsync(long id, FolderDto folderDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a folder. Succeeds only if no entities or user associations
        /// exist in this folder or any of its descendants.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.Delete - Deletes any folder) and
        /// (SubFolders.Delete - Deletes folder only if user has
        /// SubFoldersDelete permission on it).
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='ifMatch'>
        /// If-Match header
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
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(long id, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Assigns one or more users to a set of folders with an optional set
        /// of roles per folder.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.Edit or SubFolders.Edit) and
        /// (Users.View and Roles.View).
        /// </remarks>
        /// <param name='assignUsersActionParameters'>
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
        Task<HttpOperationResponse> AssignUsersWithHttpMessagesAsync(AssignUsersActionParameters assignUsersActionParameters = default(AssignUsersActionParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns the users who have access to a folder and optionally the
        /// fine-grained roles each one
        /// has on that folder.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.View or SubFolders.View) and
        /// (Users.View).
        /// </remarks>
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
        Task<HttpOperationResponse<ODataResponseListUserRolesDto>> GetUsersForFolderByKeyAndIncludeinheritedWithHttpMessagesAsync(long key, bool includeInherited, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Remove user assignment from a folder.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.Edit or SubFolders.Edit) and
        /// (Users.View).
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='removeUserFromFolderParameters'>
        /// userId - The Id of the user to remove from the folder
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
        Task<HttpOperationResponse> RemoveUserFromFolderByIdWithHttpMessagesAsync(long id, RemoveUserFromFolderParameters removeUserFromFolderParameters, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns a page of the user-folder assignments for the input user,
        /// including the roles for each folder.
        /// The response also includes the folders assigned to the directory
        /// groups of the user.
        /// The distinction between the folders assigned directly to the user
        /// and the ones assigned to one of his groups
        /// can be made via the User field of the response.
        /// </summary>
        /// <remarks>
        /// Required permissions: (Units.View or SubFolders.View) and
        /// (Users.View and Roles.View).
        /// </remarks>
        /// <param name='username'>
        /// User name
        /// </param>
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
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
        Task<HttpOperationResponse<UserRoleAssignmentsDto>> GetAllRolesForUserByUsernameAndSkipAndTakeWithHttpMessagesAsync(string username, int skip, int take, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
