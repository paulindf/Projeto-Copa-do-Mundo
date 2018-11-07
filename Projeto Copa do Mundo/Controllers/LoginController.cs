using Projeto_Copa_do_Mundo.Models;
using Projeto_Copa_do_Mundo.Models.Data;
using Projeto_Copa_do_Mundo.Utils.Extension;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Projeto_Copa_do_Mundo.Controllers
{
    public class LoginController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public LoginController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public ActionResult Login(string email, string senha)
        {
            if (!ModelState.IsValid)
            {
                TempData["mensagem"] = "Pendência de formulário";
                return View(new { email = email, senha = senha });
            }
            
            if (string.IsNullOrEmpty(email))
            {
                TempData["mensagem"] = "Email não pode ser vazio";
                return View(new { email = email, senha = senha });
            }

            if (string.IsNullOrEmpty(senha))
            {
                TempData["mensagem"] = "Senha não pode ser vazio";
                return View(new { email = email, senha = senha });
            }

            var usuario = _unitOfWork.UsuarioRepository.Buscar(email);

            if (usuario == null)
            {
                TempData["mensagem"] = "Usuário não encontrado";
                return View(new { email = email, senha = senha });
            }

            if (!usuario.Senha.Equals(senha))
            {
                TempData["mensagem"] = "A senha informada não está correta";
                return View(new { email = email, senha = senha });
            }

            FormsAuthentication.SetAuthCookie(usuario.Nome, false);

            UsuarioVM usuarioVM = new UsuarioVM();
            usuario.CopiarPropriedades(ref usuarioVM);

            Session.Timeout = FormsAuthentication.Timeout.Minutes;
            Session["usuario"] = usuarioVM;
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}