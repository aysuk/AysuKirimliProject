using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AysuProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AysuProject.Controllers
{
    public class StudentsController : Controller
    {
        StuContext StuContext;

        public StudentsController(StuContext context)
        {
            StuContext = context;
        }

        public IActionResult Index()
        {
            var students = StuContext.Students.ToList();
            return View(students);
        }

        public IActionResult Detail(int id)
        {
            Student student = StuContext.Students.Where(stu => stu.Id == id).FirstOrDefault();

            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
