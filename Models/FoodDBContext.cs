using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Models
{
    public class FoodDBContext : DbContext
    {
        public FoodDBContext(DbContextOptions<FoodDBContext> options) : base(options)
        {

        }
        public DbSet<FoodCategory> Categories { get; set; }
        public DbSet<FoodItem> Items { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory { CategoryId = 101, CategoryName = "Maharashtrian" },
                new FoodCategory { CategoryId = 102, CategoryName = "Punjabi" },
                new FoodCategory { CategoryId = 103, CategoryName = "Italian" },
                new FoodCategory { CategoryId = 104, CategoryName = "Thai" });
            
            modelBuilder.Entity<FoodItem>().HasData(
                new FoodItem
                {
                    ItemId = 1,
                    ItemName = "Puran Poli",
                    CategoryId = 101,
                    Price = 50,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = true
                },
                new FoodItem
                {
                    ItemId = 2,
                    ItemName = "Masale Vange",
                    CategoryId = 101,
                    Price = 150,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = false
                },
                new FoodItem
                {
                    ItemId = 3,
                    ItemName = "Lachha Paratha",
                    CategoryId = 102,
                    Price = 50,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = false
                },
                new FoodItem
                {
                    ItemId = 4,
                    ItemName = "Paneer Makhani",
                    CategoryId = 102,
                    Price = 220,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = true
                },
                new FoodItem
                {
                    ItemId = 5,
                    ItemName = "Spaghetti Aglio E Olio",
                    CategoryId = 103,
                    Price = 150,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = true
                },
                new FoodItem
                {
                    ItemId = 6,
                    ItemName = "Bruschetta",
                    CategoryId = 103,
                    Price = 120,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = false
                },
                new FoodItem
                {
                    ItemId = 7,
                    ItemName = "Green Thai Curry",
                    CategoryId = 104,
                    Price = 250,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = true
                },
                new FoodItem
                {
                    ItemId = 8,
                    ItemName = "Pad Thai Noodles",
                    CategoryId = 104,
                    Price = 200,
                    ImgURL = "",
                    Details = "Made with love to satisfy your taste buds!",
                    IsSpecial = false
                }
                );
        }
    }
}
