using Class6_2_refractured.Enums;

namespace Class6_2_refractured.Courses
{
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
}
