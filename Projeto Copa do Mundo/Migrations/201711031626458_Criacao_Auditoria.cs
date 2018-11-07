namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_Auditoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auditorias",
                c => new
                    {
                        AuditoriaId = c.Long(nullable: false, identity: true),
                        IP = c.String(maxLength: 20),
                        Get = c.String(maxLength: 1000),
                        Post = c.String(),
                        SessionId = c.String(maxLength: 20),
                        Sessao = c.String(maxLength: 1000),
                        DataRegistro = c.DateTime(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.AuditoriaId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Auditorias", "Usuario_Id", "dbo.Usuarios");
            DropIndex("dbo.Auditorias", new[] { "Usuario_Id" });
            DropTable("dbo.Auditorias");
        }
    }
}
