using System;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EpisodeFile
    {
        /// <summary>
        /// Gets or sets the series identifier.
        /// </summary>
        /// <value>
        /// The series identifier.
        /// </value>
        [JsonPropertyName("seriesId")] public int SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [JsonPropertyName("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [JsonPropertyName("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [JsonPropertyName("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the date added.
        /// </summary>
        /// <value>
        /// The date added.
        /// </value>
        [JsonPropertyName("dateAdded")] public DateTimeOffset DateAdded { get; set; }

        /// <summary>
        /// Gets or sets the name of the scene.
        /// </summary>
        /// <value>
        /// The name of the scene.
        /// </value>
        [JsonPropertyName("sceneName")] public string SceneName { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public EpisodeFileQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
