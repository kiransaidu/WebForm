using Microsoft.AspNetCore.Mvc;
using WebForm.Models;

namespace WebForm.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
 {
 new Student { Id = 1, Name = "kiran", Class = "A", Age = 16, Address = "Hyd"},
 new Student { Id = 2, Name = "surya", Class = "B", Age = 16, Address = "Chennai"},
 new Student { Id = 3, Name = "varma", Class = "C", Age = 16, Address = "Banglore"},
 new Student { Id = 4, Name = "Sasi", Class = "D", Age = 17, Address = "Pune"},
 };
        public IActionResult Index()
        {
            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
