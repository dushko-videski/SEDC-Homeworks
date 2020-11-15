using Microsoft.AspNetCore.Mvc;

//Bonus
//Create Order controller that will be able to create an order.After creating the order the user should be redirected to the / Home route.
//Bonus: Action end points should be available at: / pizza / order / create - order /

namespace Homework.Class2.Controllers
{
    [Route("pizza/order")]
    public class OrderController : Controller
    {


        [HttpGet("create-order")]
        public IActionResult CreateOrder()
        {
            return View();
        }


        [HttpPost("create-order")]
        public IActionResult CreateOrder(OrderModel orderModel)
        {

            return RedirectToAction("Index", "Home");

        }
    }
}
