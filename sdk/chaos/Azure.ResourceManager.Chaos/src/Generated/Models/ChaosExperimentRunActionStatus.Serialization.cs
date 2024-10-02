// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ChaosExperimentRunActionStatus : IUtf8JsonSerializable, IJsonModel<ChaosExperimentRunActionStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosExperimentRunActionStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChaosExperimentRunActionStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunActionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosExperimentRunActionStatus)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ActionName))
            {
                writer.WritePropertyName("actionName"u8);
                writer.WriteStringValue(ActionName);
            }
            if (options.Format != "W" && Optional.IsDefined(ActionId))
            {
                writer.WritePropertyName("actionId"u8);
                writer.WriteStringValue(ActionId);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Targets))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ChaosExperimentRunActionStatus IJsonModel<ChaosExperimentRunActionStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunActionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosExperimentRunActionStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosExperimentRunActionStatus(document.RootElement, options);
        }

        internal static ChaosExperimentRunActionStatus DeserializeChaosExperimentRunActionStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string actionName = default;
            string actionId = default;
            string status = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IReadOnlyList<ExperimentExecutionActionTargetDetailsProperties> targets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionName"u8))
                {
                    actionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionId"u8))
                {
                    actionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExperimentExecutionActionTargetDetailsProperties> array = new List<ExperimentExecutionActionTargetDetailsProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExperimentExecutionActionTargetDetailsProperties.DeserializeExperimentExecutionActionTargetDetailsProperties(item, options));
                    }
                    targets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChaosExperimentRunActionStatus(
                actionName,
                actionId,
                status,
                startTime,
                endTime,
                targets ?? new ChangeTrackingList<ExperimentExecutionActionTargetDetailsProperties>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChaosExperimentRunActionStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunActionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChaosExperimentRunActionStatus)} does not support writing '{options.Format}' format.");
            }
        }

        ChaosExperimentRunActionStatus IPersistableModel<ChaosExperimentRunActionStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunActionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChaosExperimentRunActionStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosExperimentRunActionStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosExperimentRunActionStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
