using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Plan
    {
        [DefaultValue(0L)]
        [DataMember, JsonProperty("collaborators")]
        public long Collaborators { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(0L)]
        [DataMember, JsonProperty("private_repos")]
        public long PrivateRepos { get; set; }

        [DefaultValue(0L)]
        [DataMember, JsonProperty("space")]
        public long Space { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("billing_email")]
        public string BillingEmail { get; set; }
    }
}