namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao_Tabela_Auditoria1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auditorias", "Url", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auditorias", "Url");
        }
    }
}
