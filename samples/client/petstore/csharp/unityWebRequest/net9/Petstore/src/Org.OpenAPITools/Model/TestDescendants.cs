/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TestDescendants
    /// </summary>
    [DataContract(Name = "TestDescendants")]
    public partial class TestDescendants : IEquatable<TestDescendants>
    {
        /// <summary>
        /// Defines ObjectType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectTypeEnum
        {
            /// <summary>
            /// Enum Descendant1 for value: Descendant1
            /// </summary>
            [EnumMember(Value = "Descendant1")]
            Descendant1 = 1,

            /// <summary>
            /// Enum Descendant2 for value: Descendant2
            /// </summary>
            [EnumMember(Value = "Descendant2")]
            Descendant2 = 2
        }


        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name = "objectType", IsRequired = true, EmitDefaultValue = true)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDescendants" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestDescendants() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDescendants" /> class.
        /// </summary>
        /// <param name="alternativeName">alternativeName (required).</param>
        /// <param name="objectType">objectType (required).</param>
        public TestDescendants(string alternativeName = default(string), ObjectTypeEnum objectType = default(ObjectTypeEnum))
        {
            // to ensure "alternativeName" is required (not null)
            if (alternativeName == null)
            {
                throw new ArgumentNullException("alternativeName is a required property for TestDescendants and cannot be null");
            }
            this.AlternativeName = alternativeName;
            this.ObjectType = objectType;
        }

        /// <summary>
        /// Gets or Sets AlternativeName
        /// </summary>
        [DataMember(Name = "alternativeName", IsRequired = true, EmitDefaultValue = true)]
        public string AlternativeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestDescendants {\n");
            sb.Append("  AlternativeName: ").Append(AlternativeName).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestDescendants);
        }

        /// <summary>
        /// Returns true if TestDescendants instances are equal
        /// </summary>
        /// <param name="input">Instance of TestDescendants to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestDescendants input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlternativeName == input.AlternativeName ||
                    (this.AlternativeName != null &&
                    this.AlternativeName.Equals(input.AlternativeName))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    this.ObjectType.Equals(input.ObjectType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AlternativeName != null)
                {
                    hashCode = (hashCode * 59) + this.AlternativeName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ObjectType.GetHashCode();
                return hashCode;
            }
        }

    }

}
