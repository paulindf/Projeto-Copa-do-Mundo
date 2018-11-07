using System;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class UnitOfWork : IDisposable
    {
        private bool _disposed = false;
        private Contexto _db = new Contexto();

        private AuditoriaRepository _auditoriaRepository = null;
        private JogadorRepository _jogadorRepository = null;
        private SelecaoRepository _selecaoRepository = null;
        private UsuarioRepository _usuarioRepository = null;

        public AuditoriaRepository AuditoriaRepository => _auditoriaRepository ?? new AuditoriaRepository(_db);

        public JogadorRepository JogadorRepository => _jogadorRepository ?? new JogadorRepository(_db);

        public SelecaoRepository SelecaoRepository => _selecaoRepository ?? new SelecaoRepository(_db);

        public UsuarioRepository UsuarioRepository => _usuarioRepository ?? new UsuarioRepository(_db);

        public void Salvar() => _db.SaveChanges();

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
                _db.Dispose();

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork() => Dispose();
    }
}