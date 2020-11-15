namespace Class6_2_refractured.Courses
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
}
