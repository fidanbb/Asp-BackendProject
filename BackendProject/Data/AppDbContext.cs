using System;
using BackendProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
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
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Advert>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Customer>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Review>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Subscribe>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<BlogImage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Tag>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Team>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<About>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Brand>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Social>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<ContactMessage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<ContactInfo>().HasQueryFilter(m => !m.SoftDeleted);




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
               new Review { Id = 3, Message = "Unfortunately, this item did not meet my expectations. The quality was subpar, and it didn't function as described. I'm quite disappointed with my purchase.", CustomerId = 3, SoftDeleted = false },
               new Review { Id = 4, Message = "I am extremely satisfied with this product! It not only met but exceeded my expectations. The quality is top-notch, and it has made a significant improvement in my daily life.", CustomerId = 2, SoftDeleted = false },
               new Review { Id = 5, Message = "The product has some great features, but there are a few drawbacks. While it's user-friendly and stylish, the battery life could be better. Overall, it's a good purchase with some room for improvement.", CustomerId = 4, SoftDeleted = false },
               new Review { Id = 6, Message = "I regret buying this item. It didn't live up to the hype, and the build quality is disappointing. I encountered issues shortly after purchase, and customer support was not helpful. Would not recommend..", CustomerId = 5, SoftDeleted = false }


               );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1,FullName="Betty More", Image= "1.jpg",SoftDeleted=false },
                new Customer { Id = 2, FullName = "Andy Morgan", Image = "1.jpg", SoftDeleted = false },
                new Customer { Id = 3, FullName = "Sandra Black", Image = "1.jpg", SoftDeleted = false },
                   new Customer { Id = 4, FullName = "Mark White", Image = "1.jpg", SoftDeleted = false },
                new Customer { Id = 5, FullName = "Lucy Western", Image = "1.jpg", SoftDeleted = false }
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
            modelBuilder.Entity<Setting>().HasData(
                new Setting { Id=1,Key="HeaderLogo",Value= "logo.png",SoftDeleted=false },
                new Setting { Id = 2, Key = "FooterLogo", Value = "footer-logo.png", SoftDeleted = false },
                new Setting { Id = 3, Key = "Address", Value = "ur address goes here,street Crossroad 123", SoftDeleted = false },
                new Setting { Id = 4, Key = "Phone", Value = "+99 859 658 589 . +69 587 456 25", SoftDeleted = false },
                new Setting { Id = 5, Key = "Eax", Value = "+55 784 7585 . + 985 698 586", SoftDeleted = false },
                new Setting { Id = 6, Key = "Email", Value = "christ@email.com", SoftDeleted = false }
                );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id=1,Name="Bestsellers",SoftDeleted=false},
                new Tag { Id = 2, Name = "Gifts", SoftDeleted = false },
                new Tag { Id = 3, Name = "New", SoftDeleted = false },
                new Tag { Id = 4, Name = "Christmas Gift", SoftDeleted = false },
                new Tag { Id = 5, Name = "Festive Cakes", SoftDeleted = false },
                new Tag { Id = 6, Name = "Home Decor", SoftDeleted = false },
                new Tag { Id = 7, Name = "Toys", SoftDeleted = false }
                );
            modelBuilder.Entity<Blog>().HasData(
                new Blog {Id=1,
                    Title= "If you are going to use a passage latin at Hampdun.",
                    Description= "Contrary to popular belief, Lorem Ipsum is not simply random text. " +
                    "It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. " +
                    "Richard McClintock, a Latin professor at Hampden-Sydney Colleg Virginia, looked up one of the more obscure Latin words," +
                    " consectetur, from a Lorem Ipsum passage, and goingthrough the cites of the word in classical literature, discovered the " +
                    "undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" " +
                    "(The Extremes of Good and Evil) by Cicero, written in 45 BC. Thisbook is a treatise on the theory of ethics, very popular during the Renaissance. " +
                    "The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.",
                    CreatedDate = new DateTime(2017, 09, 05),
                    SoftDeleted =false },
                   new Blog
                   {
                       Id = 2,
                       Title = "If you are going to use a passage latin at Hampdun.",
                       Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. " +
                    "It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. " +
                    "Richard McClintock, a Latin professor at Hampden-Sydney Colleg Virginia, looked up one of the more obscure Latin words," +
                    " consectetur, from a Lorem Ipsum passage, and goingthrough the cites of the word in classical literature, discovered the " +
                    "undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" " +
                    "(The Extremes of Good and Evil) by Cicero, written in 45 BC. Thisbook is a treatise on the theory of ethics, very popular during the Renaissance. " +
                    "The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.",
                       CreatedDate = new DateTime(2020, 04, 04),
                       SoftDeleted = false
                   },
                      new Blog
                      {
                          Id = 3,
                          Title = "If you are going to use a passage latin at Hampdun.",
                          Description = "The standard chunk of Lorem Ipsum used since the " +
                          "1500s is reproduced below for those interested. Sections 1.10.32 " +
                          "and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also " +
                          "reproduced in their exact original form, accompanied by English versions " +
                          "from the 1914 translation by H. Rackham.",
                          CreatedDate = new DateTime(2018, 12, 10),
                          SoftDeleted = false
                      },
                       new Blog
                       {
                           Id = 4,
                           Title = "If you are going to use a passage latin at Hampdun.",
                           Description = "The standard chunk of Lorem Ipsum used since the " +
                          "1500s is reproduced below for those interested. Sections 1.10.32 " +
                          "and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also " +
                          "reproduced in their exact original form, accompanied by English versions " +
                          "from the 1914 translation by H. Rackham.",
                           CreatedDate = new DateTime(2023, 02, 15),
                           SoftDeleted = false
                       },
                        new Blog
                        {
                            Id = 5,
                            Title = "If you are going to use a passage latin at Hampdun.",
                            Description = "The standard chunk of Lorem Ipsum used since the " +
                          "1500s is reproduced below for those interested. Sections 1.10.32 " +
                          "and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also " +
                          "reproduced in their exact original form, accompanied by English versions " +
                          "from the 1914 translation by H. Rackham.",
                            CreatedDate = new DateTime(2022, 11, 11),
                            SoftDeleted = false
                        },
                         new Blog
                         {
                             Id = 6,
                             Title = "If you are going to use a passage latin at Hampdun.",
                             Description = "The standard chunk of Lorem Ipsum used since the " +
                          "1500s is reproduced below for those interested. Sections 1.10.32 " +
                          "and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also " +
                          "reproduced in their exact original form, accompanied by English versions " +
                          "from the 1914 translation by H. Rackham.",
                             CreatedDate = new DateTime(2021, 09, 10),
                             SoftDeleted = false
                         },
                          new Blog
                          {
                              Id = 7,
                              Title = "If you are going to use a passage latin at Hampdun.",
                              Description = "The standard chunk of Lorem Ipsum used since the " +
                          "1500s is reproduced below for those interested. Sections 1.10.32 " +
                          "and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also " +
                          "reproduced in their exact original form, accompanied by English versions " +
                          "from the 1914 translation by H. Rackham.",
                              CreatedDate = new DateTime(2019, 11, 11),
                              SoftDeleted = false
                          },
                         new Blog
                         {
                             Id = 8,
                             Title = "If you are going to use a passage latin at Hampdun.",
                             Description = "The standard chunk of Lorem Ipsum used since the " +
                          "1500s is reproduced below for those interested. Sections 1.10.32 " +
                          "and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also " +
                          "reproduced in their exact original form, accompanied by English versions " +
                          "from the 1914 translation by H. Rackham.",
                             CreatedDate = new DateTime(2017, 10, 20),
                             SoftDeleted = false
                         }

                );

            modelBuilder.Entity<BlogImage>().HasData(

                new BlogImage { Id =  1,Image= "1.jpg", BlogId=1,IsMain=true,SoftDeleted=false},
                new BlogImage { Id = 2, Image = "2.jpg", BlogId = 1, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 3, Image = "3.jpg", BlogId = 1, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 4, Image = "2.jpg", BlogId = 2, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 5, Image = "1.jpg", BlogId = 2, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 6, Image = "3.jpg", BlogId = 2, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 7, Image = "3.jpg", BlogId = 3, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 8, Image = "1.jpg", BlogId = 3, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 9, Image = "2.jpg", BlogId = 3, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 10, Image = "1.jpg", BlogId = 4,IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 11, Image = "2.jpg", BlogId = 4, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 12, Image = "3.jpg", BlogId = 4, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 13, Image = "2.jpg", BlogId = 5, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 14, Image = "1.jpg", BlogId = 5, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 15, Image = "3.jpg", BlogId = 5, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 16, Image = "3.jpg", BlogId = 6, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 17, Image = "1.jpg", BlogId = 6, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 18, Image = "2.jpg", BlogId = 6, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 19, Image = "2.jpg", BlogId = 7, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 20, Image = "1.jpg", BlogId = 7, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 21, Image = "3.jpg", BlogId = 7, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 22, Image = "3.jpg", BlogId = 8, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 23, Image = "1.jpg", BlogId = 8, IsMain = false, SoftDeleted = false },
                new BlogImage { Id = 24, Image = "2.jpg", BlogId = 8, IsMain = false, SoftDeleted = false }
                );


            modelBuilder.Entity<BlogTag>().HasData(
                new BlogTag { Id=1,BlogId=1,TagId=1},
                new BlogTag { Id = 2, BlogId = 1, TagId = 5 },
                new BlogTag { Id = 3, BlogId = 1, TagId = 6 },
                new BlogTag { Id = 4, BlogId = 1, TagId = 4 },
                new BlogTag { Id = 5, BlogId = 2, TagId = 1 },
                new BlogTag { Id = 6, BlogId = 2, TagId = 4 },
                new BlogTag { Id = 7, BlogId = 2, TagId = 3 },
                new BlogTag { Id = 8, BlogId = 2, TagId = 6 },
                new BlogTag { Id = 9, BlogId = 3, TagId = 1 },
                new BlogTag { Id = 10, BlogId = 3, TagId = 2 },
                new BlogTag { Id = 11, BlogId = 3, TagId = 5 },
                new BlogTag { Id = 12, BlogId = 3, TagId = 3 },
                new BlogTag { Id = 13, BlogId = 4, TagId = 1 },
                new BlogTag { Id = 14, BlogId = 4, TagId = 5 },
                new BlogTag { Id = 15, BlogId = 4, TagId = 6 },
                new BlogTag { Id = 16, BlogId = 5, TagId = 4 },
                new BlogTag { Id = 17, BlogId = 5, TagId = 1 },
                new BlogTag { Id = 18, BlogId = 5, TagId = 4 },
                new BlogTag { Id = 19, BlogId = 6, TagId = 3 },
                new BlogTag { Id = 20, BlogId = 6, TagId = 6 },
                new BlogTag { Id = 21, BlogId = 6, TagId = 1 },
                new BlogTag { Id = 22, BlogId = 7, TagId = 2 },
                new BlogTag { Id = 23, BlogId = 7, TagId = 5 },
                new BlogTag { Id = 24, BlogId = 7, TagId = 3 },
                new BlogTag { Id = 25, BlogId = 8, TagId = 6 },
                new BlogTag { Id = 26, BlogId = 8, TagId = 1 },
                new BlogTag { Id = 27, BlogId = 8, TagId = 2 },
                new BlogTag { Id = 28, BlogId = 8, TagId = 5 }

                );



            modelBuilder.Entity<Subscribe>().HasData(
                new Subscribe { Id=1,Email="fidanbb@gmail.com",SoftDeleted=false},
                new Subscribe { Id = 2, Email = "surac@gmail.com", SoftDeleted = false },
                new Subscribe { Id = 3, Email = "ismayil@gmail.com", SoftDeleted = false },
                new Subscribe { Id = 4, Email = "kubra@gmail.com", SoftDeleted = false }
                );


            modelBuilder.Entity<About>().HasData(
                new About {Id=1,Title= "<h2>About <span>Christ</span></h2>",
                    Description= "There are many variations of passages of Lorem Ipsum available, majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly kn je believable There are manations of passages of Lorem Ipsum available, but the majority ahave suffered ami tar cholnay vulbo na alte ration. majority have suffered alteration in",
                    Image="about.jpg",
                    VideoLink= "https://www.youtube.com/watch?v=7e90gBu4pas",
                    SoftDeleted=false }
                );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id=1,Image= "1.jpg", Position="Ceo",FullName="Terry Soto",SoftDeleted=false},
                new Team { Id = 2, Image = "2.jpg", Position = "Marketer", FullName = "Maria Lane", SoftDeleted = false },
                new Team { Id = 3, Image = "3.jpg", Position = "Developer", FullName = "Justin Evans", SoftDeleted = false },
                new Team { Id = 4, Image = "4.jpg", Position = "Designer", FullName = "Rose Dixon", SoftDeleted = false }
                );


            modelBuilder.Entity<Brand>().HasData(

                new Brand { Id=1,Image="1.png",SoftDeleted=false},
                new Brand { Id = 2, Image = "2.png", SoftDeleted = false },
                new Brand { Id = 3, Image = "3.png", SoftDeleted = false },
                new Brand { Id = 4, Image = "4.png", SoftDeleted = false },
                new Brand { Id = 5, Image = "5.png", SoftDeleted = false },
                new Brand { Id = 6, Image = "6.png", SoftDeleted = false }
                );

            modelBuilder.Entity<Social>().HasData(
                new Social { Id=1,Name= "fa fa-facebook", SoftDeleted=false},
                new Social { Id = 2, Name = "fa fa-twitter", SoftDeleted = false },
                new Social { Id = 3, Name = "fa fa-instagram", SoftDeleted = false },
                new Social { Id = 4, Name = "fa fa-pinterest-p", SoftDeleted = false },
                new Social { Id = 5, Name = "fa fa-linkedin", SoftDeleted = false }
                );

            modelBuilder.Entity<ContactInfo>().HasData(
                new ContactInfo {Id=1,Descriptiom= "It is a long established fact that readewill be distracted by the readable content of a page when looking at ilayout.", SoftDeleted=false }
                );

            modelBuilder.Entity<ContactMessage>().HasData(
                new ContactMessage { Id=1,Name="Fidan Bashirova",Email="fidanbb@gmaill",Message="Helllooo",SoftDeleted=false}
                );

        }
    }
}

    