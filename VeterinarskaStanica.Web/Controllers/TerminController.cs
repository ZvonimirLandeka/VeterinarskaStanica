using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinarskaStanica.BLL;
using VeterinarskaStanica.DAL.Repository;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.Web.Controllers
{
    public class TerminController : Controller
    {
        // GET: Termin
        public ActionResult Index()
        {
            VlasnikService VlasnikService = new VlasnikService();
            string KorisnickoIme = User.Identity.Name;
            var Vlasik = VlasnikService.GetIdByKorisnickoIme(KorisnickoIme);

            var TerminService = new TerminService();
            var Termini = TerminService.GetAllByVlasnikId(Vlasik.Id);
            return View(Termini);
        }

        // GET: Termin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Termin/Create
        public ActionResult Create(int id)
        {
            TerminService TerminService = new TerminService();
            ViewBag.IdVrstaTermina = new SelectList(TerminService.GetAllVrstaTermina(), "Id", "Naziv");
            ViewBag.IdZivotinje = id;
            return View();
        }

        // POST: Termin/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Datum,Iskaz,Napomena,Opis,VrstaTermina_Id")] Termin Termin, int IdZivotinje)
        {

            try
            {
                var IdVrstaTermina = int.Parse(Request.Form.GetValues("IdVrstaTermina")[0]);
                TerminService TerminService = new TerminService();
                Termin.VrstaTermina = TerminService.GetVrstaTerminaById(IdVrstaTermina);

                ZivotinjaService ZivotinjaService = new ZivotinjaService();
                Termin.Zivotinja= ZivotinjaService.GetById(IdZivotinje);
                
                TerminService.Add(Termin);
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
