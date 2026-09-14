using Microsoft.AspNetCore.Mvc;
using StudentInfoDemo.Models;

namespace StudentInfoDemo.Controllers
{
    public class StudentController : Controller
    {
        public readonly StudentInfoDbContext context;
        public StudentController(StudentInfoDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var student = context.Students.ToList();
            return View(student);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                var student = context.Students.FirstOrDefault(item => item.sid == id);
                if (student != null)
                {
                    return View(student);
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var studnet = context.Students.FirstOrDefault(item => item.sid == id);
                if (studnet != null)
                {
                    return View(studnet);
                }

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var studnet = context.Students.FirstOrDefault(item => item.sid == id);
                if (studnet != null)
                {
                    return View(studnet);
                }

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (student != null)
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        
    }
}
