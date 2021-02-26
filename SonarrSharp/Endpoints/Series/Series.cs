using SonarrSharp.Helpers;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Series
{
    /// <summary>
    /// Series endpoint client
	/// </summary>
	public class Series : ISeries
    {
        private readonly SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Series"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Series(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns all series in your collection
        /// </summary>
        /// <param name="includeSeasonImages">if set to <c>true</c> [include season images].</param>
        /// <returns></returns>
        public async Task<List<Models.Series>> GetSeries([Optional] bool includeSeasonImages)
        {
            var json = await _sonarrClient.GetJson($"/series{(includeSeasonImages ? $"?includeSeasonImages={includeSeasonImages}" : "")}");
            return await Task.Run(() => JsonSerializer.Deserialize<List<Models.Series>>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns the series with the matching ID
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <param name="includeSeasonImages">if set to <c>true</c> [include season images].</param>
        /// <returns></returns>
        public async Task<Models.Series> GetSeries(int seriesId, [Optional] bool includeSeasonImages)
        {
            var json = await _sonarrClient.GetJson($"/series/id={seriesId}{(includeSeasonImages ? $"?includeSeasonImages={includeSeasonImages}" : "")}");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Series>(json, Converter.Settings));
        }

        /// <summary>
        /// Adds a new series to your collection (Refer to https://github.com/Sonarr/Sonarr/wiki/Series for more information on usage)
        /// </summary>
        /// <param name="tvdbId">TV Database ID</param>
        /// <param name="title">Title</param>
        /// <param name="qualityProfileId">Quality profile ID</param>
        /// <param name="titleSlug">Title slug</param>
        /// <param name="images">Images array</param>
        /// <param name="seasons">Seasons array</param>
        /// <param name="rootFolderPath">Full path will be created by combining the rootFolderPath with the series title</param>
        /// <param name="tvRageId">TV Rage ID</param>
        /// <param name="seasonFolder">Use season folders</param>
        /// <param name="monitored">Is monitored</param>
        /// <param name="addOptions">Object that contains three boolean properties - If supplied, all properties are required</param>
        /// <returns></returns>
        public async Task<Models.Series> AddSeries(int tvdbId, string title, int qualityProfileId, string titleSlug, Models.Image[] images, Models.Season[] seasons, string rootFolderPath, [Optional] int tvRageId, [Optional] bool seasonFolder, [Optional] bool monitored, [Optional] AddOptions addOptions)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["tvdbId"] = tvdbId,
                ["title"] = title,
                ["qualityProfileId"] = qualityProfileId,
                ["titleSlug"] = titleSlug,
                ["images"] = images,
                ["seasons"] = seasons,
                ["rootFolderPath"] = rootFolderPath
            };

            if (monitored)
                dictionary.Add("monitored", monitored);

            if (seasonFolder)
                dictionary.Add("seasonFolder", seasonFolder);

            if (tvRageId != 0)
                dictionary.Add("tvRageId", tvRageId);

            if (addOptions != null)
                dictionary.Add("addOptions", addOptions);

            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>(dictionary));

            var json = await _sonarrClient.PostJson("/series", parameter, "POST");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Series>(json, Converter.Settings));
        }

        /// <summary>
        /// Update an existing series
        /// </summary>
        /// <param name="series">Series to update - Requires all properties of Data.Series object</param>
        /// <returns></returns>
        public async Task<Models.Series> UpdateSeries(Models.Series series)
        {
            var json = await _sonarrClient.PostJson("/series", JsonSerializer.Serialize(series, Converter.Settings), "PUT");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Series>(json, Converter.Settings));
        }

        /// <summary>
        /// Delete the series with the given ID
        /// </summary>
        /// <param name="id">Series ID</param>
        /// <param name="deleteFiles">if set to <c>true</c> the series folder and all files will be deleted when the series is deleted.</param>
        /// <returns></returns>
        public async Task DeleteSeries(int id, [Optional] bool deleteFiles)
        {
            await _sonarrClient.Delete($"/series/id={id}{(deleteFiles ? $"?deleteFiles={deleteFiles}" : "")}");
        }
    }
}
