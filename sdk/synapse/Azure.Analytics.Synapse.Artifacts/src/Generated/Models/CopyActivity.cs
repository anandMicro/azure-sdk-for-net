// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Copy activity. </summary>
    public partial class CopyActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of CopyActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="source"> Copy activity source. </param>
        /// <param name="sink"> Copy activity sink. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="source"/> or <paramref name="sink"/> is null. </exception>
        public CopyActivity(string name, CopySource source, CopySink sink) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(sink, nameof(sink));

            Inputs = new ChangeTrackingList<DatasetReference>();
            Outputs = new ChangeTrackingList<DatasetReference>();
            Source = source;
            Sink = sink;
            PreserveRules = new ChangeTrackingList<object>();
            Preserve = new ChangeTrackingList<object>();
            Type = "Copy";
        }

        /// <summary> Initializes a new instance of CopyActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="inputs"> List of inputs for the activity. </param>
        /// <param name="outputs"> List of outputs for the activity. </param>
        /// <param name="source"> Copy activity source. </param>
        /// <param name="sink"> Copy activity sink. </param>
        /// <param name="translator"> Copy activity translator. If not specified, tabular translator is used. </param>
        /// <param name="enableStaging"> Specifies whether to copy data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="stagingSettings"> Specifies interim staging settings when EnableStaging is true. </param>
        /// <param name="parallelCopies"> Maximum number of concurrent sessions opened on the source or sink to avoid overloading the data store. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="dataIntegrationUnits"> Maximum number of data integration units that can be used to perform this data movement. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="enableSkipIncompatibleRow"> Whether to skip incompatible row. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="redirectIncompatibleRowSettings"> Redirect incompatible row settings when EnableSkipIncompatibleRow is true. </param>
        /// <param name="logStorageSettings"> (Deprecated. Please use LogSettings) Log storage settings customer need to provide when enabling session log. </param>
        /// <param name="logSettings"> Log settings customer needs provide when enabling log. </param>
        /// <param name="preserveRules"> Preserve Rules. </param>
        /// <param name="preserve"> Preserve rules. </param>
        /// <param name="validateDataConsistency"> Whether to enable Data Consistency validation. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="skipErrorFile"> Specify the fault tolerance for data consistency. </param>
        internal CopyActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<DatasetReference> inputs, IList<DatasetReference> outputs, CopySource source, CopySink sink, object translator, object enableStaging, StagingSettings stagingSettings, object parallelCopies, object dataIntegrationUnits, object enableSkipIncompatibleRow, RedirectIncompatibleRowSettings redirectIncompatibleRowSettings, LogStorageSettings logStorageSettings, LogSettings logSettings, IList<object> preserveRules, IList<object> preserve, object validateDataConsistency, SkipErrorFile skipErrorFile) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Inputs = inputs;
            Outputs = outputs;
            Source = source;
            Sink = sink;
            Translator = translator;
            EnableStaging = enableStaging;
            StagingSettings = stagingSettings;
            ParallelCopies = parallelCopies;
            DataIntegrationUnits = dataIntegrationUnits;
            EnableSkipIncompatibleRow = enableSkipIncompatibleRow;
            RedirectIncompatibleRowSettings = redirectIncompatibleRowSettings;
            LogStorageSettings = logStorageSettings;
            LogSettings = logSettings;
            PreserveRules = preserveRules;
            Preserve = preserve;
            ValidateDataConsistency = validateDataConsistency;
            SkipErrorFile = skipErrorFile;
            Type = type ?? "Copy";
        }

        /// <summary> List of inputs for the activity. </summary>
        public IList<DatasetReference> Inputs { get; }
        /// <summary> List of outputs for the activity. </summary>
        public IList<DatasetReference> Outputs { get; }
        /// <summary> Copy activity source. </summary>
        public CopySource Source { get; set; }
        /// <summary> Copy activity sink. </summary>
        public CopySink Sink { get; set; }
        /// <summary> Copy activity translator. If not specified, tabular translator is used. </summary>
        public object Translator { get; set; }
        /// <summary> Specifies whether to copy data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableStaging { get; set; }
        /// <summary> Specifies interim staging settings when EnableStaging is true. </summary>
        public StagingSettings StagingSettings { get; set; }
        /// <summary> Maximum number of concurrent sessions opened on the source or sink to avoid overloading the data store. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object ParallelCopies { get; set; }
        /// <summary> Maximum number of data integration units that can be used to perform this data movement. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object DataIntegrationUnits { get; set; }
        /// <summary> Whether to skip incompatible row. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableSkipIncompatibleRow { get; set; }
        /// <summary> Redirect incompatible row settings when EnableSkipIncompatibleRow is true. </summary>
        public RedirectIncompatibleRowSettings RedirectIncompatibleRowSettings { get; set; }
        /// <summary> (Deprecated. Please use LogSettings) Log storage settings customer need to provide when enabling session log. </summary>
        public LogStorageSettings LogStorageSettings { get; set; }
        /// <summary> Log settings customer needs provide when enabling log. </summary>
        public LogSettings LogSettings { get; set; }
        /// <summary> Preserve Rules. </summary>
        public IList<object> PreserveRules { get; }
        /// <summary> Preserve rules. </summary>
        public IList<object> Preserve { get; }
        /// <summary> Whether to enable Data Consistency validation. Type: boolean (or Expression with resultType boolean). </summary>
        public object ValidateDataConsistency { get; set; }
        /// <summary> Specify the fault tolerance for data consistency. </summary>
        public SkipErrorFile SkipErrorFile { get; set; }
    }
}
