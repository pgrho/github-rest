using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class PushEventPayload : ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("ref")]
        public string Ref { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("head")]
        public string Head { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("before")]
        public string Before { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("size")]
        public int Size { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("distinct_size")]
        public int DistinctSize { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commits")]
        public Commit[] Commits { get; set; }
    }
}