﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateCatalog.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RealEstateCatalogEntities : DbContext
    {
        public RealEstateCatalogEntities()
            : base("name=RealEstateCatalogEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Apartment> Apartment { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<CorporateClient> CorporateClient { get; set; }
        public virtual DbSet<IndividualClient> IndividualClient { get; set; }
        public virtual DbSet<PhotoCatalog> PhotoCatalog { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Сontract> Сontract { get; set; }
    }
}
