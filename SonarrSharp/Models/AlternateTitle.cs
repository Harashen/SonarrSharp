using System.Text.Json.Serialization;

namespace SonarrSharp.Endpoints.Series.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AlternateTitle
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [JsonPropertyName("seasonNumber")] public int SeasonNumber { get; set; }
    }
}
