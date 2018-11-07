namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajustes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Jogadores", name: "Usuario_Cadastro", newName: "UsuarioCadastro");
            RenameColumn(table: "dbo.Selecoes", name: "Usuario_Cadastro", newName: "UsuarioCadastro");
            RenameIndex(table: "dbo.Jogadores", name: "IX_Usuario_Cadastro", newName: "IX_UsuarioCadastro");
            RenameIndex(table: "dbo.Selecoes", name: "IX_Usuario_Cadastro", newName: "IX_UsuarioCadastro");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Selecoes", name: "IX_UsuarioCadastro", newName: "IX_Usuario_Cadastro");
            RenameIndex(table: "dbo.Jogadores", name: "IX_UsuarioCadastro", newName: "IX_Usuario_Cadastro");
            RenameColumn(table: "dbo.Selecoes", name: "UsuarioCadastro", newName: "Usuario_Cadastro");
            RenameColumn(table: "dbo.Jogadores", name: "UsuarioCadastro", newName: "Usuario_Cadastro");
        }
    }
}
