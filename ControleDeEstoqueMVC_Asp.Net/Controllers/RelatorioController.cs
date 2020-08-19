using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoqueMVC_Asp.Net.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        public ActionResult Posicaoestoque()
        {
            return View();
        }
		public ActionResult Ressuprimento()
		{
			return View();
		}
	}
}