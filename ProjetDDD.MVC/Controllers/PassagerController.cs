using DDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetDDD.MVC.Controllers
{
    public class PassagerController : Controller
    {
         private readonly IAppPassagerService _AppPassService;

         public PassagerController(IAppPassagerService AppPassService)
        {
            _AppPassService = AppPassService;
        }
        // GET: Passager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var model = _AppPassService.GetAll();
            return PartialView("GetAll", model);

        }
    }
}