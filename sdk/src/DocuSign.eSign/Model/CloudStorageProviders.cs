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
    /// CloudStorageProviders
    /// </summary>
    [DataContract]
    public partial class CloudStorageProviders :  IEquatable<CloudStorageProviders>, IValidatableObject
    {
        public CloudStorageProviders()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudStorageProviders" /> class.
        /// </summary>
        /// <param name="StorageProviders">An Array containing the storage providers associated with the user..</param>
        public CloudStorageProviders(List<CloudStorageProvider> StorageProviders = default(List<CloudStorageProvider>))
        {
            this.StorageProviders = StorageProviders;
        }
        
        /// <summary>
        /// An Array containing the storage providers associated with the user.
        /// </summary>
        /// <value>An Array containing the storage providers associated with the user.</value>
        [DataMember(Name="storageProviders", EmitDefaultValue=false)]
        public List<CloudStorageProvider> StorageProviders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudStorageProviders {\n");
            sb.Append("  StorageProviders: ").Append(StorageProviders).Append("\n");
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
            return this.Equals(obj as CloudStorageProviders);
        }

        /// <summary>
        /// Returns true if CloudStorageProviders instances are equal
        /// </summary>
        /// <param name="other">Instance of CloudStorageProviders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudStorageProviders other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StorageProviders == other.StorageProviders ||
                    this.StorageProviders != null &&
                    this.StorageProviders.SequenceEqual(other.StorageProviders)
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
                if (this.StorageProviders != null)
                    hash = hash * 59 + this.StorageProviders.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
