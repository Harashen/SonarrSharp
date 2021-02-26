using SonarrSharp.Enum;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SeriesLookup
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the sort title.
        /// </summary>
        /// <value>
        /// The sort title.
        /// </value>
        [JsonPropertyName("sortTitle")] public string SortTitle { get; set; }

        /// <summary>
        /// Gets or sets the season count.
        /// </summary>
        /// <value>
        /// The season count.
        /// </value>
        [JsonPropertyName("seasonCount")] public int SeasonCount { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonPropertyName("status")] public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [JsonPropertyName("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the network.
        /// </summary>
        /// <value>
        /// The network.
        /// </value>
        [JsonPropertyName("network")] public string Network { get; set; }

        /// <summary>
        /// Gets or sets the air time.
        /// </summary>
        /// <value>
        /// The air time.
        /// </value>
        [JsonPropertyName("airTime")] public string AirTime { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [JsonPropertyName("images")] public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the remote poster.
        /// </summary>
        /// <value>
        /// The remote poster.
        /// </value>
        [JsonPropertyName("remotePoster")] public string RemotePoster { get; set; }

        /// <summary>
        /// Gets or sets the seasons.
        /// </summary>
        /// <value>
        /// The seasons.
        /// </value>
        [JsonPropertyName("seasons")] public List<Season> Seasons { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [JsonPropertyName("year")] public int Year { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier.
        /// </summary>
        /// <value>
        /// The profile identifier.
        /// </value>
        [JsonPropertyName("profileId")] public int ProfileId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [season folder].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [season folder]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("seasonFolder")] public bool SeasonFolder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SeriesLookup"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use scene numbering].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use scene numbering]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("useSceneNumbering")] public bool UseSceneNumbering { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [JsonPropertyName("runtime")] public long Runtime { get; set; }

        /// <summary>
        /// Gets or sets the TVDB identifier.
        /// </summary>
        /// <value>
        /// The TVDB identifier.
        /// </value>
        [JsonPropertyName("tvdbId")] public int TvdbId { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [JsonPropertyName("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the tv maze identifier.
        /// </summary>
        /// <value>
        /// The tv maze identifier.
        /// </value>
        [JsonPropertyName("tvMazeId")] public long TvMazeId { get; set; }

        /// <summary>
        /// Gets or sets the first aired.
        /// </summary>
        /// <value>
        /// The first aired.
        /// </value>
        [JsonPropertyName("firstAired")] public DateTimeOffset FirstAired { get; set; }

        /// <summary>
        /// Gets or sets the type of the series.
        /// </summary>
        /// <value>
        /// The type of the series.
        /// </value>
        [JsonPropertyName("seriesType")] public SeriesType SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the clean title.
        /// </summary>
        /// <value>
        /// The clean title.
        /// </value>
        [JsonPropertyName("cleanTitle")] public string CleanTitle { get; set; }

        /// <summary>
        /// Gets or sets the imdb identifier.
        /// </summary>
        /// <value>
        /// The imdb identifier.
        /// </value>
        [JsonPropertyName("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the title slug.
        /// </summary>
        /// <value>
        /// The title slug.
        /// </value>
        [JsonPropertyName("titleSlug")] public string TitleSlug { get; set; }

        /// <summary>
        /// Gets or sets the certification.
        /// </summary>
        /// <value>
        /// The certification.
        /// </value>
        [JsonPropertyName("certification")] public string Certification { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        [JsonPropertyName("genres")] public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [JsonPropertyName("tags")] public List<object> Tags { get; set; }

        /// <summary>
        /// Gets or sets the added.
        /// </summary>
        /// <value>
        /// The added.
        /// </value>
        [JsonPropertyName("added")] public DateTimeOffset Added { get; set; }

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        /// <value>
        /// The ratings.
        /// </value>
        [JsonPropertyName("ratings")] public Ratings Ratings { get; set; }

        /// <summary>
        /// Gets or sets the quality profile identifier.
        /// </summary>
        /// <value>
        /// The quality profile identifier.
        /// </value>
        [JsonPropertyName("qualityProfileId")] public int QualityProfileId { get; set; }
    }
}
