using DDD.Application.Entites;
using DDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetDDD.MVC.Controllers
{
    public class ConducteurController : Controller
    {
        private readonly IAppConducteurService _AppCondService;

        public ConducteurController(IAppConducteurService AppCondService)
        {
            _AppCondService = AppCondService;
        }
        // GET: Conducteur
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Conducteur_DTO obj)
        {
            _AppCondService.Add(obj);
            return RedirectToAction("GetAll");
        }

        public ActionResult GetAll()
        {
            var model = _AppCondService.GetAll();
            return PartialView("GetAll", model);

        }
        public ActionResult Details(int id)
        {
            var model = _AppCondService.GetById(id);
            return View(model);
        }
        public ActionResult Update(Int32 id)
        {
            var model = _AppCondService.GetById(id);
            return PartialView("Update", model);
        }
        [HttpPost]

        public ActionResult Update(Conducteur_DTO obj)
        {
            _AppCondService.Update(obj);
            return RedirectToAction("GetAll");
        }


        public ActionResult Delete(int id)
        {
            var model = _AppCondService.GetById(id);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            _AppCondService.Remove(id);
            return RedirectToAction("GetAll");

        }
    }
}