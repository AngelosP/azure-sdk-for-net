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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class TruncationSelectionPolicy : IUtf8JsonSerializable, IJsonModel<TruncationSelectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TruncationSelectionPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TruncationSelectionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TruncationSelectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TruncationSelectionPolicy)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(TruncationPercentage))
            {
                writer.WritePropertyName("truncationPercentage"u8);
                writer.WriteNumberValue(TruncationPercentage.Value);
            }
        }

        TruncationSelectionPolicy IJsonModel<TruncationSelectionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TruncationSelectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TruncationSelectionPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTruncationSelectionPolicy(document.RootElement, options);
        }

        internal static TruncationSelectionPolicy DeserializeTruncationSelectionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? truncationPercentage = default;
            EarlyTerminationPolicyType policyType = default;
            int? evaluationInterval = default;
            int? delayEvaluation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("truncationPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    truncationPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyType"u8))
                {
                    policyType = new EarlyTerminationPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("evaluationInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("delayEvaluation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delayEvaluation = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TruncationSelectionPolicy(policyType, evaluationInterval, delayEvaluation, serializedAdditionalRawData, truncationPercentage);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TruncationPercentage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  truncationPercentage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TruncationPercentage))
                {
                    builder.Append("  truncationPercentage: ");
                    builder.AppendLine($"{TruncationPercentage.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PolicyType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  policyType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  policyType: ");
                builder.AppendLine($"'{PolicyType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EvaluationInterval), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  evaluationInterval: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EvaluationInterval))
                {
                    builder.Append("  evaluationInterval: ");
                    builder.AppendLine($"{EvaluationInterval.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DelayEvaluation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  delayEvaluation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DelayEvaluation))
                {
                    builder.Append("  delayEvaluation: ");
                    builder.AppendLine($"{DelayEvaluation.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<TruncationSelectionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TruncationSelectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TruncationSelectionPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        TruncationSelectionPolicy IPersistableModel<TruncationSelectionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TruncationSelectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTruncationSelectionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TruncationSelectionPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TruncationSelectionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
