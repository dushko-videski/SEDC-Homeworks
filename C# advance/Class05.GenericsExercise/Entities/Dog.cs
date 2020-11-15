using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavouriteFood { get; set; }

        public Dog()
        {

        }
        public Dog(bool goodBoi, string favFood)
        {
            GoodBoi = goodBoi;
            FavouriteFood = favFood;
        }

        public override string PrintInfo()
        {
            return $"This dog's favourite food is {FavouriteFood}";
        }
    }
}
