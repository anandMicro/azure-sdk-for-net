// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> The properties of a service. </summary>
    public partial class ServiceProperties
    {
        /// <summary> Initializes a new instance of ServiceProperties. </summary>
        /// <param name="targetLocation"> The Azure location to which the resources in the service belong to or should be deployed to. </param>
        /// <param name="targetSubscriptionId"> The subscription to which the resources in the service belong to or should be deployed to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetLocation"/> or <paramref name="targetSubscriptionId"/> is null. </exception>
        internal ServiceProperties(string targetLocation, string targetSubscriptionId)
        {
            Argument.AssertNotNull(targetLocation, nameof(targetLocation));
            Argument.AssertNotNull(targetSubscriptionId, nameof(targetSubscriptionId));

            TargetLocation = targetLocation;
            TargetSubscriptionId = targetSubscriptionId;
        }

        /// <summary> The Azure location to which the resources in the service belong to or should be deployed to. </summary>
        public string TargetLocation { get; }
        /// <summary> The subscription to which the resources in the service belong to or should be deployed to. </summary>
        public string TargetSubscriptionId { get; }
    }
}
