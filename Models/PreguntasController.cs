using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampingHalconMVC.Models
{
    public class PreguntasController : Controller
    {
        // GET: Preguntas
        public ActionResult Index()
        {
            return View();
        }
    }
}
