using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class ChangeDetail
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("from")]
        public string From { get; set; }
    }
}