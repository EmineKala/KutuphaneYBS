﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneBS.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Kutuphane_Bilgi_SistemiEntities : DbContext
    {
        public Kutuphane_Bilgi_SistemiEntities()
            : base("name=Kutuphane_Bilgi_SistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CEZA> CEZA { get; set; }
        public virtual DbSet<CEZA_UYE> CEZA_UYE { get; set; }
        public virtual DbSet<FAVORI> FAVORI { get; set; }
        public virtual DbSet<ISTEK> ISTEK { get; set; }
        public virtual DbSet<KITAP> KITAP { get; set; }
        public virtual DbSet<KUTUPHANE> KUTUPHANE { get; set; }
        public virtual DbSet<TARIH> TARIH { get; set; }
        public virtual DbSet<UYE> UYE { get; set; }
        public virtual DbSet<YORUM> YORUM { get; set; }
    }
}
