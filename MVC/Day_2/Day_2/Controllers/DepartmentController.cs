using Day_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace Day_2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department De)
        {
            DBContext.Deparments.Add(De);
            return RedirectToAction("Index");
        }


        public ActionResult Update(int Id)
        {
            ViewData["Update"] = DBContext.Deparments.Where(d => d.Id == Id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Update(Department De)
        {
            Department department = DBContext.Deparments.Where(d => d.Id == De.Id).FirstOrDefault();
            if (department != null)
            {
                department.Name = De.Name;
                department.Title = De.Title;
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
            
        }

        public ActionResult Remove(int Id)
        {
            Department De = DBContext.Deparments.Where(d => d.Id == Id).FirstOrDefault();
            DBContext.Deparments.Remove(De);
            return RedirectToAction("Index");
        }

        

    }
}