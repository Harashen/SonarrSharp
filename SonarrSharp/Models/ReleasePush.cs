using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleasePush
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [JsonPropertyName("guid")] public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public ReleasePushQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [JsonPropertyName("age")] public long Age { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [JsonPropertyName("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the indexer.
        /// </summary>
        /// <value>
        /// The indexer.
        /// </value>
        [JsonPropertyName("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [JsonPropertyName("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [full season].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [full season]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("fullSeason")] public bool FullSeason { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [scene source].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [scene source]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("sceneSource")] public bool SceneSource { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [JsonPropertyName("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonPropertyName("language")] public string Language { get; set; }

        /// <summary>
        /// Gets or sets the series title.
        /// </summary>
        /// <value>
        /// The series title.
        /// </value>
        [JsonPropertyName("seriesTitle")] public string SeriesTitle { get; set; }

        /// <summary>
        /// Gets or sets the episode numbers.
        /// </summary>
        /// <value>
        /// The episode numbers.
        /// </value>
        [JsonPropertyName("episodeNumbers")] public List<int> EpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReleasePush"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("approved")] public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [JsonPropertyName("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the rejections.
        /// </summary>
        /// <value>
        /// The rejections.
        /// </value>
        [JsonPropertyName("rejections")] public List<string> Rejections { get; set; }

        /// <summary>
        /// Gets or sets the publish date.
        /// </summary>
        /// <value>
        /// The publish date.
        /// </value>
        [JsonPropertyName("publishDate")] public DateTimeOffset PublishDate { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [JsonPropertyName("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [download allowed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [download allowed]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("downloadAllowed")] public bool DownloadAllowed { get; set; }
    }
}
