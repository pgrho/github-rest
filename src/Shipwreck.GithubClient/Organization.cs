using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Organization : Account
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("hooks_url")]
        public string HooksUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("members_url")]
        public string MembersUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("public_members_url")]
        public string PublicMembersUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public string Description { get; set; }
    }
}