using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class IssueChanges
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("title")]
        public ChangeDetail Title { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("body")]
        public ChangeDetail Body { get; set; }
    }
}