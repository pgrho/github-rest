using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum InstallationAction
    {
        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "deleted")]
        Deleted
    }
}