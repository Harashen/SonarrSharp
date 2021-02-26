using SonarrSharp.Enum;
using SonarrSharp.Extensions;

using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SonarrSharp.Helpers
{
	internal class Converter : JsonConverter<object>
    {
		public override bool CanConvert(Type t)
		{
			return t == typeof(Level) ||
             t == typeof(CoverType) ||
             t == typeof(SeriesType) ||
             t == typeof(Status) ||
             t == typeof(SystemBackupType) ||
             t == typeof(Protocol) ||
             t == typeof(QualityName) ||
             
             t == typeof(Level?) ||
             t == typeof(CoverType?) ||
             t == typeof(SeriesType?) ||
             t == typeof(Status?) ||
             t == typeof(SystemBackupType?) ||
             t == typeof(Protocol?) ||
             t == typeof(QualityName?);
		}

		public override object Read(ref Utf8JsonReader reader, Type t, JsonSerializerOptions options)
        {
            if (t == typeof(Level))
                return LevelExtensions.ReadJson(reader);
            if (t == typeof(CoverType))
                return CoverTypeExtensions.ReadJson(reader);
            if (t == typeof(SeriesType))
                return SeriesTypeExtensions.ReadJson(reader);
            if (t == typeof(Status))
                return StatusExtensions.ReadJson(reader);
            if (t == typeof(SystemBackupType))
                return SystemBackupTypeExtensions.ReadJson(reader);
            if (t == typeof(Protocol))
                return ProtocolExtensions.ReadJson(reader);
            if (t == typeof(QualityName))
                return QualityNameExtensions.ReadJson(reader);

            if (t == typeof(Level?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return LevelExtensions.ReadJson(reader);
            }
            if (t == typeof(CoverType?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return CoverTypeExtensions.ReadJson(reader);
            }
            if (t == typeof(SeriesType?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return SeriesTypeExtensions.ReadJson(reader);
            }
            if (t == typeof(Status?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return StatusExtensions.ReadJson(reader);
            }
            if (t == typeof(SystemBackupType?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return SystemBackupTypeExtensions.ReadJson(reader);
            }
            if (t == typeof(Protocol?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return ProtocolExtensions.ReadJson(reader);
            }
            if (t == typeof(QualityName?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return QualityNameExtensions.ReadJson(reader);
            }

            throw new Exception("Unknown type");
        }

		public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            var t = value.GetType();

            if (t == typeof(Level))
            {
                ((Level)value).WriteJson(writer);
                return;
            }
            if (t == typeof(CoverType))
            {
                ((CoverType)value).WriteJson(writer);
                return;
            }
            if (t == typeof(SeriesType))
            {
                ((SeriesType)value).WriteJson(writer);
                return;
            }
            if (t == typeof(Status))
            {
                ((Status)value).WriteJson(writer);
                return;
            }
            if (t == typeof(SystemBackupType))
            {
                ((SystemBackupType)value).WriteJson(writer);
                return;
            }
            if (t == typeof(Protocol))
            {
                ((Protocol)value).WriteJson(writer);
                return;
            }
            if (t == typeof(QualityName))
            {
                ((QualityName)value).WriteJson(writer);
                return;
            }

            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerOptions Settings = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters =
            {
                new Converter(),
                //new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            }
        };
    }
}
