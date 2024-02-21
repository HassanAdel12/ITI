using Day_5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Day_5.Controllers
{
    public class CityController : Controller
    {
        WorldDBContext context = new WorldDBContext();
        // GET: City
        public ActionResult Index()
        {
            return View(context.Cities.OrderByDescending(c => c.ID).Take(10).ToList());
        }

        public ActionResult Create()
        {
            ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name");
            return View(new City());
        }

        [HttpPost]
        public ActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Cities.Add(city);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name");
                    return View(city);
                }

            }
            ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name");
            return View(city);
        }

        public ActionResult Edit(int id)
        {
            
            City city = context.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name",city.CountryCode);
            return View(city);
        }


        [HttpPost]
        public ActionResult Edit(City city)
        {
            

            if (ModelState.IsValid)
            {
                try
                {
                    context.Entry(city).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name", city.CountryCode);
                    return View(city);
                }
                
            }

            ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name", city.CountryCode);
            return View(city);
        }


        public ActionResult Delete(int id)
        {
            
            City city = context.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            context.Cities.Remove(city);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}