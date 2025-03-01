// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class AddonStatus
    {
        internal static AddonStatus DeserializeAddonStatus(JsonElement element)
        {
            Optional<string> errorMessage = default;
            Optional<string> phase = default;
            Optional<bool> ready = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phase"))
                {
                    phase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ready"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ready = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AddonStatus(errorMessage.Value, phase.Value, Optional.ToNullable(ready));
        }
    }
}
