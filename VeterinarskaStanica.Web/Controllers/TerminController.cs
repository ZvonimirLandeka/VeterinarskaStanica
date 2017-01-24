using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeterinarskaStanica.Web.Controllers
{
    public class TerminController : Controller
    {
        // GET: Termin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Termin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Termin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Termin/Create
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

        // GET: Termin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Termin/Edit/5
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

        // GET: Termin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Termin/Delete/5
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
