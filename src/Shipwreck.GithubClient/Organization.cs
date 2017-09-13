using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class Organization : Account
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("billing_address")]
        public string BillingAddress { get; set; }
    }
}