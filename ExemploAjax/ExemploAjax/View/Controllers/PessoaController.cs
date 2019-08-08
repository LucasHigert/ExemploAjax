using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class PessoaController : Controller
    {
        private PessoaRepository repository;

        public PessoaController()
        {
            repository = new PessoaRepository();
        }
        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ObterTodos()
        {
            var pessoas = repository.ObterTodos();
            var resultado = new { data = pessoas };
            return Json(resultado,JsonRequestBehavior.AllowGet);
        }

    }
}