using Homework_G_6.Entities;
using Homework_G_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_G_6.Helpers
{
    public static class Methods
    {
        //1.Search products by category // return all products from given category
        public static void productsByCategory(List<Product> products, Category category)
        {
            foreach (var product in products)
            {
                if (product.Category == category)
                {
                    Console.Write($"{product.Name} ");
                }
            }
        }
        //2.Filter products by price range (from min to max) // return all products that fall in the given price range
        public static void productsByPriceRange(List<Product> products, int min, int max)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Price >= min && product.Price <= max)
                {
                    filteredProducts.Add(product);
                    Console.Write($"{product.Name} ");
                }
            }
            if (filteredProducts.Count == 0)
            {
                Console.Write("No products in that price range!");
            }
        }
        //3.Find products by part of name // get all products that consist the part in their names
        public static void productsByPartOfName(List<Product> products, string partOfName)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(partOfName))
                {
                    filteredProducts.Add(product);
                    Console.Write($"{product.Name} ");
                }
            }
            if (filteredProducts.Count == 0)
            {
                Console.Write("No such product contains that part in its name!");
            }
        }
        //4.Get only products ids // return only the ids of the products
        public static void retunrIds(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.Write($"{product.ID} ");
            }
        }
        //5.Get product price // get the price of the product - give the id as parameter
        public static void getProductPrice(List<Product> products, int id)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.ID == id)
                {
                    filteredProducts.Add(product);
                    Console.Write($"{product.Price} ");
                }
            }
            if (filteredProducts.Count == 0)
            {
                Console.Write("No product with that id!");
            }
        }
        //6.Get cheapest product // return the cheapest product
        public static void getCheapestproduct(List<Product> products)
        {

            int min = products[0].Price;

            foreach (var product in products)
            {
                if (product.Price < min)
                {
                    min = product.Price;
                }
            }
            foreach (var product in products)
            {
                if (product.Price == min)
                {
                    Console.Write(product.Name);
                }
            }
        }
        //7.Get most expensive product // return the most expensive one
        public static void getMostExpensiveProduct(List<Product> products)
        {
            int max = 0;

            foreach (var product in products)
            {
                if (product.Price > max)
                {
                    max = product.Price;
                }
            }
            foreach (var product in products)
            {
                if (product.Price == max)
                {
                    Console.Write(product.Name);
                }
            }
        }
        //8.Add product // create method to add product to the list of products
        public static void addProduct(List<Product> products, int id, string name, int price, Category category)
        {
            List<int> ids = new List<int>();
            foreach (var product in products)
            {
                ids.Add(product.ID);
            }

            products.Add(new Product() { ID = id, Name = name, Price = price, Category = category });

            if (ids.Contains(products[products.Count - 1].ID))
            {
                products.Remove(products[products.Count - 1]);
                Console.WriteLine("ID number already exists! The product was not added!");
            }
            else
            {
                Console.WriteLine($"The added product is: {products[products.Count - 1].Name}");
            }
        }
        //9.Remove product // and a method to remove it - use id as parameter
        public static void removeProduct(List<Product> products, int id)
        {
            products.ForEach(product => Console.WriteLine(product.Name));
            Console.WriteLine("------------------------");
            for (int i = products.Count-1; i >= 0; i--)
            {
                if (products[i].ID == id)
                {
                    products.RemoveAt(i);
                }
            }
            products.ForEach(product => Console.WriteLine(product.Name));
        }
    }
}
