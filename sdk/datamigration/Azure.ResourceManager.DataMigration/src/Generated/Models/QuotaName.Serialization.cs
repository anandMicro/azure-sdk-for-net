// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class QuotaName
    {
        internal static QuotaName DeserializeQuotaName(JsonElement element)
        {
            Optional<string> localizedValue = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localizedValue"))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new QuotaName(localizedValue.Value, value.Value);
        }
    }
}
