using Microsoft.EntityFrameworkCore;
using Shopper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper.Data
{
    public class ShopperContext : DbContext
    {
        public ShopperContext()
        {

        }
        public DbSet<Category> Categories { get; set; }  //add references ile shopper.entities ekle
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S3IT42P\\SQLEXPRESS;Database=ShopperDb;Trusted_Connection=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Tablo ismi : ToTable ve tabloya ait primary key : HasKey  tanımladık
            modelBuilder.Entity<Category>().ToTable("Category").HasKey(c => c.CategoryId);
            modelBuilder.Entity<Product>().ToTable("Product").HasKey(p => p.ProductId);
            modelBuilder.Entity<ProductPrice>().ToTable("ProductPrice").HasKey(pp => pp.PriceId);
            modelBuilder.Entity<ProductImage>().ToTable("ProductImage").HasKey(pi => pi.ImageId);

            //Relations
            modelBuilder.Entity<Category>()
                .HasMany<Product>(c=>c.Producst)
                .WithOne(c=>c.ProductCategory)
                .HasForeignKey(c=>c.CategoryId)
                .HasConstraintName("Fk_ProductToCategory")
                .OnDelete(DeleteBehavior.Cascade); //categori silindiğinde ona ait ürünler de gitsin

            modelBuilder.Entity<ProductPrice>()
                .HasOne<Product>(c => c.Product)
                .WithMany(c => c.ProductPrice)
                .HasForeignKey(c => c.ProductId)
                .HasConstraintName("Fk_ProductPriceToProduct")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductImage>()
                .HasOne<Product>(c => c.Product)
                .WithMany(c => c.ProductImage)
                .HasForeignKey(c => c.ProductId)
                .HasConstraintName("Fk_ProductImageToProduct")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
