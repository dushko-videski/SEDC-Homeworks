using Homework.Class2.Models;
using Microsoft.AspNetCore.Mvc;

//Create Product controller that will have two action GetProductById(int id) and GetProductByName(string name).The action end points should be available at urls:
/// product / get - product / 3
/// product / get - product / shoes

namespace Homework.Class2.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [HttpGet("get-product/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = new ProductModel()
            {
                Id = id,
                Name = "Boots"
            };

            return View(product);
        }

        [HttpGet("get-product/{name:alpha}")]
        public IActionResult GetProductByName(string name)
        {
            var product = new
            {
                Id = 1,
                Name = name
            };

            return Json(product);
        }
    }
}
