﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoGolikeEntities : DbContext
    {
        public AutoGolikeEntities()
            : base("name=AutoGolikeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankInfomation> BankInfomations { get; set; }
        public virtual DbSet<fbAccount> fbAccounts { get; set; }
        public virtual DbSet<glAccount> glAccounts { get; set; }
        public virtual DbSet<glInformation> glInformations { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<StatusTable> StatusTables { get; set; }
    }
}
