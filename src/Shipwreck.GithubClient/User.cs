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
        [JsonConverter(typeof(UnixEpochConverter))]
        public DateTimeOffset? SuspendedAt { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("ldap_distinguished_name")]
        public string LdapDistinguishedName { get; set; }

        #region Url

        [DefaultValue(null)]
        [DataMember, JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        #endregion
    }
}