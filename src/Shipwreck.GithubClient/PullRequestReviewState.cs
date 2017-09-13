using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum PullRequestReviewState
    {
        [EnumMember(Value = "approved")]
        Approved,

        [EnumMember(Value = "changes_requested")]
        ChangesRequested,

        [EnumMember(Value = "commented")]
        Commented,

        [EnumMember(Value = "dismissed")]
        Dismissed,

        [EnumMember(Value = "pending")]
        Pending,
    }
}