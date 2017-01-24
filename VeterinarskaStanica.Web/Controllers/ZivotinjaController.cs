using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeterinarskaStanica.Web.Controllers
{
    public class ZivotinjaController : Controller
    {
        // GET: Zivotinja
        public ActionResult Index()
        {
            return View();
        }

        // GET: Zivotinja/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Zivotinja/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zivotinja/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Zivotinja/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Zivotinja/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Zivotinja/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Zivotinja/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
