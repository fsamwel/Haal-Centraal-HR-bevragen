/* 
 * Handelsregister bevragen
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op het Handelsregister beschikbaar gesteld.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MaatschappelijkeActiviteitHalBasisAllOf
    /// </summary>
    [DataContract]
    public partial class MaatschappelijkeActiviteitHalBasisAllOf :  IEquatable<MaatschappelijkeActiviteitHalBasisAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaatschappelijkeActiviteitHalBasisAllOf" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        public MaatschappelijkeActiviteitHalBasisAllOf(MaatschappelijkeActiviteitLinks links = default(MaatschappelijkeActiviteitLinks))
        {
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public MaatschappelijkeActiviteitLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaatschappelijkeActiviteitHalBasisAllOf {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MaatschappelijkeActiviteitHalBasisAllOf);
        }

        /// <summary>
        /// Returns true if MaatschappelijkeActiviteitHalBasisAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of MaatschappelijkeActiviteitHalBasisAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaatschappelijkeActiviteitHalBasisAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}