using Class6_2_refractured.Courses;
using System;


namespace Class6_2_refractured.Projects
{
    public class Project
    {
        public FirstCourse first1;
        public FirstCourse first2;
        public SecondCourse second1;
        public SecondCourse second2;

        public void Passed(bool first, bool second, bool third, bool fourth)
        {
            bool[] courses = new bool[4] { first, second, third, fourth };
            int count = 0;
            foreach (var course in courses)
            {
                if (course)
                {
                    count++;
                }
            }
            if (count >= 3)
            {
                Console.WriteLine("Congratulatios! You passed the project!");
            }
            else
            {
                Console.WriteLine("Unfortunately, you failed the project!");
            }
        }
    }
}
