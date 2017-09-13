using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Author
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("login")]
        public string Login { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

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
        [DataMember, JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("type")]
        public string Type { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }
}