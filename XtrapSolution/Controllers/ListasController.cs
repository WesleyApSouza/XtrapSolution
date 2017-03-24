using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XtrapSolution.Controllers
{
    public class ListasController : Controller
    {
        // GET: Lista
        public ActionResult ListaProdutos()
        {
            ViewBag.Title = "ListaProdutos";
            return View();
        }
        public ActionResult ListaFornecedores()
        {
            ViewBag.Title = "ListaFornecedores";
            return View();
        }
        public ActionResult ListaClientes()
        {
            ViewBag.Title = "ListaClientes";
            return View();
        }
    }
}