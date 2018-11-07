using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration;

namespace Projeto_Copa_do_Mundo.Models.Data.EntityTypeConfigurations
{
    public class UsuarioConfigurations : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfigurations()
        {
            Property(x => x.DataRegistro)
                .HasColumnName("DATA_REGISTRO");

            Property(x => x.DataAlteracao)
                .HasColumnName("DATA_ALTERACAO");

            Property(x => x.Id)
                .HasColumnName("ID_USUARIO");
        }
    }
}