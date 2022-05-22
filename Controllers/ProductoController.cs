using CampingHalconMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampingHalconMVC.Controllers
{
    public class ProductoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Producto/Buscar
        public ActionResult Buscar(List<ProductoModel> productoModels)
        {
            return View(productoModels);
        }

        // POST: Producto/Buscar
        [HttpPost]
        public ActionResult Buscar(string parametro)
        {
            var productoModels = db.Productos.Where(p => p.Nombre.Contains(parametro)).ToList();
            return View(productoModels);
        }
    }
}
