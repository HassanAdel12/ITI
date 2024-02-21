using Day_4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Day_4.Controllers
{
    public class StudentController : Controller
    {
        ContextSchool context = new ContextSchool();

        // GET: Student
        public ActionResult Index()
        {
            return View(context.Students.Include("City").ToList());
        }

        public ActionResult Create()
        {
            ViewData["CityID"] = new SelectList(context.Cities.ToList(), "ID", "Name");
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
                    TempData["Create"] = st.FullName;
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewData["CityID"] = new SelectList(context.Cities.ToList(), "ID", "Name");
                    return View(st);
                }
                
            }
            ViewData["CityID"] = new SelectList(context.Cities.ToList(), "ID", "Name");
            return View(st);
        }


        public ActionResult Edit(int Id)
        {
            Student st = context.Students.Where(s => s.ID == Id).FirstOrDefault();
            ViewData["CityID"] = new SelectList(context.Cities.ToList(), "ID", "Name", st.CityID);
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
                    TempData["Edit"] = student.FullName;
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewData["CityID"] = new SelectList(context.Cities.ToList(), "ID", "Name", student.CityID);
                    return View(student);
                }
                
            }

            ViewData["CityID"] = new SelectList(context.Cities.ToList(), "ID", "Name", student.CityID);
            return View(student);

        }

        public ActionResult Delete(int Id)
        {
            Student st = context.Students.Where(s => s.ID == Id).FirstOrDefault();
            context.Students.Remove(st);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}