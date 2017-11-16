using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class CommentChanges
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("body")]
        public ChangeDetail Body { get; set; }
    }
}