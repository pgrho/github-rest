using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Repository
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("clone_url")]
        public string CloneUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("git_url")]
        public string GitUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("ssh_url")]
        public string SshUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("svn_url")]
        public string SvnUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("mirror_url")]
        public string MirrorUrl { get; set; }

        [DefaultValue(0L)]
        [DataMember, JsonProperty("id")]
        public long Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("owner")]
        public User Owner { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("full_name")]
        public string FullName { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public string Description { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("homepage")]
        public string Homepage { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("language")]
        public string Language { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("private")]
        public bool Private { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("fork")]
        public bool Fork { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("forks_count")]
        public int ForksCount { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("watchers_count")]
        public int WatchersCount { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("public")]
        public bool Public { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pushed_at")]
        public DateTimeOffset? PushedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("permissions")]
        public RepositoryPermissions Permissions { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("parent")]
        public Repository Parent { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("source")]
        public Repository Source { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("subscribers_count")]
        public int SubscribersCount { get; set; }

        [DefaultValue(0L)]
        [DataMember, JsonProperty("size")]
        public long Size { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("forks")]
        public int Forks { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("watchers")]
        public int Watchers { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        #region Url

        [DefaultValue(null)]
        [DataMember, JsonProperty("forks_url")]
        public string ForksUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("keys_url")]
        public string KeysUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("collaborators_url")]
        public string CollaboratorsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("teams_url")]
        public string TeamsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("hooks_url")]
        public string HooksUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issue_events_url")]
        public string IssueEventsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assignees_url")]
        public string AssigneesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("branches_url")]
        public string BranchesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("tags_url")]
        public string TagsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("blobs_url")]
        public string BlobsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("git_tags_url")]
        public string GitTagsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("git_refs_url")]
        public string GitRefsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("trees_url")]
        public string TreesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("languages_url")]
        public string LanguagesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("stargazers_url")]
        public string StargazersUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("contributors_url")]
        public string ContributorsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("subscribers_url")]
        public string SubscribersUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("subscription_url")]
        public string SubscriptionUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issue_comment_url")]
        public string IssueCommentUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("contents_url")]
        public string ContentsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("compare_url")]
        public string CompareUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("merges_url")]
        public string MergesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("downloads_url")]
        public string DownloadsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pulls_url")]
        public string PullsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("milestones_url")]
        public string MilestonesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("notifications_url")]
        public string NotificationsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("labels_url")]
        public string LabelsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        #endregion Url
    }
}