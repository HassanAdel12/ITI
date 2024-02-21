using Day_7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Day_7.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext context;

        public StudentController([FromServices] SchoolDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View(context.Students.Include("City").ToList());
        }

        public IActionResult Create()
        {
            ViewBag.CityId = new SelectList(context.Cities.ToList(), "Id", "Name");
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewBag.CityId = new SelectList(context.Cities.ToList(), "Id", "Name");
                    return View(student);
                }

            }
            ViewBag.CityId = new SelectList(context.Cities.ToList(), "Id", "Name");
            return View(student);
        }

        public IActionResult Edit(int id)
        {

            Student student = context.Students.Find(id);
            if (student == null)
            {
                return View("Error","Error in Data");
            }
            ViewBag.CityId = new SelectList(context.Cities.ToList(), "Id", "Name",student.CityId);
            return View(student);
        }


        [HttpPost]
        public ActionResult Edit(Student student)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    context.Entry(student).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewBag.CityId = new SelectList(context.Cities.ToList(), "Id", "Name", student.CityId);
                    return View(student);
                }

            }

            ViewBag.CityId = new SelectList(context.Cities.ToList(), "Id", "Name", student.CityId);
            return View(student);
        }


        public ActionResult Delete(int id)
        {

            Student student = context.Students.Find(id);
            if (student == null)
            {
                return View("Error", "Error in Data");
            }
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
