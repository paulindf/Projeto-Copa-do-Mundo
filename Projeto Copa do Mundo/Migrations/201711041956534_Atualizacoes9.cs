namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes9 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AUDITORIA", name: "AUDITORIA_ID", newName: "ID_AUDITORIA");
            RenameColumn(table: "dbo.AUDITORIA", name: "USUARIOID", newName: "ID_USUARIO");
            RenameColumn(table: "dbo.JOGADOR", name: "ID", newName: "ID_JOGADOR");
            RenameColumn(table: "dbo.JOGADOR", name: "NASCIMENTO", newName: "DATA_NASCIMENTO");
            RenameColumn(table: "dbo.SELECAO", name: "ID", newName: "ID_SELECAO");
            RenameColumn(table: "dbo.USUARIO", name: "USUARIO_ID", newName: "ID_USUARIO");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.USUARIO", name: "ID_USUARIO", newName: "USUARIO_ID");
            RenameColumn(table: "dbo.SELECAO", name: "ID_SELECAO", newName: "ID");
            RenameColumn(table: "dbo.JOGADOR", name: "DATA_NASCIMENTO", newName: "NASCIMENTO");
            RenameColumn(table: "dbo.JOGADOR", name: "ID_JOGADOR", newName: "ID");
            RenameColumn(table: "dbo.AUDITORIA", name: "ID_USUARIO", newName: "USUARIOID");
            RenameColumn(table: "dbo.AUDITORIA", name: "ID_AUDITORIA", newName: "AUDITORIA_ID");
        }
    }
}
