using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinarskaStanica.BLL;

namespace VeterinarskaStanica.Web.Controllers
{
    public class PasminaController : Controller
    {
        // GET: Pasmina
        [Authorize]
        public ActionResult Index()
        {
            PasminaZivotinjeService PasminaZivotinjeService = new PasminaZivotinjeService();
            var pasmine = PasminaZivotinjeService.GetAll();

            return View(pasmine);
        }

        // GET: Pasmina/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pasmina/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pasmina/Create
        [HttpPost]
        [Authorize]
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

        // GET: Pasmina/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pasmina/Edit/5
        [HttpPost]
        [Authorize]
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

        // GET: Pasmina/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pasmina/Delete/5
        [HttpPost]
        [Authorize]
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
