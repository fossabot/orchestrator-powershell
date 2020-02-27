// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AuditLogDtoAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditLogDtoAction
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Create")]
        Create,
        [EnumMember(Value = "Update")]
        Update,
        [EnumMember(Value = "Delete")]
        Delete,
        [EnumMember(Value = "StartJob")]
        StartJob,
        [EnumMember(Value = "StopJob")]
        StopJob,
        [EnumMember(Value = "Associate")]
        Associate,
        [EnumMember(Value = "Upload")]
        Upload,
        [EnumMember(Value = "ChangeStatus")]
        ChangeStatus,
        [EnumMember(Value = "Import")]
        Import,
        [EnumMember(Value = "ChangePassword")]
        ChangePassword,
        [EnumMember(Value = "Register")]
        Register,
        [EnumMember(Value = "Toggle")]
        Toggle,
        [EnumMember(Value = "ResetPassword")]
        ResetPassword,
        [EnumMember(Value = "PasswordResetAttempt")]
        PasswordResetAttempt
    }
    internal static class AuditLogDtoActionEnumExtension
    {
        internal static string ToSerializedValue(this AuditLogDtoAction? value)
        {
            return value == null ? null : ((AuditLogDtoAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuditLogDtoAction value)
        {
            switch( value )
            {
                case AuditLogDtoAction.Unknown:
                    return "Unknown";
                case AuditLogDtoAction.Create:
                    return "Create";
                case AuditLogDtoAction.Update:
                    return "Update";
                case AuditLogDtoAction.Delete:
                    return "Delete";
                case AuditLogDtoAction.StartJob:
                    return "StartJob";
                case AuditLogDtoAction.StopJob:
                    return "StopJob";
                case AuditLogDtoAction.Associate:
                    return "Associate";
                case AuditLogDtoAction.Upload:
                    return "Upload";
                case AuditLogDtoAction.ChangeStatus:
                    return "ChangeStatus";
                case AuditLogDtoAction.Import:
                    return "Import";
                case AuditLogDtoAction.ChangePassword:
                    return "ChangePassword";
                case AuditLogDtoAction.Register:
                    return "Register";
                case AuditLogDtoAction.Toggle:
                    return "Toggle";
                case AuditLogDtoAction.ResetPassword:
                    return "ResetPassword";
                case AuditLogDtoAction.PasswordResetAttempt:
                    return "PasswordResetAttempt";
            }
            return null;
        }

        internal static AuditLogDtoAction? ParseAuditLogDtoAction(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return AuditLogDtoAction.Unknown;
                case "Create":
                    return AuditLogDtoAction.Create;
                case "Update":
                    return AuditLogDtoAction.Update;
                case "Delete":
                    return AuditLogDtoAction.Delete;
                case "StartJob":
                    return AuditLogDtoAction.StartJob;
                case "StopJob":
                    return AuditLogDtoAction.StopJob;
                case "Associate":
                    return AuditLogDtoAction.Associate;
                case "Upload":
                    return AuditLogDtoAction.Upload;
                case "ChangeStatus":
                    return AuditLogDtoAction.ChangeStatus;
                case "Import":
                    return AuditLogDtoAction.Import;
                case "ChangePassword":
                    return AuditLogDtoAction.ChangePassword;
                case "Register":
                    return AuditLogDtoAction.Register;
                case "Toggle":
                    return AuditLogDtoAction.Toggle;
                case "ResetPassword":
                    return AuditLogDtoAction.ResetPassword;
                case "PasswordResetAttempt":
                    return AuditLogDtoAction.PasswordResetAttempt;
            }
            return null;
        }
    }
}
