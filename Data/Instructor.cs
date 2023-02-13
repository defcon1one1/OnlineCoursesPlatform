namespace OnlineCoursesPlatform.Data
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Course> Courses { get; set; }
    }
}