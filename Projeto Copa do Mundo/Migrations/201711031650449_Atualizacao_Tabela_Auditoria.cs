namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao_Tabela_Auditoria : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Auditorias", "Usuario_Id", "dbo.Usuarios");
            DropIndex("dbo.Auditorias", new[] { "Usuario_Id" });
            AddColumn("dbo.Auditorias", "UsuarioId", c => c.Int());
            DropColumn("dbo.Auditorias", "Usuario_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auditorias", "Usuario_Id", c => c.Int());
            DropColumn("dbo.Auditorias", "UsuarioId");
            CreateIndex("dbo.Auditorias", "Usuario_Id");
            AddForeignKey("dbo.Auditorias", "Usuario_Id", "dbo.Usuarios", "Id");
        }
    }
}
