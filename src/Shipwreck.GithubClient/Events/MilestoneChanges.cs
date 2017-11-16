using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class MilestoneChanges
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public ChangeDetail Description { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("due_on")]
        public ChangeDetail DueOn { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("title")]
        public ChangeDetail Title { get; set; }
    }
}