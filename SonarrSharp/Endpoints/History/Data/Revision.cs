﻿using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    public partial class Revision
    {
        [J("version")] public long Version { get; set; }
        [J("real")] public long Real { get; set; }
    }
}