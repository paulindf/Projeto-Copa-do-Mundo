namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn(
                "Jogador", 
                "DataRegistro", 
                c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
        }

        public override void Down()
        {
            AlterColumn(
                "Jogador",
                "DataRegistro",
                c => c.DateTime(nullable: false));
        }
    }
}
