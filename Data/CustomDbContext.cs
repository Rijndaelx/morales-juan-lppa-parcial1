using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using morales_juan_lppa_parcial1.Data.Entities;

namespace morales_juan_lppa_parcial1.Data
{
    public class CustomDbContext : DbContext
    {

        public DbSet<Afiliado> Afiliados { get; set; }


        public CustomDbContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}