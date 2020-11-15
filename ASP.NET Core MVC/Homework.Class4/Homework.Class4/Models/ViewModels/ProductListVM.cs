using System.Collections.Generic;

namespace Homework.Class4.Models.ViewModels
{
    public class ProductListVM
    {
        public int TotalNumberOfProducts { get; set; }
        public List<ProductVM> Products { get; set; }
    }
}
