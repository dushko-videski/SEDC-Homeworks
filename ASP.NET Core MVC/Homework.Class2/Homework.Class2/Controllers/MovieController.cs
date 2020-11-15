using Microsoft.AspNetCore.Mvc;
using System;


//Create Movie controller that will have two actions.The first action should have a parameter of type DateTime and the second should have the parameter of type Boolean.The action end points should be available at urls:
/// homework / movie / get - movies / 2019 - 05 - 03
/// homework / movie / get - available / true


namespace Homework.Class2.Controllers
{
    [Route("homework/movie")]
    public class MovieController : Controller
    {
        [HttpGet("get-movies/{date}")]
        public IActionResult GetDate(DateTime date)
        {
            var movie = new
            {
                Date = date.ToString("yyyy-MM-dd"),
                IsAvailabel = true
            };

            return Json(movie);
        }

        [HttpGet("get-available/{available}")]
        public IActionResult IsAvailable(bool available)
        {
            var movie = new
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd"),
                IsAvailabel = available
            };

            return Json(movie);
        }



    }
}
