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
    /// BrandLink
    /// </summary>
    [DataContract]
    public partial class BrandLink :  IEquatable<BrandLink>, IValidatableObject
    {
        public BrandLink()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandLink" /> class.
        /// </summary>
        /// <param name="LinkText">LinkText.</param>
        /// <param name="LinkType">LinkType.</param>
        /// <param name="ShowLink">ShowLink.</param>
        /// <param name="UrlOrMailTo">UrlOrMailTo.</param>
        public BrandLink(string LinkText = default(string), string LinkType = default(string), string ShowLink = default(string), string UrlOrMailTo = default(string))
        {
            this.LinkText = LinkText;
            this.LinkType = LinkType;
            this.ShowLink = ShowLink;
            this.UrlOrMailTo = UrlOrMailTo;
        }
        
        /// <summary>
        /// Gets or Sets LinkText
        /// </summary>
        [DataMember(Name="linkText", EmitDefaultValue=false)]
        public string LinkText { get; set; }
        /// <summary>
        /// Gets or Sets LinkType
        /// </summary>
        [DataMember(Name="linkType", EmitDefaultValue=false)]
        public string LinkType { get; set; }
        /// <summary>
        /// Gets or Sets ShowLink
        /// </summary>
        [DataMember(Name="showLink", EmitDefaultValue=false)]
        public string ShowLink { get; set; }
        /// <summary>
        /// Gets or Sets UrlOrMailTo
        /// </summary>
        [DataMember(Name="urlOrMailTo", EmitDefaultValue=false)]
        public string UrlOrMailTo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandLink {\n");
            sb.Append("  LinkText: ").Append(LinkText).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  ShowLink: ").Append(ShowLink).Append("\n");
            sb.Append("  UrlOrMailTo: ").Append(UrlOrMailTo).Append("\n");
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
            return this.Equals(obj as BrandLink);
        }

        /// <summary>
        /// Returns true if BrandLink instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LinkText == other.LinkText ||
                    this.LinkText != null &&
                    this.LinkText.Equals(other.LinkText)
                ) && 
                (
                    this.LinkType == other.LinkType ||
                    this.LinkType != null &&
                    this.LinkType.Equals(other.LinkType)
                ) && 
                (
                    this.ShowLink == other.ShowLink ||
                    this.ShowLink != null &&
                    this.ShowLink.Equals(other.ShowLink)
                ) && 
                (
                    this.UrlOrMailTo == other.UrlOrMailTo ||
                    this.UrlOrMailTo != null &&
                    this.UrlOrMailTo.Equals(other.UrlOrMailTo)
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
                if (this.LinkText != null)
                    hash = hash * 59 + this.LinkText.GetHashCode();
                if (this.LinkType != null)
                    hash = hash * 59 + this.LinkType.GetHashCode();
                if (this.ShowLink != null)
                    hash = hash * 59 + this.ShowLink.GetHashCode();
                if (this.UrlOrMailTo != null)
                    hash = hash * 59 + this.UrlOrMailTo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
