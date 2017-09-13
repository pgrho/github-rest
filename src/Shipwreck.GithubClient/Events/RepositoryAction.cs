using System.Runtime.Serialization;

namespace Shipwreck.GithubClient.Events
{
    [DataContract]
    public enum RepositoryAction
    {
        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "publicized")]
        Publicized,

        [EnumMember(Value = "privatized")]
        Privatized,

        [EnumMember(Value = "deleted")]
        Deleted
    }
}