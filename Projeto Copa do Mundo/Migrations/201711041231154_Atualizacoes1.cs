namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Auditorias", newName: "AUDITORIA");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AUDITORIA", newName: "Auditorias");
        }
    }
}
