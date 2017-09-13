using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class ReleaseAsset
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("label")]
        public string Label { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("state")]
        public string State { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("content_type")]
        public string ContentType { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("size")]
        public int Size { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("download_count")]
        public int DownloadCount { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("browser_download_url")]
        public string BrowserDownloadUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("uploader")]
        public Author Uploader { get; set; }
    }
}