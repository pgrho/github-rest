using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum WatchAction
    {
        [EnumMember(Value = "started")]
        Started,
    }
}