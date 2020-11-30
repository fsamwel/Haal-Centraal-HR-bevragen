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
    /// Eigenschappen van het adres die kunnen worden hergebruikt in andere API&#39;s waarin adresgegevens worden opgenomen. 
    /// </summary>
    [DataContract]
    public partial class Adres :  IEquatable<Adres>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adres" /> class.
        /// </summary>
        /// <param name="straat">Een naam die door de gemeente aan een openbare ruimte is gegeven..</param>
        /// <param name="huisnummer">Een nummer dat door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="huisletter">Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="huisnummertoevoeging">Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven..</param>
        /// <param name="postcode">De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort..</param>
        /// <param name="woonplaats">Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam..</param>
        public Adres(string straat = default(string), int huisnummer = default(int), string huisletter = default(string), string huisnummertoevoeging = default(string), string postcode = default(string), string woonplaats = default(string))
        {
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Huisletter = huisletter;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.Postcode = postcode;
            this.Woonplaats = woonplaats;
        }
        
        /// <summary>
        /// Een naam die door de gemeente aan een openbare ruimte is gegeven.
        /// </summary>
        /// <value>Een naam die door de gemeente aan een openbare ruimte is gegeven.</value>
        [DataMember(Name="straat", EmitDefaultValue=false)]
        public string Straat { get; set; }

        /// <summary>
        /// Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een nummer dat door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name="huisnummer", EmitDefaultValue=false)]
        public int Huisnummer { get; set; }

        /// <summary>
        /// Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name="huisletter", EmitDefaultValue=false)]
        public string Huisletter { get; set; }

        /// <summary>
        /// Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.
        /// </summary>
        /// <value>Een toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.</value>
        [DataMember(Name="huisnummertoevoeging", EmitDefaultValue=false)]
        public string Huisnummertoevoeging { get; set; }

        /// <summary>
        /// De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.
        /// </summary>
        /// <value>De door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.
        /// </summary>
        /// <value>Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.</value>
        [DataMember(Name="woonplaats", EmitDefaultValue=false)]
        public string Woonplaats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Adres {\n");
            sb.Append("  Straat: ").Append(Straat).Append("\n");
            sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
            sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
            sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
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
            return this.Equals(input as Adres);
        }

        /// <summary>
        /// Returns true if Adres instances are equal
        /// </summary>
        /// <param name="input">Instance of Adres to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Adres input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Straat == input.Straat ||
                    (this.Straat != null &&
                    this.Straat.Equals(input.Straat))
                ) && 
                (
                    this.Huisnummer == input.Huisnummer ||
                    this.Huisnummer.Equals(input.Huisnummer)
                ) && 
                (
                    this.Huisletter == input.Huisletter ||
                    (this.Huisletter != null &&
                    this.Huisletter.Equals(input.Huisletter))
                ) && 
                (
                    this.Huisnummertoevoeging == input.Huisnummertoevoeging ||
                    (this.Huisnummertoevoeging != null &&
                    this.Huisnummertoevoeging.Equals(input.Huisnummertoevoeging))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Woonplaats == input.Woonplaats ||
                    (this.Woonplaats != null &&
                    this.Woonplaats.Equals(input.Woonplaats))
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
                if (this.Straat != null)
                    hashCode = hashCode * 59 + this.Straat.GetHashCode();
                hashCode = hashCode * 59 + this.Huisnummer.GetHashCode();
                if (this.Huisletter != null)
                    hashCode = hashCode * 59 + this.Huisletter.GetHashCode();
                if (this.Huisnummertoevoeging != null)
                    hashCode = hashCode * 59 + this.Huisnummertoevoeging.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Woonplaats != null)
                    hashCode = hashCode * 59 + this.Woonplaats.GetHashCode();
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
