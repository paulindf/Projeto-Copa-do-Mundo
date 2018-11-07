namespace Projeto_Copa_do_Mundo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacoes6 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AUDITORIA", name: "IP", newName: "IPGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "UsuarioId", newName: "USUARIOIDGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "Get", newName: "GETGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "Post", newName: "POSTGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "SessionId", newName: "SESSIONIDGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "Sessao", newName: "SESSAOGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "DataRegistro", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.AUDITORIA", name: "Url", newName: "URLGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "Id", newName: "IDGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "Nome", newName: "NOMEGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "Posicao", newName: "POSICAOGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "Nascimento", newName: "NASCIMENTOGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "SelecaoId", newName: "SELECAOIDGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "DataRegistro", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "DataAlteracao", newName: "DATAALTERACAOGXG");
            RenameColumn(table: "dbo.JOGADOR", name: "Ativado", newName: "ATIVADOGXG");
            RenameColumn(table: "dbo.SELECAO", name: "Id", newName: "IDGXG");
            RenameColumn(table: "dbo.SELECAO", name: "Pais", newName: "PAISGXG");
            RenameColumn(table: "dbo.SELECAO", name: "Tecnico", newName: "TECNICOGXG");
            RenameColumn(table: "dbo.SELECAO", name: "DataRegistro", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.SELECAO", name: "DataAlteracao", newName: "DATAALTERACAOGXG");
            RenameColumn(table: "dbo.SELECAO", name: "Ativado", newName: "ATIVADOGXG");
            RenameColumn(table: "dbo.USUARIO", name: "Id", newName: "IDGXG");
            RenameColumn(table: "dbo.USUARIO", name: "Nome", newName: "NOMEGXG");
            RenameColumn(table: "dbo.USUARIO", name: "Email", newName: "EMAILGXG");
            RenameColumn(table: "dbo.USUARIO", name: "Senha", newName: "SENHAGXG");
            RenameColumn(table: "dbo.USUARIO", name: "DataRegistro", newName: "DATAREGISTROGXG");
            RenameColumn(table: "dbo.USUARIO", name: "DataAlteracao", newName: "DATAALTERACAOGXG");
            RenameColumn(table: "dbo.USUARIO", name: "Ativado", newName: "ATIVADOGXG");
            RenameIndex(table: "dbo.JOGADOR", name: "IX_SelecaoId", newName: "IX_SELECAOIDGXG");
            AlterColumn("dbo.AUDITORIA", "IPGXG", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AUDITORIA", "GETGXG", c => c.String(maxLength: 1000, unicode: false));
            AlterColumn("dbo.AUDITORIA", "POSTGXG", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.AUDITORIA", "SESSIONIDGXG", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AUDITORIA", "SESSAOGXG", c => c.String(maxLength: 1000, unicode: false));
            AlterColumn("dbo.AUDITORIA", "URLGXG", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.JOGADOR", "NOMEGXG", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.JOGADOR", "POSICAOGXG", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.JOGADOR", "NASCIMENTOGXG", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.SELECAO", "PAISGXG", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.SELECAO", "TECNICOGXG", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.USUARIO", "NOMEGXG", c => c.String(nullable: false, maxLength: 300, unicode: false));
            AlterColumn("dbo.USUARIO", "EMAILGXG", c => c.String(nullable: false, maxLength: 70, unicode: false));
            AlterColumn("dbo.USUARIO", "SENHAGXG", c => c.String(nullable: false, maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.USUARIO", "SENHAGXG", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.USUARIO", "EMAILGXG", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.USUARIO", "NOMEGXG", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.SELECAO", "TECNICOGXG", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.SELECAO", "PAISGXG", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.JOGADOR", "NASCIMENTOGXG", c => c.DateTime(nullable: false));
            AlterColumn("dbo.JOGADOR", "POSICAOGXG", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.JOGADOR", "NOMEGXG", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.AUDITORIA", "URLGXG", c => c.String(maxLength: 500));
            AlterColumn("dbo.AUDITORIA", "SESSAOGXG", c => c.String(maxLength: 1000));
            AlterColumn("dbo.AUDITORIA", "SESSIONIDGXG", c => c.String(maxLength: 50));
            AlterColumn("dbo.AUDITORIA", "POSTGXG", c => c.String());
            AlterColumn("dbo.AUDITORIA", "GETGXG", c => c.String(maxLength: 1000));
            AlterColumn("dbo.AUDITORIA", "IPGXG", c => c.String(maxLength: 20));
            RenameIndex(table: "dbo.JOGADOR", name: "IX_SELECAOIDGXG", newName: "IX_SelecaoId");
            RenameColumn(table: "dbo.USUARIO", name: "ATIVADOGXG", newName: "Ativado");
            RenameColumn(table: "dbo.USUARIO", name: "DATAALTERACAOGXG", newName: "DataAlteracao");
            RenameColumn(table: "dbo.USUARIO", name: "DATAREGISTROGXG", newName: "DataRegistro");
            RenameColumn(table: "dbo.USUARIO", name: "SENHAGXG", newName: "Senha");
            RenameColumn(table: "dbo.USUARIO", name: "EMAILGXG", newName: "Email");
            RenameColumn(table: "dbo.USUARIO", name: "NOMEGXG", newName: "Nome");
            RenameColumn(table: "dbo.USUARIO", name: "IDGXG", newName: "Id");
            RenameColumn(table: "dbo.SELECAO", name: "ATIVADOGXG", newName: "Ativado");
            RenameColumn(table: "dbo.SELECAO", name: "DATAALTERACAOGXG", newName: "DataAlteracao");
            RenameColumn(table: "dbo.SELECAO", name: "DATAREGISTROGXG", newName: "DataRegistro");
            RenameColumn(table: "dbo.SELECAO", name: "TECNICOGXG", newName: "Tecnico");
            RenameColumn(table: "dbo.SELECAO", name: "PAISGXG", newName: "Pais");
            RenameColumn(table: "dbo.SELECAO", name: "IDGXG", newName: "Id");
            RenameColumn(table: "dbo.JOGADOR", name: "ATIVADOGXG", newName: "Ativado");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAALTERACAOGXG", newName: "DataAlteracao");
            RenameColumn(table: "dbo.JOGADOR", name: "DATAREGISTROGXG", newName: "DataRegistro");
            RenameColumn(table: "dbo.JOGADOR", name: "SELECAOIDGXG", newName: "SelecaoId");
            RenameColumn(table: "dbo.JOGADOR", name: "NASCIMENTOGXG", newName: "Nascimento");
            RenameColumn(table: "dbo.JOGADOR", name: "POSICAOGXG", newName: "Posicao");
            RenameColumn(table: "dbo.JOGADOR", name: "NOMEGXG", newName: "Nome");
            RenameColumn(table: "dbo.JOGADOR", name: "IDGXG", newName: "Id");
            RenameColumn(table: "dbo.AUDITORIA", name: "URLGXG", newName: "Url");
            RenameColumn(table: "dbo.AUDITORIA", name: "DATAREGISTROGXG", newName: "DataRegistro");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSAOGXG", newName: "Sessao");
            RenameColumn(table: "dbo.AUDITORIA", name: "SESSIONIDGXG", newName: "SessionId");
            RenameColumn(table: "dbo.AUDITORIA", name: "POSTGXG", newName: "Post");
            RenameColumn(table: "dbo.AUDITORIA", name: "GETGXG", newName: "Get");
            RenameColumn(table: "dbo.AUDITORIA", name: "USUARIOIDGXG", newName: "UsuarioId");
            RenameColumn(table: "dbo.AUDITORIA", name: "IPGXG", newName: "IP");
        }
    }
}
