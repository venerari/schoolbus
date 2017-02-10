/*
 * REST API Documentation for the MOTI School Bus Application
 *
 * The School Bus application tracks that inspections are performed in a timely fashion. For each school bus the application tracks information about the bus (including data from ICBC, NSC, etc.), it's past and next inspection dates and results, contacts, and the inspector responsible for next inspecting the bus.
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using SchoolBusAPI.Models;

namespace SchoolBusAPI.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UserViewModel : IEquatable<UserViewModel>
    {
        /// <summary>
        /// Default constructor, required by entity framework
        /// </summary>
        public UserViewModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserViewModel" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Active">Active (required).</param>
        /// <param name="GivenName">GivenName.</param>
        /// <param name="Surname">Surname.</param>
        /// <param name="Initials">Initials.</param>
        /// <param name="Email">Email.</param>
        public UserViewModel(int Id, string GivenName, string Surname, bool Active, string Email = null, List<UserRole> UserRoles = null, List<GroupMembership> GroupMemberships = null, District District = null)
        {

            this.Id = Id;
            this.GivenName = GivenName;
            this.Surname = Surname;
            this.Email = Email;
            this.Active = Active;
            this.UserRoles = UserRoles;
            this.GroupMemberships = GroupMemberships;
            this.District = District;
            this.UserRoles = UserRoles;

        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name="givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets UserRoles
        /// </summary>
        [DataMember(Name = "UserRoles")]
        public List<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Gets or Sets GroupMemberships
        /// </summary>
        [DataMember(Name = "GroupMemberships")]
        public List<GroupMembership> GroupMemberships { get; set; }

        /// <summary>
        /// The District that the User belongs to
        /// </summary>
        /// <value>The District that the User belongs to</value>
        [DataMember(Name = "District")]
        public District District { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserViewModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");           
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  District: ").Append(this.District.ToString()).Append("\n");
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
            if (ReferenceEquals(null, obj)) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != GetType()) { return false; }
            return Equals((UserViewModel)obj);
        }

        /// <summary>
        /// Returns true if UserViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of UserViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserViewModel other)
        {

            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return 
                (
                    this.Id == other.Id ||
                    
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.GivenName == other.GivenName ||
                    this.GivenName != null &&
                    this.GivenName.Equals(other.GivenName)
                ) && 
                (
                    this.Surname == other.Surname ||
                    this.Surname != null &&
                    this.Surname.Equals(other.Surname)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.District == other.District ||
                    this.District != null &&
                    this.District.Equals(other.District)
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
                hash = hash * 59 + this.Id.GetHashCode();

                // Suitable nullity checks

                if (this.GivenName != null)
                {
                    hash = hash * 59 + this.GivenName.GetHashCode();
                }
                if (this.Surname != null)
                {
                    hash = hash * 59 + this.Surname.GetHashCode();
                }                
                if (this.Email != null)
                {
                    hash = hash * 59 + this.Email.GetHashCode();
                }
                if (this.Email != null)
                {
                    hash = hash * 59 + this.District.GetHashCode();
                }
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(UserViewModel left, UserViewModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserViewModel left, UserViewModel right)
        {
            return !Equals(left, right);
        }

        #endregion Operators
    }
}
