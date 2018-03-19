﻿using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Season
    {
        /// <summary>
        /// 
        /// </summary>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("statistics")] public Statistics Statistics { get; set; }
    }
}
