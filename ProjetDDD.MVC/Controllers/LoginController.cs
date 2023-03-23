using DDD.Application.Entites;
using DDD.Application.Interface;
using ProjetDDD.MVC.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetDDD.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAppAdminService _AdminAppService;

        public LoginController(IAppAdminService AdminAppService)
        {
            _AdminAppService = AdminAppService;
        }

        // GET: Login
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Admin_DTO obj)
        {
            var result = _AdminAppService.Login(obj.login, obj.mdp);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { login = obj.login });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "login ou mot de passe incorrecte");
            }
            return View(obj);
        }
    }
}