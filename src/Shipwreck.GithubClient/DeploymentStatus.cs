using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class DeploymentStatus
    {
        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(default(DeploymentState))]
        [DataMember, JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DeploymentState State { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("creator")]
        public User Creator { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("payload")]
        public Dictionary<string, string> Payload { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("target_url")]
        public string TargetUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("log_url")]
        public string LogUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("environment_url")]
        public string EnvironmentUrl { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public string Description { get; set; }
    }
}