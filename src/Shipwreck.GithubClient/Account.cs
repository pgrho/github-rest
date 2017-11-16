using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public abstract class Account
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("bio")]
        public string Bio { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("blog")]
        public string Blog { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("collaborators")]
        public int? Collaborators { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("company")]
        public string Company { get; set; }

        [DefaultValue(typeof(DateTimeOffset), "0001-01-01T00:00:00Z")]
        [DataMember, JsonProperty("created_at")]
        [JsonConverter(typeof(UnixEpochConverter))]
        public DateTimeOffset CreatedAt { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("disk_usage")]
        public int? DiskUsage { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("email")]
        public string Email { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("followers")]
        public int Followers { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("following")]
        public int Following { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("hireable")]
        public bool? Hireable { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("location")]
        public string Location { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("login")]
        public string Login { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("name")]
        public string Name { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountType? Type { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("owned_private_repos")]
        public int OwnedPrivateRepos { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("plan")]
        public Plan Plan { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("private_gists")]
        public int? PrivateGists { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("public_gists")]
        public int PublicGists { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("public_repos")]
        public int PublicRepos { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("total_private_repos")]
        public int TotalPrivateRepos { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("url")]
        public string Url { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("events_url")]
        public string EventsUrl { get; set; }

    }
}