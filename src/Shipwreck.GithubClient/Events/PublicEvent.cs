using System;
using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [Serializable, DataContract]
    public class PublicEvent : ActivityPayload
    { }
}