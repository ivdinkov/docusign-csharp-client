/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// AccountIdentityVerificationResponse
    /// </summary>
    [DataContract]
    public partial class AccountIdentityVerificationResponse :  IEquatable<AccountIdentityVerificationResponse>, IValidatableObject
    {
        public AccountIdentityVerificationResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentityVerificationResponse" /> class.
        /// </summary>
        /// <param name="IdentityVerification">IdentityVerification.</param>
        public AccountIdentityVerificationResponse(List<AccountIdentityVerificationWorkflow> IdentityVerification = default(List<AccountIdentityVerificationWorkflow>))
        {
            this.IdentityVerification = IdentityVerification;
        }
        
        /// <summary>
        /// Gets or Sets IdentityVerification
        /// </summary>
        [DataMember(Name="identityVerification", EmitDefaultValue=false)]
        public List<AccountIdentityVerificationWorkflow> IdentityVerification { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountIdentityVerificationResponse {\n");
            sb.Append("  IdentityVerification: ").Append(IdentityVerification).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AccountIdentityVerificationResponse);
        }

        /// <summary>
        /// Returns true if AccountIdentityVerificationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountIdentityVerificationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountIdentityVerificationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdentityVerification == other.IdentityVerification ||
                    this.IdentityVerification != null &&
                    this.IdentityVerification.SequenceEqual(other.IdentityVerification)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.IdentityVerification != null)
                    hash = hash * 59 + this.IdentityVerification.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
