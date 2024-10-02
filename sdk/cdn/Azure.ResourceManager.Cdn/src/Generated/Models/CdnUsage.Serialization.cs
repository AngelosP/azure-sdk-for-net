// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnUsage : IUtf8JsonSerializable, IJsonModel<CdnUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnUsage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CdnUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnUsage)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentValue))
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteNumberValue(CurrentValue.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Limit))
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
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

        CdnUsage IJsonModel<CdnUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnUsage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnUsage(document.RootElement, options);
        }

        internal static CdnUsage DeserializeCdnUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceType = default;
            CdnUsageUnit? unit = default;
            int? currentValue = default;
            int? limit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new CdnUsageUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CdnUsage(resourceType, unit, currentValue, limit, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CdnUsage)} does not support writing '{options.Format}' format.");
            }
        }

        CdnUsage IPersistableModel<CdnUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCdnUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
