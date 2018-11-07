using Projeto_Copa_do_Mundo.Models;
using Projeto_Copa_do_Mundo.Models.Data;
using Projeto_Copa_do_Mundo.Utils.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Copa_do_Mundo.Controllers
{
    [Authorize]
    public class JogadorController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public JogadorController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Listar()
        {
            List<JogadorVM> lista =
                (from a in _unitOfWork.JogadorRepository.ListarTodos()
                 orderby a.Selecao.Pais descending, a.Nome
                 select new JogadorVM
                 {
                     Id = a.Id,
                     Nascimento = a.Nascimento,
                     Nome = a.Nome,
                     Posicao = a.Posicao,
                     Selecao = new SelecaoVM
                     {
                         Id = a.Selecao.Id,
                         Pais = a.Selecao.Pais,
                         Tecnico = a.Selecao.Tecnico
                     }
                 })
                 .ToList()
                 ;

            return View(lista);
        }

        [HttpGet]
        [ActionName("Cadastrar")]
        public ActionResult NovoJogador()
        {
            ViewData["selecoes"] = GetSelecoes();

            return View();
        }

        private IEnumerable<SelecaoVM> GetSelecoes()
        {
            var listaBD = _unitOfWork
                .SelecaoRepository
                .ListarTodos().Where(a => a.Ativado == true).OrderBy(p => p.Pais);

            var lista =
                from a in listaBD
                select new SelecaoVM
                {
                    Pais = a.Pais,
                    Tecnico = a.Tecnico,
                    Id = a.Id
                };

            return lista;
        }

        [HttpPost, ActionName("Cadastrar"), ValidateAntiForgeryToken]
        public ActionResult NovoJogador(JogadorVM jogador)
        {
            if (!ModelState.IsValid) return View(jogador);

            jogador.Usuario = (Session["usuario"] as UsuarioVM);

            Jogador jogadorBD = new Jogador();

            jogador.CopiarPropriedades(ref jogadorBD);

            _unitOfWork.JogadorRepository.Adicionar(jogadorBD);
            _unitOfWork.Salvar();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            ViewData["selecoes"] = GetSelecoes();

            var jogadorBD = _unitOfWork.JogadorRepository.Buscar(id);

            JogadorVM jogador = new JogadorVM();

            jogadorBD.CopiarPropriedades(ref jogador);

            return View(jogador);
        }

        [HttpPost]
        public ActionResult Editar(JogadorVM edit)
        {
            if (!ModelState.IsValid)
            {
                TempData["mensagem"] = "Validação pendente";
                return View(edit);
            }



            var jogadorBD = _unitOfWork.JogadorRepository.Buscar(edit.Id);

            jogadorBD.Nome = edit.Nome;
            jogadorBD.Nascimento = edit.Nascimento;
            jogadorBD.Posicao = edit.Posicao;
            jogadorBD.SelecaoId = edit.SelecaoId;
            jogadorBD.DataAlteracao = DateTime.Now;

            _unitOfWork.JogadorRepository.Editar(jogadorBD);
            _unitOfWork.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult ConfirmarRemover(int id)
        {
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Remover(int id)
        {
            return RedirectToAction("Listar");
        }
    }
}