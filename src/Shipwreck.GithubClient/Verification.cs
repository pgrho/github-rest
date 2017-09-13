using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Verification
    {
        [DefaultValue(false)]
        [DataMember, JsonProperty("verified")]
        public bool Verified { get; set; }

        [DefaultValue(default(VerificationReason))]
        [DataMember, JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public VerificationReason Reason { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("signature")]
        public string Signature { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("payload")]
        public string Payload { get; set; }
    }
}