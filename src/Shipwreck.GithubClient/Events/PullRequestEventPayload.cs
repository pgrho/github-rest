using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class PullRequestEventPayload : ActivityPayload
    {
        [DefaultValue(default(PullRequestAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PullRequestAction Action { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("number")]
        public int Number { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }

        // TODO: changes
        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public Dictionary<string, string> Changes { get; set; }
    }
}