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
    
    public partial class pitanje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pitanje()
        {
            this.ponudeni_odgovor = new HashSet<ponudeni_odgovor>();
        }
    
        public int pitanje_id { get; set; }
        public string tekst_pitanja { get; set; }
        public int ispit_id { get; set; }
        public int kreirao_korisnik_id { get; set; }
    
        public virtual ispit ispit { get; set; }
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ponudeni_odgovor> ponudeni_odgovor { get; set; }
    }
}