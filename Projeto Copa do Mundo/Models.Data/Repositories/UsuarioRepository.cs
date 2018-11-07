using System.Linq;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(Contexto contexto) : base(contexto)
        {
        }

        public Usuario Buscar(string email) => (ListarTodos().FirstOrDefault(p => p.Ativado == true && p.Email == email));

        public Usuario VerificarLogin(string email, string senha) =>
            (ListarTodos()
            .FirstOrDefault
                (
                    p => p.Ativado == true
                    && p.Email == email
                    && p.Senha == senha
                )
            );
    }
}