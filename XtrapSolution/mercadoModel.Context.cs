﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XtrapSolution
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mercadomContext : DbContext
    {
        public mercadomContext()
            : base("name=mercadomContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria> categorias { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<fornecedor> fornecedors { get; set; }
        public virtual DbSet<produto> produtoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
