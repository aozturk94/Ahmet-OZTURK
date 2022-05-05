using System.Collections.Generic;

namespace StudentLessonApp.Models.Entity
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Departman { get; set; }
        public string HeadOfDepartment { get; set; }
        public int StudentId { get; set; }
        public List<Student> Student { get; set; }
    }
}
