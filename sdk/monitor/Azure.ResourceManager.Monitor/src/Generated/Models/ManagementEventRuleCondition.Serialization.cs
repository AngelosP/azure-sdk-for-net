// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ManagementEventRuleCondition : IUtf8JsonSerializable, IJsonModel<ManagementEventRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementEventRuleCondition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagementEventRuleCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Aggregation))
            {
                writer.WritePropertyName("aggregation"u8);
                writer.WriteObjectValue(Aggregation, options);
            }
        }

        ManagementEventRuleCondition IJsonModel<ManagementEventRuleCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementEventRuleCondition(document.RootElement, options);
        }

        internal static ManagementEventRuleCondition DeserializeManagementEventRuleCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagementEventAggregationCondition aggregation = default;
            string odataType = default;
            RuleDataSource dataSource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aggregation = ManagementEventAggregationCondition.DeserializeManagementEventAggregationCondition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSource = RuleDataSource.DeserializeRuleDataSource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagementEventRuleCondition(odataType, dataSource, serializedAdditionalRawData, aggregation);
        }

        BinaryData IPersistableModel<ManagementEventRuleCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementEventRuleCondition IPersistableModel<ManagementEventRuleCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementEventRuleCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementEventRuleCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementEventRuleCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
