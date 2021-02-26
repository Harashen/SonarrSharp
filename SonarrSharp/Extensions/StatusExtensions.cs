using SonarrSharp.Enum;

using System;
using System.Text.Json;

namespace SonarrSharp.Extensions
{
    static class StatusExtensions
    {
        public static Status? ValueForString(string str)
        {
            switch (str)
            {
                case "continuing": return Status.Continuing;
                case "ended": return Status.Ended;
                default: return null;
            }
        }

        public static Status ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Status value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case Status.Continuing: JsonSerializer.Serialize(writer, "continuing"); break;
                case Status.Ended: JsonSerializer.Serialize(writer, "ended"); break;
            }
        }
    }
}
