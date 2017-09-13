using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum DeploymentState
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "success")]
        Success,

        [EnumMember(Value = "error")]
        Error,

        [EnumMember(Value = "failure")]
        Failure,

        [EnumMember(Value = "inactive")]
        Inactive,
    }
}