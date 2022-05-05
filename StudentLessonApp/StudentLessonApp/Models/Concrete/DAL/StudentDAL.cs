using StudentLessonApp.Models.Abstract;
using StudentLessonApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Models.Concrete.DAL
{
    public class StudentDAL : BaseRepository<Student>
    {
        public StudentDAL(StudentLessonAppDbContext context) : base(context)
        {

        }
        private StudentLessonAppDbContext Context
        {
            get { return _context as StudentLessonAppDbContext; }
        }
    }
}
