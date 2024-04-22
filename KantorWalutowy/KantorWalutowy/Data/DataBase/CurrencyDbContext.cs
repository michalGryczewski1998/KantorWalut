using KantorWalutowy.Data.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantorWalutowy.Data.DataBase
{
    public class CurrencyDbContext : DbContext
    {
        private readonly string _connectionString = "Data Source=(localdb)\\Local;Initial Catalog=Kantor;Integrated Security=True;Server Certificate=False";

        public DbSet<Currency> Currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencyName)
                .IsRequired();

            modelBuilder.Entity<Currency>()
                .Property(e => e.Rate)
                .IsRequired();

            modelBuilder.Entity<Currency>()
                .Property(e => e.Time)
                .IsRequired();
        }
    }
}
