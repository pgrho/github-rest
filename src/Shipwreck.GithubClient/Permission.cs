using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum Permission
    {
        [EnumMember(Value = "admin")]
        Admin,

        [EnumMember(Value = "push")]
        Push,

        [EnumMember(Value = "pull")]
        Pull,
    }
}