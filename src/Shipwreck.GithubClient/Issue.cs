using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Issue
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
        [DataMember, JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("events_url")]
        public string EventsUrl { get; set; }

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
        [DataMember, JsonProperty("body")]
        public string Body { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("closed_by")]
        public User ClosedBy { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("user")]
        public User User { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assignee")]
        public User Assignee { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assignees")]
        public User[] Assignees { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("milestone")]
        public Milestone Milestone { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("comments")]
        public int Comments { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("closed_at")]
        public DateTimeOffset? ClosedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("locked")]
        public bool Locked { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("repository")]
        public Repository Repository { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("reactions")]
        public ReactionSummary Reactions { get; set; }
    }
}