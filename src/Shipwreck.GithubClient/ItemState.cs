using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum ItemState
    {
        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "closed")]
        Closed,
    }
}