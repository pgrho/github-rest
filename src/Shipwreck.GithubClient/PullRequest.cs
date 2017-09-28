using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class PullRequest
    {
        [DefaultValue(0L)]
        [DataMember, JsonProperty("id")]
        public long Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("diff_url")]
        public string DiffUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("patch_url")]
        public string PatchUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issue_url")]
        public string IssueUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("review_comments_url")]
        public string ReviewCommentsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("review_comment_url")]
        public string ReviewCommentUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

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

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("closed_at")]
        public DateTimeOffset? ClosedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("merged_at")]
        public DateTimeOffset? MergedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("head")]
        public GitReference Head { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("base")]
        public GitReference Base { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("user")]
        public User User { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assignee")]
        public User Assignee { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assignees")]
        public User[] Assignees { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("milestone")]
        public Milestone Milestone { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("merged")]
        public bool Merged { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("mergeable")]
        public bool? Mergeable { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("merged_by")]
        public User MergedBy { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("merge_commit_sha")]
        public string MergeCommitSha { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("comments")]
        public int Comments { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("review_comments")]
        public int ReviewComments { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("commits")]
        public int Commits { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("additions")]
        public int Additions { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("deletions")]
        public int Deletions { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("changed_files")]
        public int ChangedFiles { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("locked")]
        public bool Locked { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("requested_reviewers")]
        public User[] RequestedReviewers { get; set; }
    }
}