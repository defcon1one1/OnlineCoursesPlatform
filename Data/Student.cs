namespace OnlineCoursesPlatform.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Course> Courses { get; set; }
    }
}