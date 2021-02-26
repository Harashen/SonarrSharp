using System;
using System.Text.Json.Serialization;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SystemStatus
    {
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [JsonPropertyName("version")] public string Version { get; set; }

        /// <summary>
        /// Gets or sets the build time.
        /// </summary>
        /// <value>
        /// The build time.
        /// </value>
        [JsonPropertyName("buildTime")] public DateTimeOffset BuildTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is debug.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is debug; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isDebug")] public bool IsDebug { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is production.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is production; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isProduction")] public bool IsProduction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is admin.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is admin; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isAdmin")] public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is user interactive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is user interactive; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isUserInteractive")] public bool IsUserInteractive { get; set; }

        /// <summary>
        /// Gets or sets the startup path.
        /// </summary>
        /// <value>
        /// The startup path.
        /// </value>
        [JsonPropertyName("startupPath")] public string StartupPath { get; set; }

        /// <summary>
        /// Gets or sets the application data.
        /// </summary>
        /// <value>
        /// The application data.
        /// </value>
        [JsonPropertyName("appData")] public string AppData { get; set; }

        /// <summary>
        /// Gets or sets the os version.
        /// </summary>
        /// <value>
        /// The os version.
        /// </value>
        [JsonPropertyName("osVersion")] public string OsVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is mono.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is mono; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isMono")] public bool IsMono { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is linux.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is linux; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isLinux")] public bool IsLinux { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is windows.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is windows; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isWindows")] public bool IsWindows { get; set; }

        /// <summary>
        /// Gets or sets the branch.
        /// </summary>
        /// <value>
        /// The branch.
        /// </value>
        [JsonPropertyName("branch")] public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the authentication.
        /// </summary>
        /// <value>
        /// The authentication.
        /// </value>
        [JsonPropertyName("authentication")] public string Authentication { get; set; }

        /// <summary>
        /// Gets or sets the start of week.
        /// </summary>
        /// <value>
        /// The start of week.
        /// </value>
        [JsonPropertyName("startOfWeek")] public int StartOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the URL base.
        /// </summary>
        /// <value>
        /// The URL base.
        /// </value>
        [JsonPropertyName("urlBase")] public string UrlBase { get; set; }
    }
}
