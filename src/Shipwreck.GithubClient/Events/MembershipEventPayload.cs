using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class MembershipEventPayload : ActivityPayload
    {
        [DefaultValue(default(CollectionAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CollectionAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("scope")]
        public string Scope { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("member")]
        public User Member { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("team")]
        public Team Team { get; set; }
    }
}