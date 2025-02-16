using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hammlet.Models.BackEnd
{
    public class HomeAssistantStringEnumConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsEnum;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var converterType = typeof(HomeAssistantStringEnumConverter<>).MakeGenericType(typeToConvert);
            return (JsonConverter)Activator.CreateInstance(converterType);
        }
    }

    public class HomeAssistantStringEnumConverter<T> : JsonConverter<T> where T : struct, Enum
    {
        private readonly JsonNamingPolicy _namingPolicy = JsonNamingPolicy.SnakeCaseLower;

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var enumText = reader.GetString();
            if (enumText == null)
            {
                throw new JsonException();
            }

            foreach (var enumValue in Enum.GetValues(typeof(T)))
            {
                if (_namingPolicy.ConvertName(enumValue.ToString()).Equals(enumText, StringComparison.OrdinalIgnoreCase))
                {
                    return (T)enumValue;
                }
            }

            throw new JsonException($"Unable to convert \"{enumText}\" to Enum \"{typeof(T)}\".");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var enumText = _namingPolicy.ConvertName(value.ToString());
            writer.WriteStringValue(enumText);
        }
    }
}
