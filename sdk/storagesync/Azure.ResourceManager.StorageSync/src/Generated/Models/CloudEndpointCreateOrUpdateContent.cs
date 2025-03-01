// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> The parameters used when creating a cloud endpoint. </summary>
    public partial class CloudEndpointCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of CloudEndpointCreateOrUpdateContent. </summary>
        public CloudEndpointCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of CloudEndpointCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="storageAccountResourceId"> Storage Account Resource Id. </param>
        /// <param name="azureFileShareName"> Azure file share name. </param>
        /// <param name="storageAccountTenantId"> Storage Account Tenant Id. </param>
        /// <param name="friendlyName"> Friendly Name. </param>
        internal CloudEndpointCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier storageAccountResourceId, string azureFileShareName, Guid? storageAccountTenantId, string friendlyName) : base(id, name, resourceType, systemData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            AzureFileShareName = azureFileShareName;
            StorageAccountTenantId = storageAccountTenantId;
            FriendlyName = friendlyName;
        }

        /// <summary> Storage Account Resource Id. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; set; }
        /// <summary> Azure file share name. </summary>
        public string AzureFileShareName { get; set; }
        /// <summary> Storage Account Tenant Id. </summary>
        public Guid? StorageAccountTenantId { get; set; }
        /// <summary> Friendly Name. </summary>
        public string FriendlyName { get; set; }
    }
}
