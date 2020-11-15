using System;
using Class6_2_refractured.Courses;
using Class6_2_refractured.Enums;
using Class6_2_refractured.Projects;

namespace Class6_2_refractured
{

    class Program
    {
        static void Main(string[] args)
        {
            var firstCourseOne = new FirstCourse("C#", true);
            var firstCourseTwo = new FirstCourse("JS", false);
            var secondCourseOne = new SecondCourse("HTML", studentGrade.Bad);
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
                secondCourseOne.Passed(secondCourseOne.Grade),
                secondCourseTwo.Passed(secondCourseTwo.Grade)
                );

            Console.ReadLine();
        }
    }
}
