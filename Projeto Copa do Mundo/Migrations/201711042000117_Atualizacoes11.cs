namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes11 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AUDITORIA", name: "ID_SESSION", newName: "ID_SESSAO");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.AUDITORIA", name: "ID_SESSAO", newName: "ID_SESSION");
        }
    }
}
