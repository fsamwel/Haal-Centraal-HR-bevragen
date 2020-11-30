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
    /// uri voor het opvragen van de vorige pagina van deze collectie
    /// </summary>
    [DataContract]
    public partial class HalPaginationLinksPrevious :  IEquatable<HalPaginationLinksPrevious>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HalPaginationLinksPrevious" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="templated">templated.</param>
        /// <param name="title">title.</param>
        public HalPaginationLinksPrevious(string href = default(string), bool templated = default(bool), string title = default(string))
        {
            this.Href = href;
            this.Templated = templated;
            this.Title = title;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Templated
        /// </summary>
        [DataMember(Name="templated", EmitDefaultValue=false)]
        public bool Templated { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HalPaginationLinksPrevious {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Templated: ").Append(Templated).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as HalPaginationLinksPrevious);
        }

        /// <summary>
        /// Returns true if HalPaginationLinksPrevious instances are equal
        /// </summary>
        /// <param name="input">Instance of HalPaginationLinksPrevious to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HalPaginationLinksPrevious input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Templated == input.Templated ||
                    (this.Templated != null &&
                    this.Templated.Equals(input.Templated))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Templated != null)
                    hashCode = hashCode * 59 + this.Templated.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
