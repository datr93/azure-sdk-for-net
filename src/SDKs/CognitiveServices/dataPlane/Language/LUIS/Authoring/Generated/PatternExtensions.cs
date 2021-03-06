// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Pattern.
    /// </summary>
    public static partial class PatternExtensions
    {
            /// <summary>
            /// Adds a pattern to a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='pattern'>
            /// The input pattern.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PatternRuleInfo> AddPatternAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, PatternRuleCreateObject pattern, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPatternWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, pattern, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets patterns in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PatternRuleInfo>> ListPatternsAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPatternsWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates patterns in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='patterns'>
            /// An array represents the patterns.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PatternRuleInfo>> UpdatePatternsAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, IList<PatternRuleUpdateObject> patterns, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdatePatternsWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, patterns, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a batch of patterns in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='patterns'>
            /// A JSON array containing patterns.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PatternRuleInfo>> BatchAddPatternsAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, IList<PatternRuleCreateObject> patterns, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BatchAddPatternsWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, patterns, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a list of patterns in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='patternIds'>
            /// The patterns IDs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> DeletePatternsAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, IList<System.Guid?> patternIds, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeletePatternsWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, patternIds, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a pattern in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='patternId'>
            /// The pattern ID.
            /// </param>
            /// <param name='pattern'>
            /// An object representing a pattern.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PatternRuleInfo> UpdatePatternAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, System.Guid patternId, PatternRuleUpdateObject pattern, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdatePatternWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, patternId, pattern, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the pattern with the specified ID from a version of the
            /// application..
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='patternId'>
            /// The pattern ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> DeletePatternAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, System.Guid patternId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeletePatternWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, patternId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns patterns for the specific intent in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='intentId'>
            /// The intent classifier ID.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PatternRuleInfo>> ListIntentPatternsAsync(this IPattern operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, System.Guid intentId, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListIntentPatternsWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, intentId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
