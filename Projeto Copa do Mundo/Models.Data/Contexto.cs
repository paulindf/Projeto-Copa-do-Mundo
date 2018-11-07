using Projeto_Copa_do_Mundo.Models.Data.EntityTypeConfigurations;
using System.Data.Entity;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class Contexto : DbContext
    {
        public Contexto() : base("conecta") { }
        
        private DbSet<Jogador> Jogadores { get; set; }
        private DbSet<Selecao> Selecoes { get; set; }
        private DbSet<Usuario> Usuarios { get; set; }
        private DbSet<Auditoria> Auditorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*definindo todos os tipos 'string' para varchar ao invés de nvarchar*/
            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));

            /*
            modelBuilder.Properties()
                .Configure(x => x.HasColumnName(x.ClrPropertyInfo.Name.ToUpper() + "GXG"));
            */

            modelBuilder.Properties()
                .Configure(x => x.HasColumnName(x.ClrPropertyInfo.Name.ToUpper().Replace("GXG", "")));

            modelBuilder.Configurations.Add(new UsuarioConfigurations());
            modelBuilder.Configurations.Add(new AuditoriaConfigurations());
            modelBuilder.Configurations.Add(new JogadorConfigurations());
            modelBuilder.Configurations.Add(new SelecaoConfigurations());
            //base.OnModelCreating(modelBuilder);
        }
    }
}