using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Deployment
    {
        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("sha")]
        public string Sha { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("creator")]
        public User Creator { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("payload")]
        public Dictionary<string, string> Payload { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public string Description { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("transient_environment")]
        public bool TransientEnvironment { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("production_environment")]
        public bool ProductionEnvironment { get; set; }
    }
}