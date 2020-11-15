using System;

namespace Class6_2
{
    public class FirstCourse
    {
        public FirstCourse(string courseName, bool registration)
        {
            CourseName = courseName;
            Registration = registration;
        }
        public string CourseName;
        public bool Registration;

        //METHOD
        public bool Passed(bool registration)
        {
            if (registration)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }

    public class SecondCourse
    {
        public SecondCourse(string courseName, studentGrade grade)
        {
            CourseName = courseName;
            Grade = grade;
        }
        public string CourseName;
        public studentGrade Grade;

        //METHOD
        public bool Passed(studentGrade grade)
        {
            if ((int)grade > 5 && (int)grade <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

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

    public enum studentGrade
    {
        Fail = 5,
        Bad,
        Poor,
        Fair,
        Good,
        Excellent
    }


    class Program
    {
        static void Main(string[] args)
        {

            var firstCourseOne = new FirstCourse("C#", true);
            var firstCourseTwo = new FirstCourse("JS", true);
            var secondCourseOne = new SecondCourse("HTML", studentGrade.Fail);
            var secondCourseTwo = new SecondCourse("CSS", studentGrade.Excellent);
            var newProject = new Project()
            {
                first1 = firstCourseOne,
                first2 = firstCourseTwo,
                second1 = secondCourseOne,
                second2 = secondCourseTwo
            };

            newProject.Passed(
                firstCourseOne.Passed(firstCourseOne.Registration), 
                firstCourseTwo.Passed(firstCourseTwo.Registration), 
                secondCourseOne.Passed(studentGrade.Fail), 
                secondCourseTwo.Passed(studentGrade.Excellent)
                );

            Console.ReadLine();
        }
    }
}
