using MVCCURSO.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;

namespace MVCCURSO.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            //if (string.IsNullOrEmpty(usuario.Nome))
            //{
            //    ModelState.AddModelError("Nome", "Preencha o campo nome");
            //}

            //if (usuario.Senha != usuario.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("", "As senhas são diferentes");
            //}

            if (ModelState.IsValid)
            {
                return View("Resultado",usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var dbex = new Collection<string>
            {
                "Ana Luiza",
                "Paula",
                "Joelvis"
            };

            return Json(dbex.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}