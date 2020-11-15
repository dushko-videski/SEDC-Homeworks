using Homework.Class4.DataBase;
using Homework.Class4.Models.DataTransferModels;
using Homework.Class4.Models.Domain;
using Homework.Class4.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework.Class4.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {

            ViewBag.Error = error;

            return View();
        }
        //============================================

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductVM createProductVM)
        {

            Product newProduct = new Product()
            {
                Id = DB.Products.Count + 1,
                Category = createProductVM.Category,
                Name = createProductVM.Name,
                Description = createProductVM.Description,
                Price = createProductVM.Price
            };

            if (newProduct.Name == null ||
                    newProduct.Price == 0 ||
                    newProduct.Description == null ||
                    newProduct == null ||
                    newProduct.Category == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "The Product was NOT created successfully!!! Please try again!" });
            }
            else
            {
                DB.Products.Add(newProduct);
                return RedirectToAction("Index", "Home", new { message = "Product created successfully and added to the Data Base!" });
            }
        }

        //==================Product-Stats=======================

        [HttpGet("Product-Stats")]
        public IActionResult ProductStats()
        {
            List<ProductDto> listOfProductDto = new List<ProductDto>();

            foreach (Product product in DB.Products)
            {
                ProductDto productDto = new ProductDto()
                {
                    SerialNo = Convert.ToString($"{new Random().Next(1, 1000000)}_{product.Id}"),
                    Category = product.Category,
                    Description = product.Description,
                    Name = product.Name,
                    Price = product.Price
                };
                listOfProductDto.Add(productDto);
            }

            return Json(listOfProductDto);
        }

        //=====================Product Details===================
        [HttpGet]
        public IActionResult ProductDetails(int id)
        {
            ProductVM productVM = new ProductVM();
            List<ProductVM> listOfProductVM = new List<ProductVM>();

            foreach (Product product in DB.Products)
            {
                productVM = new ProductVM()
                {
                    Id = product.Id,
                    Category = product.Category,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price
                };
                listOfProductVM.Add(productVM);

            }

            ProductVM productVM1 = listOfProductVM.SingleOrDefault(pvm => pvm.Id == id);


            return View("_PartialProductItem", productVM1);
        }




    }
}
