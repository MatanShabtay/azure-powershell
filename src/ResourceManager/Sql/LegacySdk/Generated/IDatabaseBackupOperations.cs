// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// Represents all the operations for operating on Azure SQL Database
    /// database backups.
    /// </summary>
    public partial interface IDatabaseBackupOperations
    {
        /// <summary>
        /// Begins creating or updating an Azure SQL Server backup
        /// LongTermRetention vault. To determine the status of the operation
        /// call GetBackupLongTermRetentionVaultOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server on which the database is hosted.
        /// </param>
        /// <param name='backupLongTermRetentionVaultName'>
        /// The name of the Azure SQL Server backup LongTermRetention vault.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for creating or updating a backup
        /// LongTermRetention vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure operations.
        /// </returns>
        Task<BackupLongTermRetentionVaultCreateOrUpdateResponse> BeginCreateOrUpdateBackupLongTermRetentionVaultAsync(string resourceGroupName, string serverName, string backupLongTermRetentionVaultName, BackupLongTermRetentionVaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins creating or updating an Azure SQL Server backup
        /// LongTermRetention policy. To determine the status of the operation
        /// call GetDatabaseBackupLongTermRetentionPolicyOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server on which the database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database to be operated on.
        /// </param>
        /// <param name='backupLongTermRetentionPolicyName'>
        /// The name of the Azure SQL Database backup LongTermRetention policy.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for creating or updating a database backup
        /// LongTermRetention policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure operations.
        /// </returns>
        Task<DatabaseBackupLongTermRetentionPolicyCreateOrUpdateResponse> BeginCreateOrUpdateDatabaseBackupLongTermRetentionPolicyAsync(string resourceGroupName, string serverName, string databaseName, string backupLongTermRetentionPolicyName, DatabaseBackupLongTermRetentionPolicyCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates or updates an Azure SQL Server backup LongTermRetention
        /// vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server on which the database is hosted.
        /// </param>
        /// <param name='backupLongTermRetentionVaultName'>
        /// The name of the Azure SQL Server backup LongTermRetention vault.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for creating or updating a backup
        /// LongTermRetention vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure operations.
        /// </returns>
        Task<BackupLongTermRetentionVaultCreateOrUpdateResponse> CreateOrUpdateBackupLongTermRetentionVaultAsync(string resourceGroupName, string serverName, string backupLongTermRetentionVaultName, BackupLongTermRetentionVaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates or updates an Azure SQL Database backup LongTermRetention
        /// policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server on which the database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database to be operated on (Updated or
        /// created).
        /// </param>
        /// <param name='backupLongTermRetentionPolicyName'>
        /// The name of the Azure SQL Database backup LongTermRetention policy.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for creating or updating a database backup
        /// LongTermRetention policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure operations.
        /// </returns>
        Task<DatabaseBackupLongTermRetentionPolicyCreateOrUpdateResponse> CreateOrUpdateDatabaseBackupLongTermRetentionPolicyAsync(string resourceGroupName, string serverName, string databaseName, string backupLongTermRetentionPolicyName, DatabaseBackupLongTermRetentionPolicyCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates a Azure SQL Database Geo Backup Policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to retrieve geo backup
        /// policies for.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database to retrieve geo backup policies
        /// for.
        /// </param>
        /// <param name='geoBackupPolicyName'>
        /// The name of the Azure SQL Database Geo Backup Policy to retrieve
        /// geo backup policies for.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for creating or updating a SQL Database Geo
        /// Backup Policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for Azure Sql Database Geo Backup Policy operations.
        /// </returns>
        Task<GeoBackupPolicyCreateOrUpdateResponse> CreateOrUpdateGeoBackupPolicyAsync(string resourceGroupName, string serverName, string databaseName, string geoBackupPolicyName, GeoBackupPolicyCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns an Azure SQL Server backup LongTermRetention vault
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server.
        /// </param>
        /// <param name='backupLongTermRetentionVaultName'>
        /// The name of the Azure SQL Database backup LongTermRetention vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Server backup
        /// LongTermRetention vault request.
        /// </returns>
        Task<BackupLongTermRetentionVaultGetResponse> GetBackupLongTermRetentionVaultAsync(string resourceGroupName, string serverName, string backupLongTermRetentionVaultName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the status of an Azure Sql Server backup LongTermRetention
        /// vault create or update operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure operations.
        /// </returns>
        Task<BackupLongTermRetentionVaultCreateOrUpdateResponse> GetBackupLongTermRetentionVaultOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns an Azure SQL Database backup LongTermRetention policy
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='backupLongTermRetentionPolicyName'>
        /// The name of the Azure SQL Database backup LongTermRetention policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database backup
        /// LongTermRetention policy request.
        /// </returns>
        Task<DatabaseBackupLongTermRetentionPolicyGetResponse> GetDatabaseBackupLongTermRetentionPolicyAsync(string resourceGroupName, string serverName, string databaseName, string backupLongTermRetentionPolicyName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the status of an Azure Sql Database backup LongTermRetention
        /// policy create or update operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure operations.
        /// </returns>
        Task<DatabaseBackupLongTermRetentionPolicyCreateOrUpdateResponse> GetDatabaseBackupLongTermRetentionPolicyOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns an Azure SQL deleted database backup (a resource
        /// representing a deleted database that can be restored).
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to retrieve deleted
        /// databases for.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database to retrieve deleted databases
        /// for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database deleted
        /// database backup request.
        /// </returns>
        Task<DeletedDatabaseBackupGetResponse> GetDeletedDatabaseBackupAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns an Azure SQL Database geo backup.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to retrieve geo backups
        /// for.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database to retrieve geo backups for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database geo backup
        /// request.
        /// </returns>
        Task<GeoBackupGetResponse> GetGeoBackupAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns an Azure SQL Database geo backup policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to retrieve geo backup
        /// policies for.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database to retrieve geo backup policies
        /// for.
        /// </param>
        /// <param name='geoBackupPolicyName'>
        /// The name of the Azure SQL Database Geo Backup Policy to retrieve
        /// geo backup policies for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database geo backup
        /// policy request.
        /// </returns>
        Task<GeoBackupPolicyGetResponse> GetGeoBackupPolicyAsync(string resourceGroupName, string serverName, string databaseName, string geoBackupPolicyName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a list of Azure SQL Server backup LongTermRetention vaults
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server backup
        /// LongTermRetention vault request.
        /// </returns>
        Task<BackupLongTermRetentionVaultListResponse> ListBackupLongTermRetentionVaultsAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a list of Azure SQL Database backup LongTermRetention
        /// policies
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database backup
        /// LongTermRetention policy request.
        /// </returns>
        Task<DatabaseBackupLongTermRetentionPolicyListResponse> ListDatabaseBackupLongTermRetentionPoliciesAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a list of Azure SQL deleted database backups (a resource
        /// representing a deleted database that can be restored).
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to retrieve deleted
        /// databases for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database deleted
        /// database backups request.
        /// </returns>
        Task<DeletedDatabaseBackupListResponse> ListDeletedDatabaseBackupsAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a list of Azure SQL Database geo backup policies.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to retrieve geo backup
        /// policies for.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database to retrieve geo backup policies
        /// for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database geo backup
        /// policies request.
        /// </returns>
        Task<GeoBackupPolicyListResponse> ListGeoBackupPoliciesAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a list of Azure SQL Database geo backups.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to retrieve geo backups
        /// for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database geo backups
        /// request.
        /// </returns>
        Task<GeoBackupListResponse> ListGeoBackupsAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a list of Azure SQL Database restore points.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database from which to retrieve available
        /// restore points.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database restore points
        /// request.
        /// </returns>
        Task<RestorePointListResponse> ListRestorePointsAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken);
    }
}
