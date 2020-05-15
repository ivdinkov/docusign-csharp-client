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
    /// CloudStorageProvider
    /// </summary>
    [DataContract]
    public partial class CloudStorageProvider :  IEquatable<CloudStorageProvider>, IValidatableObject
    {
        public CloudStorageProvider()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudStorageProvider" /> class.
        /// </summary>
        /// <param name="AuthenticationUrl">The authentication URL used for the cloud storage provider. This information is only included in the response if the user has not passed authentication for the cloud storage provider. If the redirectUrl query string is provided, the returnUrl is appended to the authenticationUrl. .</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="RedirectUrl">The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains..</param>
        /// <param name="Service">The service name for the cloud storage provider..</param>
        /// <param name="ServiceId">The DocuSign generated ID for the cloud storage provider.</param>
        public CloudStorageProvider(string AuthenticationUrl = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string RedirectUrl = default(string), string Service = default(string), string ServiceId = default(string))
        {
            this.AuthenticationUrl = AuthenticationUrl;
            this.ErrorDetails = ErrorDetails;
            this.RedirectUrl = RedirectUrl;
            this.Service = Service;
            this.ServiceId = ServiceId;
        }
        
        /// <summary>
        /// The authentication URL used for the cloud storage provider. This information is only included in the response if the user has not passed authentication for the cloud storage provider. If the redirectUrl query string is provided, the returnUrl is appended to the authenticationUrl. 
        /// </summary>
        /// <value>The authentication URL used for the cloud storage provider. This information is only included in the response if the user has not passed authentication for the cloud storage provider. If the redirectUrl query string is provided, the returnUrl is appended to the authenticationUrl. </value>
        [DataMember(Name="authenticationUrl", EmitDefaultValue=false)]
        public string AuthenticationUrl { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.
        /// </summary>
        /// <value>The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.</value>
        [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }
        /// <summary>
        /// The service name for the cloud storage provider.
        /// </summary>
        /// <value>The service name for the cloud storage provider.</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }
        /// <summary>
        /// The DocuSign generated ID for the cloud storage provider
        /// </summary>
        /// <value>The DocuSign generated ID for the cloud storage provider</value>
        [DataMember(Name="serviceId", EmitDefaultValue=false)]
        public string ServiceId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudStorageProvider {\n");
            sb.Append("  AuthenticationUrl: ").Append(AuthenticationUrl).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
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
            return this.Equals(obj as CloudStorageProvider);
        }

        /// <summary>
        /// Returns true if CloudStorageProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of CloudStorageProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudStorageProvider other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationUrl == other.AuthenticationUrl ||
                    this.AuthenticationUrl != null &&
                    this.AuthenticationUrl.Equals(other.AuthenticationUrl)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.RedirectUrl == other.RedirectUrl ||
                    this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(other.RedirectUrl)
                ) && 
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
                ) && 
                (
                    this.ServiceId == other.ServiceId ||
                    this.ServiceId != null &&
                    this.ServiceId.Equals(other.ServiceId)
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
                if (this.AuthenticationUrl != null)
                    hash = hash * 59 + this.AuthenticationUrl.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.RedirectUrl != null)
                    hash = hash * 59 + this.RedirectUrl.GetHashCode();
                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();
                if (this.ServiceId != null)
                    hash = hash * 59 + this.ServiceId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
