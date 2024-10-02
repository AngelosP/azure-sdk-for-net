// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class SubscriptionEnrollmentDetails : IUtf8JsonSerializable, IJsonModel<SubscriptionEnrollmentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionEnrollmentDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SubscriptionEnrollmentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionEnrollmentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionEnrollmentDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DepartmentDisplayName))
            {
                writer.WritePropertyName("departmentDisplayName"u8);
                writer.WriteStringValue(DepartmentDisplayName);
            }
            if (Optional.IsDefined(DepartmentId))
            {
                writer.WritePropertyName("departmentId"u8);
                writer.WriteStringValue(DepartmentId);
            }
            if (Optional.IsDefined(EnrollmentAccountStatus))
            {
                writer.WritePropertyName("enrollmentAccountStatus"u8);
                writer.WriteStringValue(EnrollmentAccountStatus);
            }
            if (Optional.IsDefined(EnrollmentAccountDisplayName))
            {
                writer.WritePropertyName("enrollmentAccountDisplayName"u8);
                writer.WriteStringValue(EnrollmentAccountDisplayName);
            }
            if (Optional.IsDefined(EnrollmentAccountId))
            {
                writer.WritePropertyName("enrollmentAccountId"u8);
                writer.WriteStringValue(EnrollmentAccountId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        SubscriptionEnrollmentDetails IJsonModel<SubscriptionEnrollmentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionEnrollmentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionEnrollmentDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionEnrollmentDetails(document.RootElement, options);
        }

        internal static SubscriptionEnrollmentDetails DeserializeSubscriptionEnrollmentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string departmentDisplayName = default;
            string departmentId = default;
            string enrollmentAccountStatus = default;
            string enrollmentAccountDisplayName = default;
            string enrollmentAccountId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("departmentDisplayName"u8))
                {
                    departmentDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("departmentId"u8))
                {
                    departmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentAccountStatus"u8))
                {
                    enrollmentAccountStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentAccountDisplayName"u8))
                {
                    enrollmentAccountDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentAccountId"u8))
                {
                    enrollmentAccountId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SubscriptionEnrollmentDetails(
                departmentDisplayName,
                departmentId,
                enrollmentAccountStatus,
                enrollmentAccountDisplayName,
                enrollmentAccountId,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DepartmentDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  departmentDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DepartmentDisplayName))
                {
                    builder.Append("  departmentDisplayName: ");
                    if (DepartmentDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DepartmentDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DepartmentDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DepartmentId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  departmentId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DepartmentId))
                {
                    builder.Append("  departmentId: ");
                    if (DepartmentId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DepartmentId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DepartmentId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnrollmentAccountStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enrollmentAccountStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnrollmentAccountStatus))
                {
                    builder.Append("  enrollmentAccountStatus: ");
                    if (EnrollmentAccountStatus.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EnrollmentAccountStatus}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EnrollmentAccountStatus}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnrollmentAccountDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enrollmentAccountDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnrollmentAccountDisplayName))
                {
                    builder.Append("  enrollmentAccountDisplayName: ");
                    if (EnrollmentAccountDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EnrollmentAccountDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EnrollmentAccountDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnrollmentAccountId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enrollmentAccountId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnrollmentAccountId))
                {
                    builder.Append("  enrollmentAccountId: ");
                    if (EnrollmentAccountId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EnrollmentAccountId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EnrollmentAccountId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SubscriptionEnrollmentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionEnrollmentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SubscriptionEnrollmentDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SubscriptionEnrollmentDetails IPersistableModel<SubscriptionEnrollmentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionEnrollmentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubscriptionEnrollmentDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubscriptionEnrollmentDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubscriptionEnrollmentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
