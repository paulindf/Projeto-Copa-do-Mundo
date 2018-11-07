namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes5 : DbMigration
    {
        public override void Up()
        {
            string sql = "";

            sql += "ALTER TABLE dbo.JOGADOR DROP CONSTRAINT DF__Jogadores__Ativa__07F6335A; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.JOGADOR ADD CONSTRAINT DF_JOGADOR_DataRegistro DEFAULT getdate() FOR DataRegistro; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.JOGADOR ADD CONSTRAINT DF__Jogadores__Ativa__07F6335A DEFAULT 1 FOR Ativado; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.SELECAO DROP CONSTRAINT DF__Selecoes__DataRe__09DE7BCC; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.SELECAO DROP CONSTRAINT DF__Selecoes__Ativad__0AD2A005; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.SELECAO ADD CONSTRAINT DF__Selecoes__DataRe__09DE7BCC DEFAULT getdate() FOR DataRegistro; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.SELECAO ADD CONSTRAINT DF__Selecoes__Ativad__0AD2A005 DEFAULT 1 FOR Ativado; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.USUARIO ADD CONSTRAINT DF_USUARIO_DataRegistro DEFAULT getdate() FOR DataRegistro; ";
            //sql += "GO ";
            sql += "ALTER TABLE dbo.USUARIO ADD CONSTRAINT DF_USUARIO_Ativado DEFAULT 1 FOR Ativado; ";
            //sql += "GO ";

            Sql(sql);
        }
        
        public override void Down()
        {
        }
    }
}
