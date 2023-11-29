using System;
using BackendProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Advert>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Customer>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Review>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Subscribe>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Slider>().HasData(
              new Slider { Id = 1, Image = "1.jpg",Header= "Save 25%" ,Title = "Christmas Sale", Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which.",  SoftDeleted = false },
              new Slider { Id = 2, Image = "2.jpg", Header = "Save 25%", Title = "Christmas Sale", Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which.", SoftDeleted = false }
          );

            modelBuilder.Entity<Direction>().HasData(
                new Direction { Id=1,Name="right"},
                new Direction { Id = 2, Name = "left" }
                );

            modelBuilder.Entity<Advert>().HasData(
                new Advert {Id=1,Description= "<h1 class=\"white\"><span>Gifts</span>Christmas</h1>",Image= "1.jpg",DirectionId=1,SoftDeleted=false },
                new Advert { Id = 2, Description = "<h2 class=\"black\"><span class=\"small\">Save <span class=\"red\">25%</span></span><span class=\"red\">Offer</span> Christmas</h2>", Image = "2.jpg",DirectionId=2, SoftDeleted = false }

                );

            modelBuilder.Entity<Review>().HasData(
               new Review { Id = 1, Message= "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system.",CustomerId=1,SoftDeleted = false },
               new Review { Id = 2, Message = "I absolutely loved this product! It exceeded my expectations in every way. The quality is outstanding, and it arrived sooner than expected.", CustomerId = 2, SoftDeleted = false },
               new Review { Id = 3, Message = "Unfortunately, this item did not meet my expectations. The quality was subpar, and it didn't function as described. I'm quite disappointed with my purchase.", CustomerId = 3, SoftDeleted = false }



               );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1,FullName="Betty More", Image= "1.jpg",SoftDeleted=false },
                new Customer { Id = 2, FullName = "Andy Morgan", Image = "1.jpg", SoftDeleted = false },
                new Customer { Id = 3, FullName = "Sandra Black", Image = "1.jpg", SoftDeleted = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name="Decorations",SoftDeleted=false },
                new Category { Id = 2, Name = "Outfits", SoftDeleted = false },
                new Category { Id = 3, Name = "Candles", SoftDeleted = false },
                new Category { Id = 4, Name = "Toys", SoftDeleted = false }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product {Id=1,Name= "Holiday Candle",Description="Desc1",Price=35,CategoryId=3,SoftDeleted=false },
                new Product { Id = 2, Name = "Christmas Tree", Description = "Desc1", Price = 40, CategoryId = 1, SoftDeleted = false },
                new Product { Id = 3, Name = "Santa Claus Doll", Description = "Desc1", Price = 30, CategoryId = 4, SoftDeleted = false },
                new Product { Id = 4, Name = "Holiday Cap", Description = "Desc1", Price = 50, CategoryId = 2, SoftDeleted = false },
                new Product { Id = 5, Name = "Holiday Doll", Description = "Desc1", Price = 60, CategoryId = 4, SoftDeleted = false },
                new Product { Id = 6, Name = "Holiday Candle", Description = "Desc1", Price = 30, CategoryId = 3, SoftDeleted = false }
                );


            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage { Id = 1, Image = "1.jpg", IsMain = true, ProductId = 1, SoftDeleted = false },
                new ProductImage { Id = 2, Image = "2.jpg", IsMain = false, ProductId = 1, SoftDeleted = false },
                 new ProductImage { Id = 3, Image = "2.jpg", IsMain = true, ProductId = 2, SoftDeleted = false },
                new ProductImage { Id = 4, Image = "3.jpg", IsMain = false, ProductId = 2, SoftDeleted = false },
                new ProductImage { Id = 5, Image = "3.jpg", IsMain = true, ProductId = 3, SoftDeleted = false },
                new ProductImage { Id = 6, Image = "4.jpg", IsMain = false, ProductId = 3, SoftDeleted = false },
                 new ProductImage { Id = 7, Image = "4.jpg", IsMain = true, ProductId = 4, SoftDeleted = false },
                new ProductImage { Id = 8, Image = "5.jpg", IsMain = false, ProductId = 4, SoftDeleted = false },
                 new ProductImage { Id = 9, Image = "5.jpg", IsMain = true, ProductId = 5, SoftDeleted = false },
                new ProductImage { Id = 10, Image = "6.jpg", IsMain = false, ProductId = 5, SoftDeleted = false },
                 new ProductImage { Id = 11, Image = "6.jpg", IsMain = true, ProductId = 6, SoftDeleted = false },
                new ProductImage { Id = 12, Image = "2.jpg", IsMain = false, ProductId = 6, SoftDeleted = false }
                );

        }
    }
}

