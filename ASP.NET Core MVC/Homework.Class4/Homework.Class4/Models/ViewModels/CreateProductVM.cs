using Homework.Class4.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Homework.Class4.Models.ViewModels
{
    public class CreateProductVM
    {
        [Display(Name = "Name of product:")]
        public string Name { get; set; }


        [Display(Name = "Price in US $:")]
        public double Price { get; set; }


        public string Description { get; set; }


        public ProductCategory Category { get; set; }
    }
}
