using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Season
    {
        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [JsonPropertyName("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Season"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets the statistics.
        /// </summary>
        /// <value>
        /// The statistics.
        /// </value>
        [JsonPropertyName("statistics")] public Statistics Statistics { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [JsonPropertyName("images")] public List<Image> Images { get; set; }
    }
}
