// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class CertificateConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EncodedCertificate))
            {
                writer.WritePropertyName("encodedCertificate");
                writer.WriteStringValue(EncodedCertificate);
            }
            if (Optional.IsDefined(CertificatePassword))
            {
                writer.WritePropertyName("certificatePassword");
                writer.WriteStringValue(CertificatePassword);
            }
            writer.WritePropertyName("storeName");
            writer.WriteStringValue(StoreName.ToString());
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate");
                writer.WriteObjectValue(Certificate);
            }
            writer.WriteEndObject();
        }

        internal static CertificateConfiguration DeserializeCertificateConfiguration(JsonElement element)
        {
            Optional<string> encodedCertificate = default;
            Optional<string> certificatePassword = default;
            CertificateConfigurationStoreName storeName = default;
            Optional<CertificateInformation> certificate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedCertificate"))
                {
                    encodedCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificatePassword"))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storeName"))
                {
                    storeName = new CertificateConfigurationStoreName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificate = CertificateInformation.DeserializeCertificateInformation(property.Value);
                    continue;
                }
            }
            return new CertificateConfiguration(encodedCertificate.Value, certificatePassword.Value, storeName, certificate.Value);
        }
    }
}
