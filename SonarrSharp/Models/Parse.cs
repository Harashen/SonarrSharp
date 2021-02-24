using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Parse
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the parsed episode information.
        /// </summary>
        /// <value>
        /// The parsed episode information.
        /// </value>
        [JsonPropertyName("parsedEpisodeInfo")] public ParsedEpisodeInfo ParsedEpisodeInfo { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        [JsonPropertyName("series")] public Series Series { get; set; }

        /// <summary>
        /// Gets or sets the episodes.
        /// </summary>
        /// <value>
        /// The episodes.
        /// </value>
        [JsonPropertyName("episodes")] public List<Episode> Episodes { get; set; }
    }
}
