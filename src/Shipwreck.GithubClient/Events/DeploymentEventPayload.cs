using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class DeploymentEventPayload : ActivityPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("deployment")]
        public Deployment Deployment { get; set; }
    }
}