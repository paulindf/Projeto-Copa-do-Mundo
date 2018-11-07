using System.Data.Entity.ModelConfiguration;

namespace Projeto_Copa_do_Mundo.Models.Data.EntityTypeConfigurations
{
    public class AuditoriaConfigurations : EntityTypeConfiguration<Auditoria>
    {
        public AuditoriaConfigurations()
        { 
            Property(x => x.AuditoriaId)
                .HasColumnName("ID_AUDITORIA");

            Property(x => x.SessionId)
                .HasColumnName("ID_SESSAO");

            Property(x => x.DataRegistro)
                .HasColumnName("DATA_REGISTRO");

            Property(x => x.UsuarioId)
                .HasColumnName("ID_USUARIO");
        }
    }
}