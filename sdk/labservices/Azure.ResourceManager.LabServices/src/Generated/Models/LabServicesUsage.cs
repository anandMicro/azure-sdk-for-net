// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The core usage details. </summary>
    public partial class LabServicesUsage
    {
        /// <summary> Initializes a new instance of LabServicesUsage. </summary>
        internal LabServicesUsage()
        {
        }

        /// <summary> Initializes a new instance of LabServicesUsage. </summary>
        /// <param name="currentValue"> The current usage. </param>
        /// <param name="limit"> The limit integer. </param>
        /// <param name="unit"> The unit details. </param>
        /// <param name="name"> The name. </param>
        /// <param name="id"> The fully qualified arm resource id. </param>
        internal LabServicesUsage(long? currentValue, long? limit, LabServicesUsageUnit? unit, LabServicesUsageName name, ResourceIdentifier id)
        {
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            Name = name;
            Id = id;
        }

        /// <summary> The current usage. </summary>
        public long? CurrentValue { get; }
        /// <summary> The limit integer. </summary>
        public long? Limit { get; }
        /// <summary> The unit details. </summary>
        public LabServicesUsageUnit? Unit { get; }
        /// <summary> The name. </summary>
        public LabServicesUsageName Name { get; }
        /// <summary> The fully qualified arm resource id. </summary>
        public ResourceIdentifier Id { get; }
    }
}
