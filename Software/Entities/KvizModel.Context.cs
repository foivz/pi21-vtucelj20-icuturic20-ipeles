﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KvizModelEntities : DbContext
    {
        public KvizModelEntities()
            : base("name=KvizModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cjelina> cjeline { get; set; }
        public virtual DbSet<dan_odgovor> dani_odgovori { get; set; }
        public virtual DbSet<ispit> ispiti { get; set; }
        public virtual DbSet<izabrao> izabrao { get; set; }
        public virtual DbSet<korisnik> korisnici { get; set; }
        public virtual DbSet<pitanje> pitanja { get; set; }
        public virtual DbSet<ponudeni_odgovor> ponudeni_odgovori { get; set; }
        public virtual DbSet<predmet> predmeti { get; set; }
        public virtual DbSet<razred> razredi { get; set; }
        public virtual DbSet<skola> skole { get; set; }
        public virtual DbSet<tip_korisnika> tipovi_korisnika { get; set; }
        public virtual DbSet<zaduzen_za> zaduzen_za { get; set; }
    }
}
