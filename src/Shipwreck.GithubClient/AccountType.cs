using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum AccountType
    {
        [EnumMember(Value = "user")]
        User,

        [EnumMember(Value = "organization")]
        Organization,

        [EnumMember(Value = "bot")]
        Bot,
    }

}