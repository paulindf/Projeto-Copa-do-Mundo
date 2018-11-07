using Projeto_Copa_do_Mundo.Models.Data;
using System;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Copa_do_Mundo.Filtros
{
    public class Filtro : IActionFilter
    {
        /*
         * Implementar auditoria
             */

        private UnitOfWork _unitOfWork = new UnitOfWork();


        //Depois
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //throw new NotImplementedException();
        }

        //Antes
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usuario = filterContext.HttpContext.Session["usuario"] as Usuario;
            int? idUsuario = null;

            if (usuario != null)
                idUsuario = usuario.Id;

            var auditoria = new Auditoria
            {
                DataRegistro = DateTime.Now,
                Get = filterContext.HttpContext.Request.QueryString.ToString(),
                Post = filterContext.HttpContext.Request.Form.ToString(),
                UsuarioId = idUsuario,
                IP = filterContext.HttpContext.Request.UserHostAddress,
                SessionId = filterContext.HttpContext.Session.SessionID,
                Sessao = GetSessoes(filterContext.HttpContext.Session),
                Url = filterContext.HttpContext.Request.RawUrl
            };

            _unitOfWork.AuditoriaRepository.Adicionar(auditoria);
            _unitOfWork.AuditoriaRepository.Salvar();
        }

        private string GetSessoes(HttpSessionStateBase sessoes)
        {
            string retorno = "";
            int cont = 0;

            foreach (var item in sessoes)
            {
                string chave = item.ToString() + ":" + sessoes[item.ToString()].ToString();

                retorno = (cont == 0) ? chave : retorno + ";" + chave;
                cont++;
            }

            return retorno;
        }
    }
}