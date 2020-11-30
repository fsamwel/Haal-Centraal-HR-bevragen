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
    /// MaatschappelijkeActiviteit
    /// </summary>
    [DataContract]
    public partial class MaatschappelijkeActiviteit :  IEquatable<MaatschappelijkeActiviteit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaatschappelijkeActiviteit" /> class.
        /// </summary>
        /// <param name="kvKnummer">kvKnummer.</param>
        /// <param name="naam">naam.</param>
        /// <param name="nonMailing">nonMailing.</param>
        /// <param name="incidenteelUitlenenArbeidskrachten">incidenteelUitlenenArbeidskrachten.</param>
        /// <param name="notitie">notitie.</param>
        /// <param name="adresBerichtenbox">adresBerichtenbox.</param>
        public MaatschappelijkeActiviteit(string kvKnummer = default(string), string naam = default(string), bool nonMailing = default(bool), bool incidenteelUitlenenArbeidskrachten = default(bool), string notitie = default(string), string adresBerichtenbox = default(string))
        {
            this.KvKnummer = kvKnummer;
            this.Naam = naam;
            this.NonMailing = nonMailing;
            this.IncidenteelUitlenenArbeidskrachten = incidenteelUitlenenArbeidskrachten;
            this.Notitie = notitie;
            this.AdresBerichtenbox = adresBerichtenbox;
        }
        
        /// <summary>
        /// Gets or Sets KvKnummer
        /// </summary>
        [DataMember(Name="KvKnummer", EmitDefaultValue=false)]
        public string KvKnummer { get; set; }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name="naam", EmitDefaultValue=false)]
        public string Naam { get; set; }

        /// <summary>
        /// Gets or Sets NonMailing
        /// </summary>
        [DataMember(Name="nonMailing", EmitDefaultValue=false)]
        public bool NonMailing { get; set; }

        /// <summary>
        /// Gets or Sets IncidenteelUitlenenArbeidskrachten
        /// </summary>
        [DataMember(Name="incidenteelUitlenenArbeidskrachten", EmitDefaultValue=false)]
        public bool IncidenteelUitlenenArbeidskrachten { get; set; }

        /// <summary>
        /// Gets or Sets Notitie
        /// </summary>
        [DataMember(Name="notitie", EmitDefaultValue=false)]
        public string Notitie { get; set; }

        /// <summary>
        /// Gets or Sets AdresBerichtenbox
        /// </summary>
        [DataMember(Name="adresBerichtenbox", EmitDefaultValue=false)]
        public string AdresBerichtenbox { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaatschappelijkeActiviteit {\n");
            sb.Append("  KvKnummer: ").Append(KvKnummer).Append("\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("  NonMailing: ").Append(NonMailing).Append("\n");
            sb.Append("  IncidenteelUitlenenArbeidskrachten: ").Append(IncidenteelUitlenenArbeidskrachten).Append("\n");
            sb.Append("  Notitie: ").Append(Notitie).Append("\n");
            sb.Append("  AdresBerichtenbox: ").Append(AdresBerichtenbox).Append("\n");
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
            return this.Equals(input as MaatschappelijkeActiviteit);
        }

        /// <summary>
        /// Returns true if MaatschappelijkeActiviteit instances are equal
        /// </summary>
        /// <param name="input">Instance of MaatschappelijkeActiviteit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaatschappelijkeActiviteit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KvKnummer == input.KvKnummer ||
                    (this.KvKnummer != null &&
                    this.KvKnummer.Equals(input.KvKnummer))
                ) && 
                (
                    this.Naam == input.Naam ||
                    (this.Naam != null &&
                    this.Naam.Equals(input.Naam))
                ) && 
                (
                    this.NonMailing == input.NonMailing ||
                    (this.NonMailing != null &&
                    this.NonMailing.Equals(input.NonMailing))
                ) && 
                (
                    this.IncidenteelUitlenenArbeidskrachten == input.IncidenteelUitlenenArbeidskrachten ||
                    (this.IncidenteelUitlenenArbeidskrachten != null &&
                    this.IncidenteelUitlenenArbeidskrachten.Equals(input.IncidenteelUitlenenArbeidskrachten))
                ) && 
                (
                    this.Notitie == input.Notitie ||
                    (this.Notitie != null &&
                    this.Notitie.Equals(input.Notitie))
                ) && 
                (
                    this.AdresBerichtenbox == input.AdresBerichtenbox ||
                    (this.AdresBerichtenbox != null &&
                    this.AdresBerichtenbox.Equals(input.AdresBerichtenbox))
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
                if (this.KvKnummer != null)
                    hashCode = hashCode * 59 + this.KvKnummer.GetHashCode();
                if (this.Naam != null)
                    hashCode = hashCode * 59 + this.Naam.GetHashCode();
                if (this.NonMailing != null)
                    hashCode = hashCode * 59 + this.NonMailing.GetHashCode();
                if (this.IncidenteelUitlenenArbeidskrachten != null)
                    hashCode = hashCode * 59 + this.IncidenteelUitlenenArbeidskrachten.GetHashCode();
                if (this.Notitie != null)
                    hashCode = hashCode * 59 + this.Notitie.GetHashCode();
                if (this.AdresBerichtenbox != null)
                    hashCode = hashCode * 59 + this.AdresBerichtenbox.GetHashCode();
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
