﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp4.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DVDEntities1 : DbContext
    {
        public DVDEntities1()
            : base("name=DVDEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arenda> Arenda { get; set; }
        public virtual DbSet<Check> Check { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Film_Zhanr> Film_Zhanr { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudnik { get; set; }
        public virtual DbSet<Vozrast> Vozrast { get; set; }
        public virtual DbSet<Zhanr> Zhanr { get; set; }
    }
}
