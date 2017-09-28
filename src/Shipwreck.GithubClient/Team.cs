using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Team
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("description")]
        public string Description { get; set; }

        [DefaultValue(default(TeamPrivacy))]
        [DataMember, JsonProperty("privacy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TeamPrivacy Privacy { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("slug")]
        public string Slug { get; set; }

        [DefaultValue(default(Permission))]
        [DataMember, JsonProperty("permission")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Permission Permission { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("members_count")]
        public int MembersCount { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("repos_count")]
        public int ReposCount { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("organization")]
        public Organization Organization { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("ldap_distinguished_name")]
        public string LdapDistinguishedName { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("members_url")]
        public string MembersUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("repositories_url")]
        public string RepositoriesUrl { get; set; }
    }
}