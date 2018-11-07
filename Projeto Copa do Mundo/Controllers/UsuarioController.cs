using Projeto_Copa_do_Mundo.Models.Data;
using System.Web.Mvc;

namespace Projeto_Copa_do_Mundo.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public UsuarioController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Novo() => View();

        [HttpPost]
        [ActionName("Novo")]
        public ActionResult Cadastrar(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                TempData["mensagem"] = "Alguma pendência encontrada";
                return View(usuario);
            }

            if (_unitOfWork.UsuarioRepository.Buscar(usuario.Email) != null)
            {
                TempData["mensagem"] = "Esse e-mail já está cadastrado no sistema";
                return View(usuario);
            }

            _unitOfWork.UsuarioRepository.Adicionar(usuario);
            _unitOfWork.Salvar();

            return RedirectToAction("Index", "Home");
        }
        
    }
}