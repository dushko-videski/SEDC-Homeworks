using Homework.Class4.DataBase;
using Homework.Class4.Models;
using Homework.Class4.Models.Domain;
using Homework.Class4.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace Homework.Class4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string message)
        {
            List<ProductVM> listOfProductVM = new List<ProductVM>();

            ViewBag.Message = message;

            foreach (Product product in DB.Products)
            {
                ProductVM productVM = new ProductVM()
                {
                    Id = product.Id,
                    Category = product.Category,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price
                };
                listOfProductVM.Add(productVM);
            }

            ProductListVM productListVM = new ProductListVM()
            {
                TotalNumberOfProducts = DB.Products.Count,
                Products = listOfProductVM
            };

            return View("Index", productListVM);
        }
        //----------------------------------------------

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
