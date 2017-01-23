using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinarskaStanica.DAL;
using NHibernate;

using VeterinarskaStanica.DAL.Repository;

namespace VeterinarskaStanica.Web.Controllers
{
    public class VrstaZivotinjeController : Controller
    {
        private ZivotinjaRepository rep;

        // GET: VrstaZivotinje
        public ActionResult Index()
        {
            ISession session = NHibernateHelper.OpenSession();
            ZivotinjaRepository rep = new ZivotinjaRepository(session);
            var lista = rep.GetAllVrstaZivotinje();
            return View("VrstaZivotinjeList", lista);
        }

        // GET: VrstaZivotinje/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VrstaZivotinje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VrstaZivotinje/Create
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

        // GET: VrstaZivotinje/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VrstaZivotinje/Edit/5
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

        // GET: VrstaZivotinje/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VrstaZivotinje/Delete/5
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
