using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum CommitState
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "success")]
        Success,

        [EnumMember(Value = "failure")]
        Failure,

        [EnumMember(Value = "error")]
        Error,
    }
}