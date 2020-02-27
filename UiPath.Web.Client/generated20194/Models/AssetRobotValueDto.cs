// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Stores the value of an asset associated with a robot as well as the
    /// robot association data.
    /// </summary>
    public partial class AssetRobotValueDto
    {
        /// <summary>
        /// Initializes a new instance of the AssetRobotValueDto class.
        /// </summary>
        public AssetRobotValueDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssetRobotValueDto class.
        /// </summary>
        /// <param name="robotId">The Id of the robot with which the asset is
        /// associated.</param>
        /// <param name="robotName">The name of the robot with which the asset
        /// is associated.</param>
        /// <param name="keyTrail">Masked value of the robot key.</param>
        /// <param name="valueType">Defines the type of value stored by the
        /// asset. Possible values include: 'DBConnectionString',
        /// 'HttpConnectionString', 'Text', 'Bool', 'Integer', 'Credential',
        /// 'WindowsCredential', 'KeyValueList'</param>
        /// <param name="stringValue">The value of the asset when the value
        /// type is Text. Empty when the value type is not Text.</param>
        /// <param name="boolValue">The value of the asset when the value type
        /// is Bool. False when the value type is not Bool.</param>
        /// <param name="intValue">The value of the asset when the value type
        /// is Integer. 0 when the value type is not Integer.</param>
        /// <param name="value">The textual representation of the asset value,
        /// irrespective of value type.</param>
        /// <param name="credentialUsername">The user name when the value type
        /// is Credential. Empty when the value type is not Credential.</param>
        /// <param name="credentialPassword">The password when the value type
        /// is Credential. Empty when the value type is not Credential.</param>
        /// <param name="keyValueList">A collection of key value pairs when the
        /// type is KeyValueList. Empty when the value type is not
        /// KeyValueList.</param>
        public AssetRobotValueDto(long? robotId = default(long?), string robotName = default(string), string keyTrail = default(string), AssetRobotValueDtoValueType? valueType = default(AssetRobotValueDtoValueType?), string stringValue = default(string), bool? boolValue = default(bool?), int? intValue = default(int?), string value = default(string), string credentialUsername = default(string), string credentialPassword = default(string), IList<CustomKeyValuePair> keyValueList = default(IList<CustomKeyValuePair>), long? id = default(long?))
        {
            RobotId = robotId;
            RobotName = robotName;
            KeyTrail = keyTrail;
            ValueType = valueType;
            StringValue = stringValue;
            BoolValue = boolValue;
            IntValue = intValue;
            Value = value;
            CredentialUsername = credentialUsername;
            CredentialPassword = credentialPassword;
            KeyValueList = keyValueList;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Id of the robot with which the asset is
        /// associated.
        /// </summary>
        [JsonProperty(PropertyName = "RobotId")]
        public long? RobotId { get; set; }

        /// <summary>
        /// Gets or sets the name of the robot with which the asset is
        /// associated.
        /// </summary>
        [JsonProperty(PropertyName = "RobotName")]
        public string RobotName { get; set; }

        /// <summary>
        /// Gets or sets masked value of the robot key.
        /// </summary>
        [JsonProperty(PropertyName = "KeyTrail")]
        public string KeyTrail { get; set; }

        /// <summary>
        /// Gets or sets defines the type of value stored by the asset.
        /// Possible values include: 'DBConnectionString',
        /// 'HttpConnectionString', 'Text', 'Bool', 'Integer', 'Credential',
        /// 'WindowsCredential', 'KeyValueList'
        /// </summary>
        [JsonProperty(PropertyName = "ValueType")]
        public AssetRobotValueDtoValueType? ValueType { get; set; }

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
        /// Gets or sets the textual representation of the asset value,
        /// irrespective of value type.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

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
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
