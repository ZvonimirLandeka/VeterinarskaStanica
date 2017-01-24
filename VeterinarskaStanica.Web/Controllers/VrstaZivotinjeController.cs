using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.Model;
using NHibernate;

using VeterinarskaStanica.DAL.Repository;

namespace VeterinarskaStanica.Web.Controllers
{
    public class VrstaZivotinjeController : Controller
    {
        // GET: VrstaZivotinje
        public ActionResult Index()
        {
            ISession session = NHibernateHelper.OpenSession();
            ZivotinjaRepository rep = new ZivotinjaRepository(session);
            var vrsteZivotinja = rep.GetAllVrstaZivotinje();
            return View(vrsteZivotinja);
        }

        // GET: VrstaZivotinje/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VrstaZivotinje/Create
        public ActionResult Create()
        {
            var newVrstaZivotinje = new VrstaZivotinje();

            return View(newVrstaZivotinje);
        }

        // POST: VrstaZivotinje/Create
        [HttpPost]
        public ActionResult Create(VrstaZivotinje vrstaZivotinje)
        {
            try
            {
                ISession session = NHibernateHelper.OpenSession();
                ZivotinjaRepository repo = new ZivotinjaRepository(session);
                using(var transaction = session.BeginTransaction())
                {
                    repo.AddVrstaZivotinje(vrstaZivotinje);
                    transaction.Commit();
                }

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
