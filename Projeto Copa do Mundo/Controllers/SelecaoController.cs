using Projeto_Copa_do_Mundo.Models.Data;
using System.Linq;
using System.Web.Mvc;

namespace Projeto_Copa_do_Mundo.Controllers
{ 
    [Authorize]
    public class SelecaoController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public SelecaoController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: Selecao
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Selecao selecao)
        {
            if (!ModelState.IsValid)
            {
                TempData["mensagem"] = "Alguma validação pendente";
                return View(selecao);
            }

            selecao.Usuario = (Session["usuario"] as Usuario);

            _unitOfWork.SelecaoRepository.Adicionar(selecao);
            _unitOfWork.Salvar();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id) => View(_unitOfWork.SelecaoRepository.Buscar(id));

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _unitOfWork.SelecaoRepository.Remover(id);
            _unitOfWork.Salvar();
            return RedirectToAction("Index");
        }

        public ActionResult Index() => View(_unitOfWork.SelecaoRepository.ListarTodos().OrderBy(p => p.Pais));

        protected override void Dispose(bool disposing) => _unitOfWork.Dispose();

    }
}