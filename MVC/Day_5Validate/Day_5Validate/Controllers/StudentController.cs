using Day_5Validate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_5Validate.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        [AllowAnonymous]
        // GET: Student
        public ActionResult Index()
        {
            return View(context.Students.ToList());
        }

        [Authorize]
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(st);
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(st);
                }

            }
            return View(st);
        }

        [Authorize]

        public ActionResult Edit(int Id)
        {
            Student st = context.Students.Find(Id);
            return View(st);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Entry(student).State = EntityState.Modified;

                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(student);
                }

            }

            return View(student);

        }


        [Authorize(Roles = "Admin")]

        public ActionResult Delete(int Id)
        {
            Student st = context.Students.Find(Id);
            context.Students.Remove(st);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}