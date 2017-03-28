using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XtrapSolution.Controllers
{
    public class MercadoController : Controller
    {
        mercadomContext db = new mercadomContext();
        public ActionResult ListaProdutos()
        {
            ViewBag.Title = "ListaProdutos";
            return View(db.categorias.ToList());
        }
    }
}