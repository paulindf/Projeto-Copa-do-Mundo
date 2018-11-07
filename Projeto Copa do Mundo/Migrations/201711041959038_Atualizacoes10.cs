namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes10 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSION_ID", newName: "ID_SESSION");
            RenameColumn(table: "dbo.JOGADOR", name: "SELECAO_ID", newName: "ID_SELECAO");
            RenameColumn(table: "dbo.JOGADOR", name: "USUARIO_CADASTRO", newName: "ID_USUARIO_CADASTRO");
            RenameColumn(table: "dbo.SELECAO", name: "USUARIO_CADASTRO", newName: "ID_USUARIO_CADASTRO");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_SELECAO_ID", newName: "IX_ID_SELECAO");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_USUARIO_CADASTRO", newName: "IX_ID_USUARIO_CADASTRO");
            RenameIndex(table: "dbo.SELECAO", name: "IX_USUARIO_CADASTRO", newName: "IX_ID_USUARIO_CADASTRO");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SELECAO", name: "IX_ID_USUARIO_CADASTRO", newName: "IX_USUARIO_CADASTRO");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_ID_USUARIO_CADASTRO", newName: "IX_USUARIO_CADASTRO");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_ID_SELECAO", newName: "IX_SELECAO_ID");
            RenameColumn(table: "dbo.SELECAO", name: "ID_USUARIO_CADASTRO", newName: "USUARIO_CADASTRO");
            RenameColumn(table: "dbo.JOGADOR", name: "ID_USUARIO_CADASTRO", newName: "USUARIO_CADASTRO");
            RenameColumn(table: "dbo.JOGADOR", name: "ID_SELECAO", newName: "SELECAO_ID");
            RenameColumn(table: "dbo.AUDITORIA", name: "ID_SESSION", newName: "SESSION_ID");
        }
    }
}
