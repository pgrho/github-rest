using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum PullRequestReviewAction
    {
        [EnumMember(Value = "submitted")]
        Submitted,

        [EnumMember(Value = "edited")]
        Edited,

        [EnumMember(Value = "dismissed")]
        Dismissed
    }
}