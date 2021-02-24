using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ParsedEpisodeInfo
    {
        /// <summary>
        /// Gets or sets the release title.
        /// </summary>
        /// <value>
        /// The release title.
        /// </value>
        [JsonPropertyName("releaseTitle")] public string ReleaseTitle { get; set; }

        /// <summary>
        /// Gets or sets the series title.
        /// </summary>
        /// <value>
        /// The series title.
        /// </value>
        [JsonPropertyName("seriesTitle")] public string SeriesTitle { get; set; }

        /// <summary>
        /// Gets or sets the series title information.
        /// </summary>
        /// <value>
        /// The series title information.
        /// </value>
        [JsonPropertyName("seriesTitleInfo")] public SeriesTitleInfo SeriesTitleInfo { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public ParsedEpisodeInfoQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [JsonPropertyName("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the episode numbers.
        /// </summary>
        /// <value>
        /// The episode numbers.
        /// </value>
        [JsonPropertyName("episodeNumbers")] public List<int> EpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets the absolute episode numbers.
        /// </summary>
        /// <value>
        /// The absolute episode numbers.
        /// </value>
        [JsonPropertyName("absoluteEpisodeNumbers")] public List<object> AbsoluteEpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonPropertyName("language")] public string Language { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [full season].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [full season]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("fullSeason")] public bool FullSeason { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ParsedEpisodeInfo"/> is special.
        /// </summary>
        /// <value>
        ///   <c>true</c> if special; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("special")] public bool Special { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [JsonPropertyName("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the release hash.
        /// </summary>
        /// <value>
        /// The release hash.
        /// </value>
        [JsonPropertyName("releaseHash")] public string ReleaseHash { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is daily.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is daily; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isDaily")] public bool IsDaily { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is absolute numbering.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is absolute numbering; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isAbsoluteNumbering")] public bool IsAbsoluteNumbering { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is possible special episode.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is possible special episode; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isPossibleSpecialEpisode")] public bool IsPossibleSpecialEpisode { get; set; }
    }
}
