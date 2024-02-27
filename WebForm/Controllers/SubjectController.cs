using Microsoft.AspNetCore.Mvc;
using WebForm.Models;

namespace WebForm.Controllers
{
    public class SubjectController : Controller
    {
        List<Subject> subject = new List<Subject>()
 {
 new Subject { Id = 1, Name = "ComputerScience"},
 new Subject {Id = 2, Name = "Dbms"},
 new Subject {Id = 3, Name = "dotnet"},
 new Subject {Id = 4, Name = "DataScience"},
 };

        public IActionResult Index()
        {
            return View(subject);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject());
        }
        [HttpPost]
        public IActionResult Create(Subject model)
        {
            if (ModelState.IsValid)
            {
                subject.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
    }
}
