using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class IssueEventPayload : ActivityPayload
    {
        [DefaultValue(default(IssueAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IssueAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issue")]
        public Issue Issue { get; set; }

        // TODO: changes
        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public Dictionary<string, string> Changes { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("assignee")]
        public User Assignee { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("label")]
        public Label Label { get; set; }
    }
}