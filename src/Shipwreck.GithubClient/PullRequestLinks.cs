using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public sealed class PullRequestLinks
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("self")]
        public PullRequestLink Self { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html")]
        public PullRequestLink Html { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issue")]
        public PullRequestLink Issue { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("comments")]
        public PullRequestLink Comments { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("review_comments")]
        public PullRequestLink ReviewComments { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("review_comment")]
        public PullRequestLink ReviewComment { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commits")]
        public PullRequestLink Commits { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("statuses")]
        public PullRequestLink Statuses { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pull_request")]
        public PullRequestLink PullRequest { get; set; }
    }
}