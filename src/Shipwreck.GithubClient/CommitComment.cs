using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class CommitComment
    {
        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("body")]
        public string Body { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("path")]
        public string Path { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("position")]
        public int? Position { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("line")]
        public int? Line { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commit_id")]
        public string CommitId { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("user")]
        public User User { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("reactions")]
        public ReactionSummary Reactions { get; set; }
    }
}