using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    public sealed class UnixEpochConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTimeOffset ofs)
            {
                writer.WriteValue(ofs.ToString("o"));
            }
            else if (value is DateTime dt)
            {
                writer.WriteValue(dt.ToString("o"));
            }
            else
            {
                writer.WriteValue(value);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value is DateTimeOffset dto)
            {
                return dto;
            }
            if (reader.Value is DateTime dt)
            {
                return (DateTimeOffset)dt;
            }
            if (reader.Value is long lv)
            {
                return DateTimeOffset.FromUnixTimeSeconds(lv);
            }
            if (reader.Value is int iv)
            {
                return DateTimeOffset.FromUnixTimeSeconds(iv);
            }
            if (reader.Value is uint uiv)
            {
                return DateTimeOffset.FromUnixTimeSeconds(uiv);
            }
            return null;
        }
    }
}