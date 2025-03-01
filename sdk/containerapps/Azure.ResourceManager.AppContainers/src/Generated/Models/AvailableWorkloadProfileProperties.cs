// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Revision resource specific properties. </summary>
    public partial class AvailableWorkloadProfileProperties
    {
        /// <summary> Initializes a new instance of AvailableWorkloadProfileProperties. </summary>
        public AvailableWorkloadProfileProperties()
        {
        }

        /// <summary> Initializes a new instance of AvailableWorkloadProfileProperties. </summary>
        /// <param name="billingMeterCategory"> Used to map workload profile types to billing meter. </param>
        /// <param name="applicability"> indicates whether the profile is default for the location. </param>
        /// <param name="cores"> Number of cores in CPU. </param>
        /// <param name="memoryGiB"> Memory in GiB. </param>
        /// <param name="displayName"> The everyday name of the workload profile. </param>
        internal AvailableWorkloadProfileProperties(Category? billingMeterCategory, Applicability? applicability, int? cores, int? memoryGiB, string displayName)
        {
            BillingMeterCategory = billingMeterCategory;
            Applicability = applicability;
            Cores = cores;
            MemoryGiB = memoryGiB;
            DisplayName = displayName;
        }

        /// <summary> Used to map workload profile types to billing meter. </summary>
        public Category? BillingMeterCategory { get; set; }
        /// <summary> indicates whether the profile is default for the location. </summary>
        public Applicability? Applicability { get; set; }
        /// <summary> Number of cores in CPU. </summary>
        public int? Cores { get; set; }
        /// <summary> Memory in GiB. </summary>
        public int? MemoryGiB { get; set; }
        /// <summary> The everyday name of the workload profile. </summary>
        public string DisplayName { get; set; }
    }
}
