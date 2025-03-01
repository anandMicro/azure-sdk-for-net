// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    internal partial class UnknownAzureResourceBaseProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(AzureResourceType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownAzureResourceBaseProperties DeserializeUnknownAzureResourceBaseProperties(JsonElement element)
        {
            AzureResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new AzureResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAzureResourceBaseProperties(type);
        }
    }
}
