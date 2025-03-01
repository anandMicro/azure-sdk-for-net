// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The data type definition. </summary>
    public partial class DataTypeDefinitions
    {
        /// <summary> Initializes a new instance of DataTypeDefinitions. </summary>
        public DataTypeDefinitions()
        {
        }

        /// <summary> Initializes a new instance of DataTypeDefinitions. </summary>
        /// <param name="dataType"> The data type name. </param>
        internal DataTypeDefinitions(string dataType)
        {
            DataType = dataType;
        }

        /// <summary> The data type name. </summary>
        public string DataType { get; set; }
    }
}
