using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class ForkEventPayload : ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("forkee")]
        public Repository Forkee { get; set; }
    }
}