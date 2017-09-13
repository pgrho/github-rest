using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum GollumPageAction
    {
        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "edited")]
        Edited
    }
}