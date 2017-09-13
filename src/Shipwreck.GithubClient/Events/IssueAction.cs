using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum IssueAction
    {
        [EnumMember(Value = "assigned")]
        Assigned,

        [EnumMember(Value = "unassigned")]
        Unassigned,

        [EnumMember(Value = "labeled")]
        Labeled,

        [EnumMember(Value = "unlabeled")]
        Unlabeled,

        [EnumMember(Value = "opened")]
        Opened,

        [EnumMember(Value = "edited")]
        Edited,

        [EnumMember(Value = "milestoned")]
        Milestoned,

        [EnumMember(Value = "demilestoned")]
        Demilestoned,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "reopened")]
        Reopened,
    }
}