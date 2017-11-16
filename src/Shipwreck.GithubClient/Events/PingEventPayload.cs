using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class PingEventPayload : ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("zen")]
        public string Zen { get; set; }
    }
}