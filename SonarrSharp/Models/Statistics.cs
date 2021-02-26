using System;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Statistics
    {
        /// <summary>
        /// Gets or sets the previous airing.
        /// </summary>
        /// <value>
        /// The previous airing.
        /// </value>
        [JsonPropertyName("previousAiring")] public DateTimeOffset PreviousAiring { get; set; }

        /// <summary>
        /// Gets or sets the episode file count.
        /// </summary>
        /// <value>
        /// The episode file count.
        /// </value>
        [JsonPropertyName("episodeFileCount")] public int EpisodeFileCount { get; set; }

        /// <summary>
        /// Gets or sets the episode count.
        /// </summary>
        /// <value>
        /// The episode count.
        /// </value>
        [JsonPropertyName("episodeCount")] public int EpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the total episode count.
        /// </summary>
        /// <value>
        /// The total episode count.
        /// </value>
        [JsonPropertyName("totalEpisodeCount")] public int TotalEpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the size on disk.
        /// </summary>
        /// <value>
        /// The size on disk.
        /// </value>
        [JsonPropertyName("sizeOnDisk")] public long SizeOnDisk { get; set; }

        /// <summary>
        /// Gets or sets the percent of episodes.
        /// </summary>
        /// <value>
        /// The percent of episodes.
        /// </value>
        [JsonPropertyName("percentOfEpisodes")] public double PercentOfEpisodes { get; set; }
    }
}
