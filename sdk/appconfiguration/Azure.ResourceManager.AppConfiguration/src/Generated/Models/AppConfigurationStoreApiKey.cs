// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> An API key used for authenticating with a configuration store endpoint. </summary>
    public partial class AppConfigurationStoreApiKey
    {
        /// <summary> Initializes a new instance of AppConfigurationStoreApiKey. </summary>
        internal AppConfigurationStoreApiKey()
        {
        }

        /// <summary> Initializes a new instance of AppConfigurationStoreApiKey. </summary>
        /// <param name="id"> The key ID. </param>
        /// <param name="name"> A name for the key describing its usage. </param>
        /// <param name="value"> The value of the key that is used for authentication purposes. </param>
        /// <param name="connectionString"> A connection string that can be used by supporting clients for authentication. </param>
        /// <param name="lastModifiedOn"> The last time any of the key&apos;s properties were modified. </param>
        /// <param name="isReadOnly"> Whether this key can only be used for read operations. </param>
        internal AppConfigurationStoreApiKey(string id, string name, string value, string connectionString, DateTimeOffset? lastModifiedOn, bool? isReadOnly)
        {
            Id = id;
            Name = name;
            Value = value;
            ConnectionString = connectionString;
            LastModifiedOn = lastModifiedOn;
            IsReadOnly = isReadOnly;
        }

        /// <summary> The key ID. </summary>
        public string Id { get; }
        /// <summary> A name for the key describing its usage. </summary>
        public string Name { get; }
        /// <summary> The value of the key that is used for authentication purposes. </summary>
        public string Value { get; }
        /// <summary> A connection string that can be used by supporting clients for authentication. </summary>
        public string ConnectionString { get; }
        /// <summary> The last time any of the key&apos;s properties were modified. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Whether this key can only be used for read operations. </summary>
        public bool? IsReadOnly { get; }
    }
}
