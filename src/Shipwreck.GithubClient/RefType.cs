using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum RefType
    {
        [EnumMember(Value = "repository")]
        Repository,

        [EnumMember(Value = "branch")]
        Branch,

        [EnumMember(Value = "tag")]
        Tag,
    }
}