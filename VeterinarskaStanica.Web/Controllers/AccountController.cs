﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.BLL;
using VeterinarskaStanica.Web.Models;
using System.Web.Security;

namespace VeterinarskaStanica.Web.Controllers
{
    public class AccountController : Controller
    {


        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountModel AccountModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            VlasnikService VlasnikService = new VlasnikService();
            var exists = VlasnikService.CheckLogin(AccountModel.KorisnickoIme, AccountModel.Lozinka);
            
            if (exists)
            {
                FormsAuthentication.SetAuthCookie(AccountModel.KorisnickoIme, false);
                return RedirectToAction("Index", "Home");
            }
            HomeController HomeController = new HomeController();
            return RedirectToAction("Login", this);

        }



        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Register(string returnUrl)
        {
            
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Vlasnik Vlasnik)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            VlasnikService VlasnikService = new VlasnikService();
            var PostojeciVlasnik = VlasnikService.GetIdByKorisnickoIme(Vlasnik.KorisnickoIme);
            if (PostojeciVlasnik!=null)
            {
                return View();
            }
            
            VlasnikService.Add(Vlasnik);
            return RedirectToAction("Login");
        }


        [Authorize]
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }



        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
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

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
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

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
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
