using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum RepositorySelection
    {
        [EnumMember(Value = "selected")]
        Selected,

        [EnumMember(Value = "all")]
        All
    }
}