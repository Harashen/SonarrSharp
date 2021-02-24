using SonarrSharp.Helpers;

using System.Text.Json;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SystemStatus
{
    /// <summary>
    /// SystemStatus endpoint client
	/// </summary>
	public class SystemStatus : ISystemStatus
    {
        private readonly SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatus"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public SystemStatus(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns system status
        /// </summary>
        /// <returns></returns>
        public async Task<Models.SystemStatus> GetSystemStatus()
        {
            var json = await _sonarrClient.GetJson("/system/status");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.SystemStatus>(json, Converter.Settings));
        }
    }
}
