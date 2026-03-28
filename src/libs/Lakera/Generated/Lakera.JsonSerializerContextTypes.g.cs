
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Lakera
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.GuardRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Lakera.GuardMessage>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.GuardMessage? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.Policy? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.GuardMessageRole? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.OneOf<string, global::System.Collections.Generic.IList<global::Lakera.ContentPart>>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Lakera.ContentPart>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.ContentPart? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.ContentPartType? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.ImageUrl? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.DetectorConfig? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.PiiDetectorConfig? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.LanguageDetectorConfig? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.ModeratedContentDetectorConfig? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Lakera.ModeratedContentDetectorConfigCategorie>? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.ModeratedContentDetectorConfigCategorie? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.GuardResponse? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.Categories? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Lakera.MessageBreakdown>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.MessageBreakdown? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.GuardResultsResponse? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Lakera.DetectorResult>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.DetectorResult? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Lakera.DetailedMessageBreakdown>? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.DetailedMessageBreakdown? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Lakera.DetectorMatch>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.DetectorMatch? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.ErrorResponse? Type33 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Lakera.GuardMessage>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Lakera.OneOf<string, global::System.Collections.Generic.List<global::Lakera.ContentPart>>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Lakera.ContentPart>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Lakera.ModeratedContentDetectorConfigCategorie>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Lakera.MessageBreakdown>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Lakera.DetectorResult>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Lakera.DetailedMessageBreakdown>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Lakera.DetectorMatch>? ListType8 { get; set; }
    }
}