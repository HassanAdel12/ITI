using Day_5Bouns.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Day_5Bouns.Controllers
{
    public class StudentController : Controller
    {

        ContextDBSchool context = new ContextDBSchool();

        // GET: Student
        public ActionResult Index()
        {
            ViewData["CityID"] = new SelectList(context.Cities.ToList(), "ID", "Name");
            return View(context.Students.Include("City").ToList());
        }

        
        [HttpPost]
        public ActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Students.Add(st);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
            return PartialView("StudentListPV", context.Students.Include("City").ToList());
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
                }
                catch (Exception ex)
                {

                }
            }
            return PartialView("StudentListPV", context.Students.Include("City").ToList());
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Student st = context.Students.Where(s => s.ID == Id).FirstOrDefault();
            if(st != null)
            {
                context.Students.Remove(st);
                context.SaveChanges();
            }
            
            return PartialView("StudentListPV", context.Students.Include("City").ToList());

        }
    }
}