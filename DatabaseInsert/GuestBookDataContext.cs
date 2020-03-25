using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseInsert
{
    public partial class GuestBookDataContext : DbContext
    {
        public virtual DbSet<GuestBook> GuestBook { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestBook>(entity =>
            {
                entity.Property(e => e.Email).HasColumnType("nchar(255)");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("nchar(50)");
            });
        }
    }
}
