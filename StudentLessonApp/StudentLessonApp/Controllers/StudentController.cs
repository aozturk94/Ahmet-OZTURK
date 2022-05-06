using Microsoft.AspNetCore.Mvc;
using StudentLessonApp.Models;
using StudentLessonApp.Models.Concrete;
using StudentLessonApp.Models.Concrete.DAL;
using StudentLessonApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLessonApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new StudentDAL();
            return View(student.GetWithDepartman());
        }

        public IActionResult AssignLesson(int id)
        {
            var model2 = new LessonDAL();
            var context = new StudentDAL();
            var entity = context.GetStudentWithCourses(id);
            var model = new StudentModel()
            {
                StudentId = entity.StudentId,
                No = entity.No,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateOfBirth = entity.BirthDate,
                DateOfRegistration = entity.EnrollDate,
                Period = entity.Semester,
                DepartmentId = entity.DepartmentId,
                SelectedLessons = entity.StudentLessons.Select(x => x.Lesson).ToList()
            };
            ViewBag.Lessons = model2.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult AssignLesson(int id, Student student)
        {
            var updateStudent = new StudentDAL();
            updateStudent.Update(student);
            return RedirectToAction("AssignLesson");

            //https://www.youtube.com/watch?v=1A3J3thVAvE&ab_channel=Sad%C4%B1kTuran
        }
    }
}
