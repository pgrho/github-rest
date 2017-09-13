using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class ReactionSummary
    {
        [DefaultValue(0)]
        [DataMember, JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("plus1")]
        public int Plus1 { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("minus1")]
        public int Minus1 { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("laugh")]
        public int Laugh { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("confused")]
        public int Confused { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("heart")]
        public int Heart { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("hooray")]
        public int Hooray { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }
    }
}