using System.Data.Entity.ModelConfiguration;

namespace Projeto_Copa_do_Mundo.Models.Data.EntityTypeConfigurations
{
    internal class JogadorConfigurations : EntityTypeConfiguration<Jogador>
    {
        public JogadorConfigurations()
        {
            Property(x => x.Id)
                .HasColumnName("ID_JOGADOR");

            Property(x => x.Nascimento)
                .HasColumnType("Date")
                .HasColumnName("DATA_NASCIMENTO");

            Property(x => x.SelecaoId)
                .HasColumnName("ID_SELECAO");

            Property(x => x.UsuarioId)
                .HasColumnName("ID_USUARIO_CADASTRO");

            Property(x => x.DataRegistro)
                .HasColumnName("DATA_REGISTRO");

            Property(x => x.DataAlteracao)
                .HasColumnName("DATA_ALTERACAO");




        }
    }
}