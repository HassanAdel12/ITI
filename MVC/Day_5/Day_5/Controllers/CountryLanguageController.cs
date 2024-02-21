using Day_5.Models;
using Day_5.ViweModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_5.Controllers
{
    public class CountryLanguageController : Controller
    {
        WorldDBContext context = new WorldDBContext();

        // GET: CountryLanguage
        public ActionResult Index()
        {
            return View(context.CountryLanguages.OrderByDescending(c => c.Language).Take(10).ToList());
        }

        public ActionResult Create()
        {
            ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name");
            return View(new CountryLanguageModel());
        }

        [HttpPost]
        public ActionResult Create(CountryLanguageModel countryLanguageModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CountryLanguage countryLanguage = new CountryLanguage()
                    {
                        Language = countryLanguageModel.Language,
                        IsOfficial = countryLanguageModel.IsOfficial,
                        Percentage = countryLanguageModel.Percentage,
                        CountryCode = countryLanguageModel.CountryCode,
                    };
                    context.CountryLanguages.Add(countryLanguage);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name");
                    return View(countryLanguageModel);
                }

            }
            ViewData["CountryCode"] = new SelectList(context.Countries.Take(50).ToList(), "Code", "Name");
            return View(countryLanguageModel);
        }

        public ActionResult Edit(string id,string id2)
        {

            CountryLanguage countryLanguage  = context.CountryLanguages.Where(c => (c.Language == id) && (c.CountryCode == id2)).FirstOrDefault();
            if (countryLanguage == null)
            {
                return HttpNotFound();
            }
            CountryLanguageModel countryLanguageModel = new CountryLanguageModel()
            {
                Language = countryLanguage.Language,
                IsOfficial = countryLanguage.IsOfficial,
                Percentage = countryLanguage.Percentage,
                CountryCode = countryLanguage.CountryCode,
            };
            return View(countryLanguageModel);
        }


        [HttpPost]
        public ActionResult Edit(CountryLanguageModel countryLanguageModel)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    CountryLanguage countryLanguage = new CountryLanguage()
                    {
                        Language = countryLanguageModel.Language,
                        IsOfficial = countryLanguageModel.IsOfficial,
                        Percentage = countryLanguageModel.Percentage,
                        CountryCode = countryLanguageModel.CountryCode,
                    };
                    context.Entry(countryLanguage).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(countryLanguageModel);
                }

            }

            return View(countryLanguageModel);
        }


        public ActionResult Delete(string id,string id2)
        {

            CountryLanguage countryLanguage = context.CountryLanguages.Where(c => (c.Language == id) && (c.CountryCode == id2)).FirstOrDefault();
            if (countryLanguage == null)
            {
                return HttpNotFound();
            }
            context.CountryLanguages.Remove(countryLanguage);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {

            countryCountLanguages countryCountLanguages = new countryCountLanguages()
            {
                CountryName = context.Countries.Find(id).Name,
                LanguagesIsOfficial = context.CountryLanguages.Where(c => (c.CountryCode == id) && (c.IsOfficial == true)).Count(),
                LanguagesIsNotOfficial = context.CountryLanguages.Where(c => (c.CountryCode == id) && (c.IsOfficial == false)).Count()
            };
            return View(countryCountLanguages);
        }
    }
}