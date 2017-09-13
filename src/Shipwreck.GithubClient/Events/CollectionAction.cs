using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum CollectionAction
    {
        [EnumMember(Value = "added")]
        Added,

        [EnumMember(Value = "removed")]
        Removed
    }
}