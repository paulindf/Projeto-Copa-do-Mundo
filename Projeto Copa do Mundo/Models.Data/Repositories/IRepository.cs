using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public interface IRepository<TEntidade> : IDisposable where TEntidade : class
    {
        void Adicionar(TEntidade objeto);
        TEntidade Buscar(int id);
        IQueryable<TEntidade> ListarTodos();
        void Remover(int id);
        void Remover(TEntidade objeto);
        void Salvar();
        void Editar(int id);
        void Editar(TEntidade objeto);
    }
}
