namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 300),
                        Email = c.String(nullable: false, maxLength: 70),
                        Senha = c.String(nullable: false, maxLength: 30),
                        DataRegistro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Jogadores", "Usuario_Cadastro", c => c.Int(nullable: false));
            AddColumn("dbo.Jogadores", "DataRegistro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Jogadores", "DataAlteracao", c => c.DateTime());
            AddColumn("dbo.Jogadores", "Ativado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Selecoes", "Usuario_Cadastro", c => c.Int(nullable: false));
            AddColumn("dbo.Selecoes", "DataRegistro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Selecoes", "DataAlteracao", c => c.DateTime());
            AddColumn("dbo.Selecoes", "Ativado", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Jogadores", "Usuario_Cadastro");
            CreateIndex("dbo.Selecoes", "Usuario_Cadastro");
            AddForeignKey("dbo.Selecoes", "Usuario_Cadastro", "dbo.Usuarios", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Jogadores", "Usuario_Cadastro", "dbo.Usuarios", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogadores", "Usuario_Cadastro", "dbo.Usuarios");
            DropForeignKey("dbo.Selecoes", "Usuario_Cadastro", "dbo.Usuarios");
            DropIndex("dbo.Selecoes", new[] { "Usuario_Cadastro" });
            DropIndex("dbo.Jogadores", new[] { "Usuario_Cadastro" });
            DropColumn("dbo.Selecoes", "Ativado");
            DropColumn("dbo.Selecoes", "DataAlteracao");
            DropColumn("dbo.Selecoes", "DataRegistro");
            DropColumn("dbo.Selecoes", "Usuario_Cadastro");
            DropColumn("dbo.Jogadores", "Ativado");
            DropColumn("dbo.Jogadores", "DataAlteracao");
            DropColumn("dbo.Jogadores", "DataRegistro");
            DropColumn("dbo.Jogadores", "Usuario_Cadastro");
            DropTable("dbo.Usuarios");
        }
    }
}
