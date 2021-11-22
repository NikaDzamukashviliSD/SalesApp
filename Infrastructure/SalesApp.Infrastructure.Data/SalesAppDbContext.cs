using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SalesApp.Infrastructure.Data.Entities;

#nullable disable

namespace SalesApp.Infrastructure.Data
{
    public partial class SalesAppDbContext : DbContext
    {
        public SalesAppDbContext()
        {
        }

        public SalesAppDbContext(DbContextOptions<SalesAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-U2BV2MK\\SQLEXPRESS;Initial Catalog=SalesAppDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId)
                    .ValueGeneratedNever()
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientFname)
                    .HasMaxLength(64)
                    .HasColumnName("client_fname");

                entity.Property(e => e.ClientLname)
                    .HasMaxLength(64)
                    .HasColumnName("client_lname");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("order_id");

                entity.Property(e => e.OrderAmmount).HasColumnName("order_ammount");

                entity.Property(e => e.OrderClientId).HasColumnName("order_client_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderParentId).HasColumnName("order_parent_id");

                entity.Property(e => e.OrderSellerId).HasColumnName("order_seller_id");

                entity.HasOne(d => d.OrderClient)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__order_cl__398D8EEE");

                entity.HasOne(d => d.OrderSeller)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderSellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__order_se__3A81B327");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.Property(e => e.SellerId)
                    .ValueGeneratedNever()
                    .HasColumnName("seller_id");

                entity.Property(e => e.SellerBossId).HasColumnName("seller_boss_id");

                entity.Property(e => e.SellerFname)
                    .HasMaxLength(64)
                    .HasColumnName("seller_fname");

                entity.Property(e => e.SellerLname)
                    .HasMaxLength(64)
                    .HasColumnName("seller_lname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
