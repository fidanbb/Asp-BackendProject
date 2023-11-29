﻿// <auto-generated />
using System;
using BackendProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231129123316_AddedProductCategoryProductImagesTableAndTheirSeededData")]
    partial class AddedProductCategoryProductImagesTableAndTheirSeededData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackendProject.Models.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirectionId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DirectionId");

                    b.ToTable("Adverts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7670),
                            Description = "<h1 class=\"white\"><span>Gifts</span>Christmas</h1>",
                            DirectionId = 1,
                            Image = "1.jpg",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7670),
                            Description = "<h2 class=\"black\"><span class=\"small\">Save <span class=\"red\">25%</span></span><span class=\"red\">Offer</span> Christmas</h2>",
                            DirectionId = 2,
                            Image = "2.jpg",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730),
                            Name = "Decorations",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730),
                            Name = "Outfits",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730),
                            Name = "Candles",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730),
                            Name = "Toys",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7700),
                            FullName = "Betty More",
                            Image = "1.jpg",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7710),
                            FullName = "Andy Morgan",
                            Image = "1.jpg",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7710),
                            FullName = "Sandra Black",
                            Image = "1.jpg",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Direction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "right"
                        },
                        new
                        {
                            Id = 2,
                            Name = "left"
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760),
                            Description = "Desc1",
                            Name = "Holiday Candle",
                            Price = 35m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760),
                            Description = "Desc1",
                            Name = "Christmas Tree",
                            Price = 35m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760),
                            Description = "Desc1",
                            Name = "Santa Claus Doll",
                            Price = 35m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770),
                            Description = "Desc1",
                            Name = "Holiday Cap",
                            Price = 35m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770),
                            Description = "Desc1",
                            Name = "Holiday Doll",
                            Price = 35m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770),
                            Description = "Desc1",
                            Name = "Holiday Candle",
                            Price = 35m,
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("BackendProject.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790),
                            Image = "01.jpg",
                            IsMain = true,
                            ProductId = 1,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790),
                            Image = "02.jpg",
                            IsMain = false,
                            ProductId = 1,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790),
                            Image = "02.jpg",
                            IsMain = true,
                            ProductId = 2,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800),
                            Image = "03.jpg",
                            IsMain = false,
                            ProductId = 2,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800),
                            Image = "03.jpg",
                            IsMain = true,
                            ProductId = 3,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800),
                            Image = "04.jpg",
                            IsMain = false,
                            ProductId = 3,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800),
                            Image = "04.jpg",
                            IsMain = true,
                            ProductId = 4,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810),
                            Image = "05.jpg",
                            IsMain = false,
                            ProductId = 4,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810),
                            Image = "05.jpg",
                            IsMain = true,
                            ProductId = 5,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810),
                            Image = "06.jpg",
                            IsMain = false,
                            ProductId = 5,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7820),
                            Image = "06.jpg",
                            IsMain = true,
                            ProductId = 6,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7820),
                            Image = "02.jpg",
                            IsMain = false,
                            ProductId = 6,
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7690),
                            CustomerId = 1,
                            Message = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system.",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7690),
                            CustomerId = 2,
                            Message = "I absolutely loved this product! It exceeded my expectations in every way. The quality is outstanding, and it arrived sooner than expected.",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7690),
                            CustomerId = 3,
                            Message = "Unfortunately, this item did not meet my expectations. The quality was subpar, and it didn't function as described. I'm quite disappointed with my purchase.",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7530),
                            Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which.",
                            Header = "Save 25%",
                            Image = "1.jpg",
                            SoftDeleted = false,
                            Title = "Christmas Sale"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7570),
                            Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which.",
                            Header = "Save 25%",
                            Image = "2.jpg",
                            SoftDeleted = false,
                            Title = "Christmas Sale"
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Subscribe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Subscribes");
                });

            modelBuilder.Entity("BackendProject.Models.Advert", b =>
                {
                    b.HasOne("BackendProject.Models.Direction", "Direction")
                        .WithMany("Adverts")
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");
                });

            modelBuilder.Entity("BackendProject.Models.Product", b =>
                {
                    b.HasOne("BackendProject.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BackendProject.Models.ProductImage", b =>
                {
                    b.HasOne("BackendProject.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BackendProject.Models.Review", b =>
                {
                    b.HasOne("BackendProject.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BackendProject.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BackendProject.Models.Customer", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BackendProject.Models.Direction", b =>
                {
                    b.Navigation("Adverts");
                });

            modelBuilder.Entity("BackendProject.Models.Product", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
