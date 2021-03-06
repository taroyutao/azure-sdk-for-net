// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for RecoveryPointsOperations.
    /// </summary>
    public static partial class RecoveryPointsOperationsExtensions
    {
            /// <summary>
            /// Provides the information of the backed up data identified using
            /// RecoveryPointID. This is an asynchronous operation. To know the status of
            /// the operation, call the GetProtectedItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item name whose backup data needs to be fetched.
            /// </param>
            /// <param name='recoveryPointId'>
            /// RecoveryPointID represents the backed up data to be fetched.
            /// </param>
            public static RecoveryPointResource Get(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRecoveryPointsOperations)s).GetAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, recoveryPointId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the information of the backed up data identified using
            /// RecoveryPointID. This is an asynchronous operation. To know the status of
            /// the operation, call the GetProtectedItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item name whose backup data needs to be fetched.
            /// </param>
            /// <param name='recoveryPointId'>
            /// RecoveryPointID represents the backed up data to be fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<RecoveryPointResource> GetAsync(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, recoveryPointId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the backup copies for the backed up item.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item whose backup copies are to be fetched.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<RecoveryPointResource> List(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, Microsoft.Rest.Azure.OData.ODataQuery<BMSRPQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<BMSRPQueryObject>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRecoveryPointsOperations)s).ListAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the backup copies for the backed up item.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backed up item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backed up item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backed up item whose backup copies are to be fetched.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<RecoveryPointResource>> ListAsync(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, Microsoft.Rest.Azure.OData.ODataQuery<BMSRPQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<BMSRPQueryObject>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the backup copies for the backed up item.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<RecoveryPointResource> ListNext(this IRecoveryPointsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRecoveryPointsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the backup copies for the backed up item.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<RecoveryPointResource>> ListNextAsync(this IRecoveryPointsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
