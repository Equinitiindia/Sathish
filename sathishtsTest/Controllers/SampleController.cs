using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sathishtsTest.Models;

namespace sathishtsTest.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        static ValuesController v = new ValuesController();
        public ActionResult Index()
        {
            var model = v.Get();
            return View(model);
        }

        // GET: Sample/Details/5
        public ActionResult Details(string id)
        {
            var model = v.Get(id);
            return View(model);
        }

        // GET: Sample/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sample/Create
        [HttpPost]
        public ActionResult Create(SampleDataModel model)
        {
            try
            {
                v.Post(model);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Edit/5
        public ActionResult Edit(string id)
        {
            var model = v.Get(id);
            return View(model);
        }

        // POST: Sample/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, SampleDataModel collection)
        {
            try
            {
                // TODO: Add update logic here
                var model = v.Get(id);
                model._Amount = collection._Amount;
                model._ApplicationId = collection._ApplicationId;
                model._ClearedDate = collection._ClearedDate;
                model._IsCleared = collection._IsCleared;
                model._PostingDate = collection._PostingDate;
                model._Summary = collection._Summary;
                model._Type = collection._Type;
                v.Put(id, model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Delete/5
        public ActionResult Delete(string id)
        {
            var model = v.Get(id);

            return View(model);
        }

        // POST: Sample/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, SampleDataModel collection)
        {
            try
            {
                v.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
