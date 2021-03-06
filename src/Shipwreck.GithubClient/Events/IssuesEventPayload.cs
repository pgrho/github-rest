using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class IssuesEventPayload : ActivityPayload
    {
        [DefaultValue(default(IssueAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IssueAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issue")]
        public Issue Issue { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public IssueChanges Changes { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assignee")]
        public User Assignee { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("label")]
        public Label Label { get; set; }
    }
}