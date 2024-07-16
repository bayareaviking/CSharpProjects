using System;

namespace ClassesAndRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with C# Records";
            pluralsightCourse.Author = "Roland Guijt";

            var classroomCourse = new CourseRecord(
                "Working with C# Records",
                "Roland Guijt"
                );

            // classroomCourse.Name = "Another title"; // Record properties cannot be changed after it's constructed
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public record CourseRecord(string Name, string Author);
}
