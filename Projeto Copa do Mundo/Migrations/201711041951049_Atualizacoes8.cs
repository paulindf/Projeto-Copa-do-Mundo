namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes8 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AUDITORIA", name: "AUDITORIAID", newName: "AUDITORIA_ID");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSIONID", newName: "SESSION_ID");
            RenameColumn(table: "dbo.AUDITORIA", name: "DATAREGISTRO", newName: "DATA_REGISTRO");
            RenameColumn(table: "dbo.JOGADOR", name: "SELECAOID", newName: "SELECAO_ID");
            RenameColumn(table: "dbo.JOGADOR", name: "UsuarioCadastro", newName: "USUARIO_CADASTRO");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAREGISTRO", newName: "DATA_REGISTRO");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAALTERACAO", newName: "DATA_ALTERACAO");
            RenameColumn(table: "dbo.SELECAO", name: "UsuarioCadastro", newName: "USUARIO_CADASTRO");
            RenameColumn(table: "dbo.SELECAO", name: "DATAREGISTRO", newName: "DATA_REGISTRO");
            RenameColumn(table: "dbo.SELECAO", name: "DATAALTERACAO", newName: "DATA_ALTERACAO");
            RenameColumn(table: "dbo.USUARIO", name: "ID", newName: "USUARIO_ID");
            RenameColumn(table: "dbo.USUARIO", name: "DATAREGISTRO", newName: "DATA_REGISTRO");
            RenameColumn(table: "dbo.USUARIO", name: "DATAALTERACAO", newName: "DATA_ALTERACAO");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_SELECAOID", newName: "IX_SELECAO_ID");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_UsuarioCadastro", newName: "IX_USUARIO_CADASTRO");
            RenameIndex(table: "dbo.SELECAO", name: "IX_UsuarioCadastro", newName: "IX_USUARIO_CADASTRO");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SELECAO", name: "IX_USUARIO_CADASTRO", newName: "IX_UsuarioCadastro");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_USUARIO_CADASTRO", newName: "IX_UsuarioCadastro");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_SELECAO_ID", newName: "IX_SELECAOID");
            RenameColumn(table: "dbo.USUARIO", name: "DATA_ALTERACAO", newName: "DATAALTERACAO");
            RenameColumn(table: "dbo.USUARIO", name: "DATA_REGISTRO", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.USUARIO", name: "USUARIO_ID", newName: "ID");
            RenameColumn(table: "dbo.SELECAO", name: "DATA_ALTERACAO", newName: "DATAALTERACAO");
            RenameColumn(table: "dbo.SELECAO", name: "DATA_REGISTRO", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.SELECAO", name: "USUARIO_CADASTRO", newName: "UsuarioCadastro");
            RenameColumn(table: "dbo.JOGADOR", name: "DATA_ALTERACAO", newName: "DATAALTERACAO");
            RenameColumn(table: "dbo.JOGADOR", name: "DATA_REGISTRO", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.JOGADOR", name: "USUARIO_CADASTRO", newName: "UsuarioCadastro");
            RenameColumn(table: "dbo.JOGADOR", name: "SELECAO_ID", newName: "SELECAOID");
            RenameColumn(table: "dbo.AUDITORIA", name: "DATA_REGISTRO", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSION_ID", newName: "SESSIONID");
            RenameColumn(table: "dbo.AUDITORIA", name: "AUDITORIA_ID", newName: "AUDITORIAID");
        }
    }
}
