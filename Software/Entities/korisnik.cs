//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnik()
        {
            this.dan_odgovor = new HashSet<dan_odgovor>();
            this.izabrao = new HashSet<izabrao>();
            this.pitanje = new HashSet<pitanje>();
            this.skola = new HashSet<skola>();
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
        public virtual ICollection<dan_odgovor> dan_odgovor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<izabrao> izabrao { get; set; }
        public virtual razred razred { get; set; }
        public virtual tip_korisnika tip_korisnika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pitanje> pitanje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skola> skola { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaduzen_za> zaduzen_za { get; set; }
    }
}
