using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Installation
    {
        [DefaultValue(0)]
        [DataMember, JsonProperty("id")]
        public int Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("account")]
        public User Account { get; set; }

        [DefaultValue(default(RepositorySelection))]
        [DataMember, JsonProperty("repository_selection")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RepositorySelection RepositorySelection { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("access_tokens_url")]
        public string AccessTokensUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("repositories_url")]
        public string RepositoriesUrl { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }
}