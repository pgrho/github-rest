using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class MilestoneEventPayload : ActivityPayload
    {
        [DefaultValue(default(MilestoneAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MilestoneAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public MilestoneChanges Changes { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("milestone")]
        public Milestone Milestone { get; set; }
    }
}