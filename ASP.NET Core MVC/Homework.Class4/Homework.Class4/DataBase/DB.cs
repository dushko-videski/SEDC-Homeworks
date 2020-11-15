using Homework.Class4.Models.Domain;
using Homework.Class4.Models.Enums;
using System.Collections.Generic;

namespace Homework.Class4.DataBase
{
    public static class DB
    {
        public static List<Product> Products;

        static DB()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                     Id = 1,
                     Category = ProductCategory.Books,
                     Name = "Harry Poter",
                     Description = "Fiction childs book",
                     Price = 50.00
                },
                new Product()
                {
                    Id = 2,
                    Category = ProductCategory.Electronics,
                    Name = "Led TV",
                    Description = "Sony Led TV",
                    Price = 500.00
                },
                new Product()
                {
                    Id = 3,
                    Category = ProductCategory.Food,
                    Name = "Pizza",
                    Description = "Peperoni Pizza",
                    Price = 20.00
                },
                new Product()
                {
                    Id = 4,
                    Category = ProductCategory.Food,
                    Name = "Gyrro",
                    Description = "Pork Meet Gery with Tsaltsiki",
                    Price = 4.00
                },
                new Product()
                {
                    Id = 5,
                    Category = ProductCategory.Food,
                    Name = "Burger",
                    Description = "Angus Beef Burger",
                    Price = 10.00
                },
                new Product()
                {
                    Id= 6,
                    Category = ProductCategory.Furniture,
                    Name = "Arm Chair",
                    Description = "LazyBoy Arm Chair",
                    Price = 500.00
                },
                new Product()
                {
                    Id = 7,
                    Category = ProductCategory.Kids,
                    Name = "Toys",
                    Description = "Army soliders set",
                    Price = 40.00
                },
                new Product()
                {
                    Id = 8,
                    Category = ProductCategory.Electronics,
                    Name = "Stereo System",
                    Description = "Pionner Stereo System",
                    Price = 250.00
                },
                new Product()
                {
                    Id= 9,
                    Category = ProductCategory.Furniture,
                    Name = "Coffe table",
                    Description = "Wooden coffe table",
                    Price = 300.00
                },
            };
        }
    }
}
