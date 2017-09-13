using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("repository")]
        public Repository Repository { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("sender")]
        public User Sender { get; set; }
    }
}