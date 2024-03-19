using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Arbeit_Rahim.Database
{
    internal class DatabaseDefiner : DbContext
    {
        public DbSet<BaseItem> BaseItems { get; set; } = null!;
        public DbSet<ModItem> ModItems { get; set; } = null!;
       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseItem>().HasKey(MI => MI.Id);
            modelBuilder.Entity<ModItem>().HasKey(MI => MI.Id);
          
           
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($@"Data Source={Directory.GetCurrentDirectory()}\Database\Database.db");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}