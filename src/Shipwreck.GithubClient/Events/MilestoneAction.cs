using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum MilestoneAction
    {
        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "opened")]
        Opened,

        [EnumMember(Value = "edited")]
        Edited,

        [EnumMember(Value = "deleted")]
        Deleted
    }
}