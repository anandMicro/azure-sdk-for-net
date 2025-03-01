// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class SearchMetadata
    {
        internal static SearchMetadata DeserializeSearchMetadata(JsonElement element)
        {
            Optional<string> requestId = default;
            Optional<string> resultType = default;
            Optional<long> total = default;
            Optional<long> top = default;
            Optional<string> id = default;
            Optional<IReadOnlyList<CoreSummary>> coreSummaries = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> lastUpdated = default;
            Optional<ETag> eTag = default;
            Optional<IReadOnlyList<SearchSort>> sort = default;
            Optional<long> requestTime = default;
            Optional<string> aggregatedValueField = default;
            Optional<string> aggregatedGroupingFields = default;
            Optional<long> sum = default;
            Optional<long> max = default;
            Optional<SearchMetadataSchema> schema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    total = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("top"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    top = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreSummaries"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CoreSummary> array = new List<CoreSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CoreSummary.DeserializeCoreSummary(item));
                    }
                    coreSummaries = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SearchSort> array = new List<SearchSort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchSort.DeserializeSearchSort(item));
                    }
                    sort = array;
                    continue;
                }
                if (property.NameEquals("requestTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("aggregatedValueField"))
                {
                    aggregatedValueField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregatedGroupingFields"))
                {
                    aggregatedGroupingFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sum"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("max"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    max = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schema = SearchMetadataSchema.DeserializeSearchMetadataSchema(property.Value);
                    continue;
                }
            }
            return new SearchMetadata(requestId.Value, resultType.Value, Optional.ToNullable(total), Optional.ToNullable(top), id.Value, Optional.ToList(coreSummaries), status.Value, Optional.ToNullable(startTime), Optional.ToNullable(lastUpdated), Optional.ToNullable(eTag), Optional.ToList(sort), Optional.ToNullable(requestTime), aggregatedValueField.Value, aggregatedGroupingFields.Value, Optional.ToNullable(sum), Optional.ToNullable(max), schema.Value);
        }
    }
}
