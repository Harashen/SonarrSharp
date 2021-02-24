using System;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Calendar
    {
        /// <summary>
        /// Gets or sets the series identifier.
        /// </summary>
        /// <value>
        /// The series identifier.
        /// </value>
        [JsonPropertyName("seriesId")] public int SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the episode file identifier.
        /// </summary>
        /// <value>
        /// The episode file identifier.
        /// </value>
        [JsonPropertyName("episodeFileId")] public int EpisodeFileId { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [JsonPropertyName("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the episode number.
        /// </summary>
        /// <value>
        /// The episode number.
        /// </value>
        [JsonPropertyName("episodeNumber")] public int EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the air date.
        /// </summary>
        /// <value>
        /// The air date.
        /// </value>
        [JsonPropertyName("airDate")] public DateTimeOffset AirDate { get; set; }

        /// <summary>
        /// Gets or sets the air date UTC.
        /// </summary>
        /// <value>
        /// The air date UTC.
        /// </value>
        [JsonPropertyName("airDateUtc")] public DateTimeOffset AirDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [JsonPropertyName("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has file.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has file; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("hasFile")] public bool HasFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Calendar"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets the scene episode number.
        /// </summary>
        /// <value>
        /// The scene episode number.
        /// </value>
        [JsonPropertyName("sceneEpisodeNumber")] public int SceneEpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the scene season number.
        /// </summary>
        /// <value>
        /// The scene season number.
        /// </value>
        [JsonPropertyName("sceneSeasonNumber")] public int SceneSeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the tv database episode identifier.
        /// </summary>
        /// <value>
        /// The tv database episode identifier.
        /// </value>
        [JsonPropertyName("tvDbEpisodeId")] public int TvDbEpisodeId { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        [JsonPropertyName("series")] public Series Series { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Calendar"/> is downloading.
        /// </summary>
        /// <value>
        ///   <c>true</c> if downloading; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("downloading")] public bool Downloading { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
