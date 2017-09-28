using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

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

        [DefaultValue(null)]
        [DataMember, JsonProperty("after")]
        public string After { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("created")]
        public bool? Created { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("forced")]
        public bool? Forced { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("base_ref")]
        public string BaseRef { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("compare")]
        public string Compare { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("size")]
        public int Size { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("distinct_size")]
        public int DistinctSize { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commits")]
        public Commit[] Commits { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("head_commit")]
        public Commit HeadCommit { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("pusher")]
        public Committer Pusher { get; set; }
    }
}