using SonarrSharp.Enum;

using System;
using System.Text.Json;

namespace SonarrSharp.Extensions
{
    static class SeriesTypeExtensions
    {
        public static SeriesType? ValueForString(string str)
        {
            switch (str)
            {
                case "anime": return SeriesType.Anime;
                case "standard": return SeriesType.Standard;
                case "daily": return SeriesType.Daily;
                default: return null;
            }
        }

        public static SeriesType ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            if (System.Enum.TryParse(str, out SeriesType type) && System.Enum.IsDefined(typeof(SeriesType), type))
                return type;

            throw new Exception("Unknown SeriesType \"" + str + "\"");
        }

        public static void WriteJson(this SeriesType value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case SeriesType.Anime: JsonSerializer.Serialize(writer, "anime"); break;
                case SeriesType.Standard: JsonSerializer.Serialize(writer, "standard"); break;
                case SeriesType.Daily: JsonSerializer.Serialize(writer, "daily"); break;
            }
        }
    }
}
