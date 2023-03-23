using DDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetDDD.MVC.Controllers
{
    public class AffectationController : Controller
    {
        private readonly IAppAffectationService _AppAffService;

        public AffectationController(IAppAffectationService AppAffService)
        {
            _AppAffService = AppAffService;
        }
        // GET: Affectation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var model = _AppAffService.GetAll();
            return PartialView("GetAll", model);

        }
    }
}