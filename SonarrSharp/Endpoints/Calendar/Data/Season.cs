﻿using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Calendar.Data
{
    public partial class Season
    {
        [J("seasonNumber")] public long SeasonNumber { get; set; }
        [J("monitored")] public bool Monitored { get; set; }
    }
}
