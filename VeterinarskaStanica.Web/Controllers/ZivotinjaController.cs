using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinarskaStanica.BLL;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.DAL.Repository;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.Web.Controllers
{
    public class ZivotinjaController : Controller
    {
        // GET: Zivotinja
        public ActionResult Index()
        {
            var service = new ZivotinjaService();
            var zivotinje = service.GetAll();
            return View(zivotinje);
        }

        // GET: Zivotinja/Details/5
        public ActionResult Details(int id)
        {
            var service = new ZivotinjaService();
            var zivotinja = service.GetById(id);
            return View(zivotinja);
        }

        // GET: Zivotinja/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zivotinja/Create
        [HttpPost]
        public ActionResult Create(Zivotinja Zivotinja)
        {
            try
            {
                var service = new ZivotinjaService();
                var zivotinje = service.Add(Zivotinja);
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
                var service = new ZivotinjaService();
                var zivotinje = service.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
