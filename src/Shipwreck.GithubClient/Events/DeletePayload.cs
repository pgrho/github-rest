using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class DeletePayload : ActivityPayload
    {
        [DefaultValue(default(RefType))]
        [DataMember, JsonProperty("ref_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RefType RefType { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("ref")]
        public string Ref { get; set; }

        [DefaultValue(default(AccountType))]
        [DataMember, JsonProperty("pusher_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountType PusherType { get; set; }
    }
}