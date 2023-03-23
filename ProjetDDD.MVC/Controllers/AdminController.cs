using DDD.Application.Entites;
using DDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetDDD.MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAppAdminService _AppAdminService;

        public AdminController(IAppAdminService AppAdminService)
        {
            _AppAdminService = AppAdminService;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //ADD Author
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Admin_DTO obj)
        {
            _AppAdminService.Add(obj);
            return RedirectToAction("GetAll");
        }

        public ActionResult GetAll()
        {
            var model = _AppAdminService.GetAll();
           return PartialView("GetAll", model);
            
        }
       

        public ActionResult Details(int id)
        {
            var model = _AppAdminService.GetById(id);
            return View(model);
        }

      [HttpPost]
        public ActionResult Search(string nom, string prenom)
      
    {
            var model = _AppAdminService.GetByName(nom, prenom);
           return View(model);

       }

        public ActionResult Update(Int32 id)
        {
            var model = _AppAdminService.GetById(id);
            return PartialView("Update", model);
        }
        [HttpPost]

        public ActionResult Update(Admin_DTO obj)
        {
            _AppAdminService.Update(obj);
            return RedirectToAction("GetAll");
        }

        public ActionResult Delete(int id)
        {
            var model = _AppAdminService.GetById(id);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            _AppAdminService.Remove(id);
            return RedirectToAction("GetAll");

        }
    }
}