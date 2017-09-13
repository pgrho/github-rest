using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum PullRequestAction
    {
        [EnumMember(Value = "assigned")]
        Assigned,

        [EnumMember(Value = "unassigned")]
        Unassigned,

        [EnumMember(Value = "review_requested")]
        ReviewRequested,

        [EnumMember(Value = "review_request_removed")]
        ReviewRequestRemoved,

        [EnumMember(Value = "labeled")]
        Labeled,

        [EnumMember(Value = "unlabeled")]
        Unlabeled,

        [EnumMember(Value = "opened")]
        Opened,

        [EnumMember(Value = "edited")]
        Edited,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "reopened")]
        Reopened,
    }
}