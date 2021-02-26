using SonarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Diskspace
{
    /// <summary>
    /// Diskspace endpoint client
	/// </summary>
	public class Diskspace : IDiskspace
    {
        private readonly SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Diskspace"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Diskspace(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets information about Diskspace
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.Diskspace>> GetDiskspace()
        {
            var json = await _sonarrClient.GetJson("/diskspace");
            return await Task.Run(() => JsonSerializer.Deserialize<List<Models.Diskspace>>(json, Converter.Settings));
        }
    }
}
