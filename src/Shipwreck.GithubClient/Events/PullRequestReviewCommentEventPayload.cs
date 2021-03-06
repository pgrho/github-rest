using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class PullRequestReviewCommentEventPayload : ActivityPayload
    {
        [DefaultValue(default(EditAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EditAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("comment")]
        public PullRequestReviewComment Comment { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public CommentChanges Changes { get; set; }
    }
}