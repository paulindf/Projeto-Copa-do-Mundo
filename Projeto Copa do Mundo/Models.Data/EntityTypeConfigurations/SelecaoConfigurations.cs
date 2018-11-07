using System.Data.Entity.ModelConfiguration;

namespace Projeto_Copa_do_Mundo.Models.Data.EntityTypeConfigurations
{
    internal class SelecaoConfigurations : EntityTypeConfiguration<Selecao>
    {
        public SelecaoConfigurations()
        {
            Property(x => x.Id)
                .HasColumnName("ID_SELECAO");

            Property(x => x.DataRegistro)
                .HasColumnName("DATA_REGISTRO");

            Property(x => x.DataAlteracao)
                .HasColumnName("DATA_ALTERACAO");

            Property(x => x.UsuarioId)
                .HasColumnName("ID_USUARIO_CADASTRO");
        }
    }
}