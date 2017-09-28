using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class InstallationRepositoriesEventPayload : ActivityPayload
    {
        [DefaultValue(default(CollectionAction))]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CollectionAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("installation")]
        public Installation Installation { get; set; }

        [DefaultValue(default(RepositorySelection))]
        [DataMember, JsonProperty("repository_selection")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RepositorySelection RepositorySelection { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("repositories_added")]
        public Repository[] RepositoriesAdded { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("repositories_removed")]
        public Repository[] RepositoriesRemoved { get; set; }
    }
}