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

        [DefaultValue(null)]
        [DataMember, JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

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
    }
}