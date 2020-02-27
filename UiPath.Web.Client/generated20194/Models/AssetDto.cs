// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Stores specific data so that robots can easily have access to it.
    /// </summary>
    public partial class AssetDto
    {
        /// <summary>
        /// Initializes a new instance of the AssetDto class.
        /// </summary>
        public AssetDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssetDto class.
        /// </summary>
        /// <param name="name">A custom name for the asset.</param>
        /// <param name="valueScope">Defines the scope of the asset. Possible
        /// values include: 'Global', 'PerRobot'</param>
        /// <param name="canBeDeleted">States if an assets can be deleted. The
        /// default value of this property is true.</param>
        /// <param name="valueType">Defines the type of value stored by the
        /// asset. Possible values include: 'DBConnectionString',
        /// 'HttpConnectionString', 'Text', 'Bool', 'Integer', 'Credential',
        /// 'WindowsCredential', 'KeyValueList'</param>
        /// <param name="value">The textual representation of the asset value,
        /// irrespective of value type.</param>
        /// <param name="stringValue">The value of the asset when the value
        /// type is Text. Empty when the value type is not Text.</param>
        /// <param name="boolValue">The value of the asset when the value type
        /// is Bool. False when the value type is not Bool.</param>
        /// <param name="intValue">The value of the asset when the value type
        /// is Integer. 0 when the value type is not Integer.</param>
        /// <param name="credentialUsername">The user name when the value type
        /// is Credential. Empty when the value type is not Credential.</param>
        /// <param name="credentialPassword">The password when the value type
        /// is Credential. Empty when the value type is not Credential.</param>
        /// <param name="keyValueList">A collection of key value pairs when the
        /// type is KeyValueList. Empty when the value type is not
        /// KeyValueList.</param>
        /// <param name="robotValues">The collection of asset values per robot.
        /// Empty if the asset type is Global.</param>
        public AssetDto(string name, AssetDtoValueScope valueScope, bool? canBeDeleted = default(bool?), AssetDtoValueType? valueType = default(AssetDtoValueType?), string value = default(string), string stringValue = default(string), bool? boolValue = default(bool?), int? intValue = default(int?), string credentialUsername = default(string), string credentialPassword = default(string), IList<CustomKeyValuePair> keyValueList = default(IList<CustomKeyValuePair>), IList<AssetRobotValueDto> robotValues = default(IList<AssetRobotValueDto>), long? id = default(long?))
        {
            Name = name;
            CanBeDeleted = canBeDeleted;
            ValueScope = valueScope;
            ValueType = valueType;
            Value = value;
            StringValue = stringValue;
            BoolValue = boolValue;
            IntValue = intValue;
            CredentialUsername = credentialUsername;
            CredentialPassword = credentialPassword;
            KeyValueList = keyValueList;
            RobotValues = robotValues;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a custom name for the asset.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets states if an assets can be deleted. The default value
        /// of this property is true.
        /// </summary>
        [JsonProperty(PropertyName = "CanBeDeleted")]
        public bool? CanBeDeleted { get; set; }

        /// <summary>
        /// Gets or sets defines the scope of the asset. Possible values
        /// include: 'Global', 'PerRobot'
        /// </summary>
        [JsonProperty(PropertyName = "ValueScope")]
        public AssetDtoValueScope ValueScope { get; set; }

        /// <summary>
        /// Gets or sets defines the type of value stored by the asset.
        /// Possible values include: 'DBConnectionString',
        /// 'HttpConnectionString', 'Text', 'Bool', 'Integer', 'Credential',
        /// 'WindowsCredential', 'KeyValueList'
        /// </summary>
        [JsonProperty(PropertyName = "ValueType")]
        public AssetDtoValueType? ValueType { get; set; }

        /// <summary>
        /// Gets or sets the textual representation of the asset value,
        /// irrespective of value type.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the value of the asset when the value type is Text.
        /// Empty when the value type is not Text.
        /// </summary>
        [JsonProperty(PropertyName = "StringValue")]
        public string StringValue { get; set; }

        /// <summary>
        /// Gets or sets the value of the asset when the value type is Bool.
        /// False when the value type is not Bool.
        /// </summary>
        [JsonProperty(PropertyName = "BoolValue")]
        public bool? BoolValue { get; set; }

        /// <summary>
        /// Gets or sets the value of the asset when the value type is Integer.
        /// 0 when the value type is not Integer.
        /// </summary>
        [JsonProperty(PropertyName = "IntValue")]
        public int? IntValue { get; set; }

        /// <summary>
        /// Gets or sets the user name when the value type is Credential. Empty
        /// when the value type is not Credential.
        /// </summary>
        [JsonProperty(PropertyName = "CredentialUsername")]
        public string CredentialUsername { get; set; }

        /// <summary>
        /// Gets or sets the password when the value type is Credential. Empty
        /// when the value type is not Credential.
        /// </summary>
        [JsonProperty(PropertyName = "CredentialPassword")]
        public string CredentialPassword { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs when the type is
        /// KeyValueList. Empty when the value type is not KeyValueList.
        /// </summary>
        [JsonProperty(PropertyName = "KeyValueList")]
        public IList<CustomKeyValuePair> KeyValueList { get; set; }

        /// <summary>
        /// Gets or sets the collection of asset values per robot. Empty if the
        /// asset type is Global.
        /// </summary>
        [JsonProperty(PropertyName = "RobotValues")]
        public IList<AssetRobotValueDto> RobotValues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
