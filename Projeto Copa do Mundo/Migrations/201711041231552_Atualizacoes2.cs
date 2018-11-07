namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Usuarios", newName: "USUARIO");
        }

        public override void Down()
        {
            RenameTable(name: "dbo.USUARIO", newName: "Usuarios");
        }
    }
}
