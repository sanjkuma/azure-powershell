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

using Microsoft.Azure.Management.Internal.Resources.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.Internal.Resources
{
    public static partial class ResourceManagementClientExtensions
    {
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Internal.Resources.IResourceManagementClient.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse GetLongRunningOperationStatus(this IResourceManagementClient operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IResourceManagementClient)s).GetLongRunningOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Internal.Resources.IResourceManagementClient.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> GetLongRunningOperationStatusAsync(this IResourceManagementClient operations, string operationStatusLink)
        {
            return operations.GetLongRunningOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
    }
}
