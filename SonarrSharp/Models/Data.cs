using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// Gets or sets the dropped path.
        /// </summary>
        /// <value>
        /// The dropped path.
        /// </value>
        [JsonPropertyName("droppedPath")] public string DroppedPath { get; set; }

        /// <summary>
        /// Gets or sets the imported path.
        /// </summary>
        /// <value>
        /// The imported path.
        /// </value>
        [JsonPropertyName("importedPath")] public string ImportedPath { get; set; }

        /// <summary>
        /// Gets or sets the download client.
        /// </summary>
        /// <value>
        /// The download client.
        /// </value>
        [JsonPropertyName("downloadClient")] public string DownloadClient { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        [JsonPropertyName("reason")] public string Reason { get; set; }
    }
}
