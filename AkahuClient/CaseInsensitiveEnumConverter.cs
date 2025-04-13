using System.Text.Json;
using System.Text.Json.Serialization;

namespace AkahuClient;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

public class CaseInsensitiveEnumConverter<T> : JsonConverter<T> where T : struct, Enum
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var enumText = reader.GetString();

        // 先尝试直接匹配（大小写不敏感）
        if (Enum.TryParse<T>(enumText, ignoreCase: true, out var result))
        {
            return result;
        }

        // 尝试将 JSON 的 "PAYMENT_TO" → "PaymentTo"
        var transformed = ToPascalCase(enumText);

        if (Enum.TryParse<T>(transformed, ignoreCase: false, out result))
        {
            return result;
        }

        throw new JsonException($"Unable to convert \"{enumText}\" to enum {typeof(T)}.");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString()); // 输出仍为 PascalCase
    }

    private string ToPascalCase(string input)
    {
        return string.Join("", input.Split('_')
            .Select(part =>
                CultureInfo.InvariantCulture.TextInfo.ToTitleCase(part.ToLowerInvariant())
            ));
    }
}

