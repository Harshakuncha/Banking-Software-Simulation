﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bankmanagementmainapplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bankmanagement_dbEntities2 : DbContext
    {
        public bankmanagement_dbEntities2()
            : base("name=bankmanagement_dbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<debit> debits { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<FD> FDs { get; set; }
        public virtual DbSet<userAccount> userAccounts { get; set; }
        public virtual DbSet<usertable__> usertable__ { get; set; }
        public virtual DbSet<deposit__> deposit__ { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
    }
}
