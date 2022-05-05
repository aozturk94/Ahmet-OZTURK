using System.Collections.Generic;

namespace StudentLessonApp.Models.Entity
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string TeacherName { get; set; }
        public int Credit { get; set; }
        public int Semester { get; set; }
        public List<StudentLesson> StudentLessons { get; set; }
    }
}
