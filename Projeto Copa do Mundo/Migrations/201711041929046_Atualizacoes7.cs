namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AUDITORIA", name: "IPGXG", newName: "IP");
            RenameColumn(table: "dbo.AUDITORIA", name: "USUARIOIDGXG", newName: "USUARIOID");
            RenameColumn(table: "dbo.AUDITORIA", name: "GETGXG", newName: "GET");
            RenameColumn(table: "dbo.AUDITORIA", name: "POSTGXG", newName: "POST");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSIONIDGXG", newName: "SESSIONID");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSAOGXG", newName: "SESSAO");
            RenameColumn(table: "dbo.AUDITORIA", name: "DATAREGISTROGXG", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.AUDITORIA", name: "URLGXG", newName: "URL");
            RenameColumn(table: "dbo.JOGADOR", name: "IDGXG", newName: "ID");
            RenameColumn(table: "dbo.JOGADOR", name: "NOMEGXG", newName: "NOME");
            RenameColumn(table: "dbo.JOGADOR", name: "POSICAOGXG", newName: "POSICAO");
            RenameColumn(table: "dbo.JOGADOR", name: "NASCIMENTOGXG", newName: "NASCIMENTO");
            RenameColumn(table: "dbo.JOGADOR", name: "SELECAOIDGXG", newName: "SELECAOID");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAREGISTROGXG", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAALTERACAOGXG", newName: "DATAALTERACAO");
            RenameColumn(table: "dbo.JOGADOR", name: "ATIVADOGXG", newName: "ATIVADO");
            RenameColumn(table: "dbo.SELECAO", name: "IDGXG", newName: "ID");
            RenameColumn(table: "dbo.SELECAO", name: "PAISGXG", newName: "PAIS");
            RenameColumn(table: "dbo.SELECAO", name: "TECNICOGXG", newName: "TECNICO");
            RenameColumn(table: "dbo.SELECAO", name: "DATAREGISTROGXG", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.SELECAO", name: "DATAALTERACAOGXG", newName: "DATAALTERACAO");
            RenameColumn(table: "dbo.SELECAO", name: "ATIVADOGXG", newName: "ATIVADO");
            RenameColumn(table: "dbo.USUARIO", name: "IDGXG", newName: "ID");
            RenameColumn(table: "dbo.USUARIO", name: "NOMEGXG", newName: "NOME");
            RenameColumn(table: "dbo.USUARIO", name: "EMAILGXG", newName: "EMAIL");
            RenameColumn(table: "dbo.USUARIO", name: "SENHAGXG", newName: "SENHA");
            RenameColumn(table: "dbo.USUARIO", name: "DATAREGISTROGXG", newName: "DATAREGISTRO");
            RenameColumn(table: "dbo.USUARIO", name: "DATAALTERACAOGXG", newName: "DATAALTERACAO");
            RenameColumn(table: "dbo.USUARIO", name: "ATIVADOGXG", newName: "ATIVADO");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_SELECAOIDGXG", newName: "IX_SELECAOID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.JOGADOR", name: "IX_SELECAOID", newName: "IX_SELECAOIDGXG");
            RenameColumn(table: "dbo.USUARIO", name: "ATIVADO", newName: "ATIVADOGXG");
            RenameColumn(table: "dbo.USUARIO", name: "DATAALTERACAO", newName: "DATAALTERACAOGXG");
            RenameColumn(table: "dbo.USUARIO", name: "DATAREGISTRO", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.USUARIO", name: "SENHA", newName: "SENHAGXG");
            RenameColumn(table: "dbo.USUARIO", name: "EMAIL", newName: "EMAILGXG");
            RenameColumn(table: "dbo.USUARIO", name: "NOME", newName: "NOMEGXG");
            RenameColumn(table: "dbo.USUARIO", name: "ID", newName: "IDGXG");
            RenameColumn(table: "dbo.SELECAO", name: "ATIVADO", newName: "ATIVADOGXG");
            RenameColumn(table: "dbo.SELECAO", name: "DATAALTERACAO", newName: "DATAALTERACAOGXG");
            RenameColumn(table: "dbo.SELECAO", name: "DATAREGISTRO", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.SELECAO", name: "TECNICO", newName: "TECNICOGXG");
            RenameColumn(table: "dbo.SELECAO", name: "PAIS", newName: "PAISGXG");
            RenameColumn(table: "dbo.SELECAO", name: "ID", newName: "IDGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "ATIVADO", newName: "ATIVADOGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAALTERACAO", newName: "DATAALTERACAOGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAREGISTRO", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "SELECAOID", newName: "SELECAOIDGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "NASCIMENTO", newName: "NASCIMENTOGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "POSICAO", newName: "POSICAOGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "NOME", newName: "NOMEGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "ID", newName: "IDGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "URL", newName: "URLGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "DATAREGISTRO", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSAO", newName: "SESSAOGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSIONID", newName: "SESSIONIDGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "POST", newName: "POSTGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "GET", newName: "GETGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "USUARIOID", newName: "USUARIOIDGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "IP", newName: "IPGXG");
        }
    }
}
