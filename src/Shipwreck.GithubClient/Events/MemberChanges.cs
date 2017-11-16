using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class MemberChanges
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("old_permission")]
        public ChangeDetail OldPermission { get; set; }
    }
}