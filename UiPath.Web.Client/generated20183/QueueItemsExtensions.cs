// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QueueItems.
    /// </summary>
    public static partial class QueueItemsExtensions
    {
            /// <summary>
            /// Gets a collection of queue items.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
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
            public static ODataResponseListQueueItemDto GetQueueItems(this IQueueItems operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetQueueItemsAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a collection of queue items.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
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
            public static async Task<ODataResponseListQueueItemDto> GetQueueItemsAsync(this IQueueItems operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetQueueItemsWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a queue item by Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
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
            public static QueueItemDto GetById(this IQueueItems operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a queue item by Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
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
            public static async Task<QueueItemDto> GetByIdAsync(this IQueueItems operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a queue item by Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Delete.
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
            public static void DeleteById(this IQueueItems operations, long id, string ifMatch = default(string))
            {
                operations.DeleteByIdAsync(id, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a queue item by Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Delete.
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
            public static async Task DeleteByIdAsync(this IQueueItems operations, long id, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns data about the processing history of the given queue item. Allows
            /// odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
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
            public static ODataResponseListQueueItemDto GetItemProcessingHistoryById(this IQueueItems operations, long id, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetItemProcessingHistoryByIdAsync(id, expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns data about the processing history of the given queue item. Allows
            /// odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
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
            public static async Task<ODataResponseListQueueItemDto> GetItemProcessingHistoryByIdAsync(this IQueueItems operations, long id, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetItemProcessingHistoryByIdWithHttpMessagesAsync(id, expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the review status of the specified queue items to an indicated
            /// state.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='itemReviewStatusParameters'>
            /// &lt;para /&gt;QueueItems - The collection of ids of queue items for which
            /// the state is set.
            /// &lt;para /&gt;Status - The new value for the review status.
            /// </param>
            public static BulkOperationResponseDtoInt64 SetItemReviewStatus(this IQueueItems operations, ItemReviewStatusParameters itemReviewStatusParameters = default(ItemReviewStatusParameters))
            {
                return operations.SetItemReviewStatusAsync(itemReviewStatusParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the review status of the specified queue items to an indicated
            /// state.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='itemReviewStatusParameters'>
            /// &lt;para /&gt;QueueItems - The collection of ids of queue items for which
            /// the state is set.
            /// &lt;para /&gt;Status - The new value for the review status.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BulkOperationResponseDtoInt64> SetItemReviewStatusAsync(this IQueueItems operations, ItemReviewStatusParameters itemReviewStatusParameters = default(ItemReviewStatusParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.SetItemReviewStatusWithHttpMessagesAsync(itemReviewStatusParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the given queue items' status to Deleted.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deleteBulkParameters'>
            /// QueueItems - The collection of ids of queue items to delete.
            /// </param>
            public static BulkOperationResponseDtoInt64 DeleteBulk(this IQueueItems operations, DeleteBulkParameters deleteBulkParameters = default(DeleteBulkParameters))
            {
                return operations.DeleteBulkAsync(deleteBulkParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the given queue items' status to Deleted.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deleteBulkParameters'>
            /// QueueItems - The collection of ids of queue items to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BulkOperationResponseDtoInt64> DeleteBulkAsync(this IQueueItems operations, DeleteBulkParameters deleteBulkParameters = default(DeleteBulkParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteBulkWithHttpMessagesAsync(deleteBulkParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the progress field of a queue item with the status 'In Progress'.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='transactionProgressParameters'>
            /// &lt;para /&gt;QueueItemId - The item's id.
            /// &lt;para /&gt;Progress - The value for the Progress field.
            /// </param>
            public static void SetTransactionProgressById(this IQueueItems operations, long id, TransactionProgressParameters transactionProgressParameters = default(TransactionProgressParameters))
            {
                operations.SetTransactionProgressByIdAsync(id, transactionProgressParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the progress field of a queue item with the status 'In Progress'.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='transactionProgressParameters'>
            /// &lt;para /&gt;QueueItemId - The item's id.
            /// &lt;para /&gt;Progress - The value for the Progress field.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetTransactionProgressByIdAsync(this IQueueItems operations, long id, TransactionProgressParameters transactionProgressParameters = default(TransactionProgressParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.SetTransactionProgressByIdWithHttpMessagesAsync(id, transactionProgressParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sets the reviewer for multiple queue items
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='setReviewerBulkParameters'>
            /// &lt;para /&gt;UserId - The ID of the user to be set as the reviewer. If not
            /// set, the reviewer is cleared.
            /// &lt;para /&gt;QueueItems - The collection of ids of queue items for which
            /// the reviewer is set.
            /// </param>
            public static BulkOperationResponseDtoInt64 SetItemReviewer(this IQueueItems operations, SetReviewerBulkParameters setReviewerBulkParameters)
            {
                return operations.SetItemReviewerAsync(setReviewerBulkParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the reviewer for multiple queue items
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='setReviewerBulkParameters'>
            /// &lt;para /&gt;UserId - The ID of the user to be set as the reviewer. If not
            /// set, the reviewer is cleared.
            /// &lt;para /&gt;QueueItems - The collection of ids of queue items for which
            /// the reviewer is set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BulkOperationResponseDtoInt64> SetItemReviewerAsync(this IQueueItems operations, SetReviewerBulkParameters setReviewerBulkParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.SetItemReviewerWithHttpMessagesAsync(setReviewerBulkParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Unsets the reviewer for multiple queue items
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='unsetReviewerBulkParameters'>
            /// &lt;para /&gt;QueueItems - The collection of ids of queue items for which
            /// the reviewer is unset.
            /// </param>
            public static BulkOperationResponseDtoInt64 UnsetItemReviewer(this IQueueItems operations, UnsetReviewerBulkParameters unsetReviewerBulkParameters = default(UnsetReviewerBulkParameters))
            {
                return operations.UnsetItemReviewerAsync(unsetReviewerBulkParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unsets the reviewer for multiple queue items
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='unsetReviewerBulkParameters'>
            /// &lt;para /&gt;QueueItems - The collection of ids of queue items for which
            /// the reviewer is unset.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BulkOperationResponseDtoInt64> UnsetItemReviewerAsync(this IQueueItems operations, UnsetReviewerBulkParameters unsetReviewerBulkParameters = default(UnsetReviewerBulkParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UnsetItemReviewerWithHttpMessagesAsync(unsetReviewerBulkParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a collection of users having the permission for Queue Items review.
            /// Allows odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
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
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            public static ODataResponseListUserDto GetReviewers(this IQueueItems operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetReviewersAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of users having the permission for Queue Items review.
            /// Allows odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.Edit.
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
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListUserDto> GetReviewersAsync(this IQueueItems operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetReviewersWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
