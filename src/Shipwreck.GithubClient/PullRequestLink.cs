using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public sealed class PullRequestLink
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("href")]
        public string Href { get; set; }
    }
}