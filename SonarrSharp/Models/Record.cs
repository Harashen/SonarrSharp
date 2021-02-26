using System;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// Gets or sets the episode identifier.
        /// </summary>
        /// <value>
        /// The episode identifier.
        /// </value>
        [JsonPropertyName("episodeId")] public int EpisodeId { get; set; }

        /// <summary>
        /// Gets or sets the series identifier.
        /// </summary>
        /// <value>
        /// The series identifier.
        /// </value>
        [JsonPropertyName("seriesId")] public int SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the source title.
        /// </summary>
        /// <value>
        /// The source title.
        /// </value>
        [JsonPropertyName("sourceTitle")] public string SourceTitle { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public RecordQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [quality cutoff not met].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [quality cutoff not met]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("qualityCutoffNotMet")] public bool QualityCutoffNotMet { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [JsonPropertyName("date")] public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the download identifier.
        /// </summary>
        /// <value>
        /// The download identifier.
        /// </value>
        [JsonPropertyName("downloadId")] public string DownloadId { get; set; }

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        /// <value>
        /// The type of the event.
        /// </value>
        [JsonPropertyName("eventType")] public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonPropertyName("data")] public Data Data { get; set; }

        /// <summary>
        /// Gets or sets the episode.
        /// </summary>
        /// <value>
        /// The episode.
        /// </value>
        [JsonPropertyName("episode")] public Episode Episode { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        [JsonPropertyName("series")] public Series Series { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
