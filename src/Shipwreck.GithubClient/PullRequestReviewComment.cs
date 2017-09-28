using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class PullRequestReviewComment
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("diff_hunk")]
        public string DiffHunk { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("path")]
        public string Path { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("position")]
        public int? Position { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("original_position")]
        public int? OriginalPosition { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commit_id")]
        public string CommitId { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("original_commit_id")]
        public string OriginalCommitId { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("user")]
        public User User { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("body")]
        public string Body { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pull_request_url")]
        public string PullRequestUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("reactions")]
        public ReactionSummary Reactions { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("_links")]
        public PullRequestLinks Links { get; set; }
    }
}