using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SeriesTitleInfo
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the title without year.
        /// </summary>
        /// <value>
        /// The title without year.
        /// </value>
        [JsonPropertyName("titleWithoutYear")] public string TitleWithoutYear { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [JsonPropertyName("year")] public int Year { get; set; }
    }
}
