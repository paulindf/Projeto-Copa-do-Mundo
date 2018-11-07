namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao_Tabela_Auditoria_Tamanho_Coluna : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Auditorias", "SessionId", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Auditorias", "SessionId", c => c.String(maxLength: 20));
        }
    }
}
