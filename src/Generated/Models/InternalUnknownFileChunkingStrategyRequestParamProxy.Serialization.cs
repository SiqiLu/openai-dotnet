// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.VectorStores
{
    internal partial class InternalUnknownFileChunkingStrategyRequestParamProxy : IJsonModel<InternalFileChunkingStrategyRequestParam>
    {
        void IJsonModel<InternalFileChunkingStrategyRequestParam>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFileChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFileChunkingStrategyRequestParam)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (true && _serializedAdditionalRawData != null)
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
            writer.WriteEndObject();
        }

        InternalFileChunkingStrategyRequestParam IJsonModel<InternalFileChunkingStrategyRequestParam>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFileChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFileChunkingStrategyRequestParam)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFileChunkingStrategyRequestParam(document.RootElement, options);
        }

        internal static InternalUnknownFileChunkingStrategyRequestParamProxy DeserializeInternalUnknownFileChunkingStrategyRequestParamProxy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalUnknownFileChunkingStrategyRequestParamProxy(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalFileChunkingStrategyRequestParam>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFileChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalFileChunkingStrategyRequestParam)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFileChunkingStrategyRequestParam IPersistableModel<InternalFileChunkingStrategyRequestParam>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFileChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalFileChunkingStrategyRequestParam(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFileChunkingStrategyRequestParam)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFileChunkingStrategyRequestParam>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new InternalUnknownFileChunkingStrategyRequestParamProxy FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalUnknownFileChunkingStrategyRequestParamProxy(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create<InternalFileChunkingStrategyRequestParam>(this, ModelSerializationExtensions.WireOptions);
        }
    }
}