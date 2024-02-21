using Day_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_3.Controllers
{
    public class EmployeeController : Controller
    {
        Model1 context = new Model1();
        // GET: Employee
        public ActionResult Index()
        {
            return View(context.Employees.Include("Department").ToList());
        }

        public ActionResult Create()
        {
            ViewData["DeptNo"] = new SelectList(context.Departments.ToList(), "DeptNo", "DeptName");
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                context.Employees.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["DeptNo"] = new SelectList(context.Departments.ToList(), "DeptNo", "DeptName",emp.DeptNo);
            return View(emp);
        }


        public ActionResult Update(int Id)
        {
            Employee emp = context.Employees.Where(e => e.EmpNo == Id).FirstOrDefault();
            ViewData["DeptNo"] = new SelectList(context.Departments.ToList(), "DeptNo", "DeptName",emp.DeptNo);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Entry(employee).State = EntityState.Modified;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            ViewData["DeptNo"] = new SelectList(context.Departments.ToList(), "DeptNo", "DeptName", employee.DeptNo);
            return View(employee);

        }

        public ActionResult Remove(int Id)
        {
            Employee emp = context.Employees.Where(e => e.EmpNo == Id).FirstOrDefault();
            context.Employees.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}