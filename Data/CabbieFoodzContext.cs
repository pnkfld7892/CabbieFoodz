using System;
using CabbieFoodz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CabbieFoodz.Data
{
    public partial class CabbieFoodzContext : DbContext
    {
        public DbSet<Food> Foodz{get;set;}
        //TODO: Clean up Models and ReScaffold migrations
        public DbSet<Cabbie> Cabbies{get;set;}
        public DbSet<FoodInCabbie> FoodInCabbies{get;set;}

        public CabbieFoodzContext()
        {
        }

        public CabbieFoodzContext(DbContextOptions<CabbieFoodzContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=ConnectionStrings.CabbieFoodzDb", x => x.ServerVersion("10.4.13-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: change the foodincabbie model to have a composite key
            //this has to be done with the flutent API here in onmodelcreating
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
