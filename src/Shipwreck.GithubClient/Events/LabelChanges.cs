using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class LabelChanges
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public ChangeDetail Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("color")]
        public ChangeDetail Color { get; set; }
    }
}