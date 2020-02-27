// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UserLoginAttemptDtoResult.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserLoginAttemptDtoResult
    {
        [EnumMember(Value = "Success")]
        Success,
        [EnumMember(Value = "InvalidUserNameOrEmailAddress")]
        InvalidUserNameOrEmailAddress,
        [EnumMember(Value = "InvalidPassword")]
        InvalidPassword,
        [EnumMember(Value = "UserIsNotActive")]
        UserIsNotActive,
        [EnumMember(Value = "InvalidTenancyName")]
        InvalidTenancyName,
        [EnumMember(Value = "TenantIsNotActive")]
        TenantIsNotActive,
        [EnumMember(Value = "UserEmailIsNotConfirmed")]
        UserEmailIsNotConfirmed,
        [EnumMember(Value = "UnknownExternalLogin")]
        UnknownExternalLogin,
        [EnumMember(Value = "LockedOut")]
        LockedOut,
        [EnumMember(Value = "UserPhoneNumberIsNotConfirmed")]
        UserPhoneNumberIsNotConfirmed
    }
    internal static class UserLoginAttemptDtoResultEnumExtension
    {
        internal static string ToSerializedValue(this UserLoginAttemptDtoResult? value)
        {
            return value == null ? null : ((UserLoginAttemptDtoResult)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UserLoginAttemptDtoResult value)
        {
            switch( value )
            {
                case UserLoginAttemptDtoResult.Success:
                    return "Success";
                case UserLoginAttemptDtoResult.InvalidUserNameOrEmailAddress:
                    return "InvalidUserNameOrEmailAddress";
                case UserLoginAttemptDtoResult.InvalidPassword:
                    return "InvalidPassword";
                case UserLoginAttemptDtoResult.UserIsNotActive:
                    return "UserIsNotActive";
                case UserLoginAttemptDtoResult.InvalidTenancyName:
                    return "InvalidTenancyName";
                case UserLoginAttemptDtoResult.TenantIsNotActive:
                    return "TenantIsNotActive";
                case UserLoginAttemptDtoResult.UserEmailIsNotConfirmed:
                    return "UserEmailIsNotConfirmed";
                case UserLoginAttemptDtoResult.UnknownExternalLogin:
                    return "UnknownExternalLogin";
                case UserLoginAttemptDtoResult.LockedOut:
                    return "LockedOut";
                case UserLoginAttemptDtoResult.UserPhoneNumberIsNotConfirmed:
                    return "UserPhoneNumberIsNotConfirmed";
            }
            return null;
        }

        internal static UserLoginAttemptDtoResult? ParseUserLoginAttemptDtoResult(this string value)
        {
            switch( value )
            {
                case "Success":
                    return UserLoginAttemptDtoResult.Success;
                case "InvalidUserNameOrEmailAddress":
                    return UserLoginAttemptDtoResult.InvalidUserNameOrEmailAddress;
                case "InvalidPassword":
                    return UserLoginAttemptDtoResult.InvalidPassword;
                case "UserIsNotActive":
                    return UserLoginAttemptDtoResult.UserIsNotActive;
                case "InvalidTenancyName":
                    return UserLoginAttemptDtoResult.InvalidTenancyName;
                case "TenantIsNotActive":
                    return UserLoginAttemptDtoResult.TenantIsNotActive;
                case "UserEmailIsNotConfirmed":
                    return UserLoginAttemptDtoResult.UserEmailIsNotConfirmed;
                case "UnknownExternalLogin":
                    return UserLoginAttemptDtoResult.UnknownExternalLogin;
                case "LockedOut":
                    return UserLoginAttemptDtoResult.LockedOut;
                case "UserPhoneNumberIsNotConfirmed":
                    return UserLoginAttemptDtoResult.UserPhoneNumberIsNotConfirmed;
            }
            return null;
        }
    }
}
