using E_Commerce.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany<Address>()
                .WithOne()
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<User>()
                .HasOne<SystemRole>()
                .WithMany()
                .HasForeignKey(x => x.SystemRoleId);
            
            modelBuilder.Entity<User>()
                .HasMany<PaymentMethod>()
                .WithOne()
                .HasForeignKey(x => x.UserId);
            
            modelBuilder.Entity<PaymentMethod>()
                .HasOne<PaymentType>()
                .WithMany()
                .HasForeignKey(x => x.PaymentTypeId);

            //modelBuilder.Entity<Category>()
            //    .HasMany<Product>()
            //    .WithOne()
            //    .HasForeignKey(x => x.CatagoryId);

            //modelBuilder.Entity<ProductGender>()
            //    .HasMany<Product>()
            //    .WithOne()
            //    .HasForeignKey(x => x.ProductGenderId);

            //modelBuilder.Entity<Product>()
            //    .HasMany<ProductAttributes>()
            //    .WithOne()
            //    .HasForeignKey(x => x.ProductId);

            //modelBuilder.Entity<ProductColor>()
            //    .HasMany<ProductAttributes>()
            //    .WithOne()
            //    .HasForeignKey(x => x.ColorId);

            //modelBuilder.Entity<ProductSize>()
            //    .HasMany<ProductAttributes>()
            //    .WithOne()
            //    .HasForeignKey(x => x.SizeId);

            //modelBuilder.Entity<Material>()
            //    .HasMany<ProductAttributes>()
            //    .WithOne()
            //    .HasForeignKey(x => x.MaterialId);

            //modelBuilder.Entity<User>()
            //    .HasMany<ShoppingCart>()
            //    .WithOne()
            //    .HasForeignKey(x => x.UserId);

            //modelBuilder.Entity<ShoppingCart>()
            //    .HasMany<ShoppingCartItem>()
            //    .WithOne()
            //    .HasForeignKey(x => x.CartId);

            modelBuilder.Entity<ShoppingCartItem>()
                .HasOne<Product>()
                .WithOne()
                .HasForeignKey<ShoppingCartItem>(x => x.ProductId);

            //modelBuilder.Entity<Product>()
            //    .HasMany<Image>()
            //    .WithOne()
            //    .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<ProductColor>()
                .HasMany<Image>()
                .WithOne()
                .HasForeignKey(x => x.ColorId);

        }

        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<SystemRole> SystemRole { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductGender> ProductGender { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductAttributes> ProductAttributes { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductSize> ProductSize { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Image> Image { get; set; }
    //    public DbSet<Promotion> Promotion { get; set; } 
     //   public DbSet<ShoppingCart> ShoppingCart { get; set; } 
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; } 







    }
}
