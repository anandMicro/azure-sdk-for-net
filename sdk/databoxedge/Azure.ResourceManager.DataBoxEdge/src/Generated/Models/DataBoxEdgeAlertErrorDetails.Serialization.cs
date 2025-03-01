// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeAlertErrorDetails
    {
        internal static DataBoxEdgeAlertErrorDetails DeserializeDataBoxEdgeAlertErrorDetails(JsonElement element)
        {
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<int> occurrences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("occurrences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    occurrences = property.Value.GetInt32();
                    continue;
                }
            }
            return new DataBoxEdgeAlertErrorDetails(errorCode.Value, errorMessage.Value, Optional.ToNullable(occurrences));
        }
    }
}
