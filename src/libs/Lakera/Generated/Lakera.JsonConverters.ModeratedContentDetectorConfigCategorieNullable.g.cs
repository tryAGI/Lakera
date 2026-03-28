#nullable enable

namespace Lakera.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModeratedContentDetectorConfigCategorieNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Lakera.ModeratedContentDetectorConfigCategorie?>
    {
        /// <inheritdoc />
        public override global::Lakera.ModeratedContentDetectorConfigCategorie? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Lakera.ModeratedContentDetectorConfigCategorieExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Lakera.ModeratedContentDetectorConfigCategorie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Lakera.ModeratedContentDetectorConfigCategorie?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Lakera.ModeratedContentDetectorConfigCategorie? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Lakera.ModeratedContentDetectorConfigCategorieExtensions.ToValueString(value.Value));
            }
        }
    }
}
