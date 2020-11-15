using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Entities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }


        public override string PrintInfo()
        {
            return $"This cat has {LivesLeft} left!";
        }
    }
}
