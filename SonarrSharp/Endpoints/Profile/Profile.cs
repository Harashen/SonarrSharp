using SonarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Profile
{
    /// <summary>
    /// Profile endpoint client
	/// </summary>
	public class Profile : IProfile
    {
        private readonly SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Profile(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets all quality profiles
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.Profile>> GetProfiles()
        {
            var json = await _sonarrClient.GetJson($"/profile");
            return await Task.Run(() => JsonSerializer.Deserialize<List<Models.Profile>>(json, Converter.Settings));
        }
    }
}
