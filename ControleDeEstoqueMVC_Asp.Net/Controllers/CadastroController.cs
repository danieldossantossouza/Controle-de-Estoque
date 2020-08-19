using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoqueMVC_Asp.Net.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult GrupoProdutos()
        {
            return View();
        }
		public ActionResult MarcaProdutos()
		{
			return View();
		}
		public ActionResult LocaisArmazenamento()
		{
			return View();
		}
		public ActionResult UnidadeMedida()
		{
			return View();
		}
		public ActionResult Produtos()
		{
			return View();
		}
		public ActionResult Paises()
		{
			return View();
		}
		public ActionResult Estados()
		{
			return View();
		}
		public ActionResult Cidades()
		{
			return View();
		}
		public ActionResult Fornecedores()
		{
			return View();
		}
		public ActionResult PerfisUsuarios()
		{
			return View();
		}
		public ActionResult Usuarios()
		{
			return View();
		}

	}
}