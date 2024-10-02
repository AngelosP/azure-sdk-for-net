// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownJobInput))]
    public partial class MediaJobInputBasicProperties : IUtf8JsonSerializable, IJsonModel<MediaJobInputBasicProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobInputBasicProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaJobInputBasicProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputBasicProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobInputBasicProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        MediaJobInputBasicProperties IJsonModel<MediaJobInputBasicProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputBasicProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobInputBasicProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobInputBasicProperties(document.RootElement, options);
        }

        internal static MediaJobInputBasicProperties DeserializeMediaJobInputBasicProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.JobInputAsset": return MediaJobInputAsset.DeserializeMediaJobInputAsset(element, options);
                    case "#Microsoft.Media.JobInputClip": return MediaJobInputClip.DeserializeMediaJobInputClip(element, options);
                    case "#Microsoft.Media.JobInputHttp": return MediaJobInputHttp.DeserializeMediaJobInputHttp(element, options);
                    case "#Microsoft.Media.JobInputs": return MediaJobInputs.DeserializeMediaJobInputs(element, options);
                    case "#Microsoft.Media.JobInputSequence": return MediaJobInputSequence.DeserializeMediaJobInputSequence(element, options);
                }
            }
            return UnknownJobInput.DeserializeUnknownJobInput(element, options);
        }

        BinaryData IPersistableModel<MediaJobInputBasicProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputBasicProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaJobInputBasicProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MediaJobInputBasicProperties IPersistableModel<MediaJobInputBasicProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputBasicProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaJobInputBasicProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaJobInputBasicProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaJobInputBasicProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
