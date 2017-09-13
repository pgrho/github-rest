using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum EditAction
    {
        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "edited")]
        Edited,

        [EnumMember(Value = "deleted")]
        Deleted
    }
}