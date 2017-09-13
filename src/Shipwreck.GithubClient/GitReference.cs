using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class GitReference
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("label")]
        public string Label { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("ref")]
        public string Ref { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("sha")]
        public string Sha { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("user")]
        public User User { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("repository")]
        public Repository Repository { get; set; }
    }
}