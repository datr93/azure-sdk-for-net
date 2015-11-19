﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Search.Models;
    using Microsoft.Rest.Azure;

    public static partial class IndexerOperationsExtensions
    {
        /// <summary>
        /// Determines whether or not the given indexer exists in the Azure Search service.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name="indexerName">
        /// The name of the indexer.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <returns>
        /// <c>true</c> if the indexer exists; <c>false</c> otherwise.
        /// </returns>
        public static bool Exists(
            this IIndexersOperations operations, 
            string indexerName,
            SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
        {
            return Task.Factory.StartNew(s => ((IIndexersOperations)s).ExistsAsync(indexerName, searchRequestOptions), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Determines whether or not the given indexer exists in the Azure Search service.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name="indexerName">
        /// The name of the indexer.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <returns>
        /// <c>true</c> if the indexer exists; <c>false</c> otherwise.
        /// </returns>
        public static async Task<bool> ExistsAsync(
            this IIndexersOperations operations, 
            string indexerName, 
            SearchRequestOptions searchRequestOptions = default(SearchRequestOptions),
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                // Get validates indexName.
                await operations.GetAsync(indexerName, searchRequestOptions, cancellationToken).ConfigureAwait(false);
                return true;
            }
            catch (CloudException e)
            {
                if (e.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    return false;
                }

                throw;
            }
        }
    }
}
