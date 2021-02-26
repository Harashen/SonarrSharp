using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class QualityProfile
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonPropertyName("value")] public Value Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is loaded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is loaded; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isLoaded")] public bool IsLoaded { get; set; }
    }
}
