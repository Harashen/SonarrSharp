using SonarrSharp.Enum;

using System;
using System.Text.Json;

namespace SonarrSharp.Extensions
{
    static class LevelExtensions
    {
        public static Level? ValueForString(string str)
        {
            switch (str)
            {
                case "Info": return Level.Info;
                case "Warn": return Level.Warn;
                case "Error": return Level.Error;
                default: return null;
            }
        }

        public static Level ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Level value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case Level.Info: JsonSerializer.Serialize(writer, "Info"); break;
                case Level.Warn: JsonSerializer.Serialize(writer, "Warn"); break;
                case Level.Error: JsonSerializer.Serialize(writer, "Error"); break;
            }
        }
    }
}
