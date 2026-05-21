
#nullable enable

namespace Lakera
{
    /// <summary>
    /// Optional metadata to attach to this screening request for logging/tracking.
    /// </summary>
    public sealed partial class GuardRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}