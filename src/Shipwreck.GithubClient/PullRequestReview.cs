using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class PullRequestReview
    {
        [DefaultValue(0L)]
        [DataMember, JsonProperty("id")]
        public long Id { get; set; }

        [DefaultValue(default(PullRequestReviewState))]
        [DataMember, JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PullRequestReviewState State { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commit_id")]
        public string CommitId { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("user")]
        public User User { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("body")]
        public string Body { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pull_request_url")]
        public string PullRequestUrl { get; set; }
    }
}