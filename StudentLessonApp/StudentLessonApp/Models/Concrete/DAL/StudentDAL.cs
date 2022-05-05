using Microsoft.EntityFrameworkCore;
using StudentLessonApp.Models.Abstract;
using StudentLessonApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Concrete.DAL
{
    public class StudentDAL : BaseRepository<Student>, IStudentRepository
    {
        public List<Student> GetWithDepartman()
        {
            using (var _context = new StudentLessonAppDbContext())
            {
                return _context.Students.Include(s => s.Department).ToList();
            }
        }


    }
}
