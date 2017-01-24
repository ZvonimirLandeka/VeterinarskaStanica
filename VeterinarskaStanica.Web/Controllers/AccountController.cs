using System;
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
            AccountService AccountService = new AccountService();
            var exists = AccountService.CheckLogin(AccountModel.KorisnickoIme, AccountModel.Lozinka);
            exists = true;
            if (AccountModel.KorisnickoIme.Equals("a"))
            {
                FormsAuthentication.SetAuthCookie(AccountModel.KorisnickoIme, true);
                return RedirectToAction("Index", "Home");
            }
            HomeController HomeController = new HomeController();
            return RedirectToAction("Login", this);

        }


        [Authorize]
        public ActionResult Logoff()
        {
            
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
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
