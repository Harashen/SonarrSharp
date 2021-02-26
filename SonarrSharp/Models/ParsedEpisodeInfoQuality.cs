using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ParsedEpisodeInfoQuality
    {
        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public QualityQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the revision.
        /// </summary>
        /// <value>
        /// The revision.
        /// </value>
        [JsonPropertyName("revision")] public Revision Revision { get; set; }
    }
}
