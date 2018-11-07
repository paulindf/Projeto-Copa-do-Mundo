namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Posicao = c.String(nullable: false, maxLength: 200),
                        Nascimento = c.DateTime(nullable: false),
                        SelecaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Selecoes", t => t.SelecaoId, cascadeDelete: true)
                .Index(t => t.SelecaoId);
            
            CreateTable(
                "dbo.Selecoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pais = c.String(nullable: false, maxLength: 100),
                        Tecnico = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogadores", "SelecaoId", "dbo.Selecoes");
            DropIndex("dbo.Jogadores", new[] { "SelecaoId" });
            DropTable("dbo.Selecoes");
            DropTable("dbo.Jogadores");
        }
    }
}
