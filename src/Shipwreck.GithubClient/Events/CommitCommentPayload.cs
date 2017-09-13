using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class CommitCommentPayload : ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("comment")]
        public CommitComment Comment { get; set; }
    }
}