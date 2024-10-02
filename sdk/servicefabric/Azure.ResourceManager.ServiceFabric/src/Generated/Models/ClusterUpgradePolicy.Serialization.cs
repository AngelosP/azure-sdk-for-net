// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterUpgradePolicy : IUtf8JsonSerializable, IJsonModel<ClusterUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterUpgradePolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterUpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterUpgradePolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ForceRestart))
            {
                writer.WritePropertyName("forceRestart"u8);
                writer.WriteBooleanValue(ForceRestart.Value);
            }
            writer.WritePropertyName("upgradeReplicaSetCheckTimeout"u8);
            writer.WriteStringValue(UpgradeReplicaSetCheckTimeout, "c");
            writer.WritePropertyName("healthCheckWaitDuration"u8);
            writer.WriteStringValue(HealthCheckWaitDuration, "c");
            writer.WritePropertyName("healthCheckStableDuration"u8);
            writer.WriteStringValue(HealthCheckStableDuration, "c");
            writer.WritePropertyName("healthCheckRetryTimeout"u8);
            writer.WriteStringValue(HealthCheckRetryTimeout, "c");
            writer.WritePropertyName("upgradeTimeout"u8);
            writer.WriteStringValue(UpgradeTimeout, "c");
            writer.WritePropertyName("upgradeDomainTimeout"u8);
            writer.WriteStringValue(UpgradeDomainTimeout, "c");
            writer.WritePropertyName("healthPolicy"u8);
            writer.WriteObjectValue(HealthPolicy, options);
            if (Optional.IsDefined(DeltaHealthPolicy))
            {
                writer.WritePropertyName("deltaHealthPolicy"u8);
                writer.WriteObjectValue(DeltaHealthPolicy, options);
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

        ClusterUpgradePolicy IJsonModel<ClusterUpgradePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterUpgradePolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterUpgradePolicy(document.RootElement, options);
        }

        internal static ClusterUpgradePolicy DeserializeClusterUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? forceRestart = default;
            TimeSpan upgradeReplicaSetCheckTimeout = default;
            TimeSpan healthCheckWaitDuration = default;
            TimeSpan healthCheckStableDuration = default;
            TimeSpan healthCheckRetryTimeout = default;
            TimeSpan upgradeTimeout = default;
            TimeSpan upgradeDomainTimeout = default;
            ClusterHealthPolicy healthPolicy = default;
            ClusterUpgradeDeltaHealthPolicy deltaHealthPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forceRestart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceRestart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("upgradeReplicaSetCheckTimeout"u8))
                {
                    upgradeReplicaSetCheckTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckWaitDuration"u8))
                {
                    healthCheckWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"u8))
                {
                    healthCheckStableDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"u8))
                {
                    healthCheckRetryTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"u8))
                {
                    upgradeTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"u8))
                {
                    upgradeDomainTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthPolicy"u8))
                {
                    healthPolicy = ClusterHealthPolicy.DeserializeClusterHealthPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deltaHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaHealthPolicy = ClusterUpgradeDeltaHealthPolicy.DeserializeClusterUpgradeDeltaHealthPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterUpgradePolicy(
                forceRestart,
                upgradeReplicaSetCheckTimeout,
                healthCheckWaitDuration,
                healthCheckStableDuration,
                healthCheckRetryTimeout,
                upgradeTimeout,
                upgradeDomainTimeout,
                healthPolicy,
                deltaHealthPolicy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterUpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterUpgradePolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterUpgradePolicy IPersistableModel<ClusterUpgradePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterUpgradePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterUpgradePolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterUpgradePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
