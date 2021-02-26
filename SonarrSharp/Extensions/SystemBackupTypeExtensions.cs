using SonarrSharp.Enum;

using System;
using System.Text.Json;

namespace SonarrSharp.Extensions
{
    static class SystemBackupTypeExtensions
    {
        public static SystemBackupType? ValueForString(string str)
        {
            switch (str)
            {
                case "manual": return SystemBackupType.Manual;
                case "scheduled": return SystemBackupType.Scheduled;
                case "update": return SystemBackupType.Update;
                default: return null;
            }
        }

        public static SystemBackupType ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SystemBackupType value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case SystemBackupType.Manual: JsonSerializer.Serialize(writer, "manual"); break;
                case SystemBackupType.Scheduled: JsonSerializer.Serialize(writer, "scheduled"); break;
                case SystemBackupType.Update: JsonSerializer.Serialize(writer, "update"); break;
            }
        }
    }
}
