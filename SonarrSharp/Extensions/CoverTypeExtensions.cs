using SonarrSharp.Enum;

using System;
using System.Text.Json;

namespace SonarrSharp.Extensions
{
    static class CoverTypeExtensions
    {
        public static CoverType? ValueForString(string str)
        {
            switch (str)
            {
                case "banner": return CoverType.Banner;
                case "fanart": return CoverType.FanArt;
                case "poster": return CoverType.Poster;
                default: return null;
            }
        }

        public static CoverType ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this CoverType value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case CoverType.Banner: JsonSerializer.Serialize(writer, "banner"); break;
                case CoverType.FanArt: JsonSerializer.Serialize(writer, "fanart"); break;
                case CoverType.Poster: JsonSerializer.Serialize(writer, "poster"); break;
            }
        }
    }
}
