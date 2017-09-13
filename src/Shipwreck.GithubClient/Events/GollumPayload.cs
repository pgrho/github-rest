using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class GollumPayload : ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("pages")]
        public GollumPage[] Pages { get; set; }
    }
}