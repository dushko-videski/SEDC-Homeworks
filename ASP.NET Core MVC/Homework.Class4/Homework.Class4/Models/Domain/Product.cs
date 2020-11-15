using Homework.Class4.Models.Enums;

namespace Homework.Class4.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
    }
}
