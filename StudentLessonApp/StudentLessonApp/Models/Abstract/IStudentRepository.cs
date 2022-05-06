using StudentLessonApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Abstract
{
    interface IStudentRepository : IRepository<Student>
    {
        List<Student> GetWithDepartman();
        Student GetStudentWithCourses(int id);
    }
}
