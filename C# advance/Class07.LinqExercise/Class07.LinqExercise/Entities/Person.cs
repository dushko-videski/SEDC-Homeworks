using System;
using System.Collections.Generic;
using System.Text;
using Class07.LinqExercise.Enums;

namespace Class07.LinqExercise.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }
    }
}
