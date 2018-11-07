using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : class
    {
        private Contexto _db;
        private bool _disposed = false;

        public Repository(Contexto contexto) => _db = contexto;

        public void Adicionar(TEntidade objeto) => _db.Set<TEntidade>().Add(objeto);

        public TEntidade Buscar(int id) => _db.Set<TEntidade>().Find(id);

        public void Editar(int id) => Editar(Buscar(id));

        public void Editar(TEntidade objeto) => _db.Entry(objeto).State = EntityState.Modified;

        public virtual IQueryable<TEntidade> ListarTodos() => _db.Set<TEntidade>();

        public void Remover(int id) => Remover(Buscar(id));

        public void Remover(TEntidade objeto) => _db.Set<TEntidade>().Remove(objeto);

        public void Salvar() => _db.SaveChanges();

        public void Dispose(bool dispose)
        {
            if (!_disposed && dispose)
                _db.Dispose();

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}