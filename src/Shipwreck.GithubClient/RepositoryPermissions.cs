using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class RepositoryPermissions
    {
        [DefaultValue(false)]
        [DataMember, JsonProperty("admin")]
        public bool Admin { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("push")]
        public bool Push { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("pull")]
        public bool Pull { get; set; }
    }
}