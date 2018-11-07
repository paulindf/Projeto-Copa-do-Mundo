using System.Linq;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class JogadorRepository : Repository<Jogador>
    {
        private Contexto _db;
        public JogadorRepository(Contexto contexto) : base(contexto) => _db = contexto;

        public override IQueryable<Jogador> ListarTodos() => _db
            .Set<Jogador>()
            .Include("Selecao")
            .Where(p => p.Ativado == true)
            //.OrderByDescending(p => p.Selecao.Pais)
            //.ThenBy(p => p.Nome)
            ;
    }
}