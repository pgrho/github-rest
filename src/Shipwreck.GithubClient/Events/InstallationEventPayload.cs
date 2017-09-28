using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class InstallationEventPayload : ActivityPayload
    {
        [DefaultValue(default(InstallationAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public InstallationAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("installation")]
        public Installation Installation { get; set; }
    }

}