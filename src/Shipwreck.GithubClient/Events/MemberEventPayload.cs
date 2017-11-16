using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class MemberEventPayload : ActivityPayload
    {
        [DefaultValue(default(EditAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CollectionAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public MemberChanges Changes { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("member")]
        public User Member { get; set; }
    }
}