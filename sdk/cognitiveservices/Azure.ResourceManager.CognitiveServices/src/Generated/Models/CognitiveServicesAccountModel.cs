// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services account Model. </summary>
    public partial class CognitiveServicesAccountModel : CognitiveServicesAccountDeploymentModel
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccountModel. </summary>
        public CognitiveServicesAccountModel()
        {
            Capabilities = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of CognitiveServicesAccountModel. </summary>
        /// <param name="format"> Deployment model format. </param>
        /// <param name="name"> Deployment model name. </param>
        /// <param name="version"> Deployment model version. </param>
        /// <param name="callRateLimit"> The call rate limit Cognitive Services account. </param>
        /// <param name="baseModel"> Base Model Identifier. </param>
        /// <param name="maxCapacity"> The max capacity. </param>
        /// <param name="capabilities"> The capabilities. </param>
        /// <param name="deprecation"> Cognitive Services account ModelDeprecationInfo. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        internal CognitiveServicesAccountModel(string format, string name, string version, ServiceAccountCallRateLimit callRateLimit, CognitiveServicesAccountDeploymentModel baseModel, int? maxCapacity, IDictionary<string, string> capabilities, ServiceAccountModelDeprecationInfo deprecation, SystemData systemData) : base(format, name, version, callRateLimit)
        {
            BaseModel = baseModel;
            MaxCapacity = maxCapacity;
            Capabilities = capabilities;
            Deprecation = deprecation;
            SystemData = systemData;
        }

        /// <summary> Base Model Identifier. </summary>
        public CognitiveServicesAccountDeploymentModel BaseModel { get; set; }
        /// <summary> The max capacity. </summary>
        public int? MaxCapacity { get; set; }
        /// <summary> The capabilities. </summary>
        public IDictionary<string, string> Capabilities { get; }
        /// <summary> Cognitive Services account ModelDeprecationInfo. </summary>
        public ServiceAccountModelDeprecationInfo Deprecation { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
    }
}
