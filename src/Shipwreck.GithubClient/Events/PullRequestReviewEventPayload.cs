using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class PullRequestReviewEventPayload : ActivityPayload
    {
        [DefaultValue(default(PullRequestReviewAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PullRequestReviewAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("review")]
        public PullRequestReview Review { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public CommentChanges Changes { get; set; }
    }
}