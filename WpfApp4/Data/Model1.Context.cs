﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp4.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DVDEntities : DbContext
    {
        public DVDEntities()
            : base("name=DVDEntities")
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
