using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularApi.Models
{
    public partial class AngularApiContext : DbContext
    {
        public AngularApiContext()
        {
        }

        public AngularApiContext(DbContextOptions<AngularApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=AngularApi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("PK__Document__1ABEEF6F86285147");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentName).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderCusName).HasMaxLength(50);

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDocId).HasColumnName("OrderDocID");

                entity.Property(e => e.OrderFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderGbnum).HasColumnName("OrderGBNum");

                entity.Property(e => e.OrderTrafficType).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
