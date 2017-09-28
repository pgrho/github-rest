using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class StatusEventPayload : ActivityPayload
    {
        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("sha")]
        public string Sha { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("context")]
        public string Context { get; set; }

        [DefaultValue(default(CommitState))]
        [DataMember, JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CommitState State { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public string Description { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("target_url")]
        public string TargetUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("commit")]
        public Commit Commit { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("branches")]
        public Branch[] Branches { get; set; }
    }
}