using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class User : Account
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("permissions")]
        public RepositoryPermissions Permissions { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("suspended_at")]
        public DateTimeOffset? SuspendedAt { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("ldap_distinguished_name")]
        public string LdapDistinguishedName { get; set; }
    }
}