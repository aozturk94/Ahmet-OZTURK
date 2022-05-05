using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public int No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentId { get; set; }
        public List<Department> Department { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrollDate { get; set; }
        public int Semester { get; set; }
        public List<StudentLesson> StudentLessons { get; set; }
    }
}
