using Microsoft.EntityFrameworkCore;
using OnlineCoursesPlatform.Data;

namespace OnlineCoursesPlatform.Data
{
    public class OnlineCoursesDbContext : DbContext
    {
        public OnlineCoursesDbContext(DbContextOptions<OnlineCoursesDbContext> options)
            : base(options)
        {
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // primary keys
            modelBuilder.Entity<Instructor>()
                .HasKey(x => x.InstructorId);
            modelBuilder.Entity<Student>()
                .HasKey(x => x.StudentId);
            modelBuilder.Entity<Lesson>()
                .HasKey(x => x.LessonId);
            modelBuilder.Entity<Student>()
                .HasKey(x => x.StudentId);

            // foreign keys
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId);

            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Course)
                .WithMany(c => c.Lessons)
                .HasForeignKey(l => l.CourseId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);
        }

    }
}
