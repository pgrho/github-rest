using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Commit : GitReference
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("id")]
        public string Id { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("tree_id")]
        public string TreeId { get; set; }

        [DefaultValue(false)]
        [DataMember, JsonProperty("distinct")]
        public bool Distinct { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("message")]
        public string Message { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("author")]
        public Committer Author { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("committer")]
        public Committer Committer { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("tree")]
        public GitReference Tree { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("parents")]
        public GitReference[] Parents { get; set; }

        [DefaultValue(0)]
        [DataMember, JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("verification")]
        public Verification Verification { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
    }
}