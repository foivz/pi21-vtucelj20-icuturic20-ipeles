//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt.Enitities
{
    using System;
    using System.Collections.Generic;
    
    public partial class korisnici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnici()
        {
            this.dani_odgovori = new HashSet<dani_odgovori>();
            this.izabraos = new HashSet<izabrao>();
            this.pitanjas = new HashSet<pitanja>();
            this.skoles = new HashSet<skole>();
            this.zaduzen_za = new HashSet<zaduzen_za>();
        }
    
        public int korisnik_id { get; set; }
        public string korisnicko_ime { get; set; }
        public string lozinka { get; set; }
        public string mail { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public int postanski_broj { get; set; }
        public byte status { get; set; }
        public int tip_id { get; set; }
        public Nullable<int> razred_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dani_odgovori> dani_odgovori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<izabrao> izabraos { get; set; }
        public virtual razredi razredi { get; set; }
        public virtual tipovi_korisnika tipovi_korisnika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pitanja> pitanjas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skole> skoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaduzen_za> zaduzen_za { get; set; }
    }
}