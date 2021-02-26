using SonarrSharp.Helpers;

using System.Text.Json;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Parse
{
    /// <summary>
    /// Parse endpoint client
	/// </summary>
	public class Parse : IParse
    {
        private readonly SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Parse"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Parse(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns the result of parsing a title
        /// </summary>
        /// <param name="title">Title</param>
        /// <returns></returns>
        public async Task<Models.Parse> ParseTitle(string title)
        {
            var json = await _sonarrClient.GetJson($"/parse?title={title}");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Parse>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns the result of parsing a path
        /// </summary>
        /// <param name="path">Path</param>
        /// <returns></returns>
        public async Task<Models.Parse> ParsePath(string path)
        {
            var json = await _sonarrClient.GetJson($"/parse?path={path}");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Parse>(json, Converter.Settings));
        }
    }
}
