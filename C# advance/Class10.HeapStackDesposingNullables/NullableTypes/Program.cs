using System;

namespace NullableTypes
{

    public class Person
    {
        public int Id { get; set; }
        public int? Score { get; set; }
        public bool IsEmloyed { get; set; }
        public bool? HasPet { get; set; }
        public string Name { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            Console.WriteLine(person.Id);
            Console.WriteLine(person.Score);
            Console.WriteLine(person.HasPet);

            person.Score = null; //ova moze poradi ? gore
            //person.Id = null; //ova ne moze bidejki Id nema ? a Id koe e int nemoze da bide null tuku 0
            //person.IsEmloyed = null; // i ova ne moze radi istata pricina
            person.Name = null; // stringot e nullabel bydefault

            person = null; // moze i kaj objektite da se zadade null bidejki se nullable tipovi



            Console.ReadLine();
        }
    }
}
