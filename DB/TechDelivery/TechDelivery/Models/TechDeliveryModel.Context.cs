﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechDelivery.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TechDeliveryEntities11 : DbContext
    {
        public TechDeliveryEntities11()
            : base("name=TechDeliveryEntities11")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carriage> Carriage { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientStatusTable> ClientStatusTable { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeeStatusTable> EmployeeStatusTable { get; set; }
        public virtual DbSet<LeasingCompany> LeasingCompany { get; set; }
        public virtual DbSet<LeasingCompanyTransportTable> LeasingCompanyTransportTable { get; set; }
        public virtual DbSet<OrderTable> OrderTable { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<StorageTypeTable> StorageTypeTable { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
    }
}
