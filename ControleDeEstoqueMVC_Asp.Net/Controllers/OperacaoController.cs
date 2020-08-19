using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoqueMVC_Asp.Net.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult EntradaProduto()
        {
            return View();
        }
		public ActionResult SaidaProduto()
		{
			return View();
		}
		public ActionResult LancPerdaProduto()
		{
			return View();
		}
		public ActionResult Inventario()
		{
			return View();
		}

	}
}