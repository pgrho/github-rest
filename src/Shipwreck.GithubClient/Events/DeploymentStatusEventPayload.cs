using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class DeploymentStatusEventPayload : DeploymentEventPayload
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("deployment_status")]
        public DeploymentStatus DeploymentStatus { get; set; }
    }
}