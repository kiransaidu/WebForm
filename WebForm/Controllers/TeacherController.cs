using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebForm.Models;

namespace WebForm.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teacher = new List<Teacher>()
 {
 new Teacher { Id = 1, Name = "chaitanya", TeachingSubject = "ComputerScience"},
 new Teacher { Id = 2, Name = "Sasi", TeachingSubject = "DataScience"},
 new Teacher { Id = 3, Name = "Teja", TeachingSubject = "Dbms"},
 new Teacher { Id = 4, Name = "Phani", TeachingSubject = "dotnet"},
 };
        public IActionResult Index()
        {
            return View(teacher);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }
        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }

            else
            {
                return View(model);
            }
        }
    }
}
