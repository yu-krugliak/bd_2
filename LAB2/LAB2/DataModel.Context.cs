﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LAB2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_waterfallsEntities : DbContext
    {
        public BD_waterfallsEntities()
            : base("name=BD_waterfallsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Rivers> Rivers { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }
        public virtual DbSet<Waterfalls> Waterfalls { get; set; }
    }
}