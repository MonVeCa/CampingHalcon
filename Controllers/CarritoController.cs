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
    public class CarritoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Carrito
        public ActionResult Index()
        {
            string email = User.Identity.Name;
            var carritoModel = db.Carritos.FirstOrDefault(c => c.Creador == email);
            if (carritoModel == null)
            {
                return RedirectToAction("Index", "Categoria", null);
            }
            return View(carritoModel);
        }

        // GET: Carrito/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarritoModel carritoModel = db.Carritos.Find(id);
            if (carritoModel == null)
            {
                return HttpNotFound();
            }
            return View(carritoModel);
        }

        // GET: Carrito/AddProduct/1
        public ActionResult AddProduct(int? id)
        {
            string email = User.Identity.Name;
            var carritoModel = db.Carritos.FirstOrDefault(c => c.Creador == email);
            if (carritoModel == null)
            {
                carritoModel = new CarritoModel()
                {
                    Creador = email
                };
                db.Carritos.Add(carritoModel);
            }
            //if (!carritoModel.Productos.Any(p => p.Id == id))
            //{
            //    carritoModel.Productos.Add(db.Productos.Find(id));
            //}
            carritoModel.Productos.Add(db.Productos.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Carrito/DelProduct/1
        public ActionResult DelProduct(int? id)
        {
            string email = User.Identity.Name;
            var carritoModel = db.Carritos.FirstOrDefault(c => c.Creador == email);
            if (carritoModel.Productos.Any(p => p.Id == id))
            {
                carritoModel.Productos.Remove(db.Productos.Find(id));
            }
            db.SaveChanges();
            return RedirectToAction("Index");
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
