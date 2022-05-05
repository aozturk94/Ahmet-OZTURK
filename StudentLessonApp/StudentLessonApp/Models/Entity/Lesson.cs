using System.Collections.Generic;

namespace StudentLessonApp.Models.Entity
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string TeacherName { get; set; }
        public sbyte Credit { get; set; }
        public sbyte Semester { get; set; }
        public List<StudentLesson> StudentLessons { get; set; }
    }
}
