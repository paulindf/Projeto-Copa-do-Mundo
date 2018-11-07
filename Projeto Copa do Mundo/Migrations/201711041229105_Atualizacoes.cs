namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Jogadores", newName: "JOGADOR");
            RenameTable(name: "dbo.Selecoes", newName: "SELECAO");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SELECAO", newName: "Selecoes");
            RenameTable(name: "dbo.JOGADOR", newName: "Jogadores");
        }
    }
}
