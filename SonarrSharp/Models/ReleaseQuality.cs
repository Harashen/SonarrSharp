using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleaseQuality
    {
        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public QualityQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReleaseQuality"/> is proper.
        /// </summary>
        /// <value>
        ///   <c>true</c> if proper; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("proper")] public bool Proper { get; set; }
    }
}
