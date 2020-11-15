using Homework_G_6.Entities;
using Homework_G_6.Enums;
using Homework_G_6.Helpers;
using System;
using System.Collections.Generic;


namespace Homework_G_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product() { ID = 1, Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { ID = 2, Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { ID = 3, Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { ID = 4, Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { ID = 5, Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { ID = 6, Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { ID = 7, Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { ID = 8, Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { ID = 9, Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { ID = 10, Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { ID = 11, Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { ID = 12, Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { ID = 13, Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { ID = 14, Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { ID = 15, Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { ID = 16, Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { ID = 17, Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { ID = 18, Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { ID = 19, Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { ID = 20, Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { ID = 21, Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
            };

            Methods.productsByCategory(products, Category.ItEquipment);
            Console.WriteLine();
            Methods.productsByPriceRange(products, 200, 2000);
            Console.WriteLine();
            Methods.productsByPartOfName(products, "hp");
            Console.WriteLine();
            Methods.retunrIds(products);
            Console.WriteLine();
            Methods.getProductPrice(products, 12);
            Console.WriteLine();
            Methods.getCheapestproduct(products);
            Console.WriteLine();
            Methods.getMostExpensiveProduct(products);
            Console.WriteLine();
            Methods.addProduct(products, 64565, "iPhone", 700, Category.ItEquipment);
            Console.WriteLine();
            Methods.removeProduct(products, 5);

            Console.ReadLine();

        }
    }
}
