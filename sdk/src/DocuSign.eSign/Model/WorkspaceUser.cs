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
    /// A workspaceUser representing the user. This property is only returned in response to user specific GET call. 
    /// </summary>
    [DataContract]
    public partial class WorkspaceUser :  IEquatable<WorkspaceUser>, IValidatableObject
    {
        public WorkspaceUser()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUser" /> class.
        /// </summary>
        /// <param name="AccountId">The account ID associated with the envelope..</param>
        /// <param name="AccountName">The name of the account that the workspace user belongs to..</param>
        /// <param name="ActiveSince">ActiveSince.</param>
        /// <param name="Created">The UTC DateTime when the workspace user was created..</param>
        /// <param name="CreatedById">CreatedById.</param>
        /// <param name="Email">Email.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="LastModified">Utc date and time the comment was last updated (can only be done by creator.).</param>
        /// <param name="LastModifiedById">LastModifiedById.</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        /// <param name="Type">Type of the user. Valid values: type_owner, type_participant..</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="WorkspaceId">WorkspaceId.</param>
        /// <param name="WorkspaceUserBaseUrl">The relative URI that may be used to access a workspace user..</param>
        /// <param name="WorkspaceUserId">WorkspaceUserId.</param>
        public WorkspaceUser(string AccountId = default(string), string AccountName = default(string), string ActiveSince = default(string), string Created = default(string), string CreatedById = default(string), string Email = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string LastModified = default(string), string LastModifiedById = default(string), string Status = default(string), string Type = default(string), string UserId = default(string), string UserName = default(string), string WorkspaceId = default(string), string WorkspaceUserBaseUrl = default(string), string WorkspaceUserId = default(string))
        {
            this.AccountId = AccountId;
            this.AccountName = AccountName;
            this.ActiveSince = ActiveSince;
            this.Created = Created;
            this.CreatedById = CreatedById;
            this.Email = Email;
            this.ErrorDetails = ErrorDetails;
            this.LastModified = LastModified;
            this.LastModifiedById = LastModifiedById;
            this.Status = Status;
            this.Type = Type;
            this.UserId = UserId;
            this.UserName = UserName;
            this.WorkspaceId = WorkspaceId;
            this.WorkspaceUserBaseUrl = WorkspaceUserBaseUrl;
            this.WorkspaceUserId = WorkspaceUserId;
        }
        
        /// <summary>
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// The name of the account that the workspace user belongs to.
        /// </summary>
        /// <value>The name of the account that the workspace user belongs to.</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// Gets or Sets ActiveSince
        /// </summary>
        [DataMember(Name="activeSince", EmitDefaultValue=false)]
        public string ActiveSince { get; set; }
        /// <summary>
        /// The UTC DateTime when the workspace user was created.
        /// </summary>
        /// <value>The UTC DateTime when the workspace user was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name="createdById", EmitDefaultValue=false)]
        public string CreatedById { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Utc date and time the comment was last updated (can only be done by creator.)
        /// </summary>
        /// <value>Utc date and time the comment was last updated (can only be done by creator.)</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedById
        /// </summary>
        [DataMember(Name="lastModifiedById", EmitDefaultValue=false)]
        public string LastModifiedById { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Type of the user. Valid values: type_owner, type_participant.
        /// </summary>
        /// <value>Type of the user. Valid values: type_owner, type_participant.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name="workspaceId", EmitDefaultValue=false)]
        public string WorkspaceId { get; set; }
        /// <summary>
        /// The relative URI that may be used to access a workspace user.
        /// </summary>
        /// <value>The relative URI that may be used to access a workspace user.</value>
        [DataMember(Name="workspaceUserBaseUrl", EmitDefaultValue=false)]
        public string WorkspaceUserBaseUrl { get; set; }
        /// <summary>
        /// Gets or Sets WorkspaceUserId
        /// </summary>
        [DataMember(Name="workspaceUserId", EmitDefaultValue=false)]
        public string WorkspaceUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceUser {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ActiveSince: ").Append(ActiveSince).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedById: ").Append(LastModifiedById).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  WorkspaceUserBaseUrl: ").Append(WorkspaceUserBaseUrl).Append("\n");
            sb.Append("  WorkspaceUserId: ").Append(WorkspaceUserId).Append("\n");
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
            return this.Equals(obj as WorkspaceUser);
        }

        /// <summary>
        /// Returns true if WorkspaceUser instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkspaceUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.ActiveSince == other.ActiveSince ||
                    this.ActiveSince != null &&
                    this.ActiveSince.Equals(other.ActiveSince)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.CreatedById == other.CreatedById ||
                    this.CreatedById != null &&
                    this.CreatedById.Equals(other.CreatedById)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.LastModifiedById == other.LastModifiedById ||
                    this.LastModifiedById != null &&
                    this.LastModifiedById.Equals(other.LastModifiedById)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.WorkspaceId == other.WorkspaceId ||
                    this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(other.WorkspaceId)
                ) && 
                (
                    this.WorkspaceUserBaseUrl == other.WorkspaceUserBaseUrl ||
                    this.WorkspaceUserBaseUrl != null &&
                    this.WorkspaceUserBaseUrl.Equals(other.WorkspaceUserBaseUrl)
                ) && 
                (
                    this.WorkspaceUserId == other.WorkspaceUserId ||
                    this.WorkspaceUserId != null &&
                    this.WorkspaceUserId.Equals(other.WorkspaceUserId)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.ActiveSince != null)
                    hash = hash * 59 + this.ActiveSince.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.CreatedById != null)
                    hash = hash * 59 + this.CreatedById.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedById != null)
                    hash = hash * 59 + this.LastModifiedById.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.WorkspaceId != null)
                    hash = hash * 59 + this.WorkspaceId.GetHashCode();
                if (this.WorkspaceUserBaseUrl != null)
                    hash = hash * 59 + this.WorkspaceUserBaseUrl.GetHashCode();
                if (this.WorkspaceUserId != null)
                    hash = hash * 59 + this.WorkspaceUserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
