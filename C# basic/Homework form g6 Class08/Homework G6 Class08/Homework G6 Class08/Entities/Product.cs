using Homework_G_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_G_6.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ID { get; set; }
        public Category Category { get; set; }
    }
}
