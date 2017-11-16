using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class LabelEventPayload : ActivityPayload
    {
        [DefaultValue(default(EditAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EditAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("changes")]
        public LabelChanges Changes { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("label")]
        public Label Label { get; set; }
    }
}