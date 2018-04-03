﻿using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Log
{
    /// <summary>
    /// 
    /// </summary>
    public class Log : ILog
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Log(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets the log files.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.LogFile[]> GetLogFiles()
        {
            var json = await _sonarrClient.GetJson($"/log/file");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.LogFile[]>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Gets the log file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public async Task<string> GetLogFile(string filename)
        {
            string logFile = null;

            using (var wc = new WebClient { Headers = WebClientHelpers.GetWebHeaderCollection(_sonarrClient.ApiKey), Proxy = null })
            {
                try
                {
                    logFile = await wc.DownloadStringTaskAsync(_sonarrClient.ApiUrl + $"/log/file/filename={filename}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[SonarrSharp] [ERROR] [Log.GetLogFile] Filename: '{filename}', {ex}");
                }
            }

            if (!string.IsNullOrEmpty(logFile))
                return logFile;

            return null;
        }

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Log> GetLog()
        {
            var json = await _sonarrClient.GetJson($"/log");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.Log>(json, Converter.Settings);

            return null;
        }
    }
}