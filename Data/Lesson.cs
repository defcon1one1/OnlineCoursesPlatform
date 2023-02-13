namespace OnlineCoursesPlatform.Data
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

}
