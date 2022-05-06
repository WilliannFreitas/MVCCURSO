using MVCCURSO.Models;
using System.Web.Mvc;

namespace MVCCURSO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Willy",
                Tipo = "Power"
            };

            //ex: 01
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //ex: 02
            //ViewBag.id = pessoa.PessoaId;
            //ViewBag.nome = pessoa.Nome;
            //ViewBag.tipo = pessoa.Tipo;

            //ex: 03
            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        //{
        //    ViewData["PessoaId"] = PessoaId;
        //    ViewData["Nome"] = Nome;
        //    ViewData["Tipo"] = Tipo;

        //    return View();
        //} 
        
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }

    }

}