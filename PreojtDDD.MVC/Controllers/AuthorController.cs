using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProjetDDD.Application.Interfaces;
using ProjetDDD.Application.Entites;

namespace PreojtDDD.MVC.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorAppService _AuthorAppService;

        public AuthorController(IAuthorAppService AuthorAppService)
        {
            _AuthorAppService = AuthorAppService;
        }

        // GET: Book
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
        public ActionResult Add(Author_DTO obj)
        {
            _AuthorAppService.Add(obj);
            return RedirectToAction("GetAll");
        }
        //GetById Author
        public ActionResult GetById(Int32 id)
        {
            var model = _AuthorAppService.GetById(id);
            return PartialView("GetById", model);
        }
        //GetAll Authors
        public ActionResult GetAll()
        {
            var model = _AuthorAppService.GetAll();
            return PartialView("GetAll", model);
        }

        //Update Authors
        public ActionResult Update(Int32 id)
        {
            var model = _AuthorAppService.GetById(id);
            return PartialView("GetById", model);
        }
        [HttpPost]
        
        public ActionResult Update(Author_DTO obj)
        {
            _AuthorAppService.Update(obj);
            return RedirectToAction("GetAll");
        }

        public ActionResult Details(int id)
        {
            var model = _AuthorAppService.GetById(id);
            return View(model);
        }

        //Remove Author
        public ActionResult Delete(int id)
        {
            var model = _AuthorAppService.GetById(id);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            _AuthorAppService.Remove(id);
            return RedirectToAction("GetAll");
            
        }

    }
}