using NHibernate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using VeterinarskaStanica.BLL;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.DAL.Repository;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Web.Models;

namespace VeterinarskaStanica.Web.Controllers
{
    public class ZivotinjaController : Controller
    {
        // GET: Zivotinja
        [Authorize]
        public ActionResult Index()
        {
            VlasnikService VlasnikService = new VlasnikService();
            string KorisnickoIme = User.Identity.Name;
            var Vlasik = VlasnikService.GetIdByKorisnickoIme(KorisnickoIme);


            var ZivotinjaService = new ZivotinjaService();
            var zivotinje = ZivotinjaService.GetAllByVlasnikId(Vlasik.Id);
            return View(zivotinje);
        }

        // GET: Zivotinja
        [Authorize]
        [HttpPost]
        public ActionResult GetPasmineByIdVrsta(int id)
        {
            var service = new ZivotinjaService();
            var pasmine = service.GetPasmineByIdVrsta(id);
                
            var json= Json(pasmine);
            return json;
        }
        
        // GET: Zivotinja/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            var service = new ZivotinjaService();
            var zivotinja = service.GetById(id);

            TerminService TerminService = new TerminService();
            ViewBag.Termini = TerminService.GetAllByIdZivotinja(zivotinja.Id);
            return View(zivotinja);
        }

        // GET: Zivotinja/Create
        [Authorize]
        public ActionResult Create()
        {

            ZivotinjaService zr = new ZivotinjaService();
            

            ViewBag.IdVrstaZivotinje = new SelectList(zr.GetAllVrstaZivotinje(), "Id", "Naziv");
            ViewBag.IdPasminaZivotinje = new SelectList(zr.GetAllPasminaZivotinjeByVrstaZivotinje(zr.GetAllVrstaZivotinje()[0]), "Id", "Naziv");
            ViewBag.Spol= new SelectList(Enum.GetValues(typeof(Spol)));
            return View();
        }

        // POST: Zivotinja/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create([Bind(Include = "Ime,Spol,DatumRodenja,DatumSmrti,Boja,BrojCipa,PolozajCipa,DatumCipiranja")] Zivotinja Zivotinja, HttpPostedFileBase file)
        {
            var service = new ZivotinjaService();
            VlasnikService VlasnikService = new VlasnikService();
            string KorisnickoIme = User.Identity.Name;
            var Vlasnik = VlasnikService.GetIdByKorisnickoIme(KorisnickoIme);
            Zivotinja.Vlasnik = Vlasnik;
            var IdVrstaZivotinje = int.Parse(Request.Form.GetValues("IdVrstaZivotinje")[0]);
            var IdPasminaZivotinje = int.Parse(Request.Form.GetValues("IdPasminaZivotinje")[0]);

            ZivotinjaService ZivotinjaService = new ZivotinjaService();
            Zivotinja.VrstaZivotinje = ZivotinjaService.GetVrstaZivotinjeById(IdVrstaZivotinje);
            Zivotinja.PasminaZivotinje = ZivotinjaService.GetPasminaZivotinjeById(IdPasminaZivotinje);
            var zivotinje = service.Add(Zivotinja);
            return RedirectToAction("Index");
            //ovo dolje je bio pokusaj dokumenata
            try
            {

                
                
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                    file.SaveAs(path);
                }
                //var IdVrstaZivotinje = int.Parse(Request.Form.GetValues("IdVrstaZivotinje")[0]);
                //var IdPasminaZivotinje = int.Parse(Request.Form.GetValues("IdPasminaZivotinje")[0]);
                //ZivotinjaRepository ZivotinjaRepository = new ZivotinjaRepository();
                //Zivotinja.VrstaZivotinje = ZivotinjaRepository.GetVrstaZivotinjeById(IdVrstaZivotinje);
                //Zivotinja.PasminaZivotinje = ZivotinjaRepository.GetPasminaZivotinjeById(IdPasminaZivotinje);
                //var service = new ZivotinjaService();
                //var zivotinje = service.Add(Zivotinja);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Zivotinja/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Zivotinja/Edit/5
        [HttpPost]
        [Authorize]
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
