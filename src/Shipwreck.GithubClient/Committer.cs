using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Committer
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("username")]
        public string Username { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("email")]
        public string Email { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("date")]
        [JsonConverter(typeof(UnixEpochConverter))]
        public DateTimeOffset Date { get; set; }
    }
}