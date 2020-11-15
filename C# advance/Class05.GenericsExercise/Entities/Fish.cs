using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public double Size { get; set; }

        
        public Fish( string color, double size, string name, string type, int age)
        {
            Color = color;
            Size = size;
            Name = name;
            Type = type;
            Age = age;
        }

        public override string PrintInfo()
        {
            return $"This fish has {Color} and weighs {Size} kg";
        }
    }
}
