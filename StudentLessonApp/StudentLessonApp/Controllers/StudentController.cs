using Microsoft.AspNetCore.Mvc;
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
            var student = new Student();
            return View(student.GetAll());
        }
    }
}
