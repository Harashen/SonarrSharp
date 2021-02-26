using SonarrSharp.Enum;

using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
	/// <summary>
    /// 
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Gets or sets the type of the cover.
        /// </summary>
        /// <value>
        /// The type of the cover.
        /// </value>
        [JsonPropertyName("coverType")] public CoverType CoverType { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonPropertyName("url")] public string Url { get; set; }
    }
}
