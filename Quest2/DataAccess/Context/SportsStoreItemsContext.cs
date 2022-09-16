using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccess.Models;

namespace DataAccess.Context
{
    public partial class SportsStoreItemsContext : DbContext
    {
        public SportsStoreItemsContext()
        {
        }

        public SportsStoreItemsContext(DbContextOptions<SportsStoreItemsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-KHPQP5A\\SQLEXPRESS;Database=SportsStoreItems;User Id=INDUSOFT\\mikhail.aralin;TrustServerCertificate=True;Trusted_Connection=True;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
