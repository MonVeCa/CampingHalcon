using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CampingHalconMVC.Models
{
    public class CarritoModel
    {
        public int Id { get; set; }
        public string Creador { get; set; }
        public virtual List<ProductoModel> Productos { get; set; } = new List<ProductoModel>();

        public static int ContadorProductos(string Creador)
        {
            CampingHalconMVC.Models.ApplicationDbContext db = new CampingHalconMVC.Models.ApplicationDbContext();
            var carrito = db.Carritos.FirstOrDefault(c => c.Creador == Creador);
            if (carrito != null)
            {
                return carrito.Productos.Count;
            }
            return 0;
        }
    }
}