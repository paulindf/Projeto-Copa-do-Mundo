namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class AuditoriaRepository : Repository<Auditoria>
    {
        private Contexto _db;
        public AuditoriaRepository(Contexto contexto) : base(contexto) => _db = contexto;

    }
}