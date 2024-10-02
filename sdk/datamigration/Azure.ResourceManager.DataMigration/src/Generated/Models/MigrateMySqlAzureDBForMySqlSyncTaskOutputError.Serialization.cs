// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDBForMySqlSyncTaskOutputError : IUtf8JsonSerializable, IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputError)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error, options);
            }
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutputError IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputError(document.RootElement, options);
        }

        internal static MigrateMySqlAzureDBForMySqlSyncTaskOutputError DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReportableException error = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ReportableException.DeserializeReportableException(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrateMySqlAzureDBForMySqlSyncTaskOutputError(id, resultType, serializedAdditionalRawData, error);
        }

        BinaryData IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputError)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutputError IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
