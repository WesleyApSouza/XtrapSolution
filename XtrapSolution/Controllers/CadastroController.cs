using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XtrapSolution.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult CadastroProdutos()
        {
            ViewBag.Title = "CadastroProdutos";
            return View();
        }
        public ActionResult CadastroFornecedores()
        {
            ViewBag.Title = "CadastroFornecedores";
            return View();
        }
        public ActionResult CadastroClientes()
        {
            ViewBag.Title = "CadastroClientes";
            return View();
        }
    }
}