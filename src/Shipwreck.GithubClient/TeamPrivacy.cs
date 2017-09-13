using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum TeamPrivacy
    {
        [EnumMember(Value = "secret")]
        Secret,

        [EnumMember(Value = "closed")]
        Closed,
    }
}