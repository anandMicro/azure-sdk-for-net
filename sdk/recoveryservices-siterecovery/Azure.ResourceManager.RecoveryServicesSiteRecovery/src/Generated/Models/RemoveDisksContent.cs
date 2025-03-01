// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input for remove disk(s) operation. </summary>
    public partial class RemoveDisksContent
    {
        /// <summary> Initializes a new instance of RemoveDisksContent. </summary>
        public RemoveDisksContent()
        {
        }

        /// <summary> Remove disk input properties. </summary>
        internal RemoveDisksInputProperties Properties { get; set; }
        /// <summary>
        /// The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider, it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
        /// Please note <see cref="RemoveDisksProviderSpecificInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ARemoveDisksInput"/>.
        /// </summary>
        public RemoveDisksProviderSpecificInput RemoveDisksInputProviderSpecificDetails
        {
            get => Properties is null ? default : Properties.ProviderSpecificDetails;
            set
            {
                if (Properties is null)
                    Properties = new RemoveDisksInputProperties();
                Properties.ProviderSpecificDetails = value;
            }
        }
    }
}
