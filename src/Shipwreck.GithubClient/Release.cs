using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Release
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assets_url")]
        public string AssetsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("upload_url")]
        public string UploadUrl { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("tag_name")]
        public string TagName { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("target_commitish")]
        public string TargetCommitish { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("body")]
        public string Body { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("draft")]
        public bool Draft { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("prerelease")]
        public bool Prerelease { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("published_at")]
        public DateTimeOffset? PublishedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("author")]
        public Author Author { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("tarball_url")]
        public string TarballUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("zipball_url")]
        public string ZipballUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assets")]
        public ReleaseAsset[] Assets { get; set; }
    }
}