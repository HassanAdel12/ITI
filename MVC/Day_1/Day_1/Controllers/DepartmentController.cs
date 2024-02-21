using Day_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day_1.Models;

namespace Day_1.Controllers
{
    public class DepartmentController : Controller
    {
        public JsonResult All()
        {
            return Json(DataModel.Deparments, JsonRequestBehavior.AllowGet);
        }

        public RedirectToRouteResult Add(int Id, string Name)
        {
            DataModel.Deparments.Add(new Deparment() { Id = Id, Name = Name });
            return RedirectToAction("All");
        }

        public RedirectToRouteResult Update(int Id, string Name)
        {
            Deparment De = DataModel.Deparments.Where(d => d.Id == Id).First();
            De.Name = Name;
            return RedirectToAction("All");
        }

        public RedirectToRouteResult Remove(int Id)
        {
            Deparment De = DataModel.Deparments.Where(d => d.Id == Id).First();
            DataModel.Deparments.Remove(De);
            return RedirectToAction("All");
        }
    }
}