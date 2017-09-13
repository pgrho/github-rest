using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class ReleaseEventPayload : ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("action")]
        public string Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("release")]
        public Release Release { get; set; }
    }
}