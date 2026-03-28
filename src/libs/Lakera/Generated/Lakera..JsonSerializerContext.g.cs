
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Lakera
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Lakera.JsonConverters.GuardMessageRoleJsonConverter),

            typeof(global::Lakera.JsonConverters.GuardMessageRoleNullableJsonConverter),

            typeof(global::Lakera.JsonConverters.ContentPartTypeJsonConverter),

            typeof(global::Lakera.JsonConverters.ContentPartTypeNullableJsonConverter),

            typeof(global::Lakera.JsonConverters.ModeratedContentDetectorConfigCategorieJsonConverter),

            typeof(global::Lakera.JsonConverters.ModeratedContentDetectorConfigCategorieNullableJsonConverter),

            typeof(global::Lakera.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Lakera.ContentPart>>),

            typeof(global::Lakera.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.GuardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Lakera.GuardMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.GuardMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.Policy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.GuardMessageRole), TypeInfoPropertyName = "GuardMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.OneOf<string, global::System.Collections.Generic.IList<global::Lakera.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Lakera.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.ContentPartType), TypeInfoPropertyName = "ContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.DetectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.PiiDetectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.LanguageDetectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.ModeratedContentDetectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Lakera.ModeratedContentDetectorConfigCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.ModeratedContentDetectorConfigCategorie), TypeInfoPropertyName = "ModeratedContentDetectorConfigCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.GuardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.Categories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Lakera.MessageBreakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.MessageBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.GuardResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Lakera.DetectorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.DetectorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Lakera.DetailedMessageBreakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.DetailedMessageBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Lakera.DetectorMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.DetectorMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Lakera.GuardMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Lakera.OneOf<string, global::System.Collections.Generic.List<global::Lakera.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Lakera.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Lakera.ModeratedContentDetectorConfigCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Lakera.MessageBreakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Lakera.DetectorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Lakera.DetailedMessageBreakdown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Lakera.DetectorMatch>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}