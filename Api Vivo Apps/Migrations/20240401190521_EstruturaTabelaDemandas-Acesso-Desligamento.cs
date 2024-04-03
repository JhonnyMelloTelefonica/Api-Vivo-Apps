using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations
{
    /// <inheritdoc />
    public partial class EstruturaTabelaDemandasAcessoDesligamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Demandas");

            migrationBuilder.CreateTable(
                name: "DEMANDA_PARQUE",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DS_SGMN_CLNT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NU_TLFN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NU_ANO_MES = table.Column<int>(type: "int", unicode: false, maxLength: 10, nullable: false),
                    DS_ORIG_PRDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SG_UF = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NU_DDD = table.Column<int>(type: "int", unicode: false, maxLength: 10, nullable: false),
                    ID_PLNO = table.Column<int>(type: "int", nullable: false),
                    DS_DCTO_PRNC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_PARQUE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_RELACAO_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    Tabela = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_RELACAO_CHAMADO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_ACESSOS",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATRICULA_SOLICITANTE = table.Column<int>(type: "int", nullable: false),
                    Acao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoAcesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adabas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgaoEmissor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeContato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataContratoInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataContratoFim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ddd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinalizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExtracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileToken = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejeitarSenha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AceiteSenha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataStatus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NomeMae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataMatricula = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_ACESSOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DEMANDA_ACESSOS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_FILA_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: true),
                    MATRICULA_SOLICITANTE = table.Column<int>(type: "int", unicode: false, nullable: false),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_FECHAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRIORIDADE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CLIENTE_ALTO_VALOR = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CHAMADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_DEMANDA_PARQUE_CLIENTE_ALTO_VALOR",
                        column: x => x.CLIENTE_ALTO_VALOR,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_PARQUE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_DEMANDA_SUB_FILA_ID_FILA_CHAMADO",
                        column: x => x.ID_FILA_CHAMADO,
                        principalTable: "DEMANDA_SUB_FILA",
                        principalColumn: "ID_SUB_FILA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_CHAMADO_RESPOSTA",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESPOSTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    ID_RELACAO_CHAMADO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    DATA_RESPOSTA = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CHAMADO_RESPOSTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_RESPOSTA_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_RESPOSTA_DEMANDA_RELACAO_CHAMADO_ID_RELACAO_CHAMADO",
                        column: x => x.ID_RELACAO_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_DESLIGAMENTOS",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATRICULA_SOLICITANTE = table.Column<int>(type: "int", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOME_FUNCIONARIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MATRICULA_FUNCIONARIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOGIN_FUNCIONARIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA_CADASTRO_DESLIGAMENTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CONFIRMA_DESLIGAMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA_CONFIRMA_DESLIGAMENTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USUARIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADABAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTIVO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_DESLIGAMENTOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_DESLIGAMENTOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DEMANDA_DESLIGAMENTOS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_AVALIACAO_ANALISTA",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATRICULA_AVALIADOR = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_ANALISTA = table.Column<int>(type: "int", nullable: false),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    PROBLEMA_RESOLVIDO = table.Column<bool>(type: "bit", nullable: false),
                    AVALIACAO_ANALISTA = table.Column<int>(type: "int", unicode: false, nullable: false),
                    AVALIACAO_PLATAFORMA = table.Column<int>(type: "int", unicode: false, nullable: false),
                    AVALIACAO_GERAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_AVALIACAO_ANALISTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_AVALIACAO_ANALISTA_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_CAMPOS_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    VALOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CAMPOS_CHAMADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CAMPOS_CHAMADO_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_HISTORICO_PRIORIDADE",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MAT_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    PRIORIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_HISTORICO_PRIORIDADE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_HISTORICO_PRIORIDADE_ACESSOS_MOBILE_MAT_RESPONSAVEL",
                        column: x => x.MAT_RESPONSAVEL,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DEMANDA_HISTORICO_PRIORIDADE_DEMANDA_CHAMADO_ID_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_ARQUIVOS_RESPOSTA",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RESPOSTA = table.Column<int>(type: "int", nullable: false),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_ARQUIVOS_RESPOSTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_ARQUIVOS_RESPOSTA_DEMANDA_CHAMADO_RESPOSTA_ID_RESPOSTA",
                        column: x => x.ID_RESPOSTA,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO_RESPOSTA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_STATUS_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    ID_RELACAO_CHAMADO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_RESPOSTA = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MAT_QUEM_REDIRECIONOU = table.Column<int>(type: "int", unicode: false, nullable: true),
                    MAT_DESTINATARIO = table.Column<int>(type: "int", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_STATUS_CHAMADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_ACESSOS_MOBILE_MAT_DESTINATARIO",
                        column: x => x.MAT_DESTINATARIO,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_ACESSOS_MOBILE_MAT_QUEM_REDIRECIONOU",
                        column: x => x.MAT_QUEM_REDIRECIONOU,
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_CHAMADO_RESPOSTA_ID_RESPOSTA",
                        column: x => x.ID_RESPOSTA,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO_RESPOSTA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO_CHAMADO",
                        column: x => x.ID_RELACAO_CHAMADO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ACESSOS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "ID_RELACAO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ACESSOS_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_SOLICITANTE");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ARQUIVOS_RESPOSTA_ID_RESPOSTA",
                schema: "Demandas",
                table: "DEMANDA_ARQUIVOS_RESPOSTA",
                column: "ID_RESPOSTA");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_AVALIACAO_ANALISTA_ID_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_AVALIACAO_ANALISTA",
                column: "ID_CHAMADO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CAMPOS_CHAMADO_ID_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CAMPOS_CHAMADO",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_CLIENTE_ALTO_VALOR",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "CLIENTE_ALTO_VALOR");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_ID_FILA_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "ID_FILA_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "ID_RELACAO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "MATRICULA_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO",
                column: "MATRICULA_SOLICITANTE");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_RESPOSTA_ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                column: "ID_RELACAO_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_CHAMADO_RESPOSTA_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                column: "MATRICULA_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_DESLIGAMENTOS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                column: "ID_RELACAO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_DESLIGAMENTOS_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                column: "MATRICULA_SOLICITANTE");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_HISTORICO_PRIORIDADE_ID_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_HISTORICO_PRIORIDADE",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_HISTORICO_PRIORIDADE_MAT_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_HISTORICO_PRIORIDADE",
                column: "MAT_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_ID_RELACAO_CHAMADO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "ID_RELACAO_CHAMADO",
                unique:true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_ID_RESPOSTA",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "ID_RESPOSTA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_MAT_DESTINATARIO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "MAT_DESTINATARIO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_MAT_QUEM_REDIRECIONOU",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "MAT_QUEM_REDIRECIONOU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEMANDA_ACESSOS",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_ARQUIVOS_RESPOSTA",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_AVALIACAO_ANALISTA",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CAMPOS_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_DESLIGAMENTOS",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_HISTORICO_PRIORIDADE",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_STATUS_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CHAMADO_RESPOSTA",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_PARQUE",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_RELACAO_CHAMADO",
                schema: "Demandas");
        }
    }
}
