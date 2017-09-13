using System.Runtime.Serialization;

namespace Shipwreck.GithubClient
{
    [DataContract]
    public enum VerificationReason
    {
        [EnumMember(Value = "expired_key")]
        ExpiredKey,

        [EnumMember(Value = "not_signing_key")]
        NotSigningKey,

        [EnumMember(Value = "gpgverify_error")]
        GpgVerifyError,

        [EnumMember(Value = "gpgverify_unavailable")]
        GpgVerifyUnavailable,

        [EnumMember(Value = "unsigned")]
        Unsigned,

        [EnumMember(Value = "unknown_signature_type")]
        UnknownSignatureType,

        [EnumMember(Value = "no_user")]
        NoUser,

        [EnumMember(Value = "unverified_email")]
        UnverifiedEmail,

        [EnumMember(Value = "bad_email")]
        BadEmail,

        [EnumMember(Value = "unknown_key")]
        UnknownKey,

        [EnumMember(Value = "malformed_signature")]
        MalformedSignature,

        [EnumMember(Value = "inavlid")]
        Invalid,

        [EnumMember(Value = "valid")]
        Valid,
    }
}