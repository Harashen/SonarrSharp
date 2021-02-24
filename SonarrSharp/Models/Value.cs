using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Value
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the allowed.
        /// </summary>
        /// <value>
        /// The allowed.
        /// </value>
        [JsonPropertyName("allowed")] public List<Allowed> Allowed { get; set; }

        /// <summary>
        /// Gets or sets the cutoff.
        /// </summary>
        /// <value>
        /// The cutoff.
        /// </value>
        [JsonPropertyName("cutoff")] public Allowed Cutoff { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
