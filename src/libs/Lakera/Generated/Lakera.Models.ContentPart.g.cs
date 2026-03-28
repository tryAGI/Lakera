
#nullable enable

namespace Lakera
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentPart
    {
        /// <summary>
        /// The type of content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Lakera.JsonConverters.ContentPartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Lakera.ContentPartType Type { get; set; }

        /// <summary>
        /// Text content (when type is text).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::Lakera.ImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content part.
        /// </param>
        /// <param name="text">
        /// Text content (when type is text).
        /// </param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPart(
            global::Lakera.ContentPartType type,
            string? text,
            global::Lakera.ImageUrl? imageUrl)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        public ContentPart()
        {
        }
    }
}