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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiCreateOrUpdatePropertiesWsdlSelector : IUtf8JsonSerializable, IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCreateOrUpdatePropertiesWsdlSelector)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(WsdlServiceName))
            {
                writer.WritePropertyName("wsdlServiceName"u8);
                writer.WriteStringValue(WsdlServiceName);
            }
            if (Optional.IsDefined(WsdlEndpointName))
            {
                writer.WritePropertyName("wsdlEndpointName"u8);
                writer.WriteStringValue(WsdlEndpointName);
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

        ApiCreateOrUpdatePropertiesWsdlSelector IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCreateOrUpdatePropertiesWsdlSelector)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiCreateOrUpdatePropertiesWsdlSelector(document.RootElement, options);
        }

        internal static ApiCreateOrUpdatePropertiesWsdlSelector DeserializeApiCreateOrUpdatePropertiesWsdlSelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string wsdlServiceName = default;
            string wsdlEndpointName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wsdlServiceName"u8))
                {
                    wsdlServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wsdlEndpointName"u8))
                {
                    wsdlEndpointName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiCreateOrUpdatePropertiesWsdlSelector(wsdlServiceName, wsdlEndpointName, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WsdlServiceName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  wsdlServiceName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WsdlServiceName))
                {
                    builder.Append("  wsdlServiceName: ");
                    if (WsdlServiceName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WsdlServiceName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WsdlServiceName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WsdlEndpointName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  wsdlEndpointName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WsdlEndpointName))
                {
                    builder.Append("  wsdlEndpointName: ");
                    if (WsdlEndpointName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WsdlEndpointName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WsdlEndpointName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApiCreateOrUpdatePropertiesWsdlSelector)} does not support writing '{options.Format}' format.");
            }
        }

        ApiCreateOrUpdatePropertiesWsdlSelector IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiCreateOrUpdatePropertiesWsdlSelector(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiCreateOrUpdatePropertiesWsdlSelector)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
