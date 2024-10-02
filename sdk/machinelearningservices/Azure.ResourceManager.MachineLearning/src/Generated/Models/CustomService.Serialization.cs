// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomService : IUtf8JsonSerializable, IJsonModel<CustomService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomService>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomService)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteObjectValue(Image, options);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Docker))
            {
                if (Docker != null)
                {
                    writer.WritePropertyName("docker"u8);
                    writer.WriteObjectValue(Docker, options);
                }
                else
                {
                    writer.WriteNull("docker");
                }
            }
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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

        CustomService IJsonModel<CustomService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomService)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomService(document.RootElement, options);
        }

        internal static CustomService DeserializeCustomService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ImageSetting image = default;
            IDictionary<string, EnvironmentVariable> environmentVariables = default;
            DockerSetting docker = default;
            IList<ContainerEndpoint> endpoints = default;
            IList<VolumeDefinition> volumes = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    image = ImageSetting.DeserializeImageSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EnvironmentVariable> dictionary = new Dictionary<string, EnvironmentVariable>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EnvironmentVariable.DeserializeEnvironmentVariable(property0.Value, options));
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("docker"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        docker = null;
                        continue;
                    }
                    docker = DockerSetting.DeserializeDockerSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerEndpoint> array = new List<ContainerEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerEndpoint.DeserializeContainerEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("volumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VolumeDefinition> array = new List<VolumeDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VolumeDefinition.DeserializeVolumeDefinition(item, options));
                    }
                    volumes = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CustomService(
                name,
                image,
                environmentVariables ?? new ChangeTrackingDictionary<string, EnvironmentVariable>(),
                docker,
                endpoints ?? new ChangeTrackingList<ContainerEndpoint>(),
                volumes ?? new ChangeTrackingList<VolumeDefinition>(),
                additionalProperties);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Image), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  image: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Image))
                {
                    builder.Append("  image: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Image, options, 2, false, "  image: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnvironmentVariables), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  environmentVariables: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EnvironmentVariables))
                {
                    if (EnvironmentVariables.Any())
                    {
                        builder.Append("  environmentVariables: ");
                        builder.AppendLine("{");
                        foreach (var item in EnvironmentVariables)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  environmentVariables: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Docker), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  docker: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Docker))
                {
                    builder.Append("  docker: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Docker, options, 2, false, "  docker: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Endpoints), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpoints: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Endpoints))
                {
                    if (Endpoints.Any())
                    {
                        builder.Append("  endpoints: ");
                        builder.AppendLine("[");
                        foreach (var item in Endpoints)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  endpoints: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Volumes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  volumes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Volumes))
                {
                    if (Volumes.Any())
                    {
                        builder.Append("  volumes: ");
                        builder.AppendLine("[");
                        foreach (var item in Volumes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  volumes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CustomService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CustomService)} does not support writing '{options.Format}' format.");
            }
        }

        CustomService IPersistableModel<CustomService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomService)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
