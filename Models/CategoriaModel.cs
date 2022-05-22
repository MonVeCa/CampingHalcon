using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CampingHalconMVC.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UrlImagen { get; set; }
        public virtual List<ProductoModel> Productos { get; set; } = new List<ProductoModel>();
    }
}