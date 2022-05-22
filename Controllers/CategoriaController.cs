using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampingHalconMVC.Models;

namespace CampingHalconMVC.Controllers
{
    public class CategoriaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CategoriaModels
        public ActionResult Index()
        {
            return View(db.Categorias.ToList());
        }

        // GET: CategoriaModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaModel categoriaModel = db.Categorias.Find(id);
            if (categoriaModel == null)
            {
                return HttpNotFound();
            }
            return View(categoriaModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
