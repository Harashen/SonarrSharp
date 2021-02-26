using SonarrSharp.Helpers;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Command
{
    /// <summary>
    /// Command endpoint client
	/// </summary>
	public class Command : ICommand
    {
        private readonly SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Command" /> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Command(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Queries the status of all currently started commands.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.Command>> GetCommands()
        {
            var json = await _sonarrClient.GetJson($"/command");
            return await Task.Run(() => JsonSerializer.Deserialize<List<Models.Command>>(json, Converter.Settings));
        }

        /// <summary>
        /// Queries the status of a previously started command
        /// </summary>
        /// <param name="id">Unique ID of the command</param>
        /// <returns></returns>
        public async Task<Models.Command> GetCommand(int id)
        {
            var json = await _sonarrClient.GetJson($"/command/{id}");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Refresh series information from trakt and rescan disk. If seriesId not set, all series will be refreshed and scanned
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        public async Task<Models.Command> RefreshSeries([Optional] int seriesId)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "refreshSeries",
                ["seriesId"] = seriesId
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Refresh rescan disk for a single series. If seriesId not set all series will be scanned
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        public async Task<Models.Command> RescanSeries([Optional] int seriesId)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "rescanSeries",
                ["seriesId"] = seriesId
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Search for one or more episodes
        /// </summary>
        /// <param name="episodeIds">Episode ID's</param>
        /// <returns></returns>
        public async Task<Models.Command> EpisodeSearch(int[] episodeIds)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "episodeSearch",
                ["episodeIds"] = episodeIds
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Search for all episodes of a particular season
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <param name="seasonNumber">Season number</param>
        /// <returns></returns>
        public async Task<Models.Command> SeasonSearch(int seriesId, int seasonNumber)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "seasonSearch",
                ["seriesId"] = seriesId,
                ["seasonNumber"] = seasonNumber
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Search for all episodes in a series
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        public async Task<Models.Command> SeriesSearch(int seriesId)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "seriesSearch",
                ["seriesId"] = seriesId
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Instruct Sonarr to perform an RSS sync with all enabled indexers
        /// </summary>
        public async Task<Models.Command> RssSync()
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "rssSync"
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Instruct Sonarr to rename the list of files provided
        /// </summary>
        /// <param name="files">List of File IDs to rename</param>
        public async Task<Models.Command> RenameFiles(int[] files)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "renameFiles",
                ["files"] = files
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Instruct Sonarr to rename all files in the provided series.
        /// </summary>
        /// <param name="seriesIds">List of Series IDs to rename</param>
        public async Task<Models.Command> RenameSeries(int[] seriesIds)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "renameSeries",
                ["seriesIds"] = seriesIds
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Instruct Sonarr to perform a backup of it's database and config file (nzbdrone.db and config.xml)
        /// </summary>
        public async Task<Models.Command> Backup()
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "backup"
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }

        /// <summary>
        /// Instruct Sonarr to perform a backlog search of missing episodes (Similar functionality to Sickbeard)
        /// </summary>
        public async Task<Models.Command> MissingEpisodeSearch()
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["name"] = "missingEpisodeSearch"
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Command>(json, Converter.Settings));
        }
    }
}
