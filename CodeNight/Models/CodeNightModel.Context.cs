﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeNight.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CodeNightEntities : DbContext
    {
        public CodeNightEntities()
            : base("name=CodeNightEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Favori> Tbl_Favori { get; set; }
        public virtual DbSet<Tbl_Kategori> Tbl_Kategori { get; set; }
        public virtual DbSet<Tbl_Kullanici> Tbl_Kullanici { get; set; }
        public virtual DbSet<Tbl_Mesaj> Tbl_Mesaj { get; set; }
        public virtual DbSet<Tbl_Mesajlasma> Tbl_Mesajlasma { get; set; }
        public virtual DbSet<Tbl_Urun> Tbl_Urun { get; set; }
        public virtual DbSet<Tbl_UrunAl> Tbl_UrunAl { get; set; }
    
        public virtual ObjectResult<urunarama_Result> urunarama(string adi)
        {
            var adiParameter = adi != null ?
                new ObjectParameter("Adi", adi) :
                new ObjectParameter("Adi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<urunarama_Result>("urunarama", adiParameter);
        }
    }
}
