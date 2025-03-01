// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class WeightResolution : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("unit");
            writer.WriteStringValue(Unit.ToString());
            writer.WritePropertyName("value");
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("resolutionKind");
            writer.WriteStringValue(ResolutionKind.ToString());
            writer.WriteEndObject();
        }

        internal static WeightResolution DeserializeWeightResolution(JsonElement element)
        {
            WeightUnit unit = default;
            double value = default;
            ResolutionKind resolutionKind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"))
                {
                    unit = new WeightUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("resolutionKind"))
                {
                    resolutionKind = new ResolutionKind(property.Value.GetString());
                    continue;
                }
            }
            return new WeightResolution(resolutionKind, unit, value);
        }
    }
}
