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
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Responses;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class CapabilitiesOperationsExtensions
    {
        /// <summary>
        /// Returns information about the Azure SQL capabilities available for
        /// the specified region.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.ICapabilitiesOperations.
        /// </param>
        /// <param name='locationName'>
        /// Required. The name of the region for which the Azure SQL
        /// capabilities are retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql capabilities request
        /// </returns>
        public static LocationCapabilitiesGetResponse Get(this ICapabilitiesOperations operations, string locationName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICapabilitiesOperations)s).GetAsync(locationName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about the Azure SQL capabilities available for
        /// the specified region.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.ICapabilitiesOperations.
        /// </param>
        /// <param name='locationName'>
        /// Required. The name of the region for which the Azure SQL
        /// capabilities are retrieved.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql capabilities request
        /// </returns>
        public static Task<LocationCapabilitiesGetResponse> GetAsync(this ICapabilitiesOperations operations, string locationName)
        {
            return operations.GetAsync(locationName, CancellationToken.None);
        }
    }
}
