using System;

namespace StackHeap
{
    public class Person
    {
        public int Id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 19;
            string text = "some text";
            bool isTrue = true;

            Person person = new Person() { Id = 1 };
            Person person1 = new Person() { Id = 1 };
            Console.WriteLine(person == person1);
            person.Id = 2;
            person.Id = 5;

            CreatePerson();

            //STACK
            //------
            // number = 19
            // text = some text
            // isTrue = true
            // person = 1212121546465465 --> place in memory 
            // person1 = 4654312685432516541 --> place in memory

            //HEAP
            //------
            // Person -- Id = 1
            // person1 -- Id = 1

            Console.ReadLine();
        }
        public static void CreatePerson()
        {
            var person = new Person();
            person.Id = 1;
        }



    }
}
