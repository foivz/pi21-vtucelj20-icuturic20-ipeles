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
    
    public partial class izabrao
    {
        public int korisnik_id { get; set; }
        public int ispit_id { get; set; }
        public System.DateTime datum_vrijeme_od { get; set; }
        public Nullable<System.DateTime> datum_vrijeme_do { get; set; }
        public int rezultat { get; set; }
    
        public virtual ispiti ispiti { get; set; }
        public virtual korisnici korisnici { get; set; }
    }
}
