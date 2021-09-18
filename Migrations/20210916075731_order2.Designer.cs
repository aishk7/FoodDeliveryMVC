﻿// <auto-generated />
using System;
using FoodDeliveryMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodDeliveryMVC.Migrations
{
    [DbContext(typeof(FoodDBContext))]
    [Migration("20210916075731_order2")]
    partial class order2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodDeliveryMVC.Models.FoodCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 101,
                            CategoryName = "Maharashtrian"
                        },
                        new
                        {
                            CategoryId = 102,
                            CategoryName = "Punjabi"
                        },
                        new
                        {
                            CategoryId = 103,
                            CategoryName = "Italian"
                        },
                        new
                        {
                            CategoryId = 104,
                            CategoryName = "Thai"
                        });
                });

            modelBuilder.Entity("FoodDeliveryMVC.Models.FoodItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSpecial")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            CategoryId = 101,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = true,
                            ItemName = "Puran Poli",
                            Price = 50
                        },
                        new
                        {
                            ItemId = 2,
                            CategoryId = 101,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = false,
                            ItemName = "Masale Vange",
                            Price = 150
                        },
                        new
                        {
                            ItemId = 3,
                            CategoryId = 102,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = false,
                            ItemName = "Lachha Paratha",
                            Price = 50
                        },
                        new
                        {
                            ItemId = 4,
                            CategoryId = 102,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = true,
                            ItemName = "Paneer Makhani",
                            Price = 220
                        },
                        new
                        {
                            ItemId = 5,
                            CategoryId = 103,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = true,
                            ItemName = "Spaghetti Aglio E Olio",
                            Price = 150
                        },
                        new
                        {
                            ItemId = 6,
                            CategoryId = 103,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = false,
                            ItemName = "Bruschetta",
                            Price = 120
                        },
                        new
                        {
                            ItemId = 7,
                            CategoryId = 104,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = true,
                            ItemName = "Green Thai Curry",
                            Price = 250
                        },
                        new
                        {
                            ItemId = 8,
                            CategoryId = 104,
                            Details = "Made with love to satisfy your taste buds!",
                            ImgURL = "",
                            IsSpecial = false,
                            ItemName = "Pad Thai Noodles",
                            Price = 200
                        });
                });

            modelBuilder.Entity("FoodDeliveryMVC.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LandMark")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodDeliveryMVC.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ItemRef")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemid");

                    b.HasIndex("ItemId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("FoodDeliveryMVC.Models.FoodItem", b =>
                {
                    b.HasOne("FoodDeliveryMVC.Models.FoodCategory", "category")
                        .WithMany("FoodItems")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("FoodDeliveryMVC.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("FoodDeliveryMVC.Models.FoodItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("FoodDeliveryMVC.Models.FoodCategory", b =>
                {
                    b.Navigation("FoodItems");
                });
#pragma warning restore 612, 618
        }
    }
}
