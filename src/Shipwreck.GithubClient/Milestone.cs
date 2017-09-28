using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Milestone
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
        [DataMember, JsonProperty("labels_url")]
        public string LabelsUrl { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("number")]
        public int Number { get; set; }

        [DefaultValue(default(ItemState))]
        [DataMember, JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemState State { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("title")]
        public string Title { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public string Description { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("creator")]
        public User Creator { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("closed_issues")]
        public int ClosedIssues { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("due_on")]
        public DateTimeOffset? DueOn { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("closed_at")]
        public DateTimeOffset? ClosedAt { get; set; }
    }
}