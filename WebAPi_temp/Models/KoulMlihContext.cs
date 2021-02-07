using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KoulMlihBack.Models
{
    public partial class KoulMlihContext : DbContext
    {
        public KoulMlihContext()
        {
        }

        public KoulMlihContext(DbContextOptions<KoulMlihContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductIngredient> ProductIngredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FETNE78\\SQLEXPRESS;Database=KoulMlih;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.IngredientCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.IngredientLibelle)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.IngredientRemarque)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductBarcode).HasMaxLength(50);

                entity.Property(e => e.ProductBrand)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductLibelle)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProductIngredient>(entity =>
            {
                entity.ToTable("ProductIngredient");

                entity.Property(e => e.ProductIngredientId).HasColumnName("ProductIngredientID");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.ProductIngredients)
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("FK_ProductIngredientId_Ingredient");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductIngredients)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductIngredientId_Product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
