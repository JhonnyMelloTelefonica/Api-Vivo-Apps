using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vivo_Apps_API.Migrations.Vivo_Mais
{
    /// <inheritdoc />
    public partial class InsertNomeSocial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "Demandas");

            migrationBuilder.CreateTable(
                name: "A_QUEM_RECORRER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AREA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    NOME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    CELULAR = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    RAMAL = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ATIVIDADES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    STATUS = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    FUNCAO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    EXTENSAO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__A_QUEM_R__3214EC27335592AB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_ACOMPANHAMENTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROTOCOLO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NUMERO_PROTOCOLO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DOC_SAP = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_SOLICITACAO_PROTOCOLO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_VENCIMENTO_PROTOCOLO = table.Column<DateTime>(type: "datetime", nullable: true),
                    REL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_SOLICITACAO_REL = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_VENCIMENTO_REL = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_UPLOAD_PROCESSO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIADO_PARA_SUPORTE = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECEBIDO_SUPORTE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIADO_PARA_MKT = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIADO_QUALIDADE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIADO_CANAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIADO_MKT = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIADO_SUPORTE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIADO_JU = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS_PAGAMENTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OBS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_STATUS = table.Column<DateTime>(type: "datetime", nullable: false),
                    RECEBIDO_QUALIDADE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    STATUS_AUDITORIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_ACO__3214EC074DD47EBD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_CADASTRO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    regional = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    praca = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    idTipo = table.Column<int>(type: "int", nullable: false),
                    idDetalhada = table.Column<int>(type: "int", nullable: false),
                    veiculo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    descricaoAcao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    dia1 = table.Column<int>(type: "int", nullable: true),
                    dia2 = table.Column<int>(type: "int", nullable: true),
                    dia3 = table.Column<int>(type: "int", nullable: true),
                    dia4 = table.Column<int>(type: "int", nullable: true),
                    dia5 = table.Column<int>(type: "int", nullable: true),
                    dia6 = table.Column<int>(type: "int", nullable: true),
                    dia7 = table.Column<int>(type: "int", nullable: true),
                    dia8 = table.Column<int>(type: "int", nullable: true),
                    dia9 = table.Column<int>(type: "int", nullable: true),
                    dia10 = table.Column<int>(type: "int", nullable: true),
                    dia11 = table.Column<int>(type: "int", nullable: true),
                    dia12 = table.Column<int>(type: "int", nullable: true),
                    dia13 = table.Column<int>(type: "int", nullable: true),
                    dia14 = table.Column<int>(type: "int", nullable: true),
                    dia15 = table.Column<int>(type: "int", nullable: true),
                    dia16 = table.Column<int>(type: "int", nullable: true),
                    dia17 = table.Column<int>(type: "int", nullable: true),
                    dia18 = table.Column<int>(type: "int", nullable: true),
                    dia19 = table.Column<int>(type: "int", nullable: true),
                    dia20 = table.Column<int>(type: "int", nullable: true),
                    dia21 = table.Column<int>(type: "int", nullable: true),
                    dia22 = table.Column<int>(type: "int", nullable: true),
                    dia23 = table.Column<int>(type: "int", nullable: true),
                    dia24 = table.Column<int>(type: "int", nullable: true),
                    dia25 = table.Column<int>(type: "int", nullable: true),
                    dia26 = table.Column<int>(type: "int", nullable: true),
                    dia27 = table.Column<int>(type: "int", nullable: true),
                    dia28 = table.Column<int>(type: "int", nullable: true),
                    dia29 = table.Column<int>(type: "int", nullable: true),
                    dia30 = table.Column<int>(type: "int", nullable: true),
                    dia31 = table.Column<int>(type: "int", nullable: true),
                    campanhaMacro = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    mesAcao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    midiaExclusivaVivo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    valorTotalAcao = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    valorTotalVivo = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    percentParticipacaoVivo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    justificativa = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    focoPrincipal = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    qtdAcoes = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    insercoes = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    origemVerba = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    observacoes = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    idStatus = table.Column<int>(type: "int", nullable: false),
                    idAcesso = table.Column<int>(type: "int", nullable: false),
                    idAcessoCadastro = table.Column<int>(type: "int", nullable: false),
                    formatoMaterial = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CustoUnitario = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    dataFinalizacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Protocolo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IXO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomeContatoRede = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TelefoneContatoRede = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailContatoRede = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Consideracao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataPreenchimentoInicial = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataPreenchimentoFinal = table.Column<DateTime>(type: "datetime", nullable: true),
                    PercentualRede = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ValorTotalRede = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DevolucaoMarketing = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataValidacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_CAD__3213E83F5AB9788F", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_DOCUMENTACAO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATACADASTRO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PROTOCOLO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DOCUMENTOS = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    EXTENSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DT_APROVACAO_SUPORTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBS_APROVACAO_SUPORTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    STATUS_SUPORTE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DT_APROVACAO_QUALIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBS_APROVACAO_QUALIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    STATUS_QUALIDADE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DT_APROVACAO_MKT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBS_APROVACAO_MKT = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    STATUS_MKT = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_DOC__3213E83F08362A7C", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_LAYOUT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATACADASTRO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PROTOCOLO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DOCUMENTOS = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    EXTENSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    STATUS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_LAY__3213E83F78F3E6EC", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_MIDIA_DETALHADA",
                columns: table => new
                {
                    idTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    idTipoMidia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_MID__BDD0DFE13D2915A8", x => x.idTipo);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_SALDO_REDE",
                columns: table => new
                {
                    Rede = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Saldo_VPC = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Saldo_VIO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataInput = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACAO_STATUS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_STA__3213E83F395884C4", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_TIPO_MIDIA",
                columns: table => new
                {
                    idTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_TIP__BDD0DFE13587F3E0", x => x.idTipo);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_VALOR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDVPC = table.Column<int>(type: "int", nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ORIGEM_VERBA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    REDE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_VAL__3214EC275224328E", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ACESSO",
                columns: table => new
                {
                    idAcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Senha = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: true),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Primeiro_Acesso = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSO__CAAB807D0519C6AF", x => x.idAcesso);
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_CARGO_PERFIL",
                columns: table => new
                {
                    GERÊNCIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescricaoMenu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipoAcesso = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_TERCEIROS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TipoAcesso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Rua = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Numero = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Complemento = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Cep = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Celular = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NomeContato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SubGrupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataContratoInicio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataContratoFim = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubArea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataFinalizacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataExtracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Login = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Senha = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Obs = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Perfil = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Funcao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobileToken = table.Column<DateTime>(type: "datetime", nullable: true),
                    RejeitarSenha = table.Column<DateTime>(type: "datetime", nullable: true),
                    AceiteSenha = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Status = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DataStatus = table.Column<DateTime>(type: "datetime", nullable: true),
                    NomeMae = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DataMatricula = table.Column<DateTime>(type: "datetime", nullable: true),
                    Origem = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PIS = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    EstadoPrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CidadePrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EMAILPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GESTORLIDER = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TELEFONEPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSO_T__3214EC07758D6A5C", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_TERCEIROS_ALIADOS",
                columns: table => new
                {
                    Empresa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tipo_Terceiros = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Desc_Tipo_Terceiros = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Desc_Status_Terc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nr_CPF = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NR_Pessoal = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Documento_Compra = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nome_Fornecedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJ_Fornecedor = table.Column<double>(type: "float", nullable: true),
                    CNPJ_SubContrat = table.Column<double>(type: "float", nullable: true),
                    InValDocCompra = table.Column<double>(type: "float", nullable: true),
                    Fim_Val_Doc_Compra = table.Column<double>(type: "float", nullable: true),
                    Val_Desde = table.Column<double>(type: "float", nullable: true),
                    Valido_Ate = table.Column<double>(type: "float", nullable: true),
                    Unidade_Org_Gerente = table.Column<double>(type: "float", nullable: true),
                    Desc_Un_Org_Gerente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Desc_C_C_Gerente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nome_Gerente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email_Gerente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nome_Solicitante = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email_Solicitante = table.Column<string>(name: "Email _Solicitante", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Desc_Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Desc_Ramo_Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Grupo_Atendimento = table.Column<double>(type: "float", nullable: true),
                    Descricao_Grupo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Area_RH = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Desc_Area_RH = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Desc_Subarea_RH = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Descricao_Dependencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Descricao_Servico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Nasc = table.Column<double>(type: "float", nullable: true),
                    Nacionalide = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Criacao = table.Column<double>(type: "float", nullable: true),
                    Responsavel_Cadastro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Subgrupo_Dealers = table.Column<double>(type: "float", nullable: true),
                    Responsavel_Cadastro1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fornecedor_Dealer = table.Column<double>(type: "float", nullable: true),
                    Fornecedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_TERCEIROS_OBSERVACAO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_ACESSO_TERCEIRO = table.Column<int>(type: "int", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DATA_INICIO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DATA_FIM = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSO_T__3214EC2770C8B53F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_TERCEIROS_SISTEMAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Acesso = table.Column<int>(type: "int", nullable: true),
                    Sistema = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Senha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AceiteSenha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RejeitarSenha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataSenha = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSO_T__3214EC0705E3CDB6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_TERCEIROS_SLA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_ACESSO = table.Column<int>(type: "int", nullable: true),
                    DATA_PARADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_RETORNO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_SOLICITANTE = table.Column<int>(type: "int", nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSO_T__3214EC274AE30379", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_TERCEIROS_TESTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TipoAcesso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Rua = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Numero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cep = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Celular = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NomeContato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SubGrupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataContratoInicio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataContratoFim = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubArea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataFinalizacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataExtracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Senha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Obs = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Perfil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Funcao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobileToken = table.Column<DateTime>(type: "datetime", nullable: true),
                    RejeitarSenha = table.Column<DateTime>(type: "datetime", nullable: true),
                    AceiteSenha = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataStatus = table.Column<DateTime>(type: "datetime", nullable: true),
                    NomeMae = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DataMatricula = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sistemas = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Origem = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSO_T__3214EC077A721B0A", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ACESSOS_DANI",
                columns: table => new
                {
                    NOME = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RE = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    DATA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    USUARIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CARGO = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACESSOS_MOBILE",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MATRICULA = table.Column<int>(type: "int", nullable: false),
                    SENHA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CARGO = table.Column<int>(type: "int", nullable: false),
                    CANAL = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PDV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    STATUS = table.Column<bool>(type: "bit", nullable: true),
                    FIXA = table.Column<bool>(type: "bit", nullable: true),
                    TP_AFASTAMENTO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    OBS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UserAvatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LOGIN_MOD = table.Column<int>(type: "int", nullable: true),
                    DT_MOD = table.Column<DateTime>(type: "datetime", nullable: true),
                    ELEGIVEL = table.Column<bool>(type: "bit", nullable: true),
                    DDD = table.Column<int>(type: "int", nullable: true),
                    TP_STATUS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSOS___3214EC27413AC42D", x => x.ID);
                    table.UniqueConstraint("AK_ACESSOS_MOBILE_MATRICULA", x => x.MATRICULA);
                });

            migrationBuilder.CreateTable(
                name: "ADMISSAO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uf = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Matricula = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Candidato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    Cargo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Gestor = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Loja = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataAdmissao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NomeMae = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ALTA_SEM_TRAFEGO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANOMES = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NU_ANO_MES_RFRN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DIVISAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DS_SGMT_PRDT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DS_PRDT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DS_CTGR_PRDT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NO_PLNO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_CRDN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NO_REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_VEND = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERENTE_CONTAS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERENTE_TERRITORIAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEFANTASIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QT_TOTL_FSCO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QT_LNHA_TRFG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QT_PRQE_ANTR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_SEM_TRFG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NU_TLFN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALTA_SEM_TRAFEGO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "APARELHO_CHIP_BOLETA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBoleta = table.Column<int>(type: "int", nullable: true),
                    IMEI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CodMaterial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CodFat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Protocolo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LinhaChip = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CodFatChip = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ICCID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "API_CACHE",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(449)", maxLength: 449, nullable: false),
                    Value = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ExpiresAtTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SlidingExpirationInSeconds = table.Column<long>(type: "bigint", nullable: true),
                    AbsoluteExpiration = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__API_CACH__3214EC07E3A79E4D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "APROVADORES$",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SeçãoTerritorial = table.Column<string>(name: "Seção Territorial", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UnidadeGestorOperacional = table.Column<double>(name: "Unidade Gestor Operacional", type: "float", nullable: true),
                    UnidadeGestorContrato = table.Column<double>(name: "Unidade Gestor Contrato", type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ARQUIVOS_FAT_MANUAL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FAT = table.Column<int>(type: "int", nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ARQUIVOS__3214EC275EAB83BD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ARQUIVOS_PRESTACAO_COMPROVANTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PRESTACAO = table.Column<int>(type: "int", nullable: false),
                    DIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VALOR = table.Column<double>(type: "float", nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BAIRROS",
                columns: table => new
                {
                    bairro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cidade_id = table.Column<int>(type: "int", nullable: false),
                    desc_bairro = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE CONTROLE DE DEMANDAS MG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOMERESPONSAVEL = table.Column<string>(name: "NOME RESPONSAVEL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    MATRICULA_SOLICITANTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOMESOLICITANTE = table.Column<string>(name: "NOME SOLICITANTE", type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TIPOFILA = table.Column<string>(name: "TIPO FILA", type: "varchar(max)", unicode: false, nullable: true),
                    TIPOCHAMADO = table.Column<string>(name: "TIPO CHAMADO", type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CAMPO_COMBOBOX = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OPÇÃOSELECIONADA = table.Column<string>(name: "OPÇÃO SELECIONADA", type: "varchar(max)", unicode: false, nullable: true),
                    STATUSATUAL = table.Column<string>(name: "STATUS ATUAL", type: "varchar(max)", unicode: false, nullable: false),
                    DATASTATUSATUAL = table.Column<DateTime>(name: "DATA STATUS ATUAL", type: "datetime", nullable: true),
                    MOTIVOFECHAMENTO = table.Column<string>(name: "MOTIVO FECHAMENTO", type: "varchar(max)", unicode: false, nullable: true),
                    DESCRICAO_PROBLEMA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DESCRICAO_SOLUCAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    DTDATAABERTURA = table.Column<DateTime>(name: "DT DATA ABERTURA", type: "datetime", nullable: true),
                    DTPRIMEIRARESPOSTA = table.Column<DateTime>(name: "DT PRIMEIRA RESPOSTA", type: "datetime", nullable: true),
                    DTFINALIZACAO = table.Column<DateTime>(name: "DT FINALIZACAO", type: "datetime", nullable: true),
                    SLAUTIL1RESPOSTA = table.Column<int>(name: "SLA UTIL 1 RESPOSTA", type: "int", nullable: true),
                    SLAUTILFECHAMENTO = table.Column<int>(name: "SLA UTIL FECHAMENTO", type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_DEPOSITO_DASH",
                columns: table => new
                {
                    CENTRO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DEPOSITO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CHAVE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CHAVE_TRAM = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CANAL = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    REGIAO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    REDE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    LOCAL = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    REDE_JANE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CLUSTER = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_FFCARGO",
                columns: table => new
                {
                    CODIGOCARGO = table.Column<string>(name: "CODIGO CARGO", type: "varchar(max)", unicode: false, nullable: true),
                    DESCRICAOCARGO = table.Column<string>(name: "DESCRICAO CARGO", type: "varchar(max)", unicode: false, nullable: true),
                    DATAENTRADA = table.Column<DateTime>(name: "DATA ENTRADA", type: "date", nullable: true),
                    DATASAIDA = table.Column<string>(name: "DATA SAIDA", type: "varchar(max)", unicode: false, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PERCENTUALFERIAS = table.Column<double>(name: "PERCENTUAL FERIAS", type: "float", nullable: true),
                    NOMEGERENTE = table.Column<string>(name: "NOME GERENTE", type: "varchar(max)", unicode: false, nullable: true),
                    CLUSTER = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    COORDENADOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CONSULTOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDEDORINSTÂNCIA = table.Column<string>(name: "VENDEDOR INSTÂNCIA", type: "varchar(max)", unicode: false, nullable: true),
                    CANALDEVENDAS = table.Column<string>(name: "CANAL DE VENDAS", type: "varchar(max)", unicode: false, nullable: true),
                    GRUPOCANAL = table.Column<string>(name: "GRUPO CANAL", type: "varchar(max)", unicode: false, nullable: true),
                    GRUPOCANAL2 = table.Column<string>(name: "GRUPO CANAL 2", type: "varchar(max)", unicode: false, nullable: true),
                    REGIONAIS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    REGIONALTELE = table.Column<string>(name: "REGIONAL/TELE", type: "varchar(max)", unicode: false, nullable: true),
                    LOGINCOORDENADOR = table.Column<string>(name: "LOGIN COORDENADOR", type: "varchar(max)", unicode: false, nullable: true),
                    LOGINGERENTE = table.Column<string>(name: "LOGIN GERENTE", type: "varchar(max)", unicode: false, nullable: true),
                    LOGINDIRETOR = table.Column<string>(name: "LOGIN DIRETOR", type: "varchar(max)", unicode: false, nullable: true),
                    NOMEDIRETOR = table.Column<string>(name: "NOME DIRETOR", type: "varchar(max)", unicode: false, nullable: true),
                    GRUPOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CONTRATO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SEGUNDO_LOGIN = table.Column<double>(type: "float", nullable: true),
                    ADABASMÓVEL = table.Column<string>(name: "ADABAS MÓVEL", type: "varchar(max)", unicode: false, nullable: true),
                    ADABASFIXA = table.Column<string>(name: "ADABAS FIXA", type: "varchar(max)", unicode: false, nullable: true),
                    RECEBEDOR_SAP = table.Column<double>(type: "float", nullable: true),
                    GRUPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_GSS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD = table.Column<double>(type: "float", nullable: true),
                    Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SituaçãoLoja = table.Column<string>(name: "Situação Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    Hora = table.Column<DateTime>(type: "datetime", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Celular = table.Column<double>(type: "float", nullable: true),
                    ClienteX = table.Column<string>(name: "Cliente X", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipoCliente = table.Column<string>(name: "Tipo Cliente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Segmento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Categoria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nomedoatendente = table.Column<string>(name: "Nome do atendente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Motivodadesistência = table.Column<string>(name: "Motivo da desistência", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Painel = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tempodeespera = table.Column<DateTime>(name: "Tempo de espera", type: "datetime", nullable: true),
                    TME = table.Column<DateTime>(type: "datetime", nullable: true),
                    Inícioatendconsultor = table.Column<DateTime>(name: "Início atend consultor", type: "datetime", nullable: true),
                    Conclusaoconsultor = table.Column<DateTime>(name: "Conclusao consultor", type: "datetime", nullable: true),
                    Tempodeatendimentoconsultor = table.Column<DateTime>(name: "Tempo de atendimento consultor", type: "datetime", nullable: true),
                    TMA = table.Column<DateTime>(type: "datetime", nullable: true),
                    Totem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Detalhes1 = table.Column<string>(name: "Detalhes 1", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Detalhes2 = table.Column<string>(name: "Detalhes 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Detalhes3 = table.Column<string>(name: "Detalhes 3", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Detalhes4 = table.Column<string>(name: "Detalhes 4", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Detalhes5 = table.Column<string>(name: "Detalhes 5", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Protocolo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Observações = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InícioAtendRetaguarda = table.Column<string>(name: "Início Atend Retaguarda", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ConclusãoRetaguarda = table.Column<string>(name: "Conclusão Retaguarda", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TempodeAtendimentoRetaguarda = table.Column<string>(name: "Tempo de Atendimento Retaguarda", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TMARetaguarda = table.Column<string>(name: "TMA Retaguarda", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TempoTotaldeAtendimento = table.Column<string>(name: "Tempo Total de Atendimento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TMATotal = table.Column<string>(name: "TMA Total", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomedoAtendenteRetaguarda = table.Column<string>(name: "Nome do Atendente Retaguarda", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CpfdoAtendenteRetaguarda = table.Column<string>(name: "Cpf do Atendente Retaguarda", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CpfdoAtendente = table.Column<string>(name: "Cpf do Atendente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Statusdoatendente = table.Column<string>(name: "Status do atendente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ClienteVivo = table.Column<string>(name: "Cliente Vivo", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AtendimentoporExceção = table.Column<string>(name: "Atendimento por Exceção", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Callback = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Feriado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LojaSAP = table.Column<string>(name: "Loja SAP", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipoDocumento = table.Column<string>(name: "Tipo Documento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NúmeroDocumento = table.Column<string>(name: "Número Documento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CategoriaAtividade = table.Column<string>(name: "Categoria Atividade", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReenviodeSenhasporSMS = table.Column<string>(name: "Reenvio de Senhas por SMS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SenhasReenviadasporSMS = table.Column<string>(name: "Senhas Reenviadas por SMS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Reimpressãodesenha = table.Column<string>(name: "Reimpressão de senha", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SenhasReimpressas = table.Column<string>(name: "Senhas Reimpressas", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SenhaporSMS = table.Column<string>(name: "Senha por SMS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Contato_Realizado = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Data_Contato = table.Column<DateTime>(type: "datetime", nullable: true),
                    CN_Contato = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Recebeu_Pesquisa = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Houve_Reclamacao = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Descricao_Reclamacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BASE_GSS__3214EC27736A8770", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BASE_META_CN",
                columns: table => new
                {
                    RE = table.Column<double>(type: "float", nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SIGLACARGO = table.Column<string>(name: "SIGLA CARGO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PAGAMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMELOJA = table.Column<string>(name: "NOME LOJA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MÓVEL = table.Column<double>(type: "float", nullable: true),
                    FIXO = table.Column<double>(type: "float", nullable: true),
                    SVA = table.Column<double>(type: "float", nullable: true),
                    TERMINAIS = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DATA_CARGA = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_NOMECLATURA_SAP_LLPP",
                columns: table => new
                {
                    CENTRO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ESCV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME_SAP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME_CARTEIRA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_PARCEIROS_PAP",
                columns: table => new
                {
                    Função = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MatriculaSAP = table.Column<double>(name: "Matricula SAP", type: "float", nullable: true),
                    PIS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estadocivíl = table.Column<string>(name: "Estado civíl", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RG = table.Column<double>(type: "float", nullable: true),
                    ÓrgãoEmissor = table.Column<string>(name: "Órgão Emissor", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataNascimento = table.Column<DateTime>(name: "Data Nascimento", type: "datetime", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Passaporte = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NºTelefone = table.Column<double>(name: "Nº Telefone", type: "float", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DatadeAdmissão = table.Column<DateTime>(name: "Data de Admissão", type: "datetime", nullable: true),
                    Email = table.Column<string>(name: "E-mail", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPFLíder = table.Column<string>(name: "CPF Líder", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Regional = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Adabás = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeSolicitante = table.Column<string>(name: "Nome Solicitante", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPFSolicitante = table.Column<string>(name: "CPF Solicitante", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FunçãoSolicitante = table.Column<string>(name: "Função Solicitante", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataSolicitação = table.Column<DateTime>(name: "Data Solicitação", type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MotivoDadosInválidos = table.Column<string>(name: "Motivo Dados Inválidos", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ação = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DatadaÚltimaMovimentação = table.Column<DateTime>(name: "Data da Última Movimentação", type: "datetime", nullable: true),
                    NomeUsuáriodoCancelamento = table.Column<string>(name: "Nome Usuário do Cancelamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPFUsuáriodoCancelamento = table.Column<string>(name: "CPF Usuário do Cancelamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DatadoCancelamento = table.Column<DateTime>(name: "Data do Cancelamento", type: "datetime", nullable: true),
                    MotivodoCancelamento = table.Column<string>(name: "Motivo do Cancelamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ObservaçõesdeAtualização = table.Column<string>(name: "Observações de Atualização", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_PROJETO_LORENA",
                columns: table => new
                {
                    RE = table.Column<double>(type: "float", nullable: true),
                    CPF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Nome = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FUNÇÃO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Regional = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Rede = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PDVAdabas = table.Column<string>(name: "PDV - Adabas", type: "varchar(max)", unicode: false, nullable: true),
                    PDVLoginSiebel = table.Column<string>(name: "PDV - Login Siebel", type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_SIGITIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEQUENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ORIGEM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_CRIACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ALARME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SIGLA_ESTADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_DE_BAIXA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    HOST = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IMPACTO_EQP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ENDERECO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_MUNICIPIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TIPO_DE_PLANTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VTAPK = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BASE_SIG__3214EC270DC158E0", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BASE_SIGITIM_SUL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_ESTADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_MUNICIPIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Sequencia = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Origem = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Raiz = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tecnologia = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCriacao = table.Column<string>(name: "Data Criacao", type: "varchar(max)", unicode: false, nullable: true),
                    DataEncerramento = table.Column<string>(name: "Data Encerramento", type: "varchar(max)", unicode: false, nullable: true),
                    TipoPlanta = table.Column<string>(name: "Tipo Planta", type: "varchar(max)", unicode: false, nullable: true),
                    TipoAfetacao = table.Column<string>(name: "Tipo Afetacao", type: "varchar(max)", unicode: false, nullable: true),
                    VTAPK = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BASE_SIG__3214EC2769014BBA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BASE_TERCEIROS_SAP_GT",
                columns: table => new
                {
                    Mês = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipodeTerceiros = table.Column<string>(name: "Tipo de Terceiros", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescTpTerceiros = table.Column<string>(name: "Desc# Tp Terceiros", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescStatusdoTerc = table.Column<string>(name: "Desc Status do Terc", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NúmerodoCPF = table.Column<string>(name: "Número do CPF", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PISPASEP = table.Column<string>(name: "PIS/PASEP", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nºpessoal = table.Column<double>(name: "Nº pessoal", type: "float", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DocumentodeCompra = table.Column<string>(name: "Documento de Compra", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RaizFornecedor = table.Column<string>(name: "Raiz Fornecedor", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFornecedor = table.Column<string>(name: "Nome - Fornecedor", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RaizSubcontratada = table.Column<string>(name: "Raiz Subcontratada", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeSubContratada = table.Column<string>(name: "Nome - SubContratada", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJFornecedor = table.Column<string>(name: "CNPJ - Fornecedor", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJSubContratada = table.Column<string>(name: "CNPJ - SubContratada", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InValDocCompra = table.Column<string>(name: "In# Val# Doc# Compra", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FimValDocCompra = table.Column<string>(name: "Fim Val# Doc# Compra", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Válidodesde = table.Column<string>(name: "Válido desde", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Válidoaté = table.Column<string>(name: "Válido até", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeVP = table.Column<string>(name: "Nome VP", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dir = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeDir = table.Column<string>(name: "Nome Dir", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UnidadeOrgGerente = table.Column<string>(name: "Unidade Org Gerente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescUnOrgGerente = table.Column<string>(name: "Desc Un# Org Gerente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescrUnidOrg = table.Column<string>(name: "Descr#Unid#Org#", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomedoGerente = table.Column<string>(name: "Nome do Gerente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmaildoGerente = table.Column<string>(name: "E-mail do Gerente", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UnGestordeContrat = table.Column<string>(name: "Un#Gestor de Contrat", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescCCustoGestContra = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescUnidGestora = table.Column<string>(name: "Desc Unid Gestora", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeGestContr = table.Column<string>(name: "Nome - Gest Contr", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmailGestorContrat = table.Column<string>(name: "Email Gestor Contrat", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UnidadeOrgSol = table.Column<string>(name: "Unidade Org Sol", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UnidOrgSolicitante = table.Column<string>(name: "Unid Org Solicitante", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescCCustoSolicit = table.Column<string>(name: "Desc# CCusto Solicit", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeSolicitante = table.Column<string>(name: "Nome Solicitante", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmailSolicitante = table.Column<string>(name: "E-mail  Solicitante", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescAtividade = table.Column<string>(name: "Desc Atividade", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescRamoAtividade = table.Column<string>(name: "Desc# Ramo Atividade", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GrupodeAtendimento = table.Column<double>(name: "Grupo de Atendimento", type: "float", nullable: true),
                    DescriçãodoGrupod = table.Column<string>(name: "Descrição do Grupo d", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescriçãoSiteCall = table.Column<string>(name: "Descrição Site Call", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁreadeRH = table.Column<string>(name: "Área de RH", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescSubáreaRH = table.Column<string>(name: "Desc Subárea RH", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescriçãoDependência = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AndarDep = table.Column<string>(name: "Andar Dep#", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CidadeDep = table.Column<string>(name: "Cidade Dep#", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EstadoDep = table.Column<string>(name: "Estado Dep#", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dedicação = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Espanha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Processo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Subatividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataNasc = table.Column<string>(name: "Data Nasc#", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nacionalid = table.Column<string>(name: "Nacionalid#", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DatadeCriação = table.Column<string>(name: "Data de Criação", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ResponsCadastro = table.Column<string>(name: "Respons# Cadastro", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SubgrupoDealers = table.Column<string>(name: "Subgrupo Dealers", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DatadaModificação = table.Column<string>(name: "Data da Modificação", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UsuárioModificação = table.Column<string>(name: "Usuário Modificação", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fornecedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescEscolaridade = table.Column<string>(name: "Desc# Escolaridade", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcessoFísico = table.Column<string>(name: "Acesso Físico", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcessoLógico = table.Column<string>(name: "Acesso Lógico", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescriçãoContatoco = table.Column<string>(name: "Descrição Contato co", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DT_ATUALIZACAO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_VAT",
                columns: table => new
                {
                    ORIGEMDAVERBA = table.Column<string>(name: "ORIGEM DA VERBA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MES = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD = table.Column<double>(type: "float", nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DISTRIBUICAO = table.Column<string>(name: "DISTRIBUICAO%", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LLPP = table.Column<double>(name: "LLPP %", type: "float", nullable: true),
                    PAPCONDOMINIO = table.Column<double>(name: "PAP / CONDOMINIO %", type: "float", nullable: true),
                    REVENDA = table.Column<double>(name: "REVENDA %", type: "float", nullable: true),
                    VAREJO = table.Column<string>(name: "VAREJO %", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CAMPANHAPRODUTO = table.Column<string>(name: "CAMPANHA/ PRODUTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTRATO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COMBO = table.Column<string>(name: "COMBO ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPODEACAO = table.Column<string>(name: "TIPO DE ACAO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MECANICAOBJETIVO = table.Column<string>(name: "MECANICA OBJETIVO", type: "nvarchar(max)", nullable: true),
                    ITEMLPURESUMIDO = table.Column<string>(name: "ITEM LPU (RESUMIDO)", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RANGELPU = table.Column<string>(name: "RANGE LPU", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Contrato2 = table.Column<string>(name: "Contrato 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CAPITALINTERIORAMOSTRAPRODFINAL = table.Column<string>(name: "CAPITAL / INTERIOR - AMOSTRA / PROD# FINAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Detalhe_Range = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uniddemedida = table.Column<string>(name: "Unid# de medida", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QTDCONT_UNIDMEDIDA = table.Column<double>(name: "QTD CONT /_UNID MEDIDA", type: "float", nullable: true),
                    R_UNITARIO = table.Column<decimal>(name: "R$_UNITARIO", type: "money", nullable: true),
                    RTOTAL_semhonorario = table.Column<decimal>(name: "R$ TOTAL_(sem honorario)", type: "money", nullable: true),
                    _HONORARIO = table.Column<double>(name: "%_HONORARIO", type: "float", nullable: true),
                    R_HONORARIO = table.Column<decimal>(name: "R$_HONORARIO", type: "money", nullable: true),
                    RTOTALHONORARIO = table.Column<decimal>(name: "R$ TOTAL + HONORARIO", type: "money", nullable: true),
                    AGENCIAFORNECEDOR = table.Column<string>(name: "AGENCIA/ FORNECEDOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEDOPARCEIRO = table.Column<string>(name: "NOME DO PARCEIRO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODSAPPARCEIRO = table.Column<double>(name: "COD# SAP PARCEIRO", type: "float", nullable: true),
                    NºPEDIDOHONORARIO = table.Column<double>(name: "Nº PEDIDO - HONORARIO", type: "float", nullable: true),
                    NOMEDOPARCEIRO1 = table.Column<string>(name: "NOME DO PARCEIRO1", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CÓDSAPPARCEIRO = table.Column<double>(name: "CÓD# SAP PARCEIRO", type: "float", nullable: true),
                    NºPEDIDOSERVIÇOMATERIAL = table.Column<double>(name: "Nº  PEDIDO SERVIÇO/MATERIAL", type: "float", nullable: true),
                    CENTRODECUSTO = table.Column<string>(name: "CENTRO DE CUSTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADABAS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAINICIODAAÇÃO = table.Column<DateTime>(name: "DATA INICIO DA AÇÃO", type: "datetime", nullable: true),
                    DATAFINALDAAÇÃO = table.Column<DateTime>(name: "DATA FINAL DA AÇÃO ", type: "datetime", nullable: true),
                    HORÁRIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMELOJAPARCEIRODISTRIBUIDOR = table.Column<string>(name: "NOME LOJA/ PARCEIRO/ DISTRIBUIDOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ENDEREÇO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BAIRRO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPOLOJA = table.Column<string>(name: "TIPO LOJA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OBSERVAÇÕES = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DADOSEQUIPECOMERCIAL = table.Column<string>(name: "DADOS EQUIPE COMERCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DADOSPROFISSIONALCONTRATO = table.Column<string>(name: "DADOS PROFISSIONAL CONTRATO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F50 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F51 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_VAT_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_VAT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    EXTENSAO_ARQUIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BASE_VAT__3214EC277C61139F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BASE_VAT_BKP",
                columns: table => new
                {
                    ORIGEMDAVERBA = table.Column<string>(name: "ORIGEM DA VERBA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MES = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD = table.Column<double>(type: "float", nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DISTRIBUICAO = table.Column<string>(name: "DISTRIBUICAO%", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LLPP = table.Column<double>(name: "LLPP %", type: "float", nullable: true),
                    PAPCONDOMINIO = table.Column<double>(name: "PAP / CONDOMINIO %", type: "float", nullable: true),
                    REVENDA = table.Column<double>(name: "REVENDA %", type: "float", nullable: true),
                    VAREJO = table.Column<string>(name: "VAREJO %", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CAMPANHAPRODUTO = table.Column<string>(name: "CAMPANHA/ PRODUTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTRATO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COMBO = table.Column<string>(name: "COMBO ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPODEACAO = table.Column<string>(name: "TIPO DE ACAO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MECANICAOBJETIVO = table.Column<string>(name: "MECANICA OBJETIVO", type: "nvarchar(max)", nullable: true),
                    ITEMLPURESUMIDO = table.Column<string>(name: "ITEM LPU (RESUMIDO)", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RANGELPU = table.Column<string>(name: "RANGE LPU", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Contrato2 = table.Column<string>(name: "Contrato 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CAPITALINTERIORAMOSTRAPRODFINAL = table.Column<string>(name: "CAPITAL / INTERIOR - AMOSTRA / PROD# FINAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Detalhe_Range = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uniddemedida = table.Column<string>(name: "Unid# de medida", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QTDCONT_UNIDMEDIDA = table.Column<double>(name: "QTD CONT /_UNID MEDIDA", type: "float", nullable: true),
                    R_UNITARIO = table.Column<decimal>(name: "R$_UNITARIO", type: "money", nullable: true),
                    RTOTAL_semhonorario = table.Column<decimal>(name: "R$ TOTAL_(sem honorario)", type: "money", nullable: true),
                    _HONORARIO = table.Column<double>(name: "%_HONORARIO", type: "float", nullable: true),
                    R_HONORARIO = table.Column<decimal>(name: "R$_HONORARIO", type: "money", nullable: true),
                    RTOTALHONORARIO = table.Column<decimal>(name: "R$ TOTAL + HONORARIO", type: "money", nullable: true),
                    AGENCIAFORNECEDOR = table.Column<string>(name: "AGENCIA/ FORNECEDOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEDOPARCEIRO = table.Column<string>(name: "NOME DO PARCEIRO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODSAPPARCEIRO = table.Column<double>(name: "COD# SAP PARCEIRO", type: "float", nullable: true),
                    NºPEDIDOHONORARIO = table.Column<double>(name: "Nº PEDIDO - HONORARIO", type: "float", nullable: true),
                    NOMEDOPARCEIRO1 = table.Column<string>(name: "NOME DO PARCEIRO1", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CÓDSAPPARCEIRO = table.Column<double>(name: "CÓD# SAP PARCEIRO", type: "float", nullable: true),
                    NºPEDIDOSERVIÇOMATERIAL = table.Column<double>(name: "Nº  PEDIDO SERVIÇO/MATERIAL", type: "float", nullable: true),
                    CENTRODECUSTO = table.Column<string>(name: "CENTRO DE CUSTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADABAS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAINICIODAAÇÃO = table.Column<DateTime>(name: "DATA INICIO DA AÇÃO", type: "datetime", nullable: true),
                    DATAFINALDAAÇÃO = table.Column<DateTime>(name: "DATA FINAL DA AÇÃO ", type: "datetime", nullable: true),
                    HORÁRIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMELOJAPARCEIRODISTRIBUIDOR = table.Column<string>(name: "NOME LOJA/ PARCEIRO/ DISTRIBUIDOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ENDEREÇO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BAIRRO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPOLOJA = table.Column<string>(name: "TIPO LOJA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OBSERVAÇÕES = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DADOSEQUIPECOMERCIAL = table.Column<string>(name: "DADOS EQUIPE COMERCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DADOSPROFISSIONALCONTRATO = table.Column<string>(name: "DADOS PROFISSIONAL CONTRATO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F50 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F51 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE_ZMM34",
                columns: table => new
                {
                    Centro = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Material = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DescricaoMater = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Deposito = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    EstoqueDisponivel = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    EstoqueLivreUtil = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    TotalOrdens = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    TotalRemessas = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    PendenteSemEstoque = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    PendenteCredito = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SaldoDisponível = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    EstoqueTotalDeposito = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    BOMParaVenda = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CentroDeposito = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Resumo = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BASE$",
                columns: table => new
                {
                    CODIGOCARGO = table.Column<string>(name: "CODIGO CARGO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESCRICAOCARGO = table.Column<string>(name: "DESCRICAO CARGO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAENTRADA = table.Column<DateTime>(name: "DATA ENTRADA", type: "datetime", nullable: true),
                    DATASAIDA = table.Column<string>(name: "DATA SAIDA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PERCENTUALFERIAS = table.Column<double>(name: "PERCENTUAL FERIAS", type: "float", nullable: true),
                    NOMEGERENTE = table.Column<string>(name: "NOME GERENTE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLUSTER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COORDENADOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONSULTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VENDEDORINSTÂNCIA = table.Column<string>(name: "VENDEDOR INSTÂNCIA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANALDEVENDAS = table.Column<string>(name: "CANAL DE VENDAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOCANAL = table.Column<string>(name: "GRUPO CANAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOCANAL2 = table.Column<string>(name: "GRUPO CANAL 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAIS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONALTELE = table.Column<string>(name: "REGIONAL/TELE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINCOORDENADOR = table.Column<string>(name: "LOGIN COORDENADOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINGERENTE = table.Column<string>(name: "LOGIN GERENTE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINDIRETOR = table.Column<string>(name: "LOGIN DIRETOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEDIRETOR = table.Column<string>(name: "NOME DIRETOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTRATO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEGUNDO_LOGIN = table.Column<double>(type: "float", nullable: true),
                    ADABASMÓVEL = table.Column<string>(name: "ADABAS MÓVEL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADABASFIXA = table.Column<string>(name: "ADABAS FIXA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RECEBEDOR_SAP = table.Column<double>(type: "float", nullable: true),
                    GRUPO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BOLETA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoBoleta = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Instancia = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PlanoVivoFibra = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pontuacao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TelContato1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TelContato2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TelContato3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EmailCliente = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CodVendaFibra = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProtocoloGed = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProtocoloVendaFibra = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TipoVenda = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PlanoSmart = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PlanoControle = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PlanoDados = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdVendaBoleta = table.Column<int>(type: "int", nullable: true),
                    PlanoBandaLarga = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    PlanoFixo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    PlanoTv = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    Linha = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TipoSVA = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    NomeCliente = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    CpfCliente = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BOOK_PLANOS_7X",
                columns: table => new
                {
                    PLANO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMENCLATURASISTÊMICAVIVO360 = table.Column<string>(name: "NOMENCLATURA SISTÊMICA VIVO 360", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PREÇOASSINATURA = table.Column<string>(name: "PREÇO ASSINATURA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PREÇOFRANQUIA = table.Column<string>(name: "PREÇO FRANQUIA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VALORTOTAL = table.Column<decimal>(name: "VALOR TOTAL", type: "money", nullable: true),
                    NOMEPLANOSAPTABELAMAISVIVO = table.Column<string>(name: "NOME PLANO SAP TABELA MAIS VIVO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEPLANOSAPTABELARENOVA = table.Column<string>(name: "NOME PLANO SAP TABELA RENOVA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FRANQUIAOUTRASOPERADORASLIGAÇÃOLOCAL = table.Column<string>(name: "FRANQUIA OUTRAS OPERADORAS  - LIGAÇÃO LOCAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FRANQUIADEDADOS = table.Column<string>(name: "FRANQUIA DE DADOS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NDEMULTIVIVOS = table.Column<double>(name: "N° DE MULTIVIVOS", type: "float", nullable: true),
                    MULTIVIVOSCOMPATÍVEIS = table.Column<string>(name: "MULTIVIVOS COMPATÍVEIS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CÓDHOMOLOGAÇÃO = table.Column<double>(name: "CÓD# HOMOLOGAÇÃO", type: "float", nullable: true),
                    MATRIZOFERTA = table.Column<string>(name: "MATRIZ OFERTA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FIDELIZAÇÃOCONTRATO = table.Column<string>(name: "FIDELIZAÇÃO/ CONTRATO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VALORDAMULTA = table.Column<string>(name: "VALOR DA MULTA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PACOTEADICIONALINTERNET = table.Column<string>(name: "PACOTE ADICIONAL INTERNET", type: "nvarchar(max)", nullable: true),
                    BLOQUEIODEDADOS = table.Column<string>(name: "BLOQUEIO DE DADOS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PROMOÇÕESVIGENTES = table.Column<string>(name: "PROMOÇÕES VIGENTES", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VALIDADEDASPROMOÇÕES = table.Column<string>(name: "VALIDADE DAS PROMOÇÕES", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BOOK_PLANOS_8X",
                columns: table => new
                {
                    PLANO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMENCLATURASISTÊMICAVIVO360 = table.Column<string>(name: "NOMENCLATURA SISTÊMICA VIVO 360", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PREÇOASSINATURA = table.Column<decimal>(name: "PREÇO ASSINATURA", type: "money", nullable: true),
                    PREÇOFRANQUIA = table.Column<decimal>(name: "PREÇO FRANQUIA", type: "money", nullable: true),
                    VALORTOTAL = table.Column<decimal>(name: "VALOR TOTAL", type: "money", nullable: true),
                    NOMEPLANOSAPTABELAMAISVIVO = table.Column<string>(name: "NOME PLANO SAP TABELA MAIS VIVO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEPLANOSAPTABELARENOVA = table.Column<string>(name: "NOME PLANO SAP TABELA RENOVA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FRANQUIAOUTRASOPERADORASLIGAÇÃOLOCAL = table.Column<string>(name: "FRANQUIA OUTRAS OPERADORAS  - LIGAÇÃO LOCAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FRANQUIADEDADOS = table.Column<string>(name: "FRANQUIA DE DADOS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NDEMULTIVIVOS = table.Column<double>(name: "N° DE MULTIVIVOS", type: "float", nullable: true),
                    MULTIVIVOSCOMPATÍVEIS = table.Column<string>(name: "MULTIVIVOS COMPATÍVEIS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CÓDHOMOLOGAÇÃO = table.Column<double>(name: "CÓD# HOMOLOGAÇÃO", type: "float", nullable: true),
                    MATRIZOFERTA = table.Column<string>(name: "MATRIZ OFERTA", type: "nvarchar(max)", nullable: true),
                    FIDELIZAÇÃOCONTRATO = table.Column<string>(name: "FIDELIZAÇÃO/ CONTRATO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VALORDAMULTA = table.Column<decimal>(name: "VALOR DA MULTA", type: "money", nullable: true),
                    PACOTEADICIONALINTERNET = table.Column<string>(name: "PACOTE ADICIONAL INTERNET", type: "nvarchar(max)", nullable: true),
                    BLOQUEIODEDADOS = table.Column<string>(name: "BLOQUEIO DE DADOS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PROMOÇÕESVIGENTES = table.Column<string>(name: "PROMOÇÕES VIGENTES", type: "nvarchar(max)", nullable: true),
                    VALIDADEDASPROMOÇÕES = table.Column<string>(name: "VALIDADE DAS PROMOÇÕES", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BOOKSAP_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SESSAO_BOOK = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    EXTENCAO_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOOKSAP___3214EC2758DC1D15", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_DRN",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrDRN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RazaoSocial = table.Column<string>(type: "text", nullable: true),
                    TipoResposta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Canal = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Minuta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Socio1 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Socio2 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Socio3 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Socio4 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SocioADM1 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SocioADM2 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SocioADM3 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SocioADM4 = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CADASTRO__3213E83F3A0E4889", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_GERAL_COLABORADORES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANO = table.Column<double>(type: "float", nullable: true),
                    MÊS = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MATRÍCULA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMPRESA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CÓDIGOEMPRESA = table.Column<double>(name: "CÓDIGO EMPRESA", type: "float", nullable: true),
                    NOMEEMPRESA = table.Column<string>(name: "NOME EMPRESA", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FILIAL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SUBAREA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CÓDIGOUNIDADE = table.Column<double>(name: "CÓDIGO UNIDADE", type: "float", nullable: true),
                    ESTADOCOMERCIAL = table.Column<string>(name: "ESTADO COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CIDADECOMERCIAL = table.Column<string>(name: "CIDADE COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BAIRROCOMERCIAL = table.Column<string>(name: "BAIRRO COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ENDEREÇOCOMERCIAL = table.Column<string>(name: "ENDEREÇO COMERCIAL", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NÚMEROCOMERCIAL = table.Column<string>(name: "NÚMERO COMERCIAL", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMPLEMENTOCOMERCIAL = table.Column<string>(name: "COMPLEMENTO COMERCIAL", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CEPCOMERCIAL = table.Column<string>(name: "CEP COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIRETORIA1 = table.Column<string>(name: "DIRETORIA 1", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIRETORIA2 = table.Column<string>(name: "DIRETORIA 2", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIRETORIA3 = table.Column<string>(name: "DIRETORIA 3", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GERÊNCIASR = table.Column<string>(name: "GERÊNCIA SR", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GERÊNCIA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ÁREA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SIGLA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MATRÍCULAGESTOR = table.Column<string>(name: "MATRÍCULA GESTOR", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GESTOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMAILGESTOR = table.Column<string>(name: "E-MAIL GESTOR", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CENTRODECUSTO = table.Column<string>(name: "CENTRO DE CUSTO", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OBJETODECUSTO = table.Column<string>(name: "OBJETO DE CUSTO", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CATEGORIA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SUBGRUPO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    POSIÇÃO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    POSIÇÃOSAP = table.Column<double>(name: "POSIÇÃO SAP", type: "float", nullable: true),
                    LOJA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CALLCENTER = table.Column<string>(name: "CALL CENTER", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAADMISSÃO = table.Column<DateTime>(name: "DATA ADMISSÃO", type: "datetime", nullable: true),
                    DATADESLIGAMENTO = table.Column<DateTime>(name: "DATA DESLIGAMENTO", type: "datetime", nullable: true),
                    AFASTAMENTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ESTABILIDADE = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    QTDFILHOS = table.Column<double>(name: "QTD FILHOS", type: "float", nullable: true),
                    FÉRIASNOMÊS = table.Column<string>(name: "FÉRIAS NO MÊS", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INÍCIOFÉRIAS = table.Column<DateTime>(name: "INÍCIO FÉRIAS", type: "datetime", nullable: true),
                    FIMFÉRIAS = table.Column<DateTime>(name: "FIM FÉRIAS", type: "datetime", nullable: true),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CELULAR = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GÊNERO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DATADENASCIMENTO = table.Column<DateTime>(name: "DATA DE NASCIMENTO", type: "datetime", nullable: true),
                    FAIXADEIDADE = table.Column<string>(name: "FAIXA DE IDADE", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ANOMES_ATUAL = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CADASTRO_GERAL_COLABORADORES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_GERAL_COLABORADORES_PENDENTES",
                columns: table => new
                {
                    ID_Pendente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANO = table.Column<double>(type: "float", nullable: true),
                    MÊS = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MATRÍCULA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMPRESA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CÓDIGOEMPRESA = table.Column<double>(name: "CÓDIGO EMPRESA", type: "float", nullable: true),
                    NOMEEMPRESA = table.Column<string>(name: "NOME EMPRESA", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FILIAL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SUBAREA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CÓDIGOUNIDADE = table.Column<double>(name: "CÓDIGO UNIDADE", type: "float", nullable: true),
                    ESTADOCOMERCIAL = table.Column<string>(name: "ESTADO COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CIDADECOMERCIAL = table.Column<string>(name: "CIDADE COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BAIRROCOMERCIAL = table.Column<string>(name: "BAIRRO COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ENDEREÇOCOMERCIAL = table.Column<string>(name: "ENDEREÇO COMERCIAL", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NÚMEROCOMERCIAL = table.Column<string>(name: "NÚMERO COMERCIAL", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMPLEMENTOCOMERCIAL = table.Column<string>(name: "COMPLEMENTO COMERCIAL", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CEPCOMERCIAL = table.Column<string>(name: "CEP COMERCIAL", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIRETORIA1 = table.Column<string>(name: "DIRETORIA 1", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIRETORIA2 = table.Column<string>(name: "DIRETORIA 2", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIRETORIA3 = table.Column<string>(name: "DIRETORIA 3", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GERÊNCIASR = table.Column<string>(name: "GERÊNCIA SR", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GERÊNCIA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ÁREA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SIGLA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MATRÍCULAGESTOR = table.Column<string>(name: "MATRÍCULA GESTOR", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GESTOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMAILGESTOR = table.Column<string>(name: "E-MAIL GESTOR", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CENTRODECUSTO = table.Column<string>(name: "CENTRO DE CUSTO", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OBJETODECUSTO = table.Column<string>(name: "OBJETO DE CUSTO", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CATEGORIA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SUBGRUPO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    POSIÇÃO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    POSIÇÃOSAP = table.Column<double>(name: "POSIÇÃO SAP", type: "float", nullable: true),
                    LOJA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CALLCENTER = table.Column<string>(name: "CALL CENTER", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAADMISSÃO = table.Column<DateTime>(name: "DATA ADMISSÃO", type: "datetime", nullable: true),
                    DATADESLIGAMENTO = table.Column<DateTime>(name: "DATA DESLIGAMENTO", type: "datetime", nullable: true),
                    AFASTAMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ESTABILIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QTDFILHOS = table.Column<double>(name: "QTD FILHOS", type: "float", nullable: true),
                    FÉRIASNOMÊS = table.Column<string>(name: "FÉRIAS NO MÊS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INÍCIOFÉRIAS = table.Column<DateTime>(name: "INÍCIO FÉRIAS", type: "datetime", nullable: true),
                    FIMFÉRIAS = table.Column<DateTime>(name: "FIM FÉRIAS", type: "datetime", nullable: true),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CELULAR = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GÊNERO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DATADENASCIMENTO = table.Column<DateTime>(name: "DATA DE NASCIMENTO", type: "datetime", nullable: true),
                    IDADE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FAIXADEIDADE = table.Column<string>(name: "FAIXA DE IDADE", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataUltimaAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status_Pendente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ID_Orig = table.Column<int>(type: "int", nullable: true),
                    Motivo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ObservacaoDesligamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    idSolicitanteDesligamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CADASTRO_GERAL_COLABORADORES_PENDENTES", x => x.ID_Pendente);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_GERENTE_TERRITORIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA_ATUACAO_DDD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_EFETIVA_GESTAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CADASTRO__3214EC275EDF0F2E", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_PDV",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAINICIOCONTRATO = table.Column<DateTime>(name: "DATA INICIO CONTRATO", type: "datetime", nullable: true),
                    DATAFIMCONTRATO = table.Column<DateTime>(name: "DATA FIM CONTRATO", type: "datetime", nullable: true),
                    RAZÃOSOCIAL = table.Column<string>(name: "RAZÃO SOCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEFANTASIA = table.Column<string>(name: "NOME FANTASIA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INSCRIÇÃOESTADUAL = table.Column<string>(name: "INSCRIÇÃO ESTADUAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OPTANTESIMPLES = table.Column<short>(name: "OPTANTE SIMPLES", type: "smallint", nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ENDEREÇO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BAIRRO = table.Column<string>(name: "BAIRRO ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NUMERO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTATO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TELEFONE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CELULAR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILFINANCEIRO = table.Column<string>(name: "E-MAIL FINANCEIRO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILCOMERCIAL = table.Column<string>(name: "E-MAIL COMERCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILDIVULGAÇÃO = table.Column<string>(name: "E-MAIL DIVULGAÇÃO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HOMEPAGE = table.Column<string>(name: "HOME PAGE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODIGOBANCO = table.Column<string>(name: "CODIGO BANCO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AGENCIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NUMEROCONTA = table.Column<string>(name: "NUMERO CONTA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DIGITOVERIFICADOR = table.Column<string>(name: "DIGITO VERIFICADOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIÃOGEOGRAFICA = table.Column<string>(name: "REGIÃO GEOGRAFICA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SETORATIVIDADE = table.Column<string>(name: "SETOR ATIVIDADE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁREADECREDITO = table.Column<string>(name: "ÁREA DE CREDITO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORGANIZAÇÃODECOMPRAS = table.Column<string>(name: "ORGANIZAÇÃO DE COMPRAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORGANIZAÇÃODEVENDAS = table.Column<string>(name: "ORGANIZAÇÃO DE VENDAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOVENDEDORNOMEGC = table.Column<string>(name: "GRUPO VENDEDOR/NOME GC", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PAGADORFATURA = table.Column<string>(name: "PAGADOR FATURA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RECEBEDORDAMERCADORIA = table.Column<string>(name: "RECEBEDOR DA MERCADORIA", type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    RECEBEDORFATURA = table.Column<string>(name: "RECEBEDOR FATURA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODIGOVENDEDOR = table.Column<string>(name: "CODIGO VENDEDOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIAL2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RECEBEDORDOCOMISSIONAMENTO = table.Column<string>(name: "RECEBEDOR DO COMISSIONAMENTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PONTODEVENDA = table.Column<string>(name: "PONTO DE VENDA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GESTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_CADASTRO_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    SELLIN = table.Column<string>(name: "SELL IN", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_CADASTRO_SELL_IN = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUSCALLIDUS = table.Column<string>(name: "STATUS CALLIDUS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INSTANCIA = table.Column<double>(type: "float", nullable: true),
                    ATIVIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LIMITE = table.Column<decimal>(type: "money", nullable: true),
                    PRAZOLIMITE = table.Column<DateTime>(name: "PRAZO LIMITE", type: "datetime", nullable: true),
                    MARGEMAPARELHO = table.Column<double>(name: "MARGEM APARELHO", type: "float", nullable: true),
                    MARGEMCHIP = table.Column<double>(name: "MARGEM CHIP", type: "float", nullable: true),
                    MARGEMRECARGA = table.Column<double>(name: "MARGEM  RECARGA", type: "float", nullable: true),
                    CONDIÇÕESDEPAGAMENTO = table.Column<string>(name: "CONDIÇÕES DE PAGAMENTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VPCSellinouOut = table.Column<string>(name: "VPC (Sell in ou Out)", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATUALESTRELAGEM = table.Column<string>(name: "ATUAL ESTRELAGEM", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_EFETI_CART_SELL_IN = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_EFETI_CART_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    CANALDISTRIBUIÇÃO = table.Column<string>(name: "CANAL DISTRIBUIÇÃO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VENDEDOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CÓDIGOCLIENTE = table.Column<double>(name: "CÓDIGO CLIENTE", type: "float", nullable: true),
                    CÓDIGOFORNECEDOR = table.Column<double>(name: "CÓDIGO FORNECEDOR", type: "float", nullable: true),
                    MATRICULA_GER_CONTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COD_IBGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF_LOCALIDADE_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IXOS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDDGESTOR = table.Column<string>(name: "DDD GESTOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREAATUAÇÃODDDGESTOR = table.Column<string>(name: "AREA ATUAÇÃO DDD GESTOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERENTETERRITORIAL = table.Column<string>(name: "GERENTE TERRITORIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOVO_GESTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_NOVO_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MES_LIBERACAO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NOVO_GERENTE_TERRITORIAL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_NOVO_TERRITORIAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA_SELL_IN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO_MINUTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MODELO_CONTRATO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DRN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_ENVIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_RECEBIMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VIGENCIA_INICIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VIGENCIA_FIM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DMS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADMINISTRACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ASSINATURA_NO_CONTRATO_VIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO4 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF4 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_SELL_IN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_REDE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SELL_IN = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DATA_EFETIVACAO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CADASTRO__3214EC2720E1DCB5", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_SIMCARD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<int>(type: "int", nullable: true),
                    LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NR_TELEFONE_TROCA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    MOTIVO_DOACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ICCID_ANTIGO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ARQUIVO_BO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ICCID_NOVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXTENSAO_ARQUIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO_ARQUIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CADASTRO__3214EC275D4BCC77", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_UNICO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAcesso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Rua = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Numero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cep = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Celular = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NomeContato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SubGrupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubArea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    DataSolicitacaoAdmissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataDemissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataSolicitacaoDemissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Funcao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataAdmissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Origem = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PIS = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    EstadoPrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CidadePrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EMAILPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GESTORLIDER = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TELEFONEPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Operadora = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DataUltimaAlteracao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Canal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ObservacaoDesligamento = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Motivo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    idSolicitanteDesligamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CADASTRO__3214EC074FBAC848", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_UNICO_ACESSO",
                columns: table => new
                {
                    idAcesso = table.Column<int>(type: "int", nullable: false),
                    Perfil = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_UNICO_PEN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAcesso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Rua = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Numero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cep = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Celular = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NomeContato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SubGrupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubArea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    DataSolicitacaoAdmissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataDemissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataSolicitacaoDemissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Funcao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataAdmissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Origem = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PIS = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    EstadoPrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CidadePrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EMAILPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GESTORLIDER = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TELEFONEPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Operadora = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DataUltimaAlteracao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Canal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CADASTRO__3214EC076C7A663C", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CADASTRO_UNICO_PENDENTES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAprovado = table.Column<int>(type: "int", nullable: true),
                    TipoAcesso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Rua = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Numero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cep = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Celular = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NomeContato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SubGrupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubArea = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    DataSolicitacaoAdmissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataDemissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataSolicitacaoDemissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Funcao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataAdmissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Origem = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PIS = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    EstadoPrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CidadePrestServico = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EMAILPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GESTORLIDER = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TELEFONEPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Operadora = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DataUltimaAlteracao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Canal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ObservacaoDesligamento = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Motivo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    idSolicitanteDesligamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CADASTRO__3214EC076EA9234D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CADASTROS_ROTA_GNV",
                columns: table => new
                {
                    GerentedeContasSellOut = table.Column<string>(name: "Gerente de Contas Sell Out", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPFGNV = table.Column<string>(name: "CPF GNV", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GerentedeNegóciosVarejo = table.Column<string>(name: "Gerente de Negócios Varejo", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD = table.Column<double>(type: "float", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    agencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CARGO_HEADCOUNT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARGO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_CADASTRO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDACESSO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CARGO_HE__3214EC276B2FD77A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_ARMARIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ARMÁRIO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MICROTERRITÓRIO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DIVISAO_SIGLA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GV = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    RESP_DIVISAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    DataUltimaAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    ANOMES_ATUAL = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTEIRA_ARMARIO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_ARMARIO_PENDENTES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GV = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    Id_Armario = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    idAcesso = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AprovacaoCanal = table.Column<bool>(type: "bit", nullable: true),
                    AprovacaoDivisao = table.Column<bool>(type: "bit", nullable: true),
                    DataUltimaAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    MICROTERRITORIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ARMÁRIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTEIRA_ARMARIO_PENDENTES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_DEMAIS_CANAIS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatusCallidus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD_LOCALIDADE_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA_ATUACAO_DDD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoginSiebel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Credenciamento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Descredenciamento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Modelo_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tipo_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Local_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Clusters = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estrelagem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DataUltimaAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DivisaoOrig = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MATRICULA_GV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MATRICULA_GA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MATRICULA_GGP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ANOMES_ATUAL = table.Column<bool>(type: "bit", nullable: true),
                    QtdPA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Metragem = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTEIRA_DEMAIS_CANAIS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_DEMAIS_CANAIS_PENDENTES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatusCallidus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD_LOCALIDADE_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA_ATUACAO_DDD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoginSiebel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Credenciamento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Descredenciamento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Modelo_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tipo_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Local_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Clusters = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estrelagem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    idAcesso = table.Column<int>(type: "int", nullable: false),
                    IdDemaisCanais = table.Column<int>(type: "int", nullable: false),
                    Divisao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AprovacaoDivisao = table.Column<bool>(type: "bit", nullable: true),
                    AprovacaoCanal = table.Column<bool>(type: "bit", nullable: true),
                    DataUltimaALteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA_GA = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MATRICULA_GV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MATRICULA_GGP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTEIRA_DEMAIS_CANAIS_PENDENTES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carteira_demais_canais_rede_colaborador",
                columns: table => new
                {
                    REDE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MATRICULA_1 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_3 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_4 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MATRICULA_5 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MATRICULA_6 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MATRICULA_7 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MATRICULA_8 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_9 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_10 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_11 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_12 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_13 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_14 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MATRICULA_15 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__carteira__45467F492278E84C", x => x.REDE);
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_GNV",
                columns: table => new
                {
                    REGIONAL = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    CPF = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    NOME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REDE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CARGO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_GVT_FIXA",
                columns: table => new
                {
                    CODIGOCARGO = table.Column<string>(name: "CODIGO CARGO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESCRICAOCARGO = table.Column<string>(name: "DESCRICAO CARGO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAENTRADA = table.Column<DateTime>(name: "DATA ENTRADA", type: "datetime", nullable: true),
                    DATASAIDA = table.Column<string>(name: "DATA SAIDA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PERCENTUALFERIAS = table.Column<double>(name: "PERCENTUAL FERIAS", type: "float", nullable: true),
                    NOMEGERENTE = table.Column<string>(name: "NOME GERENTE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLUSTER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COORDENADOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONSULTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VENDEDORINSTÂNCIA = table.Column<string>(name: "VENDEDOR INSTÂNCIA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANALDEVENDAS = table.Column<string>(name: "CANAL DE VENDAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOCANAL = table.Column<string>(name: "GRUPO CANAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOCANAL2 = table.Column<string>(name: "GRUPO CANAL 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAIS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONALTELE = table.Column<string>(name: "REGIONAL/TELE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINCOORDENADOR = table.Column<string>(name: "LOGIN COORDENADOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINGERENTE = table.Column<string>(name: "LOGIN GERENTE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINDIRETOR = table.Column<string>(name: "LOGIN DIRETOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEDIRETOR = table.Column<string>(name: "NOME DIRETOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERENTETERRITORIAL = table.Column<string>(name: "GERENTE TERRITORIAL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NOVO_GESTOR = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    OBS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_NOVO_GESTOR = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_GVT_FIXA_2",
                columns: table => new
                {
                    CODIGOCARGO = table.Column<string>(name: "CODIGO CARGO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESCRICAOCARGO = table.Column<string>(name: "DESCRICAO CARGO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAENTRADA = table.Column<DateTime>(name: "DATA ENTRADA", type: "datetime", nullable: true),
                    DATASAIDA = table.Column<string>(name: "DATA SAIDA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PERCENTUALFERIAS = table.Column<double>(name: "PERCENTUAL FERIAS", type: "float", nullable: true),
                    NOMEGERENTE = table.Column<string>(name: "NOME GERENTE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLUSTER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COORDENADOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONSULTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VENDEDORINSTÂNCIA = table.Column<string>(name: "VENDEDOR INSTÂNCIA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANALDEVENDAS = table.Column<string>(name: "CANAL DE VENDAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOCANAL = table.Column<string>(name: "GRUPO CANAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOCANAL2 = table.Column<string>(name: "GRUPO CANAL 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAIS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONALTELE = table.Column<string>(name: "REGIONAL/TELE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINCOORDENADOR = table.Column<string>(name: "LOGIN COORDENADOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINGERENTE = table.Column<string>(name: "LOGIN GERENTE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGINDIRETOR = table.Column<string>(name: "LOGIN DIRETOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEDIRETOR = table.Column<string>(name: "NOME DIRETOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Carteira_NE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GAGG = table.Column<string>(name: "GA / GG", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatusCallidus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD_LOCALIDADE_PDV = table.Column<double>(type: "float", nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREAATUAÇÃODDD = table.Column<string>(name: "AREA ATUAÇÃO DDD", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoginSiebel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataCredenciamento = table.Column<string>(name: "Data Credenciamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataDescredenciamento = table.Column<string>(name: "Data Descredenciamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ModeloLoja = table.Column<string>(name: "Modelo Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipoLoja = table.Column<string>(name: "Tipo Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LocalLoja = table.Column<string>(name: "Local Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QtdePA = table.Column<string>(name: "Qt de PA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Metragem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEGMENTAÇÃO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estrelagem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    NO_VIVO360 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NO_VIVONEXT = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NO_GSS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DT_MOD_CAD = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LOGIN_MOD_CAD = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DataInicioContrato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DataFimContrato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    InscriçãoEstadual = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    OptanteSimples = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Contato = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EmailFinanceiro = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EmailComercial = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EmailDivulgação = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CodigoBanco = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Banco = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Agencia = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NumeroConta = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DigitoVerificador = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SetorAtividade = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PontoVenda = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Genero = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CodigoCliente = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CodigoFornecedor = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Area = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Ixos = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carteira__3214EC2768AFE615", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_NE_DESCREDENCIADOS",
                columns: table => new
                {
                    Cnpj = table.Column<double>(type: "float", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatusCallidus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD_LOCALIDADE_PDV = table.Column<double>(type: "float", nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA_ATUACAO_DDD = table.Column<double>(type: "float", nullable: true),
                    GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoginSiebel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cep = table.Column<double>(type: "float", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Numero = table.Column<double>(type: "float", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Credenciamento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Descredenciamento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modelo_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tipo_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Local_Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Clusters = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estrelagem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<double>(type: "float", nullable: true),
                    DataUltimaAlteracao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    idAcesso = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataSolicitacao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DivisaoOrig = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA_GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA_GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA_GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QtdPA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Metragem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Carteira_NE_Pendente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GAGG = table.Column<string>(name: "GA / GG", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatusCallidus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD_LOCALIDADE_PDV = table.Column<double>(type: "float", nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREAATUAÇÃODDD = table.Column<string>(name: "AREA ATUAÇÃO DDD", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoginSiebel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataCredenciamento = table.Column<string>(name: "Data Credenciamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataDescredenciamento = table.Column<string>(name: "Data Descredenciamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ModeloLoja = table.Column<string>(name: "Modelo Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipoLoja = table.Column<string>(name: "Tipo Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LocalLoja = table.Column<string>(name: "Local Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QtdePA = table.Column<string>(name: "Qt de PA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Metragem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEGMENTAÇÃO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estrelagem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    IsSaved = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Data_Alteracao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Matricula_Solicitante = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Nome_Solicitante = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    IsFinalizado = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    IsModificado = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Antigo_GV = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NO_VIVO360 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NO_VIVONEXT = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NO_GSS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carteira__3214EC27EBD6C271", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Carteira_NE$",
                columns: table => new
                {
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GAGG = table.Column<string>(name: "GA / GG", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatusCallidus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD_LOCALIDADE_PDV = table.Column<double>(type: "float", nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREAATUAÇÃODDD = table.Column<string>(name: "AREA ATUAÇÃO DDD", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LoginSiebel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataCredenciamento = table.Column<string>(name: "Data Credenciamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataDescredenciamento = table.Column<string>(name: "Data Descredenciamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ModeloLoja = table.Column<string>(name: "Modelo Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipoLoja = table.Column<string>(name: "Tipo Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LocalLoja = table.Column<string>(name: "Local Loja", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QtdePA = table.Column<string>(name: "Qt de PA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Metragem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEGMENTAÇÃO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estrelagem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<double>(type: "float", nullable: true),
                    NO_VIVO360 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NO_VIVONEXT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NO_GSS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DT_MOD_CAD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN_MOD_CAD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataInicioContrato = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataFimContrato = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InscriçãoEstadual = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OptanteSimples = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Contato = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmailFinanceiro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmailComercial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmailDivulgação = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodigoBanco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Banco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Agencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NumeroConta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DigitoVerificador = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SetorAtividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PontoVenda = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodigoCliente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodigoFornecedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ixos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_PDV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    GERENTE_CONTAS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_EFETIVACAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    CANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CARTEIRA__3214EC2718178C8A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_RELACAO_PDV_COLABORADOR",
                columns: table => new
                {
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Atividade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA_GV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MATRICULA_GA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MATRICULA_GGP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_SUPERV_VENDAS",
                columns: table => new
                {
                    REGIONAL = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    CPF = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    NOME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REDE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_VALIDACAO_TERRITORIAL",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAINICIOCONTRATO = table.Column<DateTime>(name: "DATA INICIO CONTRATO", type: "datetime", nullable: true),
                    DATAFIMCONTRATO = table.Column<DateTime>(name: "DATA FIM CONTRATO", type: "datetime", nullable: true),
                    RAZÃOSOCIAL = table.Column<string>(name: "RAZÃO SOCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEFANTASIA = table.Column<string>(name: "NOME FANTASIA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INSCRIÇÃOESTADUAL = table.Column<string>(name: "INSCRIÇÃO ESTADUAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OPTANTESIMPLES = table.Column<string>(name: "OPTANTE SIMPLES", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ENDEREÇO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BAIRRO = table.Column<string>(name: "BAIRRO ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NUMERO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTATO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TELEFONE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CELULAR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILFINANCEIRO = table.Column<string>(name: "E-MAIL FINANCEIRO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILCOMERCIAL = table.Column<string>(name: "E-MAIL COMERCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILDIVULGAÇÃO = table.Column<string>(name: "E-MAIL DIVULGAÇÃO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HOMEPAGE = table.Column<string>(name: "HOME PAGE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODIGOBANCO = table.Column<string>(name: "CODIGO BANCO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AGENCIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NUMEROCONTA = table.Column<string>(name: "NUMERO CONTA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DIGITOVERIFICADOR = table.Column<string>(name: "DIGITO VERIFICADOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIÃOGEOGRAFICA = table.Column<string>(name: "REGIÃO GEOGRAFICA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SETORATIVIDADE = table.Column<string>(name: "SETOR ATIVIDADE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁREADECREDITO = table.Column<string>(name: "ÁREA DE CREDITO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORGANIZAÇÃODECOMPRAS = table.Column<string>(name: "ORGANIZAÇÃO DE COMPRAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORGANIZAÇÃODEVENDAS = table.Column<string>(name: "ORGANIZAÇÃO DE VENDAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOVENDEDORNOMEGC = table.Column<string>(name: "GRUPO VENDEDOR/NOME GC", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PAGADORFATURA = table.Column<string>(name: "PAGADOR FATURA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RECEBEDORDAMERCADORIA = table.Column<string>(name: "RECEBEDOR DA MERCADORIA", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RECEBEDORFATURA = table.Column<string>(name: "RECEBEDOR FATURA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODIGOVENDEDOR = table.Column<string>(name: "CODIGO VENDEDOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIAL2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RECEBEDORDOCOMISSIONAMENTO = table.Column<string>(name: "RECEBEDOR DO COMISSIONAMENTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PONTODEVENDA = table.Column<string>(name: "PONTO DE VENDA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GESTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_CADASTRO_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    SELLIN = table.Column<string>(name: "SELL IN", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_CADASTRO_SELL_IN = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUSCALLIDUS = table.Column<string>(name: "STATUS CALLIDUS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INSTANCIA = table.Column<double>(type: "float", nullable: true),
                    ATIVIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LIMITE = table.Column<decimal>(type: "money", nullable: true),
                    PRAZOLIMITE = table.Column<DateTime>(name: "PRAZO LIMITE", type: "datetime", nullable: true),
                    MARGEMAPARELHO = table.Column<string>(name: "MARGEM APARELHO", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MARGEMCHIP = table.Column<string>(name: "MARGEM CHIP", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MARGEMRECARGA = table.Column<string>(name: "MARGEM  RECARGA", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CONDIÇÕESDEPAGAMENTO = table.Column<string>(name: "CONDIÇÕES DE PAGAMENTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VPCSellinouOut = table.Column<string>(name: "VPC (Sell in ou Out)", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATUALESTRELAGEM = table.Column<string>(name: "ATUAL ESTRELAGEM", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_EFETI_CART_SELL_IN = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_EFETI_CART_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    CANALDISTRIBUIÇÃO = table.Column<string>(name: "CANAL DISTRIBUIÇÃO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VENDEDOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CÓDIGOCLIENTE = table.Column<string>(name: "CÓDIGO CLIENTE", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CÓDIGOFORNECEDOR = table.Column<string>(name: "CÓDIGO FORNECEDOR", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MATRICULA_GER_CONTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COD_IBGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF_LOCALIDADE_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IXOS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDDGESTOR = table.Column<string>(name: "DDD GESTOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREAATUAÇÃODDDGESTOR = table.Column<string>(name: "AREA ATUAÇÃO DDD GESTOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERENTETERRITORIAL = table.Column<string>(name: "GERENTE TERRITORIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOVO_GESTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_NOVO_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MES_LIBERACAO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NOVO_GERENTE_TERRITORIAL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_NOVO_TERRITORIAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA_SELL_IN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MATRICULA_TERRITORIAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CARTEIRA_VALIDACAO_TERRITORIAL _BKP",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAINICIOCONTRATO = table.Column<DateTime>(name: "DATA INICIO CONTRATO", type: "datetime", nullable: true),
                    DATAFIMCONTRATO = table.Column<DateTime>(name: "DATA FIM CONTRATO", type: "datetime", nullable: true),
                    RAZÃOSOCIAL = table.Column<string>(name: "RAZÃO SOCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMEFANTASIA = table.Column<string>(name: "NOME FANTASIA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INSCRIÇÃOESTADUAL = table.Column<string>(name: "INSCRIÇÃO ESTADUAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OPTANTESIMPLES = table.Column<short>(name: "OPTANTE SIMPLES", type: "smallint", nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ENDEREÇO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BAIRRO = table.Column<string>(name: "BAIRRO ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NUMERO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTATO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TELEFONE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CELULAR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILFINANCEIRO = table.Column<string>(name: "E-MAIL FINANCEIRO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILCOMERCIAL = table.Column<string>(name: "E-MAIL COMERCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILDIVULGAÇÃO = table.Column<string>(name: "E-MAIL DIVULGAÇÃO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HOMEPAGE = table.Column<string>(name: "HOME PAGE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODIGOBANCO = table.Column<string>(name: "CODIGO BANCO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AGENCIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NUMEROCONTA = table.Column<string>(name: "NUMERO CONTA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DIGITOVERIFICADOR = table.Column<string>(name: "DIGITO VERIFICADOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIÃOGEOGRAFICA = table.Column<string>(name: "REGIÃO GEOGRAFICA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SETORATIVIDADE = table.Column<string>(name: "SETOR ATIVIDADE", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁREADECREDITO = table.Column<string>(name: "ÁREA DE CREDITO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORGANIZAÇÃODECOMPRAS = table.Column<string>(name: "ORGANIZAÇÃO DE COMPRAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORGANIZAÇÃODEVENDAS = table.Column<string>(name: "ORGANIZAÇÃO DE VENDAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPOVENDEDORNOMEGC = table.Column<string>(name: "GRUPO VENDEDOR/NOME GC", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PAGADORFATURA = table.Column<string>(name: "PAGADOR FATURA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RECEBEDORDAMERCADORIA = table.Column<string>(name: "RECEBEDOR DA MERCADORIA", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RECEBEDORFATURA = table.Column<string>(name: "RECEBEDOR FATURA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CODIGOVENDEDOR = table.Column<string>(name: "CODIGO VENDEDOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIAL2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RECEBEDORDOCOMISSIONAMENTO = table.Column<string>(name: "RECEBEDOR DO COMISSIONAMENTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PONTODEVENDA = table.Column<string>(name: "PONTO DE VENDA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GESTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_CADASTRO_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    SELLIN = table.Column<string>(name: "SELL IN", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_CADASTRO_SELL_IN = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUSCALLIDUS = table.Column<string>(name: "STATUS CALLIDUS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INSTANCIA = table.Column<double>(type: "float", nullable: true),
                    ATIVIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LIMITE = table.Column<decimal>(type: "money", nullable: true),
                    PRAZOLIMITE = table.Column<DateTime>(name: "PRAZO LIMITE", type: "datetime", nullable: true),
                    MARGEMAPARELHO = table.Column<string>(name: "MARGEM APARELHO", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MARGEMCHIP = table.Column<string>(name: "MARGEM CHIP", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MARGEMRECARGA = table.Column<string>(name: "MARGEM  RECARGA", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CONDIÇÕESDEPAGAMENTO = table.Column<string>(name: "CONDIÇÕES DE PAGAMENTO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VPCSellinouOut = table.Column<string>(name: "VPC (Sell in ou Out)", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATUALESTRELAGEM = table.Column<string>(name: "ATUAL ESTRELAGEM", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_EFETI_CART_SELL_IN = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_EFETI_CART_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    CANALDISTRIBUIÇÃO = table.Column<string>(name: "CANAL DISTRIBUIÇÃO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VENDEDOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CÓDIGOCLIENTE = table.Column<string>(name: "CÓDIGO CLIENTE", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CÓDIGOFORNECEDOR = table.Column<string>(name: "CÓDIGO FORNECEDOR", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MATRICULA_GER_CONTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COD_IBGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF_LOCALIDADE_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IXOS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDDGESTOR = table.Column<string>(name: "DDD GESTOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREAATUAÇÃODDDGESTOR = table.Column<string>(name: "AREA ATUAÇÃO DDD GESTOR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERENTETERRITORIAL = table.Column<string>(name: "GERENTE TERRITORIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOVO_GESTOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_NOVO_GESTOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MES_LIBERACAO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NOVO_GERENTE_TERRITORIAL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_NOVO_TERRITORIAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA_SELL_IN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MATRICULA_TERRITORIAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CASO_NAO",
                columns: table => new
                {
                    Vendedor = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Login = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHAMADO_LLPP_OLD",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chamado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rede = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DataAbertura = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataEncerramento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHAMADO___3213E83F668030F6", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_DESCREDENCIAMENTO_VAREJO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Opcao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    Responsavel = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC077227B923", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_FORMULARIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pergunta = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Peso = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Formulario = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC07617D1B65", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PDR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOME_FANTASIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DATA_VISITA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SEGMENTACAO_PDV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    INFORME_SEGMENTACAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISTRIBUIDOR_ATENDE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NOME_ENTREVISTADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CARGO_ENTREVISTADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TRABALHA_RECARGA_ELETRONICA_VIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    RECARGA_ELETRONICA_VIVO_FUNCIONA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    OBSERVACAO_RECARGA_ELETRONICA_VIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TRABALHA_RECARGA_ELETRONICA_CONCORRENCIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    RECARGA_ELETRONICA_CONCORRENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TRABALHA_CHIP_VIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_CHIP_VIVO_PARA_CLIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UNIDADE_DISPONIVEL_CHIP_VIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TRABALHA_CHIP_TURBINADO_VIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    UNIDADE_COMBO_TURBINADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VALOR_COMBO_CLIENTE_FINAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDE_CHIP_CONCORRENCIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VENDE_CHIP_TIM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_CHIP_TIM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDE_CHIP_CLARO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_CHIP_CLARO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDE_CHIP_OI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_CHIP_OI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDE_COMBO_CONCORRENCIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VENDE_COMBO_TIM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_COMBO_TIM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDE_COMBO_CLARO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_COMBO_CLARO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDE_COMBO_OI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_COMBO_OI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDE_COMBO_OUTROS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_COMBO_OUTROS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OBSERVACOES_ABASTECIMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    HORAS_RESOLUCAO_DISTRIBUIDOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PDV_POSSUI_CONTATO_VENDEDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FREQUENCIA_VISITA_VENDEDOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OBSERVACAO_FREQUENCIA_VISITA_VENDEDOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RESPONSAVEL_INFORMA_NUMERO_CADASTRO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUMERO_CADASTRO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RESPONSAVEL_INFORMA_NOME_PROMOCAO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NOME_PROMOCAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SATISFACAO_VENDEDOR = table.Column<int>(type: "int", nullable: true),
                    OBSERVACAO_ORIENTACAO_PDV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSITIVACAO_MATERIAL_MERCHANDISING = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_INTERNO_CONCORRENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OPERADORAS_MATERIAIS_INTERNO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_VIVO_VIGENTE_INTERNO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_EXTERNO_CONCORRENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OPERADORAS_MATERIAIS_EXTERNO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_VIVO_VIGENTE_EXTERNO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OBSERVACAO_MERCHANDISING = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC270C06BB60", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PDR_EXTERNO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adabas = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DataVisita = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegmentacaodoPdvCorreta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SegmentacaodoPdvCorretaQual = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DistribuidorAtendePdvInformado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeCompletoEntrevistado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CargoEntrevistado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ObsSobreDadosPdvObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdvTrabalhaRecargaEletronicavivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvTrabalhaRecargaEletronicavivoOBSObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecargaEletronicavivoFuncionandocorretamente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RecargaEletronicavivoFuncionandocorretamenteOBSObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdvTrabalhaRecargaEletronicadaConcorrencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QuaisRecargasEletronicasConcorrencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvTrabalhaComChipVivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QualValorVivoChipPraticadoPdvCliente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QuantasUnidadesChipVivoDisponivel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvTrabalhaComCombo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QuantasUnidadesCombo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QualValorComboPraticadoCliente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvVendeChipConcorrencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VendeChipTim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValorChipTim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VendeChipOi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValorChipOi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VendeChipClaro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValorChipClaro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvVendeCombo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VendeComboTim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValorComboTim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VendeComboClaro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValorComboClaro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VendeComboOi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QualoValorComboOi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ObsSobreAbastecimentoObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReposicaoConserto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    responsAvelPeloPdvPossuioContatovendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    frequenciaVisitaVendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NumeroCadastroPromocao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NCadastro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ResponsavelPromocaoVigente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomePromocao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ZeroDezIndicadeSatisfacao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ObsSobreOrientacaoPDvObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandisingInterna = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MaterialInternoConcorrencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QuaisOperadorasMaterialInterno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvPossuiMaterialVigenteInterno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvPossuiMaterialExterno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvPossuiMaterialExternoConcorrencia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PdvPossuiMaterialVigenteExterno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ObsSobreMerchandisingObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idAcesso = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Cnpj_2 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Bairro_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cidade_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RazaoSocial_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3213E83F3508D0F3", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PDR_EXTERNO_1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataVisita = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegmentacaodoPdvCorreta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SegmentacaodoPdvCorretaQual = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistribuidorAtendePdvInformado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomeCompletoEntrevistado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoEntrevistado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ObsSobreDadosPdvObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdvTrabalhaRecargaEletronicavivo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvTrabalhaRecargaEletronicavivoOBSObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecargaEletronicavivoFuncionandocorretamente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecargaEletronicavivoFuncionandocorretamenteOBSObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdvTrabalhaRecargaEletronicadaConcorrencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuaisRecargasEletronicasConcorrencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvTrabalhaComChipVivo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QualValorVivoChipPraticadoPdvCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantasUnidadesChipVivoDisponivel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvTrabalhaComCombo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantasUnidadesCombo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QualValorComboPraticadoCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvVendeChipConcorrencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendeChipTim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValorChipTim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendeChipOi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValorChipOi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendeChipClaro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValorChipClaro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvVendeCombo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendeComboTim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValorComboTim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendeComboClaro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValorComboClaro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendeComboOi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QualoValorComboOi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ObsSobreAbastecimentoObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReposicaoConserto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    responsAvelPeloPdvPossuioContatovendedor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    frequenciaVisitaVendedor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumeroCadastroPromocao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NCadastro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResponsavelPromocaoVigente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomePromocao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZeroDezIndicadeSatisfacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ObsSobreOrientacaoPDvObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandisingInterna = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaterialInternoConcorrencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuaisOperadorasMaterialInterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvPossuiMaterialVigenteInterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvPossuiMaterialExterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvPossuiMaterialExternoConcorrencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PdvPossuiMaterialVigenteExterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ObsSobreMerchandisingObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idAcesso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cnpj_2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Bairro_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cidade_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RazaoSocial_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3213E83F2C738AF2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PDR_INTERNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOME_FANTASIA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REALIZADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    QTD_VENDEDOR_DISTRIBUIDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    QTD_SUPERV_COORD_DISTRIBUIDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    QTD_GERENTE_DISTRIBUIDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CALL_CENTER_ALOC_UNID_AUDIT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    LOCAL_CALL_CENTER = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FOTO_DATADA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    QTD_ATEND_SUP_CALL_DISTR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISTR_POSSUI_ESTR_ATEND_ATIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISTR_POSSUI_REG_CLT_CONTR_VEND = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISTR_POSSUI_SAL_VEND_AUDIT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QTD_CADEIRAS_SAL_VENDAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CAD_SAL_VEND = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VEND_KIT_VENDAS_COMPL = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FORC_VENDAS_UNIFORME_PADRAO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    COR_UNIFORME = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OUTRA_COR_UNIFORME = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_PAREDE_PAINEL_SAL_VENDAS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_POSSUI_SIMUL_PDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_POSSUI_QUADRO_GEST = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OBS_DISTR_POSSUI_QUADRO_GEST = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_POSSUI_ESTR_ADEQ_MERCHAN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_POSSUI_ESTR_ADEQ_PROD_FIS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_POSSUI_ESTR_ADEQ_POS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    POSSUI_50_POS_DISP = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OBS_POSSUI_50_POS_DISP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DISTR_POSSUI_FERRAM_AUX_VENDA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_POSSUI_SIST_ROTA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_POSSUI_APP_PISTOL_FISICO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DISTR_ENTR_TODA_MERC_FIS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SIST_GEST_DISTR_IDENT_CONTR_REL_SER = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SIST_DISTR_REC_INFORM_PED_AUTOM_VENDAS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VEND_CHECK_IN_PDR_AUT_VENDA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VEND_IND_AUT_VENDA_EST_PDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VEND_LANCA_AUT_VENDA_ENT_SAI_MERC = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VEND_CONS_PIST_SER_CHIP = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VEND_CONS_PIST_SER_CARTAO_FISICO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SIST_GEST_DISTR_INF_VENDA_DATA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    IDENT_EST_CHIP_PDR = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OBS_IDENT_EST_CHIP_PDR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DISTR_REG_FREQ_VIS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OBS_CRACHA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MAT_REALIZADA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MOM_MATIN_QTD_VEND = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    QTD_VEND_ALOC_UNID_AUDIT = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CNPJ_2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BAIRRO_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CIDADE_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RAZAO_SOCIAL_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IDACESSO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC271B48FEF0", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PDR_INTERNO_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PDR_INTERNO = table.Column<int>(type: "int", nullable: true),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC2723DE44F1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_CICLO_2_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: false),
                    ADABA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_CICLO_3_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: false),
                    ADABA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_CICLO_3_ARQUIVOS_REVENDA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: false),
                    ADABA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LLPP_COMPROBATORIA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVisita = table.Column<int>(type: "int", nullable: false),
                    EquipamentoFuncionandoCorretamenteFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EquipamentoGssFuncionandoCorretamenteFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LojaLampadasFuncionandoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TvDivulgacaoVinhetasFuncionandoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TvInformeSenhaAtendimentoFuncionandoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FachadaLojaPadronizadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PisoLojaPadronizadoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ParedeLojaPadronizadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CadeirasLojaPadronizadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LixeiraLojaPadronizadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LojaPossuiUrnaColetoraPadronizadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MobiliarioPerfeitoEstadoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FiacaoExpostaFormaOrdenadaNaoVisivelClienteFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MaquinasUsamChipVivoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LojaPossuiRevistaMundoVivoVersaoDigitalFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LojaPossuiCodigoDefesaConsumidorFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    VitrineExternaPositivadaMapaPdvFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    VitrineInternaDegustadoresPositivadosFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AreaAcessoLojaPositivadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AreaEsperaEstaPositivadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AreaAtendimentoPositivadaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AparelhosLigadosVinhetasAprovadasFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DisplaysAparelhosemonstraçãoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CaixaLojaCorretoFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FechamentoFinanceiroDiaAnteriorFechouSemPendenciaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LlojaEstaAreasSalaoVendasFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MetasEstaoExpostasFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PAEscolhidaArvoreOfertasInstaladaFoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC071975C517", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LLPP_EVIDENCIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: true),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC2732CB82C6", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LLPP_INFORMATIVA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVisita = table.Column<int>(type: "int", nullable: false),
                    EquipamentoTAVFuncionandoCorretamenteChamado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EquipamentoGssFuncionandoCorretamenteChamado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ArCondicionadoFuncionandoChamado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LojaLampadasFuncionandoChamado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TvDivulgacaoVinhetasFuncionandoChamado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TvInformeSenhaAtendimentoFuncionandoChamado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LojaPossuiUrnaColetoraPadronizadaMaterialMaterial = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MobiliarioPerfeitoEstadoChamado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC07220B0B18", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ABADAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    GERENTE_RESPONSAVEL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_GERENTE_RESPONSAVEL = table.Column<int>(type: "int", nullable: true),
                    TAV_FUNCIONANDO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EXISTE_CHAMADO_TAV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_CHAMADO_TAV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_TAV_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    GSS_FUNCIONANDO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EXISTE_CHAMADO_GSS = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_CHAMADO_GSS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_GSS_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    CONSULTOR_PRESENTE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_CONSULTOR_PRESENTE = table.Column<int>(type: "int", nullable: true),
                    AR_COND_FUNC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    EXISTE_CHAMADO_AR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_CHAMADO_AR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_AR_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    LUZES_FUNC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    EXISTE_CHAMADO_LUZES = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_CHAMADO_LUZES = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_LUZES_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    TV_VINHETAS = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    EXISTE_CHAMADO_TV_VINHETA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_CHAMADO_TV_VINHETA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_TV_VINHETAS = table.Column<int>(type: "int", nullable: true),
                    TV_SENHA_FUNC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    EXISTE_CHAMADO_TV_SENHA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_CHAMADO_TV_SENHA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_TV_SENHA = table.Column<int>(type: "int", nullable: true),
                    FACHADA_PADRONIZADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_FACHADA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    PISO_PADRONIZADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_PISO_PADRONIZADO = table.Column<int>(type: "int", nullable: true),
                    PAREDE_PADRONIZADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_PAREDE_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    CADEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_CADEIRAS_PADRONIZADAS = table.Column<int>(type: "int", nullable: true),
                    LIXEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_LIXEIRAS_PADRONIZADAS = table.Column<int>(type: "int", nullable: true),
                    POSSUI_URNA_COLETORA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MATERIAL_URNA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    OUTRO_MATERIAL_URNA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_URNA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    MOBILIARIO_LOJA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    EXISTE_CHAMADO_MOBILIARIO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_CHAMADO_MOBILIARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PONTUACAO_MOBILIARIO_LOJA = table.Column<int>(type: "int", nullable: true),
                    FIACAO_LOJA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_FIACAO_LOJA = table.Column<int>(type: "int", nullable: true),
                    MAQUINAS_POS_CHIP_VIVO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_MAQUINAS_POS_CHIP_VIVO = table.Column<int>(type: "int", nullable: true),
                    LOJA_POSSUI_REVISTA_VIVO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_LOJA_POSSUI_REVISTA_VIVO = table.Column<int>(type: "int", nullable: true),
                    POSSUI_COD_DEF_CONS = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_POSSUI_COD_DEF_CONS = table.Column<int>(type: "int", nullable: true),
                    VITRINE_EXTERNA_POSITIVADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_VITRINE_EXTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    VITRINE_INTERNA_POSITIVADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_VITRINE_INTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ACESSO_POSITIVADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_AREA_ACESSO_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ESPERA_POSITIVADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_AREA_ESPERA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ATEND_POSITIVADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_AREA_ATEND_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    APARELHOS_POSSUEM_VINHETA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_APARELHOS_POSSUEM_VINHETA = table.Column<int>(type: "int", nullable: true),
                    VINHETA_DEVICE_FUNCIONANDO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_DEVICE_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    DISPLAYS_LOJA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_DISPLAYS_LOJA = table.Column<int>(type: "int", nullable: true),
                    SEGURANCA_DEGUSTADORES_LOJA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_SEGURANCA_DEGUSTADORES_LOJA = table.Column<int>(type: "int", nullable: true),
                    EQUIPE_UNIFORMIZADA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_EQUIPE_UNIFORMIZADA = table.Column<int>(type: "int", nullable: true),
                    PROMOTORES_UNIFORMIZADOS = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_PROMOTORES_UNIFORMIZADOS = table.Column<int>(type: "int", nullable: true),
                    COLABORADORES_USAM_CRACHA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_COLABORADORES_USAM_CRACHA = table.Column<int>(type: "int", nullable: true),
                    ATLYS_CONSULTOR_1 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_ATLYS_CONSULTOR_1 = table.Column<int>(type: "int", nullable: true),
                    ATLYS_CONSULTOR_2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_ATLYS_CONSULTOR_2 = table.Column<int>(type: "int", nullable: true),
                    VIVO_360_CONSULTOR_1 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_VIVO_360_CONSULTOR_1 = table.Column<int>(type: "int", nullable: true),
                    VIVO_360_CONSULTOR_2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_VIVO_360_CONSULTOR_2 = table.Column<int>(type: "int", nullable: true),
                    NSIA_CONSULTOR_1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PONTUACAO_NSIA_CONSULTOR_1 = table.Column<int>(type: "int", nullable: true),
                    NSIA_CONSULTOR_2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PONTUACAO_NSIA_CONSULTOR_2 = table.Column<int>(type: "int", nullable: true),
                    WEB_VENDAS_CONSULTOR_1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PONTUACAO_WEB_VENDAS_CONSULTOR_1 = table.Column<int>(type: "int", nullable: true),
                    WEB_VENDAS_CONSULTOR_2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PONTUACAO_WEB_VENDAS_CONSULTOR_2 = table.Column<int>(type: "int", nullable: true),
                    TREINA_APP_CONSULTOR_1 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_TREINA_APP_CONSULTOR_1 = table.Column<int>(type: "int", nullable: true),
                    TREINA_AAP_CONSULTOR_2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_TREINA_APP_CONSULTOR_2 = table.Column<int>(type: "int", nullable: true),
                    EMISSAO_SENHA_TESTE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_EMISSAO_SENHA_TESTE = table.Column<int>(type: "int", nullable: true),
                    CAIXA_LOJA_ABERTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_CAIXA_LOJA_ABERTO = table.Column<int>(type: "int", nullable: true),
                    FECHAMENTO_FINANCEIRO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_FECHAMENTO_FINANCEIRO = table.Column<int>(type: "int", nullable: true),
                    AREAS_LOJA_OK = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_AREAS_LOJA_OK = table.Column<int>(type: "int", nullable: true),
                    METAS_LOJA_OK = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_METAS_LOJA_OK = table.Column<int>(type: "int", nullable: true),
                    CARTAZ_ATITUDES_OK = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_CARTAZ_ATITUDES_OK = table.Column<int>(type: "int", nullable: true),
                    PA_LOJA_OK = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PONTUACAO_PA_LOJA_OK = table.Column<int>(type: "int", nullable: true),
                    CURSO_FOCO = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PONTUACAO_CURSO_FOCO = table.Column<int>(type: "int", nullable: true),
                    TRILHA_CONHECIMENTO = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PONTUACAO_TRILHA_CONHECIMENTO = table.Column<int>(type: "int", nullable: true),
                    ALTAS_MIGRAS = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PONTUACAO_ALTAS_MIGRAS = table.Column<int>(type: "int", nullable: true),
                    GESTAO_ALTAS_MIGRAS_DOC = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PONTUACAO_GESTAO_ALTAS_MIGRAS_DOC = table.Column<int>(type: "int", nullable: true),
                    GESTAO_TROCA_CHIP_DOC = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PONTUACAO_GESTAO_TROCA_CHIP_DOC = table.Column<int>(type: "int", nullable: true),
                    GESTAO_TROCA_PLANO_DOC = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PONTUACAO_GESTAO_TROCA_PLANO_DOC = table.Column<int>(type: "int", nullable: true),
                    ADESAO_CONTA_DIGITAL = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    PONTUACAO_ADESAO_CONTA_DIGITAL = table.Column<int>(type: "int", nullable: true),
                    PLANEJADOR_KPI = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PONTUACAO_PLANEJADOR_KPI = table.Column<int>(type: "int", nullable: true),
                    SCORE = table.Column<int>(type: "int", nullable: true),
                    ID_ACESSO = table.Column<int>(type: "int", nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LP_CICLO_3",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ABADAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_PONTUACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXISTE_GERENTE_AUDITORIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUSTIFICATIVA_AUSENCIA_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DESC_JUSTIFICATIVA_AUSENCIA_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AUSENCIA_GERENTE_JUSTIFICAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GERENTE_AUDITORIA = table.Column<int>(type: "int", nullable: true),
                    EXISTE_GURU_AUDITORIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUSTIFICATIVA_AUSENCIA_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DESC_JUSTIFICATIVA_AUSENCIA_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AUSENCIA_GURU_JUSTIFICAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GURU_AUDITORIA = table.Column<int>(type: "int", nullable: true),
                    CARTAZ_10_ATITUDES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CARTAZ_10_ATITUDES = table.Column<int>(type: "int", nullable: true),
                    CONSULTOR_ENTRADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CONSULTOR_ENTRADA = table.Column<int>(type: "int", nullable: true),
                    LIDER_MERCHAN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_LIDER_MERCHAN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUSTIFICATIVA_AUSENCIA_LIDER_MERCHAN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DESC_JUSTIFICATIVA_AUSENCIA_LIDER_MERCHAN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AUSENCIA_LIDER_MERCHAN_JUSTIFICAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LIDER_MERCHAN = table.Column<int>(type: "int", nullable: true),
                    COLABORADORES_CRACHA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COLABORADORES_CRACHA = table.Column<int>(type: "int", nullable: true),
                    ACESSO_GERENTE_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_GERENTE_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_GERENTE_360 = table.Column<int>(type: "int", nullable: true),
                    ACESSO_ATLYS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_ATLYS = table.Column<int>(type: "int", nullable: true),
                    ACESSO_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_360 = table.Column<int>(type: "int", nullable: true),
                    ACESSO_NSIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_NSIA = table.Column<int>(type: "int", nullable: true),
                    ACESSO_WEBVENDAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_WEBVENDAS = table.Column<int>(type: "int", nullable: true),
                    ACESSO_KIPON = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_KIPON = table.Column<int>(type: "int", nullable: true),
                    ACESSO_TREINAPP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_TREINAPP = table.Column<int>(type: "int", nullable: true),
                    EMISSAO_SENHA_TESTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EMISSAO_SENHA_TESTE = table.Column<int>(type: "int", nullable: true),
                    APARELHO_ECO_RATING = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FACHADA_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_FACHADA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    LOGO_LUMINOSO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LOGO_LUMINOSO = table.Column<int>(type: "int", nullable: true),
                    SOLEIRA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PORTICO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ICONE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    INSTALACAO_ICONE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ICONE = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_ANTIROMBADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_ANTIROMBADA = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_HORARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_HORARIO = table.Column<int>(type: "int", nullable: true),
                    PAREDE_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGO_PAREDE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PAREDE_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    PISO_PADRONIZADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PISO_PADRONIZADO = table.Column<int>(type: "int", nullable: true),
                    TAV_FUNCIONANDO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXISTE_CHAMADO_TAV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NUM_CHAMADO_TAV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_TAV_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    GSS_FUNCIONANDO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXISTE_CHAMADO_GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NUM_CHAMADO_GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GSS_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    POSSUI_SVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MESA_DEGUSTACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PAINEL_ACESSORIOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PRODUTOS_PRECIFICADOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    WALL_TESTEIRA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_URNA_COLETORA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OUTRO_MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_URNA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    ESPACO_TV_POLTRONA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADESIVO_CARREGUE_AQUI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOSAICO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    COMUNICACAO_MOSAICO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PUFFS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GIGANTOGRAFIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ANTI_ROMBADA_GERENTE_PREMIUM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MESA_ATEND_PRIORITARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ESPACO_ATEND_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CADEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOBILIARIO_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MOBILIARIO_LOJA = table.Column<int>(type: "int", nullable: true),
                    LIXEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LIXEIRAS_PADRONIZADAS = table.Column<int>(type: "int", nullable: true),
                    ILUMINACAO_AGRADAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LAMPADA_QUEIMADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ILUMINACAO_AGRADAVEL = table.Column<int>(type: "int", nullable: true),
                    POLUICAO_VISUAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POLUICAO_VISUAL = table.Column<int>(type: "int", nullable: true),
                    COMUNICACAO_LEGAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COMUNICACAO_LEGAL = table.Column<int>(type: "int", nullable: true),
                    NUMERACAO_PA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_NUMERACAO_PA = table.Column<int>(type: "int", nullable: true),
                    VITRINE_EXTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_EXTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    VITRINE_INTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_INTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ESPERA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ESPERA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ATEND_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ATEND_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    EQUIPE_UNIFORMIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ERRO_EQUIPE_UNIFORMIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EQUIPE_UNIFORMIZADA = table.Column<int>(type: "int", nullable: true),
                    SCORE = table.Column<int>(type: "int", nullable: true),
                    ID_ACESSO = table.Column<int>(type: "int", nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_REVENDA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LAUDA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ABADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GERENTE_PRESENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GERENTE_PRESENTE = table.Column<int>(type: "int", nullable: true),
                    NOME_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUSTIFICATIVA_AUSENCIA_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_AUSENCIA_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AUSENCIA_GERENTE_JUSTIFICAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GERENTE_POSSUI_ACESSO_VIVO_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GERENTE_POSSUI_ACESSO_VIVO_360 = table.Column<int>(type: "int", nullable: true),
                    LOGIN_GERENTE_VIVO_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    QTD_VENDEDORES_LOJA = table.Column<int>(type: "int", nullable: true),
                    NOME_VEND_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_VEND_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_VIVO_360_VEND_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_VEND_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_VEND_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_VIVO_360_VEND_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_VEND_3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_VEND_3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_VIVO_360_VEND_3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VENDEDORES_POSSUEM_ACESSO_VIVO_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VENDEDORES_POSSUEM_ACESSO_VIVO_360 = table.Column<int>(type: "int", nullable: true),
                    GURU_PRESENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GURU_PRESENTE = table.Column<int>(type: "int", nullable: true),
                    NOME_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_VIVO_360_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUST_AUS_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_AUS_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AUSENCIA_JUSTIFICAVEL_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EQUIPE_UNIFORMIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EQUIPE_UNIFORMIZADA = table.Column<int>(type: "int", nullable: true),
                    EXISTE_PROMOTOR_FABRICANTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VITRINE_EXTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_EXTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    VITRINE_INTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_INTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ACESSO_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ACESSO_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ESPERA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ESPERA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ATEND_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ATEND_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    EXISTE_POLUICAO_VIS_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EXISTE_POLUICAO_VIS_LOJA = table.Column<int>(type: "int", nullable: true),
                    DISPLAYS_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_DISPLAYS_LOJA = table.Column<int>(type: "int", nullable: true),
                    FACHADA_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_FACHADA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    PISO_PADRONIZADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PISO_PADRONIZADO = table.Column<int>(type: "int", nullable: true),
                    PAREDE_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PAREDE_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    CADEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CADEIRAS_PADRONIZADAS = table.Column<int>(type: "int", nullable: true),
                    LIXEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LIXEIRAS_PADRONIZADAS = table.Column<int>(type: "int", nullable: true),
                    LAMPADAS_FUNCIONANDO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LAMPADAS_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    AR_COND_LIGADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AR_COND_LIGADO = table.Column<int>(type: "int", nullable: true),
                    TAV_FUNCIONANDO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXISTE_CHAMADO_TAV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NUM_CHAMADO_TAV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_TAV_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    GSS_FUNCIONANDO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXISTE_CHAMADO_GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NUM_CHAMADO_GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GSS_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    LOJA_LIMPA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LOJA_LIMPA = table.Column<int>(type: "int", nullable: true),
                    MOBILIARIO_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MOBILIARIO_LOJA = table.Column<int>(type: "int", nullable: true),
                    MOBILIARIO_FABRICANTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSSUI_MOBILIARIO_FABRICANTE = table.Column<int>(type: "int", nullable: true),
                    POSSUI_URNA_COLETORA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OUTRO_MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSSUI_URNA_COLETORA = table.Column<int>(type: "int", nullable: true),
                    POSSUI_PC_TABLET = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_IMPRESSORA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_SCANNER = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_TEL_1058 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NUM_TEL_1058 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_PIN_PAD = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_PISTOLA_LEITURA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_COD_DEF_CONS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSSUI_MATERIAIS_BASICOS = table.Column<int>(type: "int", nullable: true),
                    VELOCIDADE_INTERNET = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VELOCIDADE_INTERNET = table.Column<int>(type: "int", nullable: true),
                    PA_ARVORE_OFERTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PA_ARVORE_OFERTA = table.Column<int>(type: "int", nullable: true),
                    VIVO_360_OK = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_FALHA_VIVO_OK = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VIVO_360_OK = table.Column<int>(type: "int", nullable: true),
                    VIVO_GED_OK = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_FALHA_VIVO_GED = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VIVO_GED_OK = table.Column<int>(type: "int", nullable: true),
                    EMISSAO_SENHA_GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EMISSAO_SENHA_GSS = table.Column<int>(type: "int", nullable: true),
                    QUADRO_GESTAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_QUADRO_GESTAO = table.Column<int>(type: "int", nullable: true),
                    CAPACITACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CAPACITACAO = table.Column<int>(type: "int", nullable: true),
                    ALTAS_MIGRAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ALTAS_MIGRAS = table.Column<int>(type: "int", nullable: true),
                    TROCA_CHIP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_TROCA_CHIP = table.Column<int>(type: "int", nullable: true),
                    TROCA_PLANO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_TROCA_PLANO = table.Column<int>(type: "int", nullable: true),
                    SCORE = table.Column<int>(type: "int", nullable: true),
                    ID_ACESSO = table.Column<int>(type: "int", nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_REVENDA_CICLO_3",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PONTUACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ABADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GERENTE_PRESENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUSTIFICATIVA_AUSENCIA_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DESCRICAO_OUTRO_MOTIVO_AUSENCIA_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AUSENCIA_GERENTE_JUSTIFICAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GERENTE_PRESENTE = table.Column<int>(type: "int", nullable: true),
                    GURU_PRESENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUSTIFICATIVA_AUSENCIA_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DESCRICAO_OUTRO_MOTIVO_AUSENCIA_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AUSENCIA_GURU_JUSTIFICAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GURU_PRESENTE = table.Column<int>(type: "int", nullable: true),
                    EQUIPE_UNIFORMIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ERRO_EQUIPE_UNIFORMIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EQUIPE_UNIFORMIZADA = table.Column<int>(type: "int", nullable: true),
                    CARTAZ_ATITUDES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CARTAZ_ATITUDES = table.Column<int>(type: "int", nullable: true),
                    GERENTE_POSSUI_ACESSO_VIVO_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_GERENTE_VIVO_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GERENTE_POSSUI_ACESSO_VIVO_360 = table.Column<int>(type: "int", nullable: true),
                    ACESSO_ATLYS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_ATLYS = table.Column<int>(type: "int", nullable: true),
                    ACESSO_360 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_360 = table.Column<int>(type: "int", nullable: true),
                    ACESSO_NSIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_NSIA = table.Column<int>(type: "int", nullable: true),
                    ACESSO_WEB_VENDAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_WEB_VENDAS = table.Column<int>(type: "int", nullable: true),
                    ACESSO_KIPON = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_KIPON = table.Column<int>(type: "int", nullable: true),
                    ACESSO_TREINAPP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSO_TREINAPP = table.Column<int>(type: "int", nullable: true),
                    FACHADA_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_FACHADA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    LOGO_LUMINOSO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LOGO_LUMINOSO = table.Column<int>(type: "int", nullable: true),
                    SOLEIRA_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PORTICO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_ICONE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ICONE_INSTALADO_PADRAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ICONE = table.Column<int>(type: "int", nullable: true),
                    PONTUACAO_INSTALACAO_ICONE = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_ANTIROMBADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_ANTIROMBADA = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_HORARIO_FUNC = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_HORARIO_FUNC = table.Column<int>(type: "int", nullable: true),
                    PAREDE_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PAREDE_PADRONIZADA_STENCIL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PAREDE_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    PISO_PADRONIZADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PISO_PADRONIZADO = table.Column<int>(type: "int", nullable: true),
                    TAV_FUNCIONANDO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXISTE_CHAMADO_TAV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NUM_CHAMADO_TAV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_TAV_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    GSS_FUNCIONANDO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXISTE_CHAMADO_GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NUM_CHAMADO_GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GSS_FUNCIONANDO = table.Column<int>(type: "int", nullable: true),
                    MODULO_SVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MODULO_SVA = table.Column<int>(type: "int", nullable: true),
                    MESA_DEGUSTACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PAINEL_ACC = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PRECIFICACAO_PRODUTOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    WALL_TESTEIRA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_URNA_COLETORA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OUTRO_MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSSUI_URNA_COLETORA = table.Column<int>(type: "int", nullable: true),
                    ESPACO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADESIVO_CARREGUE_AQUI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOSAICO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    COMUNICACAO_MOSAICO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PUFF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GIGANTOGRAFIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADESIVO_PREMIUM_GERENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MESA_BANCADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ESPACO_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BANQUETAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOBILIARIO_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MOBILIARIO_LOJA = table.Column<int>(type: "int", nullable: true),
                    LIXEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_LIXEIRAS_PADRONIZADAS = table.Column<int>(type: "int", nullable: true),
                    ILUMINACAO_AGRADAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LAMPADA_QUEIMADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ILUMINACAO_AGRADAVEL = table.Column<int>(type: "int", nullable: true),
                    PONTUACAO_LAMPADA_QUEIMADA = table.Column<int>(type: "int", nullable: true),
                    EXISTE_POLUICAO_VIS_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EXISTE_POLUICAO_VIS_LOJA = table.Column<int>(type: "int", nullable: true),
                    COMUNICACAO_LEGAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COMUNICACAO_LEGAL = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_PA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_PA = table.Column<int>(type: "int", nullable: true),
                    VITRINE_EXTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_EXTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    VITRINE_INTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_INTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ESPERA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ESPERA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    AREA_ATEND_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ATEND_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    VELOCIDADE_INTERNET = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VELOCIDADE_INTERNET = table.Column<int>(type: "int", nullable: true),
                    SCORE = table.Column<int>(type: "int", nullable: true),
                    ID_ACESSO = table.Column<int>(type: "int", nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PRE_PEX_LP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ABADAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FACHADA_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_FACHADA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    PAREDE_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PAREDE_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    PISO_PADRONIZADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_PISO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PISO_PADRONIZADO = table.Column<int>(type: "int", nullable: true),
                    CADEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_CADEIRAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CADEIRAS = table.Column<int>(type: "int", nullable: true),
                    POSSUI_URNA_COLETORA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OUTRO_MATERIAL_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_URNA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_URNA_PADRONIZADA = table.Column<int>(type: "int", nullable: true),
                    POLUICAO_VISUAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_POLUICAO_VISUAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POLUICAO_VISUAL = table.Column<int>(type: "int", nullable: true),
                    QUADRO_GESTAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_QUADRO_GESTAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_QUADRO_GESTAO = table.Column<int>(type: "int", nullable: true),
                    PASTA_CONTIGENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_PASTA_CONTIGENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PASTA_CONTIGENCIA = table.Column<int>(type: "int", nullable: true),
                    ACESSORIOS_POSITIVADOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MOTIVO_ACESSORIOS_POSITIVADOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSORIOS_POSITIVADOS = table.Column<int>(type: "int", nullable: true),
                    VITRINE_EXTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_EXTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    VITRINE_INTERNA_POSITIVADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VITRINE_INTERNA_POSITIVADA = table.Column<int>(type: "int", nullable: true),
                    KPI_ENVIADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_KPI_ENVIADO = table.Column<int>(type: "int", nullable: true),
                    CAPACITACAO_FOCO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CAPACITACAO_FOCO = table.Column<int>(type: "int", nullable: true),
                    MEDIA_CAPACITACAO_FOCO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MEDIA_CAPACITACAO_FOCO = table.Column<int>(type: "int", nullable: true),
                    QSC_FIXA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_QSC_FIXA = table.Column<int>(type: "int", nullable: true),
                    QSC_MOVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_QSC_MOVEL = table.Column<int>(type: "int", nullable: true),
                    RECEPCAO_CLIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_RECEPCAO_CLIENTE = table.Column<int>(type: "int", nullable: true),
                    VENDEDOR_PERGUNTOU_NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VENDEDOR_PERGUNTOU_NOME = table.Column<int>(type: "int", nullable: true),
                    VENDEDOR_DISSE_NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VENDEDOR_DISSE_NOME = table.Column<int>(type: "int", nullable: true),
                    EMISSAO_SENHA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EMISSAO_SENHA = table.Column<int>(type: "int", nullable: true),
                    SENHA_ENTREGUE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_SENHA_ENTREGUE = table.Column<int>(type: "int", nullable: true),
                    ACOMPANHAMENTO_SENHA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACOMPANHAMENTO_SENHA = table.Column<int>(type: "int", nullable: true),
                    ATENDIMENTO_CR_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ATENDIMENTO_CR_GURU = table.Column<int>(type: "int", nullable: true),
                    SENHA_CHAMADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_SENHA_CHAMADA = table.Column<int>(type: "int", nullable: true),
                    PRODUTOS_MOVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PRODUTOS_MOVEL = table.Column<int>(type: "int", nullable: true),
                    PRODUTOS_FIXA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PRODUTOS_FIXA = table.Column<int>(type: "int", nullable: true),
                    PERGUNTAS_COLABORADOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PERGUNTAS_COLABORADOR = table.Column<int>(type: "int", nullable: true),
                    NECESSIDADES_CLIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_NECESSIDADES_CLIENTE = table.Column<int>(type: "int", nullable: true),
                    OFERTA_SVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_OFERTA_SVA = table.Column<int>(type: "int", nullable: true),
                    COMPARTILHAMENTO_PLANO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COMPARTILHAMENTO_PLANO = table.Column<int>(type: "int", nullable: true),
                    COMBO_DIGITAL_POS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COMBO_DIGITAL_POS = table.Column<int>(type: "int", nullable: true),
                    DOUBLE_PLAY = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_DOUBLE_PLAY = table.Column<int>(type: "int", nullable: true),
                    CONTA_DIGITAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CONTA_DIGITAL = table.Column<int>(type: "int", nullable: true),
                    DEBITO_AUTOMATICO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_DEBITO_AUTOMATICO = table.Column<int>(type: "int", nullable: true),
                    VIVO_RENOVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VIVO_RENOVA = table.Column<int>(type: "int", nullable: true),
                    PORTABILIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PORTABILIDADE = table.Column<int>(type: "int", nullable: true),
                    EXPLICACAO_PORTABILIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EXPLICACAO_PORTABILIDADE = table.Column<int>(type: "int", nullable: true),
                    VENDA_APARELHO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VENDA_APARELHO = table.Column<int>(type: "int", nullable: true),
                    VIVO_VALORIZA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VIVO_VALORIZA = table.Column<int>(type: "int", nullable: true),
                    FINALIZACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_FINALIZACAO = table.Column<int>(type: "int", nullable: true),
                    PESQUISA_SATISFACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PESQUISA_SATISFACAO = table.Column<int>(type: "int", nullable: true),
                    INFORMACAO_PESQUISA_SATISFACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INFORMACAO_PESQUISA_SATISFACAO = table.Column<int>(type: "int", nullable: true),
                    APRESENTACAO_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_APRESENTACAO_LOJA = table.Column<int>(type: "int", nullable: true),
                    COLABORADOR_PROXIMO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COLABORADOR_PROXIMO = table.Column<int>(type: "int", nullable: true),
                    SCRIPT_VENDA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_SCRIPT_VENDA = table.Column<int>(type: "int", nullable: true),
                    INSISTENCIA_VENDEDOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INSISTENCIA_VENDEDOR = table.Column<int>(type: "int", nullable: true),
                    POSTURA_COLABORADOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSTURA_COLABORADOR = table.Column<int>(type: "int", nullable: true),
                    INFORMACAO_VANTAGEM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INFORMACAO_VANTAGEM = table.Column<int>(type: "int", nullable: true),
                    ACESSORIOS_LUGAR_CORRETO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSORIOS_LUGAR_CORRETO = table.Column<int>(type: "int", nullable: true),
                    COLABORADORES_UNIFORME_CORRETO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COLABORADORES_UNIFORME_CORRETO = table.Column<int>(type: "int", nullable: true),
                    APARELHOS_DISPLAY_LIGADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_APARELHOS_DISPLAY_LIGADO = table.Column<int>(type: "int", nullable: true),
                    MUSICA_AMBIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MUSICA_AMBIENTE = table.Column<int>(type: "int", nullable: true),
                    MEU_VIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MEU_VIVO = table.Column<int>(type: "int", nullable: true),
                    VOCABULARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VOCABULARIO = table.Column<int>(type: "int", nullable: true),
                    GIRIAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GIRIAS = table.Column<int>(type: "int", nullable: true),
                    INTERRUPCAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INTERRUPCAO = table.Column<int>(type: "int", nullable: true),
                    CHAMAR_NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CHAMAR_NOME = table.Column<int>(type: "int", nullable: true),
                    RETORNAR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_RETORNAR = table.Column<int>(type: "int", nullable: true),
                    SCORE = table.Column<int>(type: "int", nullable: true),
                    ID_ACESSO = table.Column<int>(type: "int", nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DDD = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AREA_ATENDIMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_AREA_ATENDIMENTO = table.Column<int>(type: "int", nullable: true),
                    SCORE_CLIENTE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PRE_PEX_REVENDA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ABADAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    POSSUI_SOLEIRA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSSUI_SOLEIRA = table.Column<int>(type: "int", nullable: true),
                    PORTICO_ACESSO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PORTICO_ACESSO = table.Column<int>(type: "int", nullable: true),
                    LOJA_POSSUI_ICONE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ICONE_INSTALADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ICONE = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_ANTIROMBADA_PORTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_ANTIROMBADA_PORTA = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_HORARIO_FUNCIONAMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_HORARIO_FUNCIONAMENTO = table.Column<int>(type: "int", nullable: true),
                    PAREDE_PADRONIZADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    STENCIL_LOGO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PAREDE_STENCIL = table.Column<int>(type: "int", nullable: true),
                    POSSUI_SVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSSUI_SVA = table.Column<int>(type: "int", nullable: true),
                    PAINEL_ACESSORIOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PRODUTOS_PRECIFICADOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PAINEL_ACESSORIOS = table.Column<int>(type: "int", nullable: true),
                    WALL_TESTEIRA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_WALL_TESTEIRA = table.Column<int>(type: "int", nullable: true),
                    ESPACO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ESPACO_TV = table.Column<int>(type: "int", nullable: true),
                    ADESIVO_CARREGUE_AQUI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ADESIVO_CARREGUE_AQUI = table.Column<int>(type: "int", nullable: true),
                    MOSAICO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MOSAICO_TV = table.Column<int>(type: "int", nullable: true),
                    PUFFS_ESPACO_TV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PUFFS_ESPACO_TV = table.Column<int>(type: "int", nullable: true),
                    GIGANTOGRAFIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOCAIS_GIGANTOGRAFIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GIGANTOGRAFIA = table.Column<int>(type: "int", nullable: true),
                    ANTIROMBADA_SALAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ANTIROMBADA_SALAS = table.Column<int>(type: "int", nullable: true),
                    MESA_ATENDIMENTO_PRIORITARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MESA_ATENDIMENTO_PRIORITARIO = table.Column<int>(type: "int", nullable: true),
                    NUMERACAO_PA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_NUMERACAO_PA = table.Column<int>(type: "int", nullable: true),
                    CADEIRAS_PADRONIZADAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CADEIRAS_PADRONIZADAS = table.Column<int>(type: "int", nullable: true),
                    ILUMINACAO_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ILUMINACAO_LOJA = table.Column<int>(type: "int", nullable: true),
                    COLABORADORES_UNIFORMIZADOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COLABORADORES_UNIFORMIZADOS = table.Column<int>(type: "int", nullable: true),
                    RECEPCAO_CLIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_RECEPCAO_CLIENTE = table.Column<int>(type: "int", nullable: true),
                    VENDEDOR_PERGUNTOU_NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VENDEDOR_PERGUNTOU_NOME = table.Column<int>(type: "int", nullable: true),
                    VENDEDOR_DISSE_NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VENDEDOR_DISSE_NOME = table.Column<int>(type: "int", nullable: true),
                    EMISSAO_SENHA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EMISSAO_SENHA = table.Column<int>(type: "int", nullable: true),
                    SENHA_ENTREGUE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_SENHA_ENTREGUE = table.Column<int>(type: "int", nullable: true),
                    ACOMPANHAMENTO_SENHA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACOMPANHAMENTO_SENHA = table.Column<int>(type: "int", nullable: true),
                    ATENDIMENTO_CR_GURU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ATENDIMENTO_CR_GURU = table.Column<int>(type: "int", nullable: true),
                    SENHA_CHAMADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_SENHA_CHAMADA = table.Column<int>(type: "int", nullable: true),
                    PRODUTOS_MOVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PRODUTOS_MOVEL = table.Column<int>(type: "int", nullable: true),
                    PRODUTOS_FIXA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PRODUTOS_FIXA = table.Column<int>(type: "int", nullable: true),
                    PERGUNTAS_COLABORADOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PERGUNTAS_COLABORADOR = table.Column<int>(type: "int", nullable: true),
                    NECESSIDADES_CLIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_NECESSIDADES_CLIENTE = table.Column<int>(type: "int", nullable: true),
                    OFERTA_SVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_OFERTA_SVA = table.Column<int>(type: "int", nullable: true),
                    COMPARTILHAMENTO_PLANO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COMPARTILHAMENTO_PLANO = table.Column<int>(type: "int", nullable: true),
                    COMBO_DIGITAL_POS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COMBO_DIGITAL_POS = table.Column<int>(type: "int", nullable: true),
                    DOUBLE_PLAY = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_DOUBLE_PLAY = table.Column<int>(type: "int", nullable: true),
                    CONTA_DIGITAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CONTA_DIGITAL = table.Column<int>(type: "int", nullable: true),
                    DEBITO_AUTOMATICO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_DEBITO_AUTOMATICO = table.Column<int>(type: "int", nullable: true),
                    VIVO_RENOVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VIVO_RENOVA = table.Column<int>(type: "int", nullable: true),
                    PORTABILIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PORTABILIDADE = table.Column<int>(type: "int", nullable: true),
                    EXPLICACAO_PORTABILIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_EXPLICACAO_PORTABILIDADE = table.Column<int>(type: "int", nullable: true),
                    VENDA_APARELHO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VENDA_APARELHO = table.Column<int>(type: "int", nullable: true),
                    VIVO_VALORIZA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VIVO_VALORIZA = table.Column<int>(type: "int", nullable: true),
                    FINALIZACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_FINALIZACAO = table.Column<int>(type: "int", nullable: true),
                    PESQUISA_SATISFACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_PESQUISA_SATISFACAO = table.Column<int>(type: "int", nullable: true),
                    INFORMACAO_PESQUISA_SATISFACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INFORMACAO_PESQUISA_SATISFACAO = table.Column<int>(type: "int", nullable: true),
                    APRESENTACAO_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_APRESENTACAO_LOJA = table.Column<int>(type: "int", nullable: true),
                    COLABORADOR_PROXIMO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COLABORADOR_PROXIMO = table.Column<int>(type: "int", nullable: true),
                    SCRIPT_VENDA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_SCRIPT_VENDA = table.Column<int>(type: "int", nullable: true),
                    INSISTENCIA_VENDEDOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INSISTENCIA_VENDEDOR = table.Column<int>(type: "int", nullable: true),
                    POSTURA_COLABORADOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_POSTURA_COLABORADOR = table.Column<int>(type: "int", nullable: true),
                    INFORMACAO_VANTAGEM = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INFORMACAO_VANTAGEM = table.Column<int>(type: "int", nullable: true),
                    ACESSORIOS_LUGAR_CORRETO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_ACESSORIOS_LUGAR_CORRETO = table.Column<int>(type: "int", nullable: true),
                    COLABORADORES_UNIFORME_CORRETO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_COLABORADORES_UNIFORME_CORRETO = table.Column<int>(type: "int", nullable: true),
                    APARELHOS_DISPLAY_LIGADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_APARELHOS_DISPLAY_LIGADO = table.Column<int>(type: "int", nullable: true),
                    MUSICA_AMBIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MUSICA_AMBIENTE = table.Column<int>(type: "int", nullable: true),
                    MEU_VIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_MEU_VIVO = table.Column<int>(type: "int", nullable: true),
                    VOCABULARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_VOCABULARIO = table.Column<int>(type: "int", nullable: true),
                    GIRIAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_GIRIAS = table.Column<int>(type: "int", nullable: true),
                    INTERRUPCAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_INTERRUPCAO = table.Column<int>(type: "int", nullable: true),
                    CHAMAR_NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_CHAMAR_NOME = table.Column<int>(type: "int", nullable: true),
                    RETORNAR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PONTUACAO_RETORNAR = table.Column<int>(type: "int", nullable: true),
                    SCORE = table.Column<int>(type: "int", nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    SCORE_CLIENTE = table.Column<int>(type: "int", nullable: true),
                    ID_ACESSO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_ROTA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NomeFantasia = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Uf = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ObsDadosPDV = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CpfCnpjPDV = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NomePDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EnderecoPDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BairroPDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CidadePDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CurvaPDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    QtdChipHR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    QtdChipSKU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    QtdChipHROutOperadoras = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    QtdChipSKUOutOperadoras = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FaturamentoRecarga = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ConsultaSerial = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MaterialMerchanInterno = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MaterialMerchanInternoVisivel = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MaterialMerchanInternoConcorrencia = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MaterialMerchanExterno = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MaterialMerchanExternoVisivel = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MaterialMerchanExternoConcorrencia = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    RecargaEletronicaFuncionando = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TempoRetorno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PdvPossuiAdesivo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FreqVisitaVendedor = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    NomePromoVigente = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NrCadastroPromocao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IndiceSatisfacao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC0735C7EB02", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CIDADES",
                columns: table => new
                {
                    cidade_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desc_cidade = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    flg_estado = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    capacidade_rede_primaria = table.Column<int>(type: "int", nullable: true),
                    em_uso_rede_primaria = table.Column<int>(type: "int", nullable: true),
                    indisponivel_rede_primaria = table.Column<int>(type: "int", nullable: true),
                    disponivel_rede_primaria = table.Column<int>(type: "int", nullable: true),
                    saturacao_rede_primaria = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    capacidade_rede_secundaria = table.Column<int>(type: "int", nullable: true),
                    em_uso_rede_secundaria = table.Column<int>(type: "int", nullable: true),
                    indisponivel_rede_secundaria = table.Column<int>(type: "int", nullable: true),
                    disponivel_rede_secundaria = table.Column<int>(type: "int", nullable: true),
                    saturacao_rede_secundaria = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    qtd_predios_adequados = table.Column<int>(type: "int", nullable: true),
                    capacidade_predios_adequados = table.Column<int>(type: "int", nullable: true),
                    em_uso_predios_adequados = table.Column<int>(type: "int", nullable: true),
                    disponivel_predios_adequados = table.Column<int>(type: "int", nullable: true),
                    saturacao_predios_adequados = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    capacidade_rede_primaria_fibra = table.Column<int>(type: "int", nullable: true),
                    em_uso_rede_primaria_fibra = table.Column<int>(type: "int", nullable: true),
                    indisponivel_rede_primaria_fibra = table.Column<int>(type: "int", nullable: true),
                    disponivel_rede_primaria_fibra = table.Column<int>(type: "int", nullable: true),
                    saturacao_rede_primaria_fibra = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    capacidade_rede_secundaria_fibra = table.Column<int>(type: "int", nullable: true),
                    em_uso_rede_secundaria_fibra = table.Column<int>(type: "int", nullable: true),
                    indisponivel_rede_secundaria_fibra = table.Column<int>(type: "int", nullable: true),
                    disponivel_rede_secundaria_fibra = table.Column<int>(type: "int", nullable: true),
                    saturacao_rede_secundaria_fibra = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    qtd_predios_adequados_fibra = table.Column<int>(type: "int", nullable: true),
                    em_uso_predios_adequados_fibra = table.Column<int>(type: "int", nullable: true),
                    disponivel_predios_adequados_fibra = table.Column<int>(type: "int", nullable: true),
                    saturacao_predios_adequados_fibra = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    capacidade_predios_adequados_fibra = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "COBERTURA",
                columns: table => new
                {
                    COD_IBGE = table.Column<double>(type: "float", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD = table.Column<double>(type: "float", nullable: true),
                    Regional = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Município = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Móvel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    _4G = table.Column<string>(name: "4G", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fixo = table.Column<double>(type: "float", nullable: true),
                    BL_Fixa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PayTV = table.Column<string>(name: "Pay TV", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CoberturaExclusiva3G = table.Column<string>(name: "Cobertura Exclusiva 3G", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "COMISSIONAMENTO",
                columns: table => new
                {
                    uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    cod_credenc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    cod_ent_vend = table.Column<double>(type: "float", nullable: true),
                    cod_alvo = table.Column<double>(type: "float", nullable: true),
                    nome_ent_abr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    nome_ent = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    desc_tipo_comissao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tipo2 = table.Column<string>(name: "Tipo 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SomaDevalor = table.Column<double>(type: "float", nullable: true),
                    obs = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    competencia = table.Column<DateTime>(type: "datetime", nullable: true),
                    F15 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F16 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F17 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTAS_A_PAGAR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adabas = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Uf = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Fornecedor = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pedido = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataDocumento = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Lancamento = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    NotaFiscal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ValorNF = table.Column<decimal>(type: "decimal(20,2)", nullable: true),
                    Status = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tipo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PrevisaoDataPagto = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Sla = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Farol = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GerenteContas = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Territorio = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTAS_A__3214EC074356F04A", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONTAS_A_PAGAR_BKP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adabas = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Uf = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Fornecedor = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pedido = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataDocumento = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Lancamento = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NotaFiscal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ValorNF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tipo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PrevisaoDataPagto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Sla = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Farol = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GerenteContas = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Territorio = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Data_Atualizacao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTAS_A__3214EC074727812E", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE DE DEMANDAS RELATORIO LINHA TESTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    RESPONSAVEL = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    MATRICULA_SOLICITANTE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SOLICITANTE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    FILA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CAMPO_COMBOBOX = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OpçãoSelecionada = table.Column<string>(name: "Opção Selecionada", type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MOTIVO_FECHAMENTO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DATA_ABERTURA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_ENCERRAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DESCRICAO_PROBLEMA = table.Column<string>(type: "text", nullable: true),
                    DESCRICAO_SOLUCAO = table.Column<string>(type: "text", nullable: true),
                    PRIMEIRA_RESPOSTA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_ACESSO_LIMITE_CREDITO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAcesso = table.Column<DateTime>(type: "date", nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC072EFAF1E2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_ARQUIVOS_RESPOSTA",
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
                    table.PrimaryKey("PK__CONTROLE__3214EC273C8AC281", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPO_LISTA_ICCID",
                columns: table => new
                {
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: true),
                    NR_ICCID = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC2749E4BD9F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_FILA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FILA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADD_CAMPOS_AUTOMATICOS = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    MAT_QUEM_CRIOU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADD_CAMPOS_MUNICIPIOS = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    TIPO_CHAMADO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ADD_PDV_DESTINO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC2731190FD5", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_OPERADORES",
                columns: table => new
                {
                    LOGIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NIVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    UF = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO_BKP",
                columns: table => new
                {
                    ID_CAMPOS_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    VALOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_STATUS_CHAMADO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC2736D1E92B", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_SUGESTOES_NOMES_CAMPOS",
                columns: table => new
                {
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MASCARA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DEMANDAS_GRAFICO",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MESANO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QTD = table.Column<int>(type: "int", nullable: true),
                    IDRESPONSAVEL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TAB_RAIZ = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DATACADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATAFECHADO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DEMANDAS_LOGIN",
                columns: table => new
                {
                    ASSUNTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DEMANDAS_TABELA_GRAFICO",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MESANO = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    QTD = table.Column<int>(type: "int", nullable: true),
                    IDRESPONSAVEL = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TAB_RAIZ = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CREDENCIAMENTO = table.Column<int>(type: "int", nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOMEARQUIVO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC2733C07256", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_CADASTRO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DDD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RAZAOSOCIAL = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPOCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CANAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATACADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    IDACESSO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC272FEFE172", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_CHECKLIST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CREDENCIAMENTO = table.Column<int>(type: "int", nullable: true),
                    OPCAO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RESPONSAVEL = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC273B61941E", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_LINHA_TEMPO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CREDENCIAMENTO = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    IDACESSO = table.Column<int>(type: "int", nullable: true),
                    OBS = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC273791033A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_OPERADORES",
                columns: table => new
                {
                    LOGIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NIVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_PROSPECT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA_SOLICITANTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CANAL_CREDENCIAMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_PREVISTA_CREDENCIAMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    data_ultimo_status = table.Column<DateTime>(type: "datetime", nullable: true),
                    ultimo_status = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_TORNOU_CREDENCIAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TIPO_REVENDA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC27359E9927", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DADOS_PARA_CONTRATO_COMODATO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATA_APROVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DRN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CANAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_ASSINATURA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOTA_FISCAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IXOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DMS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NOME_COMERCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PESSOA_CONTATO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GERENTE_CONTAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FONE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGRADOURO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOCALIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    COD_POSTAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DADOS_PA__3214EC27A051CD31", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DADOS_PARA_CONTRATO_SOCIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADMINISTRACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ASSINATURA_NO_CONTRATO_VIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO_3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SOCIO_4 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_4 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DADOS_PA__3214EC27BABD613E", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DADOS_PESSOAIS_TERCEIROS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    Sexo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PrimeiroNome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SobreNome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NomeMae = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Funcao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rg = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    OrgaoEmissor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataNasc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PIS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMAILPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GESTORLIDER = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TELEFONEPESSOAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DASHBOARD_TERMINAIS_SIMULADOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fornecedor = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    ValorNF = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tipo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DASHBOAR__3214EC075A254709", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_BD_OPERADORES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA = table.Column<int>(type: "int", nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    STATUS = table.Column<bool>(type: "bit", nullable: true),
                    DT_MOD = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA_MOD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEMANDA___3214EC27D6B950B2", x => x.ID);
                });

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
                name: "DEMANDA_TIPO_FILA",
                columns: table => new
                {
                    ID_TIPO_FILA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_TIPO_FILA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    REGIONAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    STATUS_TIPO_FILA = table.Column<bool>(type: "bit", nullable: false),
                    MAT_CRIADOR = table.Column<int>(type: "int", nullable: false),
                    DT_CRIACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEMANDA___36A34C2CC293E3B4", x => x.ID_TIPO_FILA);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDAS_JSON",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FILA = table.Column<int>(type: "int", nullable: false),
                    REPOSTA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    STATUS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    REGIONAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DADOS_ABERTURA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    OBSERVACOES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DEMANDAS_TELEGRAM",
                columns: table => new
                {
                    ID = table.Column<double>(type: "float", nullable: true),
                    ID_STATUS_CHAMADO = table.Column<double>(type: "float", nullable: true),
                    FILA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA_RESPONSAVEL = table.Column<double>(type: "float", nullable: true),
                    RESPONSAVEL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA_SOLICITANTE = table.Column<double>(type: "float", nullable: true),
                    SOLICITANTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_ABERTURA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_FECHAMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MINUTOSSLAFECHAMENTOS = table.Column<double>(name: "MINUTOS SLA FECHAMENTOS", type: "float", nullable: true),
                    HORASSLAFECHAMENTOS = table.Column<DateTime>(name: "HORAS SLA FECHAMENTOS", type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAPRIMEIRARESPOSTA = table.Column<string>(name: "DATA PRIMEIRA RESPOSTA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MINUTOSSLAPRIMEIRARESPOSTA = table.Column<double>(name: "MINUTOS SLA PRIMEIRA RESPOSTA", type: "float", nullable: true),
                    HORAPRIMEIRARESPOSTA = table.Column<DateTime>(name: "HORA PRIMEIRA RESPOSTA", type: "datetime", nullable: true),
                    MOTIVO_FECHAMENTO_SUPORTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_CHAMADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_CADASTRO X",
                columns: table => new
                {
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_DESCREDENCIAMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MOTIVO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATASOLICITAÇÃO = table.Column<DateTime>(name: "DATA SOLICITAÇÃO ", type: "datetime", nullable: true),
                    CANCELADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS OLD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_INFORMADA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DATA_DATA_INFORMADA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "text", nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true),
                    LISTA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC2771FCD09A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS_BKP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_INFORMADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_DATA_INFORMADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "text", nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true),
                    LISTA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SLALINHA = table.Column<int>(name: "SLA LINHA", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC27F591EAAB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_DADOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DESCREDENCIAMENTO = table.Column<int>(type: "int", nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_INFORMADA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DATA_DATA_INFORMADA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "text", nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC2761C668D1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_VAREJO_CADASTRO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    IDACESSO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CANCELADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SITUACAO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC271E105D02", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_VAREJO_DADOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_INFORMADA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DATA_DATA_INFORMADA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "text", nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC27330B79E8", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EMAIL_CONTROLE_DEMANDAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCHAMADO = table.Column<int>(type: "int", nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TIPO_CHAMADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    REDE_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_ENVIO_EMAIL = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ESTOQUE_VITRINE_VIRTUAL",
                columns: table => new
                {
                    CENTRO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATERIAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESCRICAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DEPOSITO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SALDO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_CARGA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EXTE",
                columns: table => new
                {
                    DDD = table.Column<string>(name: "\"DDD\"", type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    TERRITÓRIO = table.Column<string>(name: "\"TERRITÓRIO\"", type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    UF = table.Column<string>(name: "\"UF\"", type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    CIDADE = table.Column<string>(name: "\"CIDADE\"", type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    BAIRRO = table.Column<string>(name: "\"BAIRRO\"", type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    MICRORREGIÃO = table.Column<string>(name: "\"MICRORREGIÃO\"", type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    CEP = table.Column<string>(name: "\"CEP\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO = table.Column<string>(name: "\"TIPO\"", type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    TITULO = table.Column<string>(name: "\"TITULO\"", type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    LOGRADOURO = table.Column<string>(name: "\"LOGRADOURO\"", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NÚMERO = table.Column<string>(name: "\"NÚMERO\"", type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    DATA_ARMÁRIO = table.Column<string>(name: "\"DATA_ARMÁRIO\"", type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    ARMÁRIO = table.Column<string>(name: "\"ARMÁRIO\"", type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    CAIXA = table.Column<string>(name: "\"CAIXA\"", type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    CAPACIDADE = table.Column<string>(name: "\"CAPACIDADE\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    USADOS = table.Column<string>(name: "\"USADOS\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISPONÍVEL = table.Column<string>(name: "\"DISPONÍVEL\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OCUPAÇÃO = table.Column<string>(name: "\"OCUPAÇÃO\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_LOTE = table.Column<string>(name: "\"STATUS_LOTE\"", type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    BADDEBT = table.Column<string>(name: "\"BADDEBT\"", type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FRAUDE = table.Column<string>(name: "\"FRAUDE\"", type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    SEGMENTO = table.Column<string>(name: "\"SEGMENTO\"", type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_CONDOMINIO = table.Column<string>(name: "\"COD_CONDOMINIO\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOM_CONDOMINIO = table.Column<string>(name: "\"NOM_CONDOMINIO\"", type: "varchar(22)", unicode: false, maxLength: 22, nullable: true),
                    ESTEIRA = table.Column<string>(name: "\"ESTEIRA\"", type: "varchar(27)", unicode: false, maxLength: 27, nullable: true),
                    DATA_ESTEIRA = table.Column<string>(name: "\"DATA_ESTEIRA\"", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PRIORIDADE = table.Column<string>(name: "\"PRIORIDADE\"", type: "varchar(34)", unicode: false, maxLength: 34, nullable: true),
                    BLOCOS = table.Column<string>(name: "\"BLOCOS\"", type: "varchar(34)", unicode: false, maxLength: 34, nullable: true),
                    QTD_APARTAMENTO = table.Column<string>(name: "\"QTD_APARTAMENTO\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_A = table.Column<string>(name: "\"CLASSE_A\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_B = table.Column<string>(name: "\"CLASSE_B\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_C = table.Column<string>(name: "\"CLASSE_C\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_AB = table.Column<string>(name: "\"CLASSE_AB\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO_RESIDENCIA = table.Column<string>(name: "\"TIPO_RESIDENCIA\"", type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    CLIENTE_FTTC = table.Column<string>(name: "\"CLIENTE_FTTC\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VENDAS = table.Column<string>(name: "\"VENDAS\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MIGRAÇÃO = table.Column<string>(name: "\"MIGRAÇÃO\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CEP_NUM = table.Column<string>(name: "\"CEP_NUM\"", type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    CLIENTE_FTTC_POR_DISPONIBILIDADE = table.Column<string>(name: "\"CLIENTE_FTTC_POR_DISPONIBILIDADE\"", type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    AGING_ARMÁRIO = table.Column<string>(name: "\"AGING_ARMÁRIO\"", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FATURAMENTOSAP",
                columns: table => new
                {
                    MES = table.Column<DateTime>(type: "datetime", nullable: true),
                    DT_MVMT_LNHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_NF = table.Column<DateTime>(type: "datetime", nullable: true),
                    NR_NOTA_FSCL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NR_SRAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_DOCT_FTRM = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_ORDM_VNDA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_TIPO_ORDM_VNDA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_TIPO_ORDM_VNDA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NR_CPF_CNPJ_SAP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPF_CLIENTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_RZAO_SCAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORGV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIO_UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD = table.Column<double>(type: "float", nullable: true),
                    SEGMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_CLT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL_FATURAMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CENT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME_FANTASIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJ_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATIVIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GENERO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATVD_CNL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FG_SHOPPING = table.Column<double>(type: "float", nullable: true),
                    FG_QUIOSQUE = table.Column<double>(type: "float", nullable: true),
                    FG_ESTOQUE_ZERO = table.Column<double>(type: "float", nullable: true),
                    CLASS_CLUSTER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLASS_DEALER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VOUCHER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_MTRL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ID_DPGC = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLASSIF_CATEGORIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CATEGORIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MODELO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME_COMERCIAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FABRICANTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GAMA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TECNOLOGIA_APARELHO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SISTEMA_OPERACIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_COND_PGTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_COND_PGTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DEPOSITO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_DPST = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QTDE_FATURADA = table.Column<double>(type: "float", nullable: true),
                    VALOR_NF = table.Column<double>(type: "float", nullable: true),
                    RECEITA_BRUTA = table.Column<double>(type: "float", nullable: true),
                    DESCONTO_TOTAL = table.Column<double>(type: "float", nullable: true),
                    VL_ICMS = table.Column<double>(type: "float", nullable: true),
                    ICMS_ST_BLENDED = table.Column<double>(type: "float", nullable: true),
                    PIS = table.Column<double>(type: "float", nullable: true),
                    COFINS = table.Column<double>(type: "float", nullable: true),
                    RECEITA_LIQUIDA_S_PRICE = table.Column<double>(type: "float", nullable: true),
                    RECEITA_LIQUIDA = table.Column<double>(type: "float", nullable: true),
                    CMV = table.Column<double>(type: "float", nullable: true),
                    VL_MARGEM_BRUTA = table.Column<double>(type: "float", nullable: true),
                    REBATE = table.Column<double>(type: "float", nullable: true),
                    VL_PRICE_FCDI = table.Column<double>(type: "float", nullable: true),
                    VALOR_DESCONTO_PPTO = table.Column<double>(type: "float", nullable: true),
                    VALOR_PAGO_PROG_PNTO = table.Column<double>(type: "float", nullable: true),
                    DESCONTO_FABRICANTE = table.Column<double>(type: "float", nullable: true),
                    DESCONTO_RENOVA = table.Column<double>(type: "float", nullable: true),
                    VL_SUBSIDIO_CALCULADO = table.Column<double>(type: "float", nullable: true),
                    VALOR_VENDA = table.Column<double>(type: "float", nullable: true),
                    VL_PVP_DW = table.Column<double>(type: "float", nullable: true),
                    VL_VNDA_VGO = table.Column<double>(type: "float", nullable: true),
                    DESCONTO_MANUAL = table.Column<double>(type: "float", nullable: true),
                    MODELO_RECEBIDO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ID_CLASSIF_PED = table.Column<double>(type: "float", nullable: true),
                    DESC_CLASSIF_PED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ID_CLASSIF_DOA = table.Column<double>(type: "float", nullable: true),
                    DESC_CLASSIF_DOA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_PROG_PNTO = table.Column<double>(type: "float", nullable: true),
                    FLAG_DESCONTO_MANUAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_ONLINE_LLPP = table.Column<double>(type: "float", nullable: true),
                    FLAG_RENOVA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_ATIVADO = table.Column<double>(type: "float", nullable: true),
                    FLAG_ULTIMO_FAT = table.Column<double>(type: "float", nullable: true),
                    FLAG_MOVIMENTO = table.Column<double>(type: "float", nullable: true),
                    FLAG_FONTE = table.Column<double>(type: "float", nullable: true),
                    DESC_FLAG_FONTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_PORTABILIDADE = table.Column<double>(type: "float", nullable: true),
                    CD_TIPO_PDDO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_TIPO_PDDO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ID_TIPO_MVMT_LNHA = table.Column<double>(type: "float", nullable: true),
                    DS_TIPO_MVMT_LNHA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AGRP_MVMT_LNHA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA_REGISTRO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NR_TLFN = table.Column<double>(type: "float", nullable: true),
                    DS_PLTF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DS_SIST_PGTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEGMENTO_PLANO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_PLNO_SIST_ORIG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DS_PLNO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PLANO_PRICING = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIT_DEP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CD_CRDN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_LOGN_ATND = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_FDLZ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_POLITICA_SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEMANA_DO_ANO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEMANA_DO_MÊS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLASSIF_DIFERIMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_VENHA_SER_VIVO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESC_CAMP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DT_REF_PAGAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FLAG_FCDI = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_LOGN_ATND_SAP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NM_LOGN_ATND_FDLZ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_PICK_UP_IN_STORE = table.Column<double>(type: "float", nullable: true),
                    NM_SIST_ORIG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MOT_ORDEM = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_ONLINE_RVNDA = table.Column<double>(type: "float", nullable: true),
                    DS_TIPO_MVMT_UP_DOWN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FLAG_VITRINE = table.Column<double>(type: "float", nullable: true),
                    SG_TRRT_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NO_TRRT_PDV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FIXA_BASE_PRUMA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_PREDIO = table.Column<int>(type: "int", nullable: true),
                    NOM_PREDIO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    COD_CONDOMINIO = table.Column<int>(type: "int", nullable: true),
                    NOM_CONDOMINIO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DAT_INSERCAO = table.Column<string>(type: "varchar(26)", unicode: false, maxLength: 26, nullable: true),
                    NOM_CONTVIST = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    NOM_CONTOBRAEXT = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    SEGMENTO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    LOGRADOURO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    NUMERO = table.Column<int>(type: "int", nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    ESTEIRA = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    DAT_LIB_COMERCIAL = table.Column<string>(type: "varchar(26)", unicode: false, maxLength: 26, nullable: true),
                    CUSTO_OBRA_EXT = table.Column<int>(type: "int", nullable: true),
                    BLOCOS = table.Column<int>(type: "int", nullable: true),
                    QTD_APARTAMENTO = table.Column<int>(type: "int", nullable: true),
                    PROSPECTOR = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CEP = table.Column<int>(type: "int", nullable: true),
                    DATA_ESTEIRA = table.Column<string>(type: "varchar(26)", unicode: false, maxLength: 26, nullable: true),
                    OBRA_RUA_ESPECIAL = table.Column<int>(type: "int", nullable: true),
                    OBRA_PREDIO_ESPECIAL = table.Column<int>(type: "int", nullable: true),
                    VAL_QTDVISTAG = table.Column<int>(type: "int", nullable: true),
                    PRIORIDADE = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    REDE = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    ARMARIO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CAIXA = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    UF = table.Column<string>(type: "varchar(26)", unicode: false, maxLength: 26, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(26)", unicode: false, maxLength: 26, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CASAS_CONSTRUIDAS = table.Column<int>(type: "int", nullable: true),
                    ARMARIO_COBRE = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CONCORRENCIA = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CLASSE = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CEP_NUM = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FIXA_BAS__3214EC27032573E8", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FIXA_VIEW_PAINEL_DE_ROTAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TERRITÓRIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MICRORREGIÃO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CEP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TITULO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LOGRADOURO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NÚMERO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ARMÁRIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ARMÁRIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CAIXA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CAPACIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    USADOS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISPONÍVEL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OCUPAÇÃO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_LOTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BADDEBT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FRAUDE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SEGMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COD_CONDOMINIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOM_CONDOMINIO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ESTEIRA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ESTEIRA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PRIORIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BLOCOS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QTD_APARTAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_A = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_B = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_C = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLASSE_AB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO_RESIDENCIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLIENTE_FTTC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VENDAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MIGRAÇÃO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CEP_NUM = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLIENTE_FTTC_POR_DISPONIBILIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AGING_ARMÁRIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FIXA_VIE__3214EC2792A20242", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FPD_FIXA_AGRUPADO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SAFRA_ALTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ESTADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN_VNDA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN_CNST = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLASSE_SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_CLIENTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL_INSTALACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL_CNST = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL_TRATADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DEALER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TECNOLOGIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_BL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_VOZ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_TV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_0 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_15 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_30 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_60 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_180 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_0 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_15 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_30 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_60 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_180 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FPD_FIXA_AGRUPADO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FPD_FIXA_ANALITICO",
                columns: table => new
                {
                    FPD_FIXA_ANALITICO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SAFRA_ALTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DT_ALTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NR_DOC = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ESTADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN_VNDA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN_CNST = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLASSE_SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_CLIENTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL_INSTALACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL_CNST = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL_TRATADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DEALER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TECNOLOGIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTA_COBRANCA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_BL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_VOZ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_TV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_0 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_15 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_30 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_60 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_180 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_0 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_15 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_30 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_60 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_180 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FPD_FIXA_ANALITICO", x => x.FPD_FIXA_ANALITICO_ID);
                });

            migrationBuilder.CreateTable(
                name: "HC_NORDESTE",
                columns: table => new
                {
                    MATRÍCULA = table.Column<double>(type: "float", nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CATEGORIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SIGLA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERÊNCIASR = table.Column<string>(name: "GERÊNCIA SR", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERÊNCIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COORDENAÇÃO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁREA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRÍCULAGESTORA = table.Column<double>(name: "MATRÍCULA GESTOR(A)", type: "float", nullable: true),
                    NOMEGESTORA = table.Column<string>(name: "NOME GESTOR(A)", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAILGESTORA = table.Column<string>(name: "E-MAIL GESTOR(A)", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ESTADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HEADCOUNT",
                columns: table => new
                {
                    Ano = table.Column<double>(type: "float", nullable: true),
                    Mês = table.Column<double>(type: "float", nullable: true),
                    Matrícula = table.Column<double>(type: "float", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Regional = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁreaRH = table.Column<string>(name: "Área RH", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Subarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Filial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Unidade = table.Column<double>(type: "float", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dir1 = table.Column<string>(name: "Dir 1", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dir2 = table.Column<string>(name: "Dir 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Div = table.Column<string>(name: "Div ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ger = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Área = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MatGestor = table.Column<double>(name: "Mat Gestor", type: "float", nullable: true),
                    Gestor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CentroCusto = table.Column<string>(name: "Centro Custo", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ObjetoCusto = table.Column<string>(name: "Objeto Custo", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrdemInterna = table.Column<string>(name: "Ordem Interna", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodCargo = table.Column<double>(name: "Cod Cargo", type: "float", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NvRelEspanha = table.Column<string>(name: "Nv Rel Espanha", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Subgrupo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vinculo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PosiçãoSAPHCM = table.Column<double>(name: "Posição SAP HCM", type: "float", nullable: true),
                    PosiçãoSSFF = table.Column<string>(name: "Posição SSFF", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Pirâmide = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Executivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nível = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CallCenter = table.Column<string>(name: "Call Center ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VariávelVendas = table.Column<string>(name: "Variável Vendas", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataAdmissão = table.Column<DateTime>(name: "Data Admissão", type: "datetime", nullable: true),
                    TempoEmpresa = table.Column<double>(name: "Tempo Empresa", type: "float", nullable: true),
                    TipoPonto = table.Column<string>(name: "Tipo Ponto", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Teletrabalho = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÂmbitoOrganizacional = table.Column<string>(name: "Âmbito Organizacional", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmpHyperion = table.Column<string>(name: "Emp Hyperion", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁreaFuncionalHyperion = table.Column<string>(name: "Área Funcional Hyperion", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataNascimento = table.Column<DateTime>(name: "Data Nascimento", type: "datetime", nullable: true),
                    Idade = table.Column<double>(type: "float", nullable: true),
                    ContIdade = table.Column<string>(name: "Cont-Idade", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EstadoCivil = table.Column<string>(name: "Estado Civil", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Raça = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GraudeInstrução = table.Column<string>(name: "Grau de Instrução", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Formação = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PCD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(name: "Email ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Comercial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Afastado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Motivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Início = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Término = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TempoAfastamento = table.Column<string>(name: "Tempo Afastamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estável = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estabilidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Início1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Término1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Headcount = table.Column<double>(type: "float", nullable: true),
                    FériasnoMês = table.Column<string>(name: "Férias no Mês", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InícioFérias = table.Column<string>(name: "Início Férias", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TérminoFérias = table.Column<string>(name: "Término Férias", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NºDepIRRF = table.Column<string>(name: "Nº Dep IRRF", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FTE = table.Column<double>(type: "float", nullable: true),
                    OperaçãoGlobal = table.Column<string>(name: "Operação Global", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CelClub = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sindicalizado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PrevPrivada = table.Column<string>(name: "Prev Privada ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Plano = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AssistMédica = table.Column<string>(name: "Assist Médica", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Plano1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipodePlano = table.Column<string>(name: "Tipo de Plano", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndereçoInfotipo6 = table.Column<string>(name: "Endereço - Infotipo  - 6", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Número = table.Column<double>(type: "float", nullable: true),
                    Comp = table.Column<double>(type: "float", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndereçoComercial = table.Column<string>(name: "Endereço Comercial", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Número1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Comp1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Processo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HEADCOUNT_CN",
                columns: table => new
                {
                    Ano = table.Column<double>(type: "float", nullable: true),
                    Mês = table.Column<double>(type: "float", nullable: true),
                    Matrícula = table.Column<double>(type: "float", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Regional = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁreaRH = table.Column<string>(name: "Área RH", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Subarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Filial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Unidade = table.Column<double>(type: "float", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dir1 = table.Column<string>(name: "Dir 1", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dir2 = table.Column<string>(name: "Dir 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Div = table.Column<string>(name: "Div ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ger = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Área = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MatGestor = table.Column<double>(name: "Mat Gestor", type: "float", nullable: true),
                    Gestor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CentroCusto = table.Column<string>(name: "Centro Custo", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ObjetoCusto = table.Column<string>(name: "Objeto Custo", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrdemInterna = table.Column<string>(name: "Ordem Interna", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CodCargo = table.Column<double>(name: "Cod Cargo", type: "float", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NvRelEspanha = table.Column<string>(name: "Nv Rel Espanha", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Subgrupo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vinculo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PosiçãoSAPHCM = table.Column<double>(name: "Posição SAP HCM", type: "float", nullable: true),
                    PosiçãoSSFF = table.Column<string>(name: "Posição SSFF", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Pirâmide = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Executivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nível = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Loja = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CallCenter = table.Column<string>(name: "Call Center ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VariávelVendas = table.Column<string>(name: "Variável Vendas", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataAdmissão = table.Column<DateTime>(name: "Data Admissão", type: "datetime", nullable: true),
                    TempoEmpresa = table.Column<double>(name: "Tempo Empresa", type: "float", nullable: true),
                    TipoPonto = table.Column<string>(name: "Tipo Ponto", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Teletrabalho = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÂmbitoOrganizacional = table.Column<string>(name: "Âmbito Organizacional", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmpHyperion = table.Column<string>(name: "Emp Hyperion", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ÁreaFuncionalHyperion = table.Column<string>(name: "Área Funcional Hyperion", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataNascimento = table.Column<DateTime>(name: "Data Nascimento", type: "datetime", nullable: true),
                    Idade = table.Column<double>(type: "float", nullable: true),
                    ContIdade = table.Column<string>(name: "Cont-Idade", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EstadoCivil = table.Column<string>(name: "Estado Civil", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Raça = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GraudeInstrução = table.Column<string>(name: "Grau de Instrução", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Formação = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PCD = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(name: "Email ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Comercial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Afastado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Motivo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Início = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Término = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TempoAfastamento = table.Column<string>(name: "Tempo Afastamento", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estável = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estabilidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Início1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Término1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Headcount = table.Column<double>(type: "float", nullable: true),
                    FériasnoMês = table.Column<string>(name: "Férias no Mês", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InícioFérias = table.Column<string>(name: "Início Férias", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TérminoFérias = table.Column<string>(name: "Término Férias", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NºDepIRRF = table.Column<string>(name: "Nº Dep IRRF", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FTE = table.Column<double>(type: "float", nullable: true),
                    OperaçãoGlobal = table.Column<string>(name: "Operação Global", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CelClub = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sindicalizado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PrevPrivada = table.Column<string>(name: "Prev Privada ", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Plano = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AssistMédica = table.Column<string>(name: "Assist Médica", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Plano1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TipodePlano = table.Column<string>(name: "Tipo de Plano", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndereçoInfotipo6 = table.Column<string>(name: "Endereço - Infotipo  - 6", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Número = table.Column<double>(type: "float", nullable: true),
                    Comp = table.Column<double>(type: "float", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndereçoComercial = table.Column<string>(name: "Endereço Comercial", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Número1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Comp1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Bairro1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UF2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CEP1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Processo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HISTORICO_ACESSOS_MOBILE_PENDENTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_ACESSOS_PENDENTE = table.Column<int>(type: "int", nullable: false),
                    MATRICULA = table.Column<int>(type: "int", nullable: true),
                    RESPOSTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    STATUS = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HISTORIC__3214EC276FEC305B", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ITENS_NAO_VENDA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INDICADOR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ITENS_NA__3214EC276A7C75BA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_ANSWER_ALTERNATIVAS",
                columns: table => new
                {
                    ID_ALTERNATIVA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ALTERNATIVA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_QUESTION = table.Column<int>(type: "int", nullable: true),
                    STATUS_ALTERNATIVA = table.Column<bool>(type: "bit", nullable: true),
                    PESO = table.Column<double>(type: "float", nullable: true),
                    RESPOSTA_CORRETA = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___6759B3ED9D446566", x => x.ID_ALTERNATIVA);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_ANSWER_AVALIACAO",
                columns: table => new
                {
                    ID_PROVA_RESPONDIDA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TEMAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TP_FORMS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PUBLICO_CANAL = table.Column<int>(type: "int", nullable: true),
                    PUBLICO_CARGO = table.Column<int>(type: "int", nullable: true),
                    DT_AVALIACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA_APLICADOR = table.Column<int>(type: "int", nullable: true),
                    NOME_APLICADOR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CADERNO = table.Column<int>(type: "int", nullable: true),
                    NOTA = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    REDE_AVALIADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DDD_AVALIADO = table.Column<int>(type: "int", nullable: true),
                    PDV_AVALIADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RE_AVALIADO = table.Column<int>(type: "int", nullable: true),
                    ID_SUB_TEMAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ID_PROVA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___3214EC27512CA59D", x => x.ID_PROVA_RESPONDIDA);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_AVALIACAO_RETORNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_QUESTION = table.Column<int>(type: "int", nullable: true),
                    TEMAS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TP_FORMS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PESO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PUBLICO_CANAL = table.Column<int>(type: "int", nullable: true),
                    PUBLICO_CARGO = table.Column<int>(type: "int", nullable: true),
                    DT_AVALIACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA_APLICADOR = table.Column<int>(type: "int", nullable: true),
                    CADERNO = table.Column<int>(type: "int", nullable: true),
                    RESPOSTA_USER = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    REDE_AVALIADA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DDD_AVALIADO = table.Column<int>(type: "int", nullable: true),
                    PDV_AVALIADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RE_AVALIADO = table.Column<int>(type: "int", nullable: true),
                    STATUS_RESPOSTA = table.Column<bool>(type: "bit", nullable: true),
                    ID_PROVA_RESPONDIDA = table.Column<int>(type: "int", nullable: true),
                    ID_SUB_TEMAS = table.Column<int>(type: "int", nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ID_PROVA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___3214EC27B6951282", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_CARGOS_CANAL",
                columns: table => new
                {
                    ID = table.Column<double>(type: "float", nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ID_CANAL = table.Column<double>(type: "float", nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    USER_PDV = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_CARTEIRA_DIVISAO_RJES",
                columns: table => new
                {
                    DIVISAO = table.Column<double>(type: "float", nullable: true),
                    NOME_DIVISAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    GAGG = table.Column<string>(name: "GA / GG", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GGP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RE_GV = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    GV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DDD_LOCALIDADE_PDV = table.Column<double>(type: "float", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_HIERARQUIA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NOME_FANTASIA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DDD = table.Column<int>(type: "int", nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    STATUS = table.Column<bool>(type: "bit", nullable: true),
                    LOGIN_MOD = table.Column<int>(type: "int", nullable: true),
                    DT_MOD = table.Column<DateTime>(type: "datetime", nullable: true),
                    RE_DIVISAO = table.Column<int>(type: "int", nullable: true),
                    RE_GA = table.Column<int>(type: "int", nullable: true),
                    RE_GP = table.Column<int>(type: "int", nullable: true),
                    RE_GV = table.Column<int>(type: "int", nullable: true),
                    CANAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___3214EC27A998B09B", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_QUESTION",
                columns: table => new
                {
                    ID_QUESTION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TEMAS = table.Column<int>(type: "int", nullable: true),
                    TP_FORMS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TP_QUESTAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PERGUNTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PESO = table.Column<double>(type: "float", nullable: true),
                    EXPLICACAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS_QUESTION = table.Column<bool>(type: "bit", nullable: true),
                    FIXA = table.Column<bool>(type: "bit", nullable: true),
                    ID_SUB_TEMAS = table.Column<int>(type: "int", nullable: true),
                    DT_MOD = table.Column<DateTime>(type: "datetime", nullable: true),
                    LOGIN_MOD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___331A4B0AD52DC391", x => x.ID_QUESTION);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_QUESTION_HISTORICO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_QUESTION = table.Column<int>(type: "int", nullable: true),
                    CANAL = table.Column<int>(type: "int", nullable: true),
                    DT_CRIACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_CRIADOR = table.Column<int>(type: "int", nullable: true),
                    CARGO = table.Column<int>(type: "int", nullable: true),
                    CADERNO = table.Column<int>(type: "int", nullable: true),
                    TP_FORMS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DT_INICIO_AVALIACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DT_FINALIZACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FIXA = table.Column<bool>(type: "bit", nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ID_PROVA = table.Column<int>(type: "int", nullable: true),
                    ELEGIVEL = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___79F0FBF3E6AFD006", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_RELACAO_HISTORICO",
                columns: table => new
                {
                    ID_PROVA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN_MOD = table.Column<int>(type: "int", nullable: true),
                    DT_MOD = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___3214EC27E49F91A7", x => x.ID_PROVA);
                });

            migrationBuilder.CreateTable(
                name: "JORNADA_BD_TEMAS_SUB_TEMAS",
                columns: table => new
                {
                    ID_SUB_TEMAS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SUB_TEMAS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ID_TEMAS = table.Column<int>(type: "int", nullable: true),
                    TEMAS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JORNADA___DE5581391EF734BB", x => x.ID_SUB_TEMAS);
                });

            migrationBuilder.CreateTable(
                name: "JUSTIFICATIVA_HE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    JUSTIFICATIVA = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    AREA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOME = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HORAS_EXCEDIDAS = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JUSTIFIC__3214EC272C88998B", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LIMITE_CREDITO",
                columns: table => new
                {
                    ADABAS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LIMITE_CREDITO = table.Column<double>(type: "float", nullable: true),
                    DIVIDA_RECEBER = table.Column<double>(type: "float", nullable: true),
                    F40 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LIMITE_CREDITO_NOVO",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    REDE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LIMITE_CREDITO = table.Column<double>(type: "float", nullable: true),
                    DIVIDA_RECEBER = table.Column<double>(type: "float", nullable: true),
                    LIMITE_PLUS = table.Column<double>(type: "float", nullable: true),
                    CNPJ_RAIZ = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LINHA_TESTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrLinhaTeste = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    NomeLoja = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SimCard = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descricao = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Area = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Regional = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Adabas = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Uf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FuncaoLinha = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DataAtivacao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DataVencimento = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Arquivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Validador = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    NrDocumento = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Servico = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LINHA_TE__3214EC071BE8E8C5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LINHA_TESTE_HISTORICO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NomeLoja = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Descricao = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Area = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Regional = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Adabas = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Uf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FuncaoLinha = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DataAtivacao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DataVencimento = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Arquivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Validador = table.Column<int>(type: "int", nullable: true),
                    NrLinhaTeste = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SimCard = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LINHA_TE__3214EC07181857E1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LOG_ERROS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO_REDE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ERRO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    OPERACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOG_ERRO__3214EC2705EF8605", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LOGRADOUROS",
                columns: table => new
                {
                    num_cep = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bairro_id = table.Column<int>(type: "int", nullable: false),
                    desc_logradouro = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    desc_tipo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    numero = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ard_metalica = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tbox_metalica = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    pares_metalica = table.Column<int>(type: "int", nullable: true),
                    pares_ocupados_metalica = table.Column<int>(type: "int", nullable: true),
                    pares_disponiveis_metalica = table.Column<int>(type: "int", nullable: true),
                    lote_cobertura_fibra = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ard_fibra = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cx_fibra = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ra_fibra = table.Column<int>(type: "int", nullable: true),
                    rb_fibra = table.Column<int>(type: "int", nullable: true),
                    rc_fibra = table.Column<int>(type: "int", nullable: true),
                    na_fibra = table.Column<int>(type: "int", nullable: true),
                    nb_fibra = table.Column<int>(type: "int", nullable: true),
                    nc_fibra = table.Column<int>(type: "int", nullable: true),
                    capacidade_caixa_fibra = table.Column<int>(type: "int", nullable: true),
                    disponibilidade_caixa_fibra = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LOJAS_GERACAO_CARGAS",
                columns: table => new
                {
                    PDV = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TIPOLOJAS = table.Column<string>(name: "TIPO LOJAS", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LOGINSIEBEL = table.Column<string>(name: "LOGIN SIEBEL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SCAVIVO360 = table.Column<string>(name: "SCA - VIVO360", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    VIVONEXT = table.Column<string>(name: "VIVO NEXT", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CODGSS = table.Column<string>(name: "COD GSS", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    POOLDECOBRANÇA = table.Column<string>(name: "POOL DE COBRANÇA", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GLOBALONE = table.Column<string>(name: "GLOBAL ONE", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    RAZÃOSOCIAL = table.Column<string>(name: "RAZÃO SOCIAL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DDD = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TELEFONE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GERENTECONTAS = table.Column<string>(name: "GERENTE CONTAS", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SELLIN = table.Column<string>(name: "SELL IN", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SEÇÃO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DIVISÃO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    AREASEÇÃO = table.Column<string>(name: "AREA SEÇÃO", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    UNIDADESEÇÃO = table.Column<double>(name: "UNIDADE SEÇÃO", type: "float", nullable: true),
                    AREADIVISÃO = table.Column<string>(name: "AREA DIVISÃO", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    UNIDADEDIVISÃO = table.Column<double>(name: "UNIDADE DIVISÃO", type: "float", nullable: true),
                    StatusCallidus = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LOJAS_GERACAO_CARGAS_BKP",
                columns: table => new
                {
                    PDV = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TIPOLOJAS = table.Column<string>(name: "TIPO LOJAS", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LOGINSIEBEL = table.Column<string>(name: "LOGIN SIEBEL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SCAVIVO360 = table.Column<string>(name: "SCA - VIVO360", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    VIVONEXT = table.Column<string>(name: "VIVO NEXT", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GSS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CODGSS = table.Column<string>(name: "COD GSS", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    POOLDECOBRANÇA = table.Column<string>(name: "POOL DE COBRANÇA", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GLOBALONE = table.Column<string>(name: "GLOBAL ONE", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    RAZÃOSOCIAL = table.Column<string>(name: "RAZÃO SOCIAL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DDD = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TELEFONE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GERENTECONTAS = table.Column<string>(name: "GERENTE CONTAS", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SELLIN = table.Column<string>(name: "SELL IN", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SEÇÃO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DIVISÃO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    AREASEÇÃO = table.Column<string>(name: "AREA SEÇÃO", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    UNIDADESEÇÃO = table.Column<double>(name: "UNIDADE SEÇÃO", type: "float", nullable: true),
                    AREADIVISÃO = table.Column<string>(name: "AREA DIVISÃO", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    UNIDADEDIVISÃO = table.Column<double>(name: "UNIDADE DIVISÃO", type: "float", nullable: true),
                    StatusCallidus = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MAILING_ENVIO_COMUNICADOS",
                columns: table => new
                {
                    Adabas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MARGEM REVENDA PRE",
                columns: table => new
                {
                    UF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeDPGC = table.Column<string>(name: "Nome DPGC", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeComercial = table.Column<string>(name: "Nome Comercial", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GrupoMargemPré = table.Column<string>(name: "Grupo Margem Pré", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MargemLíquidaOutubro18 = table.Column<double>(name: "Margem Líquida Outubro/18", type: "float", nullable: true),
                    COD_MAT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MARKETSHARE",
                columns: table => new
                {
                    DDD = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    PRÉ = table.Column<double>(type: "float", nullable: true),
                    POSVOZ = table.Column<double>(name: "POS VOZ", type: "float", nullable: true),
                    MODEM = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MATRIZ_ACESSO_CONCESSAO",
                columns: table => new
                {
                    Cargo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Canal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Nome = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DataAdmissao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Uf = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Area = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    AreaProposta = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SistemaUtilizado = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Perfil = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Login = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Senha = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DataAlteracao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MATRIZ_ACESSOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SistemasUtilizados = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GrupoDeAcesso = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Canal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SenhaDeRede = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data_Cadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Oculto = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MATRIZ_A__3214EC270524B3A7", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MOVIMENTACAO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Matricula = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    DataMovimentacao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Uf = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Cargo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Gestor = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    LojaAtual = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LojaDestino = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MOVIMENTACOES",
                columns: table => new
                {
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_MOVIMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_ADMISSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UF_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SIGLA_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VP_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MOVIMENTACOES_BKP",
                columns: table => new
                {
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_MOVIMENTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_ADMISSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UF_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SIGLA_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VP_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA_PROPOSTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_ALTERACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MUNICIPIOS_MINAS",
                columns: table => new
                {
                    MUNICIPIO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DDD = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OCORRENCIA_QUEDA_LINK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrChamado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TipoLoja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NomeLoja = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DDD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    UF = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    HoraInicio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataFim = table.Column<DateTime>(type: "datetime", nullable: true),
                    HoraFim = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TempoTotal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Plantonista = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    MOTIVO_QUEDA_LINK = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    NR_INCIDENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    STATUS_QUEDA_LINK = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OCORRENC__3214EC2700F5C6BE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OCORRENCIAS_SISTEMICAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    CHAMADO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    IMPACTO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    SISTEMA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    INICIO = table.Column<TimeSpan>(type: "time", nullable: true),
                    FIM = table.Column<TimeSpan>(type: "time", nullable: true),
                    TIPOERRO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DESCRICAOOCORRENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PLANTONISTA = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DATAFIM = table.Column<DateTime>(type: "datetime", nullable: true),
                    TIPO_IMPACTO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OCORRENC__3214EC276FCB3ABC", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OCORRENCIAS_SISTEMICAS_REDE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    Uf = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DDD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    GC = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Canal = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    HoraInicio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HoraFim = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Duracao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataFinal = table.Column<DateTime>(type: "datetime", nullable: true),
                    Motivo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    Plantonista = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_INICIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NR_INCIDENTE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OCORRENC__3214EC27739BCBA0", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PALITAGEM_LLPP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROTOCOLO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CPF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PLANO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    LINHA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPOMOVIMENTO = table.Column<string>(name: "TIPO MOVIMENTO", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MOVIMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRESENTINHO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LOJA = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SISTEMA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PLANOATUAL = table.Column<string>(type: "varchar(750)", unicode: false, maxLength: 750, nullable: true),
                    PLANOANTERIOR = table.Column<string>(type: "varchar(750)", unicode: false, maxLength: 750, nullable: true),
                    DEVICE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    IMEI = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    LINHA_TEMPORARIO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    LINHA_MIGRADA = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PALITAGE__3214EC272917FB5A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PALITAGEM_LLPP 3",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROTOCOLO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CPF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PLANO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    LINHA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPOMOVIMENTO = table.Column<string>(name: "TIPO MOVIMENTO", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MOVIMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRESENTINHO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LOJA = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SISTEMA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PLANOATUAL = table.Column<string>(type: "varchar(750)", unicode: false, maxLength: 750, nullable: true),
                    PLANOANTERIOR = table.Column<string>(type: "varchar(750)", unicode: false, maxLength: 750, nullable: true),
                    DEVICE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    IMEI = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    LINHA_TEMPORARIO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    LINHA_MIGRADA = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PALITAGE__3214EC2709D45A2B", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PERFIL_GERACAO_CARGAS",
                columns: table => new
                {
                    PERFIL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Vivo360Loja = table.Column<string>(name: "Vivo 360 Loja", type: "varchar(max)", unicode: false, nullable: true),
                    VivoNext = table.Column<string>(name: "Vivo Next", type: "varchar(max)", unicode: false, nullable: true),
                    GEDOC = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Siebel15 = table.Column<string>(name: "Siebel 15", type: "varchar(max)", unicode: false, nullable: true),
                    ESIM = table.Column<string>(name: "E-SIM", type: "varchar(max)", unicode: false, nullable: true),
                    LOJAONLINE = table.Column<string>(name: "LOJA ONLINE", type: "varchar(max)", unicode: false, nullable: true),
                    REDEEXT = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VIVONET = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VISFAT = table.Column<string>(name: "VIS FAT", type: "varchar(max)", unicode: false, nullable: true),
                    GRPSEG = table.Column<string>(name: "GRP SEG", type: "varchar(max)", unicode: false, nullable: true),
                    GRPSEG2 = table.Column<string>(name: "GRP SEG2", type: "varchar(max)", unicode: false, nullable: true),
                    GRPSEG3 = table.Column<string>(name: "GRP SEG3", type: "varchar(max)", unicode: false, nullable: true),
                    GRPSEG4 = table.Column<string>(name: "GRP SEG4", type: "varchar(max)", unicode: false, nullable: true),
                    PLATON = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VIVOCRÉDITO = table.Column<string>(name: "VIVO CRÉDITO", type: "varchar(max)", unicode: false, nullable: true),
                    ATLYS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NGINCARE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GPS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GSS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TOKEN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PAPMOBILE = table.Column<string>(name: "PAP MOBILE", type: "varchar(max)", unicode: false, nullable: true),
                    GLOBALONE = table.Column<string>(name: "GLOBAL ONE", type: "varchar(max)", unicode: false, nullable: true),
                    SPN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SICS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GSS2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PSI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADIANTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PERFIL_PLATAFORMAS_VIVO",
                columns: table => new
                {
                    ID_PERFIL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Perfil = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    obs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CARGO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERFIL_P__90BDE809D056135B", x => x.ID_PERFIL);
                });

            migrationBuilder.CreateTable(
                name: "PERFIL_USUARIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA = table.Column<int>(type: "int", nullable: true),
                    id_Perfil = table.Column<int>(type: "int", nullable: true),
                    DT_MOD = table.Column<DateTime>(type: "datetime", nullable: true),
                    LOGIN_MOD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERFIL_U__3214EC271E092576", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PERFIL_USUARIO_PENDENTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_ACESSO_PENDENTE = table.Column<int>(type: "int", nullable: true),
                    ID_PERFIL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERFIL_U__3214EC278ECEB79A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PERFIL_VIVO_TASK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARGO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    VIVO_MAIS = table.Column<int>(type: "int", nullable: true),
                    RTCZ = table.Column<int>(type: "int", nullable: true),
                    FIXA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERFIL_V__3214EC2760BB35A3", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Planilha1$",
                columns: table => new
                {
                    Vendedor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Regional = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ddd = table.Column<double>(type: "float", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StatusCallidus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TERRITORIO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULA_TERRITORIAL = table.Column<double>(type: "float", nullable: true),
                    SELLIN = table.Column<string>(name: "SELL IN", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULASELLIN = table.Column<string>(name: "MATRICULA SELLIN", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GERENTECONTAS = table.Column<string>(name: "GERENTE CONTAS", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MATRICULAGC = table.Column<double>(name: "MATRICULA GC", type: "float", nullable: true),
                    TIPO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRE_PEX_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: false),
                    ADABA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_AUDITORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRE_PEX_EXTERNO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uf = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Ddd = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Adabas = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CurvaPDV = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    RecargaEletronicaFuncionando = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PDVTrabalhaComChip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    ConsultaSerial = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PositivacaoMaterialMerchanInterno = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PossuiMaterialInternoVisivel = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PossuiMaterialMerchanInternoConcorrencia = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PositivacaoMaterialMerchanExterno = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PossuiMaterialMerchanExterno = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PossuiMaterialMerchanExternoConcorrencia = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    TempoReposicaoConserto = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PdvPossuiAdesivo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    FreqVisitaVendedor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PdvSabeInformarPromo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PdvSabeInformarNumPromo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    NrCadastroPromocao = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    IndiceSatisfacao = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true),
                    CpfCnpjPDV = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NomePDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EnderecoPDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BairroPDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CidadePDV = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Observacao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NomeFantasia = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    QtdChipSKU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    QtdChipHROutOperadoras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    QtdChipSKUOutOperadoras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FaturamentoRecarga = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    QtdChipHR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRE_PEX_INTERNO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAuditoria = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Uf = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Ddd = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Adabas = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MatinalRealizada = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    QtdVendedoresMatinal = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Abertura = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Reforco = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PEX = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Capacitacao = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Encerramento = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    ForcaVendasUniformizada = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    UniformeAlusaoOutraOperadora = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CorUniforme = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DistribuidorPossuiSalaoVendas = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorPossuiParedePainel = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorPossuiSimuladorPDV = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorPossuiQuadroGestao = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    OfertasVigentesVivo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PoliticaIncentivo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    ReforcoPilarPex = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorPossuiFerramentasAuxVenda = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorPossuiSistemaRotas = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorEntradaMercadoriaChip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SistemaGestaoIdentificaSerial = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    PistolagemVendedor = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    VendedorLancaVendaChipSistema = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SistemaRecebeInformacoesVenda = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    VendedorLancaRetiradaChip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    VendedorLancaDevolucaoChip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    VendedorLancaDevolucaoChipVivo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorLancaCancelamentoChip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    IdentificarEstoqueChipPDV = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    VendedorFazCheckinPDV = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorPossuiRegistroFrequencia = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DistribuidorPossuiCallCenter = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    EnderecoCallCenter = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EquipamentosCallCenter = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    QtdAtendentesCallCenter = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    NomeAcompanhanteAuditoria = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: true),
                    NomeFantasia = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRESTACAO_COMPROVANTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    CENTRO_CUSTO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GESTOR = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    FINALIZADO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    MATRICULA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRESTACAO_KM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    CENTRO_CUSTO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GESTOR = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    FINALIZADO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    MATRICULA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    CARRO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PLACA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ANO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    COR = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "QUALIDADE_BD_MANUAL_AUDIT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_LAST_STATUS = table.Column<int>(type: "int", nullable: false),
                    LOGIN_ANALISTA = table.Column<int>(type: "int", nullable: false),
                    LOGIN_RESPONSAVEL = table.Column<int>(type: "int", nullable: false),
                    ANOMES = table.Column<int>(type: "int", nullable: false),
                    LOJA = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    CENT = table.Column<int>(type: "int", nullable: false),
                    CD = table.Column<int>(type: "int", nullable: false),
                    ORDEM_VEND = table.Column<int>(type: "int", nullable: false),
                    TPOV = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    TIPO_MOVIMENTO = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    CPF_CNPJ = table.Column<int>(type: "int", nullable: false),
                    MATERIAL = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    DATA_NF = table.Column<DateTime>(type: "datetime", nullable: false),
                    N_DE_SERIE = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    VALOR_NF = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    NUMERO_PED = table.Column<int>(type: "int", nullable: false),
                    CRIADO_POR = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    NM_PLANO = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    FIDELIZAÇÃO = table.Column<bool>(type: "bit", nullable: true),
                    TIPO_JUST_FIDELIZACAO = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    LINHA_FIDELIZADA = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    DT_FIDELIZACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    MULTA_FAT_FID = table.Column<bool>(type: "bit", nullable: true),
                    IMEI_NEXT = table.Column<bool>(type: "bit", nullable: true),
                    MOTIVO_EXCECAO_FIDELIZACAO = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    RENOVA = table.Column<bool>(type: "bit", nullable: true),
                    N_VOUCHER = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    DT_EMISSAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    VL_VOUCHER = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    VALOR_NA_TABELA_DE_PREÇO = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    DIGITALIZADO = table.Column<bool>(type: "bit", nullable: true),
                    N_PROTOCOLO_GED = table.Column<int>(type: "int", nullable: true),
                    CHAMADO = table.Column<bool>(type: "bit", nullable: true),
                    N_CHAMADO = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    DT_CHAMADO = table.Column<DateTime>(type: "datetime", nullable: true),
                    TICKET_RH = table.Column<bool>(type: "bit", nullable: true),
                    DT_ABERTURA_TICKET = table.Column<DateTime>(type: "datetime", nullable: true),
                    N_TICKET = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    ACAO_CORRETIVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ACAO_PREVENTIVA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    JUSTIFICATIVA_LOJA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AVALIACAO_REGIONAL = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    RETORNO_REGIONAL = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QUALIDAD__3214EC278C80C5A8", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QUEM_ENTROU",
                columns: table => new
                {
                    Login = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "REANALISE_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_REANALISE = table.Column<int>(type: "int", nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOMEARQUIVO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__REANALIS__3214EC275ADA3F77", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "REANALISE_CADASTRO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DDD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RAZAOSOCIAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CANAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATACADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    IDACESSO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LIMITE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__REANALIS__3214EC275709AE93", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "REANALISE_CHECKLIST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CREDENCIAMENTO = table.Column<int>(type: "int", nullable: true),
                    OPCAO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RESPONSAVEL = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__REANALIS__3214EC274F688CCB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RELACAO_EMAILS_VIVO_MAIS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REGIONAL = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    SENHA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMAIL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RELATORIO_SIGTM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MUNICIPIO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RETORNO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RELATORI__3214EC2734E90F6D", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RELATORIO_SIGTM_SUL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MUNICIPIO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RETORNO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RELATORI__3214EC27E72521DF", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "REPOSITORIO_ARQUIVOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDACESSO = table.Column<int>(type: "int", nullable: false),
                    TOPICO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ASSUNTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    LINK = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DATAINCLUSAO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VERSAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__REPOSITO__3214EC27E7505153", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ROTAS_GNV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REDE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    LOGIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ROTAS_GN__3214EC2722A007F5", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SAGRE_REAL_COBERTURA_GPON",
                columns: table => new
                {
                    UF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ARMARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLLI_CODE_TBS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TITULO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LOGRADOURO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CEP_DIR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CEP_ESQ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CAIXA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LOTE_COBERTURA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LINHASINSTALADAS = table.Column<string>(name: "LINHAS INSTALADAS", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    USADOS_CAIXA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUANTIDADE_LIVRE_CAIXA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_LOTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUANTIDADE_MERCADO_RA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUANTIDADE_MERCADO_RB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUANTIDADE_MERCADO_RC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUANTIDADE_MERCADO_NA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUANTIDADE_MERCADO_NB = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUANTIDADE_MERCADO_NC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ANTENA_COLETIVA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CAPACIDADE_CAIXA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISPONIVEIS_CAIXA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO_GPON = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LIVRE_CONDICIONADO_CAIXA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    QUTY_SPL_PRI_LIVRES = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MIN_PORTAS_SP_LIVRES = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TOPOLOGIA_SP_1N = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COD_LOG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SAVING_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mesAcao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    rede = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    tipoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    opcaoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    oferta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    periodoInicial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    periodoFinal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    comprovanteAcao = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    valorAcao = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    MIME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SAVING_ARQUIVO_LAYOUT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SAVING = table.Column<int>(type: "int", nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EXTENSAO_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SAVING_A__3214EC2727CED166", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SAVING_BKP",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mesAcao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    rede = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    tipoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    opcaoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    oferta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    periodoInicial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    periodoFinal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    comprovanteAcao = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    valorAcao = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    MIME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SAVING_CADASTRO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mesAcao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    rede = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    tipoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    opcaoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    oferta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    periodoInicial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    periodoFinal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    valorAcao = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    valorPlanejado = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    valorEstimadoRetorno = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ParecerMKT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParecerCanal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataParecerMKT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataParecerCanal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ObsMKT = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ObsCanal = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Necessita_Parecer_MKT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SAVING_C__3213E83F53385258", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SOLICITACAO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATASOLICITACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IdBoleta = table.Column<int>(type: "int", nullable: true),
                    Tipo_Venda = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SOLICITACAO_APARELHO_CHIP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSolicitacao = table.Column<int>(type: "int", nullable: true),
                    Solicitacao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IMEI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ICCID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Tipo_Venda = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    IdPedido = table.Column<int>(type: "int", nullable: true),
                    NrSerial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TAB_PESSOAS_SUPORTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRÍCULA = table.Column<double>(type: "float", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TELEFONE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TAB_PESS__3214EC27A03B0125", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TABELA DE PRECOS",
                columns: table => new
                {
                    NOMEDPGC = table.Column<string>(name: "NOME DPGC", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMECOMERCIAL = table.Column<string>(name: "NOME COMERCIAL", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ALTERACOES = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PONTUACAO = table.Column<double>(type: "float", nullable: true),
                    PLANO = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    PLANOFOCO = table.Column<string>(name: "PLANO FOCO", type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    PRECOANTIGO = table.Column<double>(name: "PRECO ANTIGO", type: "float", nullable: true),
                    PRECO = table.Column<double>(type: "float", nullable: true),
                    PRECORENOVA = table.Column<string>(name: "PRECO RENOVA", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATAINICIO = table.Column<string>(name: "DATA INICIO", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PRODUTO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FABRICANTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOMESISTEMICO = table.Column<string>(name: "NOME SISTEMICO", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TABELA_QUALIDADE_FPD_FIXA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SAFRA_ALTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DT_ALTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NR_DOC = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ESTADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN_VNDA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGIN_CNST = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CLASSE_SCORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_CLIENTE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL_INSTALACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL_CNST = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL_TRATADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DEALER = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TECNOLOGIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTA_COBRANCA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_BL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_VOZ = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO_TV = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FATURADO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_0 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_15 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_30 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_60 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F_OVER_180 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_0 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_8 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_15 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_30 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_60 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FL_FTRM_OVER_180 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELA_QUALIDADE_FPD_FIXA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TABELA_QUALIDADE_FPD_MOVEL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DT_MOVIMENTO = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DT_MVMT_LNHA = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DT_PRMR_ATVC_LNHA = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DT_ATVC_CNTA = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TIPO_MOVIMENTO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NR_DOC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ID_LNHA = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NR_TLFN = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CD_CNTA = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LAST_BILL_DT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DT_PAGAMENTO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AGING = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FATURADO = table.Column<byte>(type: "tinyint", nullable: true),
                    CD_AREA_RGST = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CD_CCLO_FTRM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DS_CCLO_FTRM = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CD_TIPO_AVSO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DS_TIPO_AVSO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TP_AVISO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUTO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DS_PLNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AREA_REGIONAL = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CANAL_VNDA = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CD_CRDN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NM_FNTS = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    NM_LOGN_ATND = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CD_LOGN_USRO_GSTR = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    IN_ATRZ_GSTR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FILTRO_APROVACAO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DS_SCOREPLAN = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    POLITICA = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    APARELHO_SUBSIDIO = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    OFERTA_FINAL_AGG = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SISTEMA_ORIGEM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CLASSIF_BAIXA = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    DT_BAIXA = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    N_LINHAS = table.Column<byte>(type: "tinyint", nullable: true),
                    N_OVER8 = table.Column<byte>(type: "tinyint", nullable: true),
                    N_OVER15 = table.Column<byte>(type: "tinyint", nullable: true),
                    N_FPD = table.Column<byte>(type: "tinyint", nullable: true),
                    N_OVER30 = table.Column<byte>(type: "tinyint", nullable: true),
                    N_IP = table.Column<byte>(type: "tinyint", nullable: true),
                    PRDT_PLNO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TIT_DEP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTD_FATURAMENTO = table.Column<byte>(type: "tinyint", nullable: true),
                    QTD_FATURAMENTO_PARCIAL_8 = table.Column<byte>(type: "tinyint", nullable: true),
                    QTD_FATURAMENTO_PARCIAL_15 = table.Column<byte>(type: "tinyint", nullable: true),
                    QTD_FATURAMENTO_PARCIAL_30 = table.Column<byte>(type: "tinyint", nullable: true),
                    QTD_FATURAMENTO_PARCIAL_60 = table.Column<byte>(type: "tinyint", nullable: true),
                    QTD_FATURAMENTO_PARCIAL_180 = table.Column<byte>(type: "tinyint", nullable: true),
                    ANOMES = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELA_QUALIDADE_FPD_MOVEL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TABELA_VALORES_COMISSIONAMENTO",
                columns: table => new
                {
                    desc_tipo_comissao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Mes1 = table.Column<double>(type: "float", nullable: true),
                    Mes2 = table.Column<double>(type: "float", nullable: true),
                    Mes3 = table.Column<double>(type: "float", nullable: true),
                    Mes4 = table.Column<double>(type: "float", nullable: true),
                    Tipo2 = table.Column<string>(name: "Tipo 2", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    cod_credenc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REDE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TABELAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CPFCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipoMailing = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipoServicoFixa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipoServicoMovel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipoServicoTerminais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NomeMailing = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    NomePlanoFixa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NomePlanoMovel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NomePlanoTerminais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ordem = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ValorFixa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValorFixaDelta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValorMovel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValorMovelDelta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValorTerminais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValorTerminaisDelta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GEDFixa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LinhaMovel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LinhaTerminais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GEDMovel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GEDTerminais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InstanciaFixa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataInstalacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataEntrega = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataMailing = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DDDCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MotivoNaoVenda = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    DataEntregaTerminais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    idAcesso = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ServicoMailing = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    DataPalitagem = table.Column<DateTime>(type: "datetime", nullable: true),
                    UfCliente = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CidadeCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CEPCliente = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TABELAO__3214EC077D2C4479", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TABELAO_NOMES_FIXA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAMPO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TABELAO___3214EC0760043184", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TABELAO_SERVICO_FIXA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servico = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    CategoriaServico = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TABELAO___3214EC0723CCEC5D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TESTE_NEW",
                columns: table => new
                {
                    TEMA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TP_FORMS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FIXA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TP_QUESTAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PERGUNTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RESPOSTA_CORRETA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PESO = table.Column<double>(type: "float", nullable: true),
                    EXPLICACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CANAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS_QUESTION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TRAJETOS_PRESTACAO_KM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPRESTACAO = table.Column<int>(type: "int", nullable: true),
                    KMANTERIOR = table.Column<int>(type: "int", nullable: true),
                    KMATUAL = table.Column<int>(type: "int", nullable: true),
                    KMSRODADOS = table.Column<int>(type: "int", nullable: true),
                    INTINERARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DIA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TRIAGEM_CLIENTE_BOLETA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SENHA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CLIENTE_VIVO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    CLIENTE_FIXA_MOVEL_VIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LINHA = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    NUMERO = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RUA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    POSSUI_COBERTURA_FIXA_VIVO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    OBSERVACOES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LOGIN_QUEM_INSERIU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_TRIAGEM = table.Column<DateTime>(type: "datetime", nullable: true),
                    LOJA = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    NOME_CLIENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TRIAGEM___3214EC274FC87F7E", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VALIDACAO_HC",
                columns: table => new
                {
                    MATRICULA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UNIDADE = table.Column<double>(type: "float", nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COD_CARGO = table.Column<double>(type: "float", nullable: true),
                    CARGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA_ADMISSAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_DE_AUSENCIA_OU_PRESENÇA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    INICIO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FIM = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DIVERGENCIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OBS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ANOMES = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VALOR_SAVING",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REDE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TOTAL = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VALOR_SA__3214EC271AA9E072", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VENDA_BOLETA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginConsultor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataVenda = table.Column<DateTime>(type: "datetime", nullable: true),
                    CpfCliente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomeCliente = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VISAO_GERENCIAL_BOLETA",
                columns: table => new
                {
                    login = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VISAO_LOJA_BOLETA",
                columns: table => new
                {
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA_EVIDENCIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: true),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_ABERTURA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC2746D27B73", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_EVIDENCIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: true),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_ABERTURA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC273B60C8C7", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_GERENTE_GERAL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Loja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    TipoAbertura = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC077073AF84", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_GERENTE_GERAL_EVIDENCIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: true),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_ABERTURA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC274301EA8F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_ABERTURA_EVIDENCIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHECKLIST_PEX = table.Column<int>(type: "int", nullable: true),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_ABERTURA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC273F3159AB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_CAIXA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    CaixaValorFundoTrocoCorretoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CaixaValorFundoTrocoCorretoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CaixaValorFundoTrocoCorretoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaixaValorFundoTrocoCorretoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CaixaNaoExisteReembolsoPendenteSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CaixaNaoExisteReembolsoPendenteObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CaixaNaoExisteReembolsoPendentePrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaixaNaoExisteReembolsoPendenteResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CaixaNaoExistePendenciaMovimentosSAPSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CaixaNaoExistePendenciaMovimentosSAPObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CaixaNaoExistePendenciaMovimentosSAPPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaixaNaoExistePendenciaMovimentosSAPResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CaixaDemaisConsideracoes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC0759904A2C", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_ESTOQUE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    EstoqueQtdSeriaisAparelhosSAPSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueQtdSeriaisAparelhosSAPObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueQtdSeriaisAparelhosSAPPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueQtdSeriaisAparelhosSAPResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueQtdSeriaisChipsSAPSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueQtdSeriaisChipsSAPObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueQtdSeriaisChipsSAPPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueQtdSeriaisChipsSAPResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueQtdSeriaisCartõesRecargaSAPSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueQtdSeriaisCartõesRecargaSAPObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueQtdSeriaisCartõesRecargaSAPPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueQtdSeriaisCartõesRecargaSAPResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueQtdSeriaisAcessoriosSAPSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueQtdSeriaisAcessoriosSAPObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueQtdSeriaisAcessoriosSAPPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueQtdSeriaisAcessoriosSAPResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueQtdSeriaisWearablesSAPSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueQtdSeriaisWearablesSAPObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueQtdSeriaisWearablesSAPPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueQtdSeriaisWearablesSAPResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueCaixasAbertasKitsCompletosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueCaixasAbertasKitsCompletosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueCaixasAbertasKitsCompletosPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueCaixasAbertasKitsCompletosResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueAparelhosDemonstracaoKitCompletoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueAparelhosDemonstracaoKitCompletoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueAparelhosDemonstracaoKitCompletoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueAparelhosDemonstracaoKitCompletoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueAparelhosAlocadosEstoqueCorretoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstoqueAparelhosAlocadosEstoqueCorretoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstoqueAparelhosAlocadosEstoqueCorretoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstoqueAparelhosAlocadosEstoqueCorretoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstoqueDemaisConsideracoes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC0755BFB948", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_ESTRUTURA_PROCESSOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    EstruturaProcessosMobiliariosReparoOSAbertaRegularizacaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosMobiliariosReparoOSAbertaRegularizacaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosMobiliariosReparoOSAbertaRegularizacaoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosMobiliariosReparoOSAbertaRegularizacaoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosEquipamentosReparoChamadosAbertosRegularizacaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosEquipamentosReparoChamadosAbertosRegularizacaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosEquipamentosReparoChamadosAbertosRegularizacaoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosEquipamentosReparoChamadosAbertosRegularizacaoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosChamadosAbertosDentroPrazoCobrançaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosChamadosAbertosDentroPrazoCobrançaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosChamadosAbertosDentroPrazoCobrançaPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosChamadosAbertosDentroPrazoCobrançaResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosLojaPossuiControleNovoGerenteSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosLojaPossuiControleNovoGerenteObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosLojaPossuiControleNovoGerentePrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosLojaPossuiControleNovoGerenteResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosLojaOrganizadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosLojaOrganizadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosLojaOrganizadaPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosLojaOrganizadaResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosEquipamentosMobiliariosNUsadosAguardandoColetaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosEquipamentosMobiliariosNUsadosAguardandoColetaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosEquipamentosMobiliariosNUsadosAguardandoColetaPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosEquipamentosMobiliariosNUsadosAguardandoColetaResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosAlarmesReinicializadosSenhaNovosGerentesSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosAlarmesReinicializadosSenhaNovosGerentesObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosAlarmesReinicializadosSenhaNovosGerentesPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosAlarmesReinicializadosSenhaNovosGerentesResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosLojaPastaAtendeProcedimentoContingenciaGSSSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosLojaPastaAtendeProcedimentoContingenciaGSSObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosLojaPastaAtendeProcedimentoContingenciaGSSPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosLojaPastaAtendeProcedimentoContingenciaGSSResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosLojaQuadroAvisosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosLojaQuadroAvisosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosLojaQuadroAvisosPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosLojaQuadroAvisosResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosEstaoGuardadosDocumentosFiscaisSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosEstaoGuardadosDocumentosFiscaisObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosEstaoGuardadosDocumentosFiscaisPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosEstaoGuardadosDocumentosFiscaisResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EstruturaProcessosDemaisConsideracoes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosLojaPossuiMaterialEscritorioGuardadoAdequadoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaProcessosLojaPossuiMaterialEscritorioGuardadoAdequadoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaProcessosLojaPossuiMaterialEscritorioGuardadoAdequadoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstruturaProcessosLojaPossuiMaterialEscritorioGuardadoAdequadoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC0751EF2864", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_PESSOAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    PessoasSolicitadoSPPVagasAbertoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasSolicitadoSPPVagasAbertoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasSolicitadoSPPVagasAbertoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PessoasSolicitadoSPPVagasAbertoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PessoasNaoExisteColaboradoresPendenciaTreinamentoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasNaoExisteColaboradoresPendenciaTreinamentoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasNaoExisteColaboradoresPendenciaTreinamentoPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PessoasNaoExisteColaboradoresPendenciaTreinamentoResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PessoasLojaPossuiArquivoFolhaPontoTodasAssinadasResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PessoasLojaPossuiProgramacaoFeriasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasLojaPossuiProgramacaoFeriasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasLojaPossuiProgramacaoFeriasPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PessoasLojaPossuiProgramacaoFeriasResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PessoasTodosColaboradoresPossuemCrachaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasTodosColaboradoresPossuemCrachaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasTodosColaboradoresPossuemCrachaPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PessoasTodosColaboradoresPossuemCrachaResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC074E1E9780", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_POSITIVACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    PositivacaoMateriaisPositivadosManualPDVSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PositivacaoMateriaisPositivadosManualPDVObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PositivacaoMateriaisPositivadosManualPDVPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PositivacaoMateriaisPositivadosManualPDVResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PositivacaoAreaArmazenamentoOrganizadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PositivacaoAreaArmazenamentoOrganizadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PositivacaoAreaArmazenamentoOrganizadaPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PositivacaoAreaArmazenamentoOrganizadaResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PositivacaoPossuiFolheteriaCompletaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PositivacaoPossuiFolheteriaCompletaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PositivacaoPossuiFolheteriaCompletaPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PositivacaoPossuiFolheteriaCompletaResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PositivacaoPossuiPrecificadoresSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PositivacaoPossuiPrecificadoresObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PositivacaoPossuiPrecificadoresPrazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    PositivacaoPossuiPrecificadoresResponsavel = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PositivacaoDemaisConsideracoes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC074A4E069C", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_VAGAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    VagasQuantidadeVagasGerenteGeral = table.Column<int>(type: "int", nullable: true),
                    VagasQuantidadeVagasGerenteNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasQuantidadeVagasConsultorRelacionamento = table.Column<int>(type: "int", nullable: true),
                    VagasQuantidadeVagasConsultorPremium = table.Column<int>(type: "int", nullable: true),
                    VagasQuantidadeVagasConsultorNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasQuantidadeVagasAnalistaSuporteComercial = table.Column<int>(type: "int", nullable: true),
                    VagasQuantidadeVagasCaixa = table.Column<int>(type: "int", nullable: true),
                    VagasQuantidadeVagasRecepcionista = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosGerenteGeral = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosGerenteNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosConsultorRelacionamento = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosConsultorPremium = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosConsultorNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosAnalistaSuporteComercial = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosCaixa = table.Column<int>(type: "int", nullable: true),
                    VagasAtivosRecepcionista = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoGerenteGeral = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoGerenteNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoConsultorRelacionamento = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoConsultorPremium = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoConsultorNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoAnalistaSuporteComercial = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoCaixa = table.Column<int>(type: "int", nullable: true),
                    VagasVagasAbertoRecepcionista = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosGerenteGeral = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosGerenteNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosConsultorRelacionamento = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosConsultorPremium = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosConsultorNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosAnalistaSuporteComercial = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosCaixa = table.Column<int>(type: "int", nullable: true),
                    VagasLicencaAfastadosRecepcionista = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalGerenteGeral = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalGerenteNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalConsultorRelacionamento = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalConsultorPremium = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalConsultorNegocios = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalAnalistaSuporteComercial = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalCaixa = table.Column<int>(type: "int", nullable: true),
                    VagasQuadroTotalRecepcionista = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC072A4B4B5E", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ACAO_HISTORICO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDVPC = table.Column<int>(type: "int", nullable: false),
                    LIBERACAO_VERBA = table.Column<DateTime>(type: "datetime", nullable: true),
                    CADASTRO_ACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    VALIDACAO_MKT_TERRITORIAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    VALIDACAO_MKT_REGIONAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    APROVACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    RETORNAR_GC = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACAO_HIS__3214EC27625A9A57", x => x.ID);
                    table.ForeignKey(
                        name: "FK__ACAO_HIST__IDVPC__6442E2C9",
                        column: x => x.IDVPC,
                        principalTable: "ACAO_CADASTRO",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ACESSO_PERMISSAO_MENU",
                columns: table => new
                {
                    idPermissao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idAcesso = table.Column<int>(type: "int", nullable: false),
                    DescricaoMenu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TipoAcesso = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSO_P__7FFFCF600DAF0CB0", x => x.idPermissao);
                    table.ForeignKey(
                        name: "FK__ACESSO_PE__idAce__0F975522",
                        column: x => x.idAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "CHAMADO_LLPP",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chamado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rede = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DataAbertura = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataPrevisaoEncerramento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataEncerramento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHAMADO___3213E83F51A50FA1", x => x.id);
                    table.ForeignKey(
                        name: "FK__CHAMADO_L__idAce__538D5813",
                        column: x => x.idAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LLPP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Loja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    TipoLoja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC070B27A5C0", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CHECKLIST__IdAce__0D0FEE32",
                        column: x => x.IdAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LLPP_2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Loja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    TipoLoja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC07369C13AA", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CHECKLIST__IdAce__38845C1C",
                        column: x => x.IdAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DEMANDAS_CADASTRO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    ASSUNTO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CPF_CLIENTE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    LINHA_CLIENTE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    OBSERVACOES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CHAMADO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AREA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DATA_RESOLUCAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    RESPONSAVEL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SOLUCAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CPF_COLABORADOR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LOGIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC2777DFC722", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CONTROLE___IdAce__79C80F94",
                        column: x => x.IdAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_CADASTRO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    TIPO_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_CADASTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ARQUIVO_DESCREDENCIAMENTO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IDACESSO = table.Column<int>(type: "int", nullable: false),
                    EXTENSAO_ARQUIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIPO_ARQUIVO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CANCELADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC270F624AF8", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESCREDEN__IDACE__114A936A",
                        column: x => x.IDACESSO,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "DESLIGAMENTOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    NOME_FUNCIONARIO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MATRICULA_FUNCIONARIO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LOGIN_FUNCIONARIO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DATA_CADASTRO_DESLIGAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    CONFIRMA_DESLIGAMENTO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DATA_CONFIRMA_DESLIGAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    idAcesso = table.Column<int>(type: "int", nullable: false),
                    USUARIO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CPF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESLIGAM__3214EC2708D548FA", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESLIGAME__idAce__0ABD916C",
                        column: x => x.idAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "LOJA_CONTESTACAO_FATURA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Linha = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    CPF = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    MesReferencia = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    Conta = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    Produto = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    OBS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoContestacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Ddd = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOJA_CON__3213E83F71F1E3A2", x => x.id);
                    table.ForeignKey(
                        name: "FK__LOJA_CONT__IdAce__73DA2C14",
                        column: x => x.IdAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "RESET_SENHA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Matricula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    idAcesso = table.Column<int>(type: "int", nullable: false),
                    Ddd = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Uf = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    regional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RESET_SE__3214EC277D439ABD", x => x.ID);
                    table.ForeignKey(
                        name: "FK__RESET_SEN__idAce__7F2BE32F",
                        column: x => x.idAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "SAVING_CADASTRO_BKP",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mesAcao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    rede = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    tipoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    opcaoAcao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    oferta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    periodoInicial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    periodoFinal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    valorAcao = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SAVING_C__3213E83F546180BB", x => x.id);
                    table.ForeignKey(
                        name: "FK__SAVING_CA__IdAce__5649C92D",
                        column: x => x.IdAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Loja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    TipoAbertura = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    Extensao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Arquivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC072F10007B", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAce__30F848ED",
                        column: x => x.IdAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_PASSAGEM_ABERTURA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ddd = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Loja = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    TipoAbertura = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdAcesso = table.Column<int>(type: "int", nullable: false),
                    Extensao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Arquivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC071273C1CD", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAce__145C0A3F",
                        column: x => x.IdAcesso,
                        principalTable: "ACESSO",
                        principalColumn: "idAcesso");
                });

            migrationBuilder.CreateTable(
                name: "ACESSOS_MOBILE_PENDENTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MATRICULA = table.Column<int>(type: "int", nullable: true),
                    SENHA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CARGO = table.Column<int>(type: "int", nullable: false),
                    CANAL = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NOME = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UF = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    APROVACAO = table.Column<bool>(type: "bit", nullable: true),
                    FIXA = table.Column<bool>(type: "bit", nullable: true),
                    LOGIN_SOLICITANTE = table.Column<int>(type: "int", nullable: true),
                    LOGIN_RESPONSAVEL = table.Column<int>(type: "int", nullable: true),
                    DT_SOLICITACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DT_RETORNO = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DT_PRIMEIRO_RETORNO = table.Column<DateTime>(type: "datetime", nullable: true),
                    CPF = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PDV = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID_ACESSOS_MOBILE = table.Column<int>(type: "int", nullable: true),
                    STATUS_USUARIO = table.Column<bool>(type: "bit", nullable: true),
                    DDD = table.Column<int>(type: "int", nullable: true),
                    TP_STATUS = table.Column<int>(type: "int", nullable: true),
                    ELEGIVEL = table.Column<bool>(type: "bit", nullable: true),
                    UserAvatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ACESSOS___3214EC27196F6B07", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ACESSOS_MOBILE_PENDENTE_ACESSOS_MOBILE_LOGIN_SOLICITANTE",
                        column: x => x.LOGIN_SOLICITANTE,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "MATRICULA");
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_RELACAO_CHAMADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATRICULA_SOLICITANTE = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", nullable: true),
                    PRIORIDADE = table.Column<bool>(type: "bit", nullable: false),
                    PRIORIDADE_SEGMENTO = table.Column<bool>(type: "bit", nullable: false),
                    Tabela = table.Column<int>(type: "int", nullable: false),
                    LastStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA_ULTIMA_INTERACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATA_FINALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    REGIONAL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_RELACAO_CHAMADO", x => x.ID_RELACAO);
                    table.ForeignKey(
                        name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DEMANDA_RELACAO_CHAMADO_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ALTA_SEM_TRAFEGO_STATUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAST = table.Column<int>(type: "int", nullable: false),
                    OBSERVACAO = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    RETORNO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ULTIMA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_SOLICITANTE_ALTERACAO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ALTA_SEM__3214EC0740615315", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ALTA_SEM___IdAST__74E4F594",
                        column: x => x.IdAST,
                        principalTable: "ALTA_SEM_TRAFEGO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PDR_EXTERNO_IMAGENS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCheckListExterno = table.Column<int>(type: "int", nullable: false),
                    Arquivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NomeArquivo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ExtensaoArquivo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3213E83F3E923B2D", x => x.id);
                    table.ForeignKey(
                        name: "FK__CHECKLIST__idChe__407A839F",
                        column: x => x.idCheckListExterno,
                        principalTable: "CHECKLIST_PDR_EXTERNO",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CAMPOS_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    VALOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC265180919D", x => x.ID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADO",
                        column: x => x.ID_CAMPOS_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FILA = table.Column<int>(type: "int", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC27411A6D74", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA",
                        column: x => x.ID_FILA,
                        principalTable: "CONTROLE_DE_DEMANDAS_FILA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPOS_FILA",
                columns: table => new
                {
                    ID_FILA = table.Column<int>(type: "int", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MASCARA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CONTROLE_DE_DEMANDAS_CAMPOS_FILA",
                        column: x => x.ID_FILA,
                        principalTable: "CONTROLE_DE_DEMANDAS_FILA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA",
                columns: table => new
                {
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ID_FILA_CHAMADO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA",
                        column: x => x.ID_FILA_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_FILA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_CHAMADO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CAMPOS_CHAMADO = table.Column<int>(type: "int", nullable: true),
                    ID_STATUS_CHAMADO = table.Column<int>(type: "int", nullable: true),
                    ID_FILA_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MATRICULA_SOLICITANTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_FECHAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOTIVO_FECHAMENTO_SUPORTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PRIORIDADE = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PBI = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EMAIL_SECUNDARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RESPONSAVEL_OUTRA_AREA = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC27536E27D9", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CAMPOS_CHAMADO",
                        column: x => x.ID_CAMPOS_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FILA_CHAMADO",
                        column: x => x.ID_FILA_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_FILA",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_STATUS_CHAMADO",
                        column: x => x.ID_STATUS_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_STATUS_CHAMADO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_STATUS_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MAT_QUEM_REDIRECIONOU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ID_RESPOSTA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC27E28B3A02", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RELACAO_STATUS_CHAMADO",
                        column: x => x.ID_STATUS_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_STATUS_CHAMADO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA_SOLICITANTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    TIPO_CREDENCIAMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CANAL_CREDENCIAMENTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_FECHAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ULTIMO_STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    REGIONAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_ULTIMO_STATUS = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUMERO_REQUEST = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ID_PROSPECT = table.Column<int>(type: "int", nullable: true),
                    CIDADE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TIPO_REVENDA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ADABAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC2713498123", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CRED_PROSPECT",
                        column: x => x.ID_PROSPECT,
                        principalTable: "CREDENCIAMENTO_PROSPECT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_PROSPECT_RELACAO_ARQUIVOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CREDENCIAMENTO_PROSPECT = table.Column<int>(type: "int", nullable: false),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC073D3FBAEF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CREDENCIAMENTO_PROSPECT",
                        column: x => x.ID_CREDENCIAMENTO_PROSPECT,
                        principalTable: "CREDENCIAMENTO_PROSPECT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PROSPECT_RESPOSTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESPOSTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    IDPROSPECT = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_RESPOSTA = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PROSPECT__3214EC27776C5C84", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RESPOSTA_PROSPECT",
                        column: x => x.IDPROSPECT,
                        principalTable: "CREDENCIAMENTO_PROSPECT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_SUB_FILA",
                columns: table => new
                {
                    ID_SUB_FILA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_SUB_FILA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    REGIONAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CAMPOS_AUTO = table.Column<bool>(type: "bit", nullable: false),
                    CAMPOS_IDENT_USER = table.Column<bool>(type: "bit", nullable: false),
                    STATUS_SUB_FILA = table.Column<bool>(type: "bit", nullable: false),
                    MAT_CRIADOR = table.Column<int>(type: "int", nullable: true),
                    ID_TIPO_FILA = table.Column<int>(type: "int", nullable: false),
                    DATA_CRIACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ID_ANTIGO = table.Column<int>(type: "int", nullable: true),
                    DESCRICAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SLA = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEMANDA___B761D9E4B84AE788", x => x.ID_SUB_FILA);
                    table.ForeignKey(
                        name: "FK_SUB_FILA_ID_TIPO_FILA",
                        column: x => x.ID_TIPO_FILA,
                        principalTable: "DEMANDA_TIPO_FILA",
                        principalColumn: "ID_TIPO_FILA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LINHA_TESTE_NRSIMC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLinha = table.Column<int>(type: "int", nullable: false),
                    Nr_LinhaTeste = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SimCard = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LINHA_TE__3214EC071FB979A9", x => x.Id);
                    table.ForeignKey(
                        name: "FK__LINHA_TES__IdLin__21A1C21B",
                        column: x => x.IdLinha,
                        principalTable: "LINHA_TESTE",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FAT_MANUAL_STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FATURAMENTO = table.Column<int>(type: "int", nullable: true),
                    RESPOSTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MATRICULA = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FAT_MANU__3214EC271917FDA6", x => x.ID);
                    table.ForeignKey(
                        name: "FK_STATUS_FAT_MANUAL_Cascade",
                        column: x => x.ID_FATURAMENTO,
                        principalTable: "QUALIDADE_BD_MANUAL_AUDIT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SAVING_EVIDENCIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SAVING = table.Column<int>(type: "int", nullable: false),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SAVING_E__3214EC275708E33C", x => x.ID);
                    table.ForeignKey(
                        name: "FK__SAVING_EV__ID_SA__58F12BAE",
                        column: x => x.ID_SAVING,
                        principalTable: "SAVING_CADASTRO",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TABELA_QUALIDADE_FPD_FIXA_STATUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFPD = table.Column<int>(type: "int", nullable: false),
                    OBSERVACAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RETORNO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DATA_ULTIMA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_SOLICITANTE_ALTERACAO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TABELA_Q__3214EC07F2589BA8", x => x.Id);
                    table.ForeignKey(
                        name: "FK__TABELA_QU__IdFPD__687F1EAF",
                        column: x => x.IdFPD,
                        principalTable: "TABELA_QUALIDADE_FPD_FIXA",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TABELA_QUALIDADE_FPD_MOVEL_STATUS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFPD = table.Column<int>(type: "int", nullable: false),
                    OBSERVACAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RETORNO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DATA_ULTIMA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_SOLICITANTE_ALTERACAO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TABELA_Q__3214EC07B8998EF6", x => x.Id);
                    table.ForeignKey(
                        name: "FK__TABELA_QU__IdFPD__6E37F805",
                        column: x => x.IdFPD,
                        principalTable: "TABELA_QUALIDADE_FPD_MOVEL",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TRIAGEM = table.Column<int>(type: "int", nullable: false),
                    CONCORRENCIA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_concorrencia_produto_triagem",
                        column: x => x.ID_TRIAGEM,
                        principalTable: "TRIAGEM_CLIENTE_BOLETA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MOTIVOS_PRODUTO_TRIAGEM_CLIENTE_BOLETA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TRIAGEM = table.Column<int>(type: "int", nullable: false),
                    PRODUTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_motivos_produto_triagem",
                        column: x => x.ID_TRIAGEM,
                        principalTable: "TRIAGEM_CLIENTE_BOLETA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS_CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TRIAGEM = table.Column<int>(type: "int", nullable: false),
                    PRODUTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_produtos_concorrencia_produto_triagem",
                        column: x => x.ID_TRIAGEM,
                        principalTable: "TRIAGEM_CLIENTE_BOLETA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_GERENTE_GERAL_ESTRUTURA_OPERACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    EstruturaOperacoesMateriasTradeTVConformeMapaPDVSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesMateriasTradeTVConformeMapaPDVPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesMateriasTradeTVConformeMapaPDVObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesMaterialTradeVencidoDescartadoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesMaterialTradeVencidoDescartadoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesMaterialTradeVencidoDescartadoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesCRAcessoMapaPDVSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesCRAcessoMapaPDVPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesCRAcessoMapaPDVObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesCartazesRegulatoriosCodigoDefesaConsumidorExpostoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesCartazesRegulatoriosCodigoDefesaConsumidorExpostoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesCartazesRegulatoriosCodigoDefesaConsumidorExpostoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesPromotoresFabricantesUniformizadosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPromotoresFabricantesUniformizadosPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesPromotoresFabricantesUniformizadosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesTabelaPrecoComDivulgacaoAparelhosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesTabelaPrecoComDivulgacaoAparelhosPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesTabelaPrecoComDivulgacaoAparelhosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesPrecificadoresAcordoTabelaPrecoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPrecificadoresAcordoTabelaPrecoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesPrecificadoresAcordoTabelaPrecoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesAparelhosDegustacaoLigadosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesAparelhosDegustacaoLigadosPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesAparelhosDegustacaoLigadosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesAparelhosExpostosTradeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesAparelhosExpostosTradePeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesAparelhosExpostosTradeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesUrnaReciclarPegaBemPositivadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesUrnaReciclarPegaBemPositivadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesUrnaReciclarPegaBemPositivadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesRevistaMundoVivoAtualizadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesRevistaMundoVivoAtualizadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesRevistaMundoVivoAtualizadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesArvoreOfertasUtilizadaEquipeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesArvoreOfertasUtilizadaEquipePeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesArvoreOfertasUtilizadaEquipeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesEquipeAlinhadaCartazPositivadoAtitudesPegamBemSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesEquipeAlinhadaCartazPositivadoAtitudesPegamBemPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesEquipeAlinhadaCartazPositivadoAtitudesPegamBemObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesColaboradoresApresentacaoManualSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesColaboradoresApresentacaoManualPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesColaboradoresApresentacaoManualObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesEquipeAptaChamarSenhasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesEquipeAptaChamarSenhasPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesEquipeAptaChamarSenhasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesGNSuporteEquipeVendasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesGNSuporteEquipeVendasPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesGNSuporteEquipeVendasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesCRAbordandoClientesEsperaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesCRAbordandoClientesEsperaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesCRAbordandoClientesEsperaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesGuruIncentivandoMeuVivoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesGuruIncentivandoMeuVivoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesGuruIncentivandoMeuVivoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesCNsSeguindoScriptdeVendasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesCNsSeguindoScriptdeVendasPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesCNsSeguindoScriptdeVendasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesEquipeSenhaLiberadaAcessoSistemasAtendimentoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesEquipeSenhaLiberadaAcessoSistemasAtendimentoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesEquipeSenhaLiberadaAcessoSistemasAtendimentoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesMarcacaoTotemEmissãoSenhaEnvioSMSClienteSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesMarcacaoTotemEmissãoSenhaEnvioSMSClientePeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesMarcacaoTotemEmissãoSenhaEnvioSMSClienteObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesGestaoChamadosManutencaoTISimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesGestaoChamadosManutencaoTIPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesGestaoChamadosManutencaoTIObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesPainelSenhaFuncionandoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPainelSenhaFuncionandoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesPainelSenhaFuncionandoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesVivoBoxFuncionandoDegustaçãoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesVivoBoxFuncionandoDegustaçãoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesVivoBoxFuncionandoDegustaçãoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesTabletFuncionandoUtilizadoVendaSustentavelSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesTabletFuncionandoUtilizadoVendaSustentavelPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesTabletFuncionandoUtilizadoVendaSustentavelObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesComputadoresImpressorasFuncionandoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesComputadoresImpressorasFuncionandoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesComputadoresImpressorasFuncionandoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesAlarmesAparelhosFuncionandoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesAlarmesAparelhosFuncionandoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesAlarmesAparelhosFuncionandoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesSistemaSegurançaLojaOperandoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesSistemaSegurançaLojaOperandoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesSistemaSegurançaLojaOperandoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesMobiliariosBomEstadoDentroPadraoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesMobiliariosBomEstadoDentroPadraoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesMobiliariosBomEstadoDentroPadraoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesLampadasAcesasTonalidadesSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesLampadasAcesasTonalidadesPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesLampadasAcesasTonalidadesObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesVitrineFachadaLuzesAcesasMesmasTonalidadesSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesVitrineFachadaLuzesAcesasMesmasTonalidadesPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesVitrineFachadaLuzesAcesasMesmasTonalidadesObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesArCondiconadoFuncionandoTemperaturaAdequadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesArCondiconadoFuncionandoTemperaturaAdequadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesArCondiconadoFuncionandoTemperaturaAdequadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesParedesInternasExternasMateriaisColadosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesParedesInternasExternasMateriaisColadosPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesParedesInternasExternasMateriaisColadosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesLojaLimpaeOganizadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesLojaLimpaeOganizadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesLojaLimpaeOganizadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesNaoPossuiAcumuloMateriaisDesusoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesNaoPossuiAcumuloMateriaisDesusoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesNaoPossuiAcumuloMateriaisDesusoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesLixeirasLimpasLocalApropriadoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesLixeirasLimpasLocalApropriadoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesLixeirasLimpasLocalApropriadoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesFiacaoNaoExpostaOrganizadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesFiacaoNaoExpostaOrganizadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesFiacaoNaoExpostaOrganizadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesFechamentoFinanceiroDiaAnteriorPendenciasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesFechamentoFinanceiroDiaAnteriorPendenciasPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesFechamentoFinanceiroDiaAnteriorPendenciasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesPossuiSinalVivoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPossuiSinalVivoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesPossuiSinalVivoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesImpressorasSemDocumentosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesImpressorasSemDocumentosPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstruturaOperacoesImpressorasSemDocumentosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC0774444068", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__762C88DA",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_GERENTE_GERAL",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_GERENTE_GERAL_PESSOAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    PessoasPlanejamentoDivulgacaoFériasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasPlanejamentoDivulgacaoFériasPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PessoasPlanejamentoDivulgacaoFériasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasTodosColaboradoresPossuemLinhaFuncionalSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasTodosColaboradoresPossuemLinhaFuncionalPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PessoasTodosColaboradoresPossuemLinhaFuncionalObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasTreinamentoFocoRealizadoEquipeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasTreinamentoFocoRealizadoEquipePeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PessoasTreinamentoFocoRealizadoEquipeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasEquipeAcessoPlataformasTreinamentoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasEquipeAcessoPlataformasTreinamentoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PessoasEquipeAcessoPlataformasTreinamentoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasFeedbackindividualderesultadosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasFeedbackindividualderesultadosPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PessoasFeedbackindividualderesultadosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasGestaoPontoRealizadaSemanalmenteSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasGestaoPontoRealizadaSemanalmentePeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PessoasGestaoPontoRealizadaSemanalmenteObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVagasAbertoPossuemSPPSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVagasAbertoPossuemSPPPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PessoasVagasAbertoPossuemSPPObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC077908F585", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__7AF13DF7",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_GERENTE_GERAL",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_GERENTE_GERAL_PROCESSOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    ProcessosManualLojaPropriaAtualizadoDisponívelSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosManualLojaPropriaAtualizadoDisponívelPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosManualLojaPropriaAtualizadoDisponívelObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosQuadroAvisosAtualizadoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosQuadroAvisosAtualizadoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosQuadroAvisosAtualizadoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAtaReuniaoRealizadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAtaReuniaoRealizadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosAtaReuniaoRealizadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosGestaoMaterialEscritorioSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosGestaoMaterialEscritorioPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosGestaoMaterialEscritorioObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosUpLoadBookFotograficoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosUpLoadBookFotograficoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosUpLoadBookFotograficoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAlvaraFuncionamentoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAlvaraFuncionamentoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosAlvaraFuncionamentoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAuditoriaBVCSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAuditoriaBVCPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosAuditoriaBVCObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAnaliseIndicadoresQualidadeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAnaliseIndicadoresQualidadePeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosAnaliseIndicadoresQualidadeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAnaliseIndicadoresTempoPlanoAcaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAnaliseIndicadoresTempoPlanoAcaoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosAnaliseIndicadoresTempoPlanoAcaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosEquipeAlinhadaGestaoDocumentalSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosEquipeAlinhadaGestaoDocumentalPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosEquipeAlinhadaGestaoDocumentalObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosGestaoIrregularidadesApontadasVivoGEDSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosGestaoIrregularidadesApontadasVivoGEDPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosGestaoIrregularidadesApontadasVivoGEDObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosEquipeAlinhadaAtendimentoPJSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosEquipeAlinhadaAtendimentoPJPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosEquipeAlinhadaAtendimentoPJObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosMasterBoxFechadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosMasterBoxFechadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosMasterBoxFechadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosConferenciaEstoqueConformeITSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosConferenciaEstoqueConformeITPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosConferenciaEstoqueConformeITObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosConferenciaRPARConformeITSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosConferenciaRPARConformeITPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosConferenciaRPARConformeITObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosConferenciaAleatoriaAparelhosAbertosDemonstracaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosConferenciaAleatoriaAparelhosAbertosDemonstracaoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosConferenciaAleatoriaAparelhosAbertosDemonstracaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosBaixaProgramaPontosRealizadaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosBaixaProgramaPontosRealizadaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosBaixaProgramaPontosRealizadaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosPendenciasEmissaoNotasFiscaisSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosPendenciasEmissaoNotasFiscaisPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosPendenciasEmissaoNotasFiscaisObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosCaixaConferirFundoTrocoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosCaixaConferirFundoTrocoPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosCaixaConferirFundoTrocoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosCofreFechadoSegredoChaveSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosCofreFechadoSegredoChavePeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProcessosCofreFechadoSegredoChaveObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC077DCDAAA2", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__7FB5F314",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_GERENTE_GERAL",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_GERENTE_GERAL_RESULTADO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    ResultadosIndicadoresAnaliseIndicadoresBookLojaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ResultadosIndicadoresAnaliseIndicadoresBookLojaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ResultadosIndicadoresAnaliseIndicadoresBookLojaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ResultadosIndicadoresAnaliseIndividualIndicadoresSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ResultadosIndicadoresAnaliseIndividualIndicadoresPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ResultadosIndicadoresAnaliseIndividualIndicadoresObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ResultadosIndicadoresMetaDiariaDefinidaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ResultadosIndicadoresMetaDiariaDefinidaPeriodicidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ResultadosIndicadoresMetaDiariaDefinidaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC0702925FBF", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__047AA831",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_GERENTE_GERAL",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CHECKLIST_PEX_LLPP_AVALIADORA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVisita = table.Column<int>(type: "int", nullable: false),
                    ExisteGerenteResponsavelMomentoAuditoriaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EquipamentoTavFuncionandoCorretamenteSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EquipamentoGSSFuncionandoCorretamenteSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ConsultorRecepcionandoClientesSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ArCondicionadoFuncionandoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LojaLampadasFuncionandoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TvDivulgacaoVinhetasFuncionandoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TvInformeSenhaAtendimentoFuncionandoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FachadaLojaPadronizadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PisoLojaPadronizadoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ParedeLojaPadronizadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CadeirasLojaPadronizadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LixeiraLojaPadronizadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MobiliarioPerfeitoEstadoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FiacaoExpostaFormaOrdenadaNaoVisivelClienteSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LojaPossuiRevistaMundoVivoVersaoDigitalSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LojaPossuiCodigoDefesaConsumidorSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    VitrineExternaPositivadaMapaPdvSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    VitrineInternaDegustadoresPositivadosSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AreaAcessoLojaPositivadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AreaEsperaEstaPositivadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AreaAtendimentoPositivadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AparelhosLigadosVinhetasAprovadasSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DisplaysAparelhosDemonstracaoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SistemaSegurancaDegustadoresFuncionandoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EquipeUniformizadaCorretamenteSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PromotoresFabricantesUniformizadosCorretamenteSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ColaboradoresUsandoCrachaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AtlysSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Vivo360SimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ProgramaPontosSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NsiaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    WebVendasSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TreinappSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SenhaTesteEmitidaDiaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CaixaLojaCorretoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FechamentoFinanceiroDiaAnteriorFechouSemPendenciaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BaixaProgramaPontosOkSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LojaEstaAreasSalaoVendasSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MetasEstaoExpostasSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Cartaz10AtitudesPositivadoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PAEscolhidaArvoreOfertasInstaladaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LojaPossuiUrnaColetoraPadronizadaSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MaquinasUsamChipVivoSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Capacitacao = table.Column<int>(type: "int", nullable: true),
                    FDP = table.Column<int>(type: "int", nullable: true),
                    SenhasDesistidas = table.Column<int>(type: "int", nullable: true),
                    GestaoDocumentalQuantitaticaAltaMigra = table.Column<int>(type: "int", nullable: true),
                    GestaoDocumentalQuantitaticaTrocaChip = table.Column<int>(type: "int", nullable: true),
                    UtilizacaoSap = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PenetracaoDigitalSimNao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EmailsValidosContaDigital = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHECKLIS__3214EC0725DB9BFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CHECKLIST__IdVis__27C3E46E",
                        column: x => x.IdVisita,
                        principalTable: "CHECKLIST_PEX_LLPP",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DEMANDAS_CHAT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDemandas = table.Column<int>(type: "int", nullable: false),
                    RESPONSAVEL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC27184C96B4", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CONTROLE___IdDem__1A34DF26",
                        column: x => x.IdDemandas,
                        principalTable: "CONTROLE_DEMANDAS_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DEMANDAS_EVIDENCIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DEMANDAS = table.Column<int>(type: "int", nullable: false),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC277E8CC4B1", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CONTROLE___ID_DE__00750D23",
                        column: x => x.ID_DEMANDAS,
                        principalTable: "CONTROLE_DEMANDAS_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_AMIGAVEL OLD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DESCREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    SOLICITACAO_PARCEIRO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_SOLICITACAO_PARCEIRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    INFORME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LIBERADO_CHANCELA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_LIBERADO_CHANCELA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_CHANCELA_DISTRATO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ENVIO_TERRITORIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ENVIO_TERRITORIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECEBIMENTO_DISTRATO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_RECEBIMENTO_DISTRATO = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ASSINATURA_DIVISAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ASSINATURA_DIVISAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASSINATURA_DIRETORIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ASSINATURA_DIRETORIA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECONHECIMENTO_FIRMA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_RECONHECIMENTO_FIRMA = table.Column<DateTime>(type: "datetime", nullable: true),
                    EXCLUSAO_ACESSOS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_EXCLUSAO_ACESSOS = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ENVIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_RECEBIMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMISSAO_NOTIFICACAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_SOLIC_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CONFIRMACAO_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC2714270015", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESCREDEN__ID_DE__160F4887",
                        column: x => x.ID_DESCREDENCIAMENTO,
                        principalTable: "DESCREDENCIAMENTO_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_INFORMADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_DATA_INFORMADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "text", nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true),
                    LISTA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SLALINHA = table.Column<int>(name: "SLA LINHA", type: "int", nullable: true),
                    ID_DESCREDENCIAMENTO_CADASTRO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC273C75B3E8", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESCREDEN__ID_DE__0B3E4B07",
                        column: x => x.ID_DESCREDENCIAMENTO_CADASTRO,
                        principalTable: "DESCREDENCIAMENTO_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS_TESTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADABAS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATA_INFORMADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_DATA_INFORMADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "text", nullable: true),
                    IdAcesso = table.Column<int>(type: "int", nullable: true),
                    LISTA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    SLALINHA = table.Column<int>(name: "SLA LINHA", type: "int", nullable: true),
                    ID_DESCREDENCIAMENTO_CADASTRO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC27D4896D03", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESCREDEN__ID_DE__0861DE5C",
                        column: x => x.ID_DESCREDENCIAMENTO_CADASTRO,
                        principalTable: "DESCREDENCIAMENTO_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_DENUNCIA_IMOTIVADA_OLD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DESCREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    SOLICITACAO_PARCEIRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_SOLICITACAO_PARCEIRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    INFORME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LIBERADO_CHANCELA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_LIBERADO_CHANCELA = table.Column<DateTime>(type: "datetime", nullable: true),
                    CHANCELA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_CHANCELA = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASSINATURA_DIVISAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_ASSINATURA_DIVISAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASSINATURA_DIRETORIA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_ASSINATURA_DIRETORIA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECONHECIMENTO_FIRMA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_RECONHECIMENTO_FIRMA = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIO_TERRITORIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_ENVIO_TERRITORIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECEBIMENTO_NOTIFICACAO_CERTIDAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_RECEBIMENTO_NOTIFICACAO_CERTIDAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_CERTIDAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_DATA_CERTIDAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    EXCLUSAO_ACESSOS = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_EXCLUSAO_ACESSOS = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ENVIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_RECEBIMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMISSAO_NOTIFICACAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_SOLIC_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CONFIRMACAO_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RECEBIMENTO_DISTRATO = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    DATA_RECEBIMENTO_DISTRATO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC2743E1002F", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESCREDEN__ID_DE__45C948A1",
                        column: x => x.ID_DESCREDENCIAMENTO,
                        principalTable: "DESCREDENCIAMENTO_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_INATIVIDADE_OLD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DESCREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    SOLICITACAO_PARCEIRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_SOLICITACAO_PARCEIRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    INFORME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LIBERADO_CHANCELA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_LIBERADO_CHANCELA = table.Column<DateTime>(type: "datetime", nullable: true),
                    CHANCELA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_CHANCELA = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASSINATURA_DIVISAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_ASSINATURA_DIVISAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASSINATURA_DIRETORIA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_ASSINATURA_DIRETORIA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECONHECIMENTO_FIRMA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_RECONHECIMENTO_FIRMA = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIO_TERRITORIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_ENVIO_TERRITORIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECEBIMENTO_NOTIFICACAO_CERTIDAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_RECEBIMENTO_NOTIFICACAO_CERTIDAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DATA_CERTIDAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_DATA_CERTIDAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    EXCLUSAO_ACESSOS = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_EXCLUSAO_ACESSOS = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ENVIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_RECEBIMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMISSAO_NOTIFICACAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_SOLIC_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CONFIRMACAO_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC2718EBB532", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESCREDEN__ID_DE__1AD3FDA4",
                        column: x => x.ID_DESCREDENCIAMENTO,
                        principalTable: "DESCREDENCIAMENTO_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DESCREDENCIAMENTO_VIGENCIA_CONTRATO_OLD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DESCREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    SOLICITACAO_PARCEIRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_SOLICITACAO_PARCEIRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    INFORME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LIBERADO_CHANCELA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_LIBERADO_CHANCELA = table.Column<DateTime>(type: "datetime", nullable: true),
                    CHANCELA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CHANCELA = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASSINATURA_DIVISAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ASSINATURA_DIVISAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ASSINATURA_DIRETORIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ASSINATURA_DIRETORIA = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECONHECIMENTO_FIRMA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_RECONHECIMENTO_FIRMA = table.Column<DateTime>(type: "datetime", nullable: true),
                    TERMINO_CONTRATO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_TERMINO_CONTRATO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENVIO_RECEBIMENTO_NOTIFICACAO_CERTIDAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_ENVIO_RECEBIMENTO_NOTIFICACAO_CERTIDAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EXCLUSAO_ACESSOS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_EXCLUSAO_ACESSOS = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DATA_ENVIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_RECEBIMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMISSAO_NOTIFICACAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_SOLIC_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_CONFIRMACAO_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DATA_DATA_PREVISTA_DESCREDENCIAMENTO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DESCREDE__3214EC271DB06A4F", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DESCREDEN__ID_DE__1F98B2C1",
                        column: x => x.ID_DESCREDENCIAMENTO,
                        principalTable: "DESCREDENCIAMENTO_CADASTRO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RESET_SENHA_SISTEMAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReset = table.Column<int>(type: "int", nullable: false),
                    Sistema = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Senha = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    MotivoRejeite = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DataRejeite = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSenha = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataRejeiteGc = table.Column<DateTime>(type: "datetime", nullable: true),
                    MotivoRejeiteGc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DataAceiteGc = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RESET_SE__3214EC2702084FDA", x => x.ID);
                    table.ForeignKey(
                        name: "FK__RESET_SEN__IdRes__03F0984C",
                        column: x => x.IdReset,
                        principalTable: "RESET_SENHA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SAVING_EVIDENCIAS_BKP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SAVING = table.Column<int>(type: "int", nullable: false),
                    IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    EXTENSAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SAVING_E__3214EC27592635D8", x => x.ID);
                    table.ForeignKey(
                        name: "FK__SAVING_EV__ID_SA__5B0E7E4A",
                        column: x => x.ID_SAVING,
                        principalTable: "SAVING_CADASTRO_BKP",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_ESTRUTURAS_OPERACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    EstruturaOperacoesPositivacaoVerificarMaterialPositivadoMapaPDVSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPositivacaoVerificarMaterialPositivadoMapaPDVObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesPositivacaoVerificarExisteFaltaMaterialSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPositivacaoVerificarExisteFaltaMaterialObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesPositivacaoVerificarExisteMaterialVencidoAcumuladoLojaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPositivacaoVerificarExisteMaterialVencidoAcumuladoLojaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesPositivacaoVerificarAparelhosLigadosVitrineSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesPositivacaoVerificarAparelhosLigadosVitrineObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesVerificarPendenciaManutencaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesVerificarPendenciaManutencaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesVerificarExisteChamadadoAbertoManutencaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesVerificarExisteChamadadoAbertoManutencaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesConferirEquipamentoInformaticaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesConferirEquipamentoInformaticaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesConferirOrganizacaoAreaInternaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesConferirOrganizacaoAreaInternaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesVerificarExisteAcumuloEquipamentoMobiliarioDevolucaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesVerificarExisteAcumuloEquipamentoMobiliarioDevolucaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesConferirLimpezaLojaAreaInternaExternaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesConferirLimpezaLojaAreaInternaExternaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesConferirVitrinesEstaoTrancadasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesConferirVitrinesEstaoTrancadasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EstruturaOperacoesConferirAlarmeEstaFuncionandoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EstruturaOperacoesConferirAlarmeEstaFuncionandoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC076BAEFA67", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__6D9742D9",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_INDICADORES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    ResultadosIndicadoresAvaliarPerformanceCorrenteSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ResultadosIndicadoresAvaliarPerformanceCorrenteObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ResultadosIndicadoresIndicadoresTempoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ResultadosIndicadoresIndicadoresTempoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ResultadosIndicadoresAcompanharAlgunsAtendimentosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ResultadosIndicadoresAcompanharAlgunsAtendimentosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ResultadosIndicadoresRentabilidadeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ResultadosIndicadoresRentabilidadeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC0766EA454A", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__68D28DBC",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_PESSOAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    PessoasExisteVagaOpenSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasExisteVagaOpenObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasPossuiVagaExcedenteReintegracaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasPossuiVagaExcedenteReintegracaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarExisteFuncionarioAfastadoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarExisteFuncionarioAfastadoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarexisteFuncionarioEstabilidadeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarexisteFuncionarioEstabilidadeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarUniformeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarUniformeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarAbsenteismoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarAbsenteismoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarFechamentoPontoHCSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarFechamentoPontoHCObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarDocumentacaoFiscalizacaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarDocumentacaoFiscalizacaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasTodosEstaoCrachaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasTodosEstaoCrachaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarApresentacaoPessoalEquipeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarApresentacaoPessoalEquipeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarAdesaoEscalaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarAdesaoEscalaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarClimaEquipeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarClimaEquipeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasRealizarInteracaoEquipeSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasRealizarInteracaoEquipeObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasTodosEstaoSenhasLiberadasAcessoSistemasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasTodosEstaoSenhasLiberadasAcessoSistemasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarAdesaoTreinamentosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarAdesaoTreinamentosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasVerificarEscalaFeriasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasVerificarEscalaFeriasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasParticiparMatinaisVespertinasSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasParticiparMatinaisVespertinasObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PessoasConfirmarTodosCargosEstaoRealizandoAtuacaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PessoasConfirmarTodosCargosEstaoRealizandoAtuacaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC076225902D", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__640DD89F",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_PROCESSOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbertura = table.Column<int>(type: "int", nullable: false),
                    ProcessosVerificarRealizacaoContagemDiariaEstoqueSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosVerificarRealizacaoContagemDiariaEstoqueObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosVerificarPlanilhaVendasConferidaSinalizacaoEspecialSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosVerificarPlanilhaVendasConferidaSinalizacaoEspecialObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosVerificarOrganizacaoEstoqueSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosVerificarOrganizacaoEstoqueObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosVerificarCofreTrancadoSenhaEquipeGerencialSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosVerificarCofreTrancadoSenhaEquipeGerencialObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosVerificarExisteAcumuloRPARDevolucaoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosVerificarExisteAcumuloRPARDevolucaoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosRealizarEventualmenteContagemConjuntoGerenteAuditoriaProcessosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosRealizarEventualmenteContagemConjuntoGerenteAuditoriaProcessosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosVerificarEnvioNumerarioSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosVerificarEnvioNumerarioObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosConferirFundoTrocoSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosConferirFundoTrocoObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosGestaoDocumentalConferirDocumentosAcumuladosLojaNDigitalizadosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosGestaoDocumentalConferirDocumentosAcumuladosLojaNDigitalizadosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosGestaoDocumentalObservarLojaEstaUtilizandoTabletsAssinaturaDigitalSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosGestaoDocumentalObservarLojaEstaUtilizandoTabletsAssinaturaDigitalObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAnatelVerificarPastaGSSSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAnatelVerificarPastaGSSObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAnatelVerificarJustificativaSMP14SimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAnatelVerificarJustificativaSMP14Obs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAnatelVerificarAtendimentoDevidamenteRegistradosSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAnatelVerificarAtendimentoDevidamenteRegistradosObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosAnatelObservarGestaoFluxoGeralLojaSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosAnatelObservarGestaoFluxoGeralLojaObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosVerificarQuadroAvisosAtualizacaoPadraoPEXSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosVerificarQuadroAvisosAtualizacaoPadraoPEXObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ProcessosSuprimentosVerificarEstoqueMaterialEscritorioSimNao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProcessosSuprimentosVerificarEstoqueMaterialEscritorioObs = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIVO_VIS__3214EC075D60DB10", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VIVO_VISI__IdAbe__5F492382",
                        column: x => x.IdAbertura,
                        principalTable: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CHAMADO_HISTORICO_PRIORIDADE",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MAT_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    PRIORIDADE = table.Column<bool>(type: "bit", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMADO_HISTORICO_PRIORIDADE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CHAMADO_HISTORICO_PRIORIDADE_ACESSOS_MOBILE_MAT_RESPONSAVEL",
                        column: x => x.MAT_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHAMADO_HISTORICO_PRIORIDADE_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_ACESSOS",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", unicode: false, nullable: false),
                    Acao = table.Column<int>(type: "int", nullable: false),
                    Adabas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeContato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubGrupo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataContratoInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ddd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinalizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExtracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Funcao = table.Column<int>(type: "int", nullable: false),
                    RejeitarSenha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataMatricula = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PIS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    REGIONAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATRICULA_SOLICITANTE = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_ACESSOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DEMANDA_ACESSOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_ACESSOS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
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
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    DATA_RESPOSTA = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CHAMADO_RESPOSTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_RESPOSTA_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_RESPOSTA_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
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
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", nullable: true),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    REGIONAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matricula = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_DESLIGAMENTOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_DESLIGAMENTOS_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DEMANDA_DESLIGAMENTOS_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_DESLIGAMENTOS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_OBSERVACOES_ANALISTAS",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MAT_ANALISTA = table.Column<int>(type: "int", unicode: false, nullable: false),
                    OBSERVACAO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_OBSERVACOES_ANALISTAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_OBSERVACOES_ANALISTAS_ACESSOS_MOBILE_MAT_ANALISTA",
                        column: x => x.MAT_ANALISTA,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_OBSERVACOES_ANALISTAS_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                schema: "Demandas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA = table.Column<int>(type: "int", nullable: false),
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Data_Admissão = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    Canal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Data_Conclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STATUS_MATRICULA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DT_MOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MAT_MOD = table.Column<int>(type: "int", nullable: false),
                    Modo_Inclusao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_ITENS_CAMPO_COMBOBOX_FILA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CAMPO_COMBOBOX_FILA = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CONTROLE_DE_DEMANDAS_ITENS_CAMPO_COMBOBOX_FILA",
                        column: x => x.ID_CAMPO_COMBOBOX_FILA,
                        principalTable: "CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_CHAMADO_ARQUIVOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC075A1B2568", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ARQUIVOS_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_CHAMADO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESPOSTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_RESPOSTA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC275EDFDA85", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RESPOSTA_CHAMADO",
                        column: x => x.ID_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_CHAMADO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DE_DEMANDAS_EMAIL",
                columns: table => new
                {
                    ID_CHAMADO = table.Column<int>(type: "int", nullable: false),
                    EMAIL_REMETENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MAT_REMETENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NOME_REMETENTE = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    EMAIL_DESTINATARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MAT_DESTINATARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NOME_DESTINATARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    TIPO_CHAMADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    STATUS_CHAMADO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA_ENVIO_EMAIL = table.Column<DateTime>(type: "datetime", nullable: true),
                    CORPO_EMAIL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CONTROLE_DE_DEMANDAS_EMAIL",
                        column: x => x.ID_CHAMADO,
                        principalTable: "CONTROLE_DE_DEMANDAS_CHAMADO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_ANALISTAS_HISTORICO",
                columns: table => new
                {
                    LOGIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ID_CREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CREDENCIAMENTO_OPERADORES_CHISTORICO",
                        column: x => x.ID_CREDENCIAMENTO,
                        principalTable: "CREDENCIAMENTO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_RELACAO_ARQUIVOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    NOME_CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC07171A1207", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CREDENCIAMENTO",
                        column: x => x.ID_CREDENCIAMENTO,
                        principalTable: "CREDENCIAMENTO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_RELACAO_STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC275CB86648", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RELACAO_STATUS_CREDENCIAMENTO",
                        column: x => x.ID_CREDENCIAMENTO,
                        principalTable: "CREDENCIAMENTO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_RESPOSTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESPOSTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    IDCREDENCIAMENTO = table.Column<int>(type: "int", nullable: false),
                    MATRICULA_RESPONSAVEL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DATA_RESPOSTA = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SLALINHA = table.Column<int>(name: "SLA LINHA", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CREDENCI__3214EC2747BD4962", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RESPOSTA_CREDENCIAMENTO",
                        column: x => x.IDCREDENCIAMENTO,
                        principalTable: "CREDENCIAMENTO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PROSPECT_ARQUIVOS_RESPOSTA",
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
                    table.PrimaryKey("PK__PROSPECT__3214EC277C3111A1", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ARQUIVO_RESPOSTA_PROSPECT",
                        column: x => x.ID_RESPOSTA,
                        principalTable: "PROSPECT_RESPOSTA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_CAMPOS_FILA",
                columns: table => new
                {
                    ID_CAMPOS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SUB_FILA = table.Column<int>(type: "int", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MASCARA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CAMPO_SUSPENSO = table.Column<bool>(type: "bit", nullable: false),
                    REGIONAL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DT_CRIACAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    STATUS_CAMPOS_FILA = table.Column<bool>(type: "bit", nullable: false),
                    MAT_CRIADOR = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEMANDA___435DD5A7F07B2C1C", x => x.ID_CAMPOS);
                    table.ForeignKey(
                        name: "FK_CAMPOS_FILA_ID_SUB_FILA",
                        column: x => x.ID_SUB_FILA,
                        principalTable: "DEMANDA_SUB_FILA",
                        principalColumn: "ID_SUB_FILA",
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
                    REGIONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CLIENTE_ALTO_VALOR = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEMANDA_CHAMADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_ACESSOS_MOBILE_MATRICULA_RESPONSAVEL",
                        column: x => x.MATRICULA_RESPONSAVEL,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_ACESSOS_MOBILE_MATRICULA_SOLICITANTE",
                        column: x => x.MATRICULA_SOLICITANTE,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "ID_RELACAO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_CHAMADO_DEMANDA_SUB_FILA_ID_FILA_CHAMADO",
                        column: x => x.ID_FILA_CHAMADO,
                        principalTable: "DEMANDA_SUB_FILA",
                        principalColumn: "ID_SUB_FILA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_RESPONSAVEL_FILA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATRICULA_RESPONSAVEL = table.Column<int>(type: "int", nullable: true),
                    ID_SUB_FILA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEMANDA___3214EC273330E626", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RESPONSAVEL_ID_FILA",
                        column: x => x.ID_SUB_FILA,
                        principalTable: "DEMANDA_SUB_FILA",
                        principalColumn: "ID_SUB_FILA");
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
                    ID_RELACAO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_ACESSOS_MOBILE_MAT_QUEM_REDIRECIONOU",
                        column: x => x.MAT_QUEM_REDIRECIONOU,
                        principalSchema: "dbo",
                        principalTable: "ACESSOS_MOBILE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_CHAMADO_RESPOSTA_ID_RESPOSTA",
                        column: x => x.ID_RESPOSTA,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_CHAMADO_RESPOSTA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEMANDA_STATUS_CHAMADO_DEMANDA_RELACAO_CHAMADO_ID_RELACAO",
                        column: x => x.ID_RELACAO,
                        principalSchema: "Demandas",
                        principalTable: "DEMANDA_RELACAO_CHAMADO",
                        principalColumn: "ID_RELACAO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_DEMANDAS_ARQUIVOS_RESPOSTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_RESPOSTA = table.Column<int>(type: "int", nullable: false),
                    NOME_ARQUIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    EXT_ARQUIVO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ARQUIVO = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONTROLE__3214EC276498B3DB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CONTROLE_DEMANDAS_ARQUIVOS_RESPOSTA",
                        column: x => x.ID_RESPOSTA,
                        principalTable: "CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_RELACAO_ARQUIVOS_STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_ARQUIVO = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CREDENCIAMENTO_RELACAO_ARQUIVOS_STATUS_CREDENCIAMENTO_RELACAO_ARQUIVOS1",
                        column: x => x.ID_ARQUIVO,
                        principalTable: "CREDENCIAMENTO_RELACAO_ARQUIVOS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CREDENCIAMENTO_ARQUIVOS_RESPOSTA",
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
                    table.PrimaryKey("PK__CREDENCI__3214EC274C81FE7F", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ARQUIVO_RESPOSTA_CREDENCIAMENTO",
                        column: x => x.ID_RESPOSTA,
                        principalTable: "CREDENCIAMENTO_RESPOSTA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DEMANDA_VALORES_CAMPOS_SUSPENSO",
                columns: table => new
                {
                    ID_VALORES = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VALOR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ID_CAMPOS = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEMANDA___633D96C82F5148A8", x => x.ID_VALORES);
                    table.ForeignKey(
                        name: "FK_CAMPOS_SUSPENSO_ID_SUB_FILA",
                        column: x => x.ID_CAMPOS,
                        principalTable: "DEMANDA_CAMPOS_FILA",
                        principalColumn: "ID_CAMPOS",
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

            migrationBuilder.CreateIndex(
                name: "IX_ACAO_HISTORICO_IDVPC",
                table: "ACAO_HISTORICO",
                column: "IDVPC");

            migrationBuilder.CreateIndex(
                name: "IX_ACESSO_PERMISSAO_MENU_idAcesso",
                table: "ACESSO_PERMISSAO_MENU",
                column: "idAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_ACESSOS_MOBILE_PENDENTE_LOGIN_SOLICITANTE",
                table: "ACESSOS_MOBILE_PENDENTE",
                column: "LOGIN_SOLICITANTE",
                unique: true,
                filter: "[LOGIN_SOLICITANTE] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ALTA_SEM_TRAFEGO_STATUS_IdAST",
                table: "ALTA_SEM_TRAFEGO_STATUS",
                column: "IdAST");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMADO_HISTORICO_PRIORIDADE_ID_RELACAO",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                column: "ID_RELACAO");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMADO_HISTORICO_PRIORIDADE_MAT_RESPONSAVEL",
                schema: "Demandas",
                table: "CHAMADO_HISTORICO_PRIORIDADE",
                column: "MAT_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMADO_LLPP_idAcesso",
                table: "CHAMADO_LLPP",
                column: "idAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_CHECKLIST_PDR_EXTERNO_IMAGENS_idCheckListExterno",
                table: "CHECKLIST_PDR_EXTERNO_IMAGENS",
                column: "idCheckListExterno");

            migrationBuilder.CreateIndex(
                name: "IX_CHECKLIST_PEX_LLPP_IdAcesso",
                table: "CHECKLIST_PEX_LLPP",
                column: "IdAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_CHECKLIST_PEX_LLPP_2_IdAcesso",
                table: "CHECKLIST_PEX_LLPP_2",
                column: "IdAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_CHECKLIST_PEX_LLPP_AVALIADORA_IdVisita",
                table: "CHECKLIST_PEX_LLPP_AVALIADORA",
                column: "IdVisita");

            migrationBuilder.CreateIndex(
                name: "IX_CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA_ID_TRIAGEM",
                table: "CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA",
                column: "ID_TRIAGEM");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA_ID_FILA",
                table: "CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA",
                column: "ID_FILA");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_CAMPOS_FILA_ID_FILA",
                table: "CONTROLE_DE_DEMANDAS_CAMPOS_FILA",
                column: "ID_FILA");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_CHAMADO_ID_CAMPOS_CHAMADO",
                table: "CONTROLE_DE_DEMANDAS_CHAMADO",
                column: "ID_CAMPOS_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_CHAMADO_ID_FILA_CHAMADO",
                table: "CONTROLE_DE_DEMANDAS_CHAMADO",
                column: "ID_FILA_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_CHAMADO_ID_STATUS_CHAMADO",
                table: "CONTROLE_DE_DEMANDAS_CHAMADO",
                column: "ID_STATUS_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_CHAMADO_ARQUIVOS_ID_CHAMADO",
                table: "CONTROLE_DE_DEMANDAS_CHAMADO_ARQUIVOS",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20200414-145819",
                table: "CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTA",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_EMAIL_ID_CHAMADO",
                table: "CONTROLE_DE_DEMANDAS_EMAIL",
                column: "ID_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "ClusteredIndex-20200414-144037",
                table: "CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO",
                column: "ID_CAMPOS_CHAMADO")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_RELACAO_ITENS_CAMPO_COMBOBOX_FILA_ID_CAMPO_COMBOBOX_FILA",
                table: "CONTROLE_DE_DEMANDAS_RELACAO_ITENS_CAMPO_COMBOBOX_FILA",
                column: "ID_CAMPO_COMBOBOX_FILA");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO_ID_STATUS_CHAMADO",
                table: "CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO",
                column: "ID_STATUS_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA_ID_FILA_CHAMADO",
                table: "CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA",
                column: "ID_FILA_CHAMADO");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DEMANDAS_ARQUIVOS_RESPOSTA_ID_RESPOSTA",
                table: "CONTROLE_DEMANDAS_ARQUIVOS_RESPOSTA",
                column: "ID_RESPOSTA");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DEMANDAS_CADASTRO_IdAcesso",
                table: "CONTROLE_DEMANDAS_CADASTRO",
                column: "IdAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DEMANDAS_CHAT_IdDemandas",
                table: "CONTROLE_DEMANDAS_CHAT",
                column: "IdDemandas");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_DEMANDAS_EVIDENCIAS_ID_DEMANDAS",
                table: "CONTROLE_DEMANDAS_EVIDENCIAS",
                column: "ID_DEMANDAS");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_ID_PROSPECT",
                table: "CREDENCIAMENTO",
                column: "ID_PROSPECT");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_ANALISTAS_HISTORICO_ID_CREDENCIAMENTO",
                table: "CREDENCIAMENTO_ANALISTAS_HISTORICO",
                column: "ID_CREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_ARQUIVOS_RESPOSTA_ID_RESPOSTA",
                table: "CREDENCIAMENTO_ARQUIVOS_RESPOSTA",
                column: "ID_RESPOSTA");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_PROSPECT_RELACAO_ARQUIVOS_ID_CREDENCIAMENTO_PROSPECT",
                table: "CREDENCIAMENTO_PROSPECT_RELACAO_ARQUIVOS",
                column: "ID_CREDENCIAMENTO_PROSPECT");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_RELACAO_ARQUIVOS_ID_CREDENCIAMENTO",
                table: "CREDENCIAMENTO_RELACAO_ARQUIVOS",
                column: "ID_CREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_RELACAO_ARQUIVOS_STATUS_ID_ARQUIVO",
                table: "CREDENCIAMENTO_RELACAO_ARQUIVOS_STATUS",
                column: "ID_ARQUIVO");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_RELACAO_STATUS_ID_CREDENCIAMENTO",
                table: "CREDENCIAMENTO_RELACAO_STATUS",
                column: "ID_CREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_CREDENCIAMENTO_RESPOSTA_IDCREDENCIAMENTO",
                table: "CREDENCIAMENTO_RESPOSTA",
                column: "IDCREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ACESSOS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "ID_RELACAO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_ACESSOS_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_ACESSOS",
                column: "MATRICULA_RESPONSAVEL");

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
                name: "IX_DEMANDA_CAMPOS_FILA_ID_SUB_FILA",
                table: "DEMANDA_CAMPOS_FILA",
                column: "ID_SUB_FILA");

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
                name: "IX_DEMANDA_CHAMADO_RESPOSTA_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_CHAMADO_RESPOSTA",
                column: "ID_RELACAO");

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
                name: "IX_DEMANDA_DESLIGAMENTOS_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                column: "MATRICULA_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_DESLIGAMENTOS_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_DESLIGAMENTOS",
                column: "MATRICULA_SOLICITANTE");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_OBSERVACOES_ANALISTAS_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_OBSERVACOES_ANALISTAS",
                column: "ID_RELACAO");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_OBSERVACOES_ANALISTAS_MAT_ANALISTA",
                schema: "Demandas",
                table: "DEMANDA_OBSERVACOES_ANALISTAS",
                column: "MAT_ANALISTA");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_RELACAO_CHAMADO_MATRICULA_RESPONSAVEL",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                column: "MATRICULA_RESPONSAVEL");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_RELACAO_CHAMADO_MATRICULA_SOLICITANTE",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_CHAMADO",
                column: "MATRICULA_SOLICITANTE");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_RELACAO_TREINAMENTO_FINALIZADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                column: "ID_RELACAO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_RESPONSAVEL_FILA_ID_SUB_FILA",
                table: "DEMANDA_RESPONSAVEL_FILA",
                column: "ID_SUB_FILA");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_STATUS_CHAMADO_ID_RELACAO",
                schema: "Demandas",
                table: "DEMANDA_STATUS_CHAMADO",
                column: "ID_RELACAO");

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

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_SUB_FILA_ID_TIPO_FILA",
                table: "DEMANDA_SUB_FILA",
                column: "ID_TIPO_FILA");

            migrationBuilder.CreateIndex(
                name: "IX_DEMANDA_VALORES_CAMPOS_SUSPENSO_ID_CAMPOS",
                table: "DEMANDA_VALORES_CAMPOS_SUSPENSO",
                column: "ID_CAMPOS");

            migrationBuilder.CreateIndex(
                name: "IX_DESCREDENCIAMENTO_AMIGAVEL OLD_ID_DESCREDENCIAMENTO",
                table: "DESCREDENCIAMENTO_AMIGAVEL OLD",
                column: "ID_DESCREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESCREDENCIAMENTO_CADASTRO_IDACESSO",
                table: "DESCREDENCIAMENTO_CADASTRO",
                column: "IDACESSO");

            migrationBuilder.CreateIndex(
                name: "IX_DESCREDENCIAMENTO_COMPLETO_DADOS_ID_DESCREDENCIAMENTO_CADASTRO",
                table: "DESCREDENCIAMENTO_COMPLETO_DADOS",
                column: "ID_DESCREDENCIAMENTO_CADASTRO");

            migrationBuilder.CreateIndex(
                name: "IX_DESCREDENCIAMENTO_COMPLETO_DADOS_TESTE_ID_DESCREDENCIAMENTO_CADASTRO",
                table: "DESCREDENCIAMENTO_COMPLETO_DADOS_TESTE",
                column: "ID_DESCREDENCIAMENTO_CADASTRO");

            migrationBuilder.CreateIndex(
                name: "IX_DESCREDENCIAMENTO_DENUNCIA_IMOTIVADA_OLD_ID_DESCREDENCIAMENTO",
                table: "DESCREDENCIAMENTO_DENUNCIA_IMOTIVADA_OLD",
                column: "ID_DESCREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESCREDENCIAMENTO_INATIVIDADE_OLD_ID_DESCREDENCIAMENTO",
                table: "DESCREDENCIAMENTO_INATIVIDADE_OLD",
                column: "ID_DESCREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESCREDENCIAMENTO_VIGENCIA_CONTRATO_OLD_ID_DESCREDENCIAMENTO",
                table: "DESCREDENCIAMENTO_VIGENCIA_CONTRATO_OLD",
                column: "ID_DESCREDENCIAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_DESLIGAMENTOS_idAcesso",
                table: "DESLIGAMENTOS",
                column: "idAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_FAT_MANUAL_STATUS_ID_FATURAMENTO",
                table: "FAT_MANUAL_STATUS",
                column: "ID_FATURAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_LINHA_TESTE_NRSIMC_IdLinha",
                table: "LINHA_TESTE_NRSIMC",
                column: "IdLinha");

            migrationBuilder.CreateIndex(
                name: "IX_LOJA_CONTESTACAO_FATURA_IdAcesso",
                table: "LOJA_CONTESTACAO_FATURA",
                column: "IdAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_MOTIVOS_PRODUTO_TRIAGEM_CLIENTE_BOLETA_ID_TRIAGEM",
                table: "MOTIVOS_PRODUTO_TRIAGEM_CLIENTE_BOLETA",
                column: "ID_TRIAGEM");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA_ID_TRIAGEM",
                table: "PRODUTOS_CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA",
                column: "ID_TRIAGEM");

            migrationBuilder.CreateIndex(
                name: "IX_PROSPECT_ARQUIVOS_RESPOSTA_ID_RESPOSTA",
                table: "PROSPECT_ARQUIVOS_RESPOSTA",
                column: "ID_RESPOSTA");

            migrationBuilder.CreateIndex(
                name: "IX_PROSPECT_RESPOSTA_IDPROSPECT",
                table: "PROSPECT_RESPOSTA",
                column: "IDPROSPECT");

            migrationBuilder.CreateIndex(
                name: "IX_RESET_SENHA_idAcesso",
                table: "RESET_SENHA",
                column: "idAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_RESET_SENHA_SISTEMAS_IdReset",
                table: "RESET_SENHA_SISTEMAS",
                column: "IdReset");

            migrationBuilder.CreateIndex(
                name: "IX_SAVING_CADASTRO_BKP_IdAcesso",
                table: "SAVING_CADASTRO_BKP",
                column: "IdAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_SAVING_EVIDENCIAS_ID_SAVING",
                table: "SAVING_EVIDENCIAS",
                column: "ID_SAVING");

            migrationBuilder.CreateIndex(
                name: "IX_SAVING_EVIDENCIAS_BKP_ID_SAVING",
                table: "SAVING_EVIDENCIAS_BKP",
                column: "ID_SAVING");

            migrationBuilder.CreateIndex(
                name: "IX_TABELA_QUALIDADE_FPD_FIXA_STATUS_IdFPD",
                table: "TABELA_QUALIDADE_FPD_FIXA_STATUS",
                column: "IdFPD");

            migrationBuilder.CreateIndex(
                name: "IX_TABELA_QUALIDADE_FPD_MOVEL_STATUS_IdFPD",
                table: "TABELA_QUALIDADE_FPD_MOVEL_STATUS",
                column: "IdFPD");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_CANAL_TERRITORIO_ABERTURA_IdAcesso",
                table: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA",
                column: "IdAcesso");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_CANAL_TERRITORIO_ESTRUTURAS_OPERACAO_IdAbertura",
                table: "VIVO_VISITA_CANAL_TERRITORIO_ESTRUTURAS_OPERACAO",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_CANAL_TERRITORIO_INDICADORES_IdAbertura",
                table: "VIVO_VISITA_CANAL_TERRITORIO_INDICADORES",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_CANAL_TERRITORIO_PESSOAS_IdAbertura",
                table: "VIVO_VISITA_CANAL_TERRITORIO_PESSOAS",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_CANAL_TERRITORIO_PROCESSOS_IdAbertura",
                table: "VIVO_VISITA_CANAL_TERRITORIO_PROCESSOS",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_GERENTE_GERAL_ESTRUTURA_OPERACAO_IdAbertura",
                table: "VIVO_VISITA_GERENTE_GERAL_ESTRUTURA_OPERACAO",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_GERENTE_GERAL_PESSOAS_IdAbertura",
                table: "VIVO_VISITA_GERENTE_GERAL_PESSOAS",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_GERENTE_GERAL_PROCESSOS_IdAbertura",
                table: "VIVO_VISITA_GERENTE_GERAL_PROCESSOS",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_GERENTE_GERAL_RESULTADO_IdAbertura",
                table: "VIVO_VISITA_GERENTE_GERAL_RESULTADO",
                column: "IdAbertura");

            migrationBuilder.CreateIndex(
                name: "IX_VIVO_VISITA_PASSAGEM_ABERTURA_IdAcesso",
                table: "VIVO_VISITA_PASSAGEM_ABERTURA",
                column: "IdAcesso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A_QUEM_RECORRER");

            migrationBuilder.DropTable(
                name: "ACAO_ACOMPANHAMENTO");

            migrationBuilder.DropTable(
                name: "ACAO_DOCUMENTACAO");

            migrationBuilder.DropTable(
                name: "ACAO_HISTORICO");

            migrationBuilder.DropTable(
                name: "ACAO_LAYOUT");

            migrationBuilder.DropTable(
                name: "ACAO_MIDIA_DETALHADA");

            migrationBuilder.DropTable(
                name: "ACAO_SALDO_REDE");

            migrationBuilder.DropTable(
                name: "ACAO_STATUS");

            migrationBuilder.DropTable(
                name: "ACAO_TIPO_MIDIA");

            migrationBuilder.DropTable(
                name: "ACAO_VALOR");

            migrationBuilder.DropTable(
                name: "ACESSO_CARGO_PERFIL");

            migrationBuilder.DropTable(
                name: "ACESSO_PERMISSAO_MENU");

            migrationBuilder.DropTable(
                name: "ACESSO_TERCEIROS");

            migrationBuilder.DropTable(
                name: "ACESSO_TERCEIROS_ALIADOS");

            migrationBuilder.DropTable(
                name: "ACESSO_TERCEIROS_OBSERVACAO");

            migrationBuilder.DropTable(
                name: "ACESSO_TERCEIROS_SISTEMAS");

            migrationBuilder.DropTable(
                name: "ACESSO_TERCEIROS_SLA");

            migrationBuilder.DropTable(
                name: "ACESSO_TERCEIROS_TESTE");

            migrationBuilder.DropTable(
                name: "ACESSOS_DANI");

            migrationBuilder.DropTable(
                name: "ACESSOS_MOBILE_PENDENTE");

            migrationBuilder.DropTable(
                name: "ADMISSAO");

            migrationBuilder.DropTable(
                name: "ALTA_SEM_TRAFEGO_STATUS");

            migrationBuilder.DropTable(
                name: "APARELHO_CHIP_BOLETA");

            migrationBuilder.DropTable(
                name: "API_CACHE");

            migrationBuilder.DropTable(
                name: "APROVADORES$");

            migrationBuilder.DropTable(
                name: "ARQUIVOS_FAT_MANUAL");

            migrationBuilder.DropTable(
                name: "ARQUIVOS_PRESTACAO_COMPROVANTE");

            migrationBuilder.DropTable(
                name: "BAIRROS");

            migrationBuilder.DropTable(
                name: "BASE CONTROLE DE DEMANDAS MG");

            migrationBuilder.DropTable(
                name: "BASE_DEPOSITO_DASH");

            migrationBuilder.DropTable(
                name: "BASE_FFCARGO");

            migrationBuilder.DropTable(
                name: "BASE_GSS");

            migrationBuilder.DropTable(
                name: "BASE_META_CN");

            migrationBuilder.DropTable(
                name: "BASE_NOMECLATURA_SAP_LLPP");

            migrationBuilder.DropTable(
                name: "BASE_PARCEIROS_PAP");

            migrationBuilder.DropTable(
                name: "BASE_PROJETO_LORENA");

            migrationBuilder.DropTable(
                name: "BASE_SIGITIM");

            migrationBuilder.DropTable(
                name: "BASE_SIGITIM_SUL");

            migrationBuilder.DropTable(
                name: "BASE_TERCEIROS_SAP_GT");

            migrationBuilder.DropTable(
                name: "BASE_VAT");

            migrationBuilder.DropTable(
                name: "BASE_VAT_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "BASE_VAT_BKP");

            migrationBuilder.DropTable(
                name: "BASE_ZMM34");

            migrationBuilder.DropTable(
                name: "BASE$");

            migrationBuilder.DropTable(
                name: "BOLETA");

            migrationBuilder.DropTable(
                name: "BOOK_PLANOS_7X");

            migrationBuilder.DropTable(
                name: "BOOK_PLANOS_8X");

            migrationBuilder.DropTable(
                name: "BOOKSAP_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "CADASTRO_DRN");

            migrationBuilder.DropTable(
                name: "CADASTRO_GERAL_COLABORADORES");

            migrationBuilder.DropTable(
                name: "CADASTRO_GERAL_COLABORADORES_PENDENTES");

            migrationBuilder.DropTable(
                name: "CADASTRO_GERENTE_TERRITORIO");

            migrationBuilder.DropTable(
                name: "CADASTRO_PDV");

            migrationBuilder.DropTable(
                name: "CADASTRO_SELL_IN");

            migrationBuilder.DropTable(
                name: "CADASTRO_SIMCARD");

            migrationBuilder.DropTable(
                name: "CADASTRO_UNICO");

            migrationBuilder.DropTable(
                name: "CADASTRO_UNICO_ACESSO");

            migrationBuilder.DropTable(
                name: "CADASTRO_UNICO_PEN");

            migrationBuilder.DropTable(
                name: "CADASTRO_UNICO_PENDENTES");

            migrationBuilder.DropTable(
                name: "CADASTROS_ROTA_GNV");

            migrationBuilder.DropTable(
                name: "CARGO_HEADCOUNT");

            migrationBuilder.DropTable(
                name: "CARTEIRA_ARMARIO");

            migrationBuilder.DropTable(
                name: "CARTEIRA_ARMARIO_PENDENTES");

            migrationBuilder.DropTable(
                name: "CARTEIRA_DEMAIS_CANAIS");

            migrationBuilder.DropTable(
                name: "CARTEIRA_DEMAIS_CANAIS_PENDENTES");

            migrationBuilder.DropTable(
                name: "carteira_demais_canais_rede_colaborador");

            migrationBuilder.DropTable(
                name: "CARTEIRA_GNV");

            migrationBuilder.DropTable(
                name: "CARTEIRA_GVT_FIXA");

            migrationBuilder.DropTable(
                name: "CARTEIRA_GVT_FIXA_2");

            migrationBuilder.DropTable(
                name: "Carteira_NE");

            migrationBuilder.DropTable(
                name: "CARTEIRA_NE_DESCREDENCIADOS");

            migrationBuilder.DropTable(
                name: "Carteira_NE_Pendente");

            migrationBuilder.DropTable(
                name: "Carteira_NE$");

            migrationBuilder.DropTable(
                name: "CARTEIRA_PDV");

            migrationBuilder.DropTable(
                name: "CARTEIRA_RELACAO_PDV_COLABORADOR");

            migrationBuilder.DropTable(
                name: "CARTEIRA_SUPERV_VENDAS");

            migrationBuilder.DropTable(
                name: "CARTEIRA_VALIDACAO_TERRITORIAL");

            migrationBuilder.DropTable(
                name: "CARTEIRA_VALIDACAO_TERRITORIAL _BKP");

            migrationBuilder.DropTable(
                name: "CASO_NAO");

            migrationBuilder.DropTable(
                name: "CHAMADO_HISTORICO_PRIORIDADE",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "CHAMADO_LLPP");

            migrationBuilder.DropTable(
                name: "CHAMADO_LLPP_OLD");

            migrationBuilder.DropTable(
                name: "CHECKLIST_DESCREDENCIAMENTO_VAREJO");

            migrationBuilder.DropTable(
                name: "CHECKLIST_FORMULARIO");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PDR");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PDR_EXTERNO_1");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PDR_EXTERNO_IMAGENS");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PDR_INTERNO");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PDR_INTERNO_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_CICLO_2_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_CICLO_3_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_CICLO_3_ARQUIVOS_REVENDA");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LLPP_2");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LLPP_AVALIADORA");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LLPP_COMPROBATORIA");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LLPP_EVIDENCIAS");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LLPP_INFORMATIVA");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LP");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LP_CICLO_3");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_REVENDA");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_REVENDA_CICLO_3");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PRE_PEX_LP");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PRE_PEX_REVENDA");

            migrationBuilder.DropTable(
                name: "CHECKLIST_ROTA");

            migrationBuilder.DropTable(
                name: "CIDADES");

            migrationBuilder.DropTable(
                name: "COBERTURA");

            migrationBuilder.DropTable(
                name: "COMISSIONAMENTO");

            migrationBuilder.DropTable(
                name: "CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA");

            migrationBuilder.DropTable(
                name: "CONTAS_A_PAGAR");

            migrationBuilder.DropTable(
                name: "CONTAS_A_PAGAR_BKP");

            migrationBuilder.DropTable(
                name: "CONTROLE DE DEMANDAS RELATORIO LINHA TESTE");

            migrationBuilder.DropTable(
                name: "CONTROLE_ACESSO_LIMITE_CREDITO");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_ARQUIVOS_RESPOSTA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPO_LISTA_ICCID");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPOS_FILA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_CHAMADO_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_EMAIL");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_OPERADORES");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO_BKP");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_ITENS_CAMPO_COMBOBOX_FILA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_SUGESTOES_NOMES_CAMPOS");

            migrationBuilder.DropTable(
                name: "CONTROLE_DEMANDAS_ARQUIVOS_RESPOSTA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DEMANDAS_CHAT");

            migrationBuilder.DropTable(
                name: "CONTROLE_DEMANDAS_EVIDENCIAS");

            migrationBuilder.DropTable(
                name: "CONTROLE_DEMANDAS_GRAFICO");

            migrationBuilder.DropTable(
                name: "CONTROLE_DEMANDAS_LOGIN");

            migrationBuilder.DropTable(
                name: "CONTROLE_DEMANDAS_TABELA_GRAFICO");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_ANALISTAS_HISTORICO");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_ARQUIVOS_RESPOSTA");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_CADASTRO");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_CHECKLIST");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_LINHA_TEMPO");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_OPERADORES");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_PROSPECT_RELACAO_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_RELACAO_ARQUIVOS_STATUS");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_RELACAO_STATUS");

            migrationBuilder.DropTable(
                name: "DADOS_PARA_CONTRATO_COMODATO");

            migrationBuilder.DropTable(
                name: "DADOS_PARA_CONTRATO_SOCIOS");

            migrationBuilder.DropTable(
                name: "DADOS_PESSOAIS_TERCEIROS");

            migrationBuilder.DropTable(
                name: "DASHBOARD_TERMINAIS_SIMULADOR");

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
                name: "DEMANDA_BD_OPERADORES");

            migrationBuilder.DropTable(
                name: "DEMANDA_CAMPOS_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_DESLIGAMENTOS",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_OBSERVACOES_ANALISTAS",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_RELACAO_TREINAMENTO_FINALIZADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_RESPONSAVEL_FILA");

            migrationBuilder.DropTable(
                name: "DEMANDA_STATUS_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_VALORES_CAMPOS_SUSPENSO");

            migrationBuilder.DropTable(
                name: "DEMANDAS_JSON");

            migrationBuilder.DropTable(
                name: "DEMANDAS_TELEGRAM");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_AMIGAVEL OLD");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_CADASTRO X");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS OLD");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS_BKP");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_COMPLETO_DADOS_TESTE");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_DADOS");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_DENUNCIA_IMOTIVADA_OLD");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_INATIVIDADE_OLD");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_VAREJO_CADASTRO");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_VAREJO_DADOS");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_VIGENCIA_CONTRATO_OLD");

            migrationBuilder.DropTable(
                name: "DESLIGAMENTOS");

            migrationBuilder.DropTable(
                name: "EMAIL_CONTROLE_DEMANDAS");

            migrationBuilder.DropTable(
                name: "ESTOQUE_VITRINE_VIRTUAL");

            migrationBuilder.DropTable(
                name: "EXTE");

            migrationBuilder.DropTable(
                name: "FAT_MANUAL_STATUS");

            migrationBuilder.DropTable(
                name: "FATURAMENTOSAP");

            migrationBuilder.DropTable(
                name: "FIXA_BASE_PRUMA");

            migrationBuilder.DropTable(
                name: "FIXA_VIEW_PAINEL_DE_ROTAS");

            migrationBuilder.DropTable(
                name: "FPD_FIXA_AGRUPADO");

            migrationBuilder.DropTable(
                name: "FPD_FIXA_ANALITICO");

            migrationBuilder.DropTable(
                name: "HC_NORDESTE");

            migrationBuilder.DropTable(
                name: "HEADCOUNT");

            migrationBuilder.DropTable(
                name: "HEADCOUNT_CN");

            migrationBuilder.DropTable(
                name: "HISTORICO_ACESSOS_MOBILE_PENDENTE");

            migrationBuilder.DropTable(
                name: "ITENS_NAO_VENDA");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_ANSWER_ALTERNATIVAS");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_ANSWER_AVALIACAO");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_AVALIACAO_RETORNO");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_CARGOS_CANAL");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_CARTEIRA_DIVISAO_RJES");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_HIERARQUIA");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_QUESTION");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_QUESTION_HISTORICO");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_RELACAO_HISTORICO");

            migrationBuilder.DropTable(
                name: "JORNADA_BD_TEMAS_SUB_TEMAS");

            migrationBuilder.DropTable(
                name: "JUSTIFICATIVA_HE");

            migrationBuilder.DropTable(
                name: "LIMITE_CREDITO");

            migrationBuilder.DropTable(
                name: "LIMITE_CREDITO_NOVO");

            migrationBuilder.DropTable(
                name: "LINHA_TESTE_HISTORICO");

            migrationBuilder.DropTable(
                name: "LINHA_TESTE_NRSIMC");

            migrationBuilder.DropTable(
                name: "LOG_ERROS");

            migrationBuilder.DropTable(
                name: "LOGRADOUROS");

            migrationBuilder.DropTable(
                name: "LOJA_CONTESTACAO_FATURA");

            migrationBuilder.DropTable(
                name: "LOJAS_GERACAO_CARGAS");

            migrationBuilder.DropTable(
                name: "LOJAS_GERACAO_CARGAS_BKP");

            migrationBuilder.DropTable(
                name: "MAILING_ENVIO_COMUNICADOS");

            migrationBuilder.DropTable(
                name: "MARGEM REVENDA PRE");

            migrationBuilder.DropTable(
                name: "MARKETSHARE");

            migrationBuilder.DropTable(
                name: "MATRIZ_ACESSO_CONCESSAO");

            migrationBuilder.DropTable(
                name: "MATRIZ_ACESSOS");

            migrationBuilder.DropTable(
                name: "MOTIVOS_PRODUTO_TRIAGEM_CLIENTE_BOLETA");

            migrationBuilder.DropTable(
                name: "MOVIMENTACAO");

            migrationBuilder.DropTable(
                name: "MOVIMENTACOES");

            migrationBuilder.DropTable(
                name: "MOVIMENTACOES_BKP");

            migrationBuilder.DropTable(
                name: "MUNICIPIOS_MINAS");

            migrationBuilder.DropTable(
                name: "OCORRENCIA_QUEDA_LINK");

            migrationBuilder.DropTable(
                name: "OCORRENCIAS_SISTEMICAS");

            migrationBuilder.DropTable(
                name: "OCORRENCIAS_SISTEMICAS_REDE");

            migrationBuilder.DropTable(
                name: "PALITAGEM_LLPP");

            migrationBuilder.DropTable(
                name: "PALITAGEM_LLPP 3");

            migrationBuilder.DropTable(
                name: "PERFIL_GERACAO_CARGAS");

            migrationBuilder.DropTable(
                name: "PERFIL_PLATAFORMAS_VIVO");

            migrationBuilder.DropTable(
                name: "PERFIL_USUARIO");

            migrationBuilder.DropTable(
                name: "PERFIL_USUARIO_PENDENTE");

            migrationBuilder.DropTable(
                name: "PERFIL_VIVO_TASK");

            migrationBuilder.DropTable(
                name: "Planilha1$");

            migrationBuilder.DropTable(
                name: "PRE_PEX_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "PRE_PEX_EXTERNO");

            migrationBuilder.DropTable(
                name: "PRE_PEX_INTERNO");

            migrationBuilder.DropTable(
                name: "PRESTACAO_COMPROVANTE");

            migrationBuilder.DropTable(
                name: "PRESTACAO_KM");

            migrationBuilder.DropTable(
                name: "PRODUTOS_CONCORRENCIA_CLIENTE_TRIAGEM_CLIENTE_BOLETA");

            migrationBuilder.DropTable(
                name: "PROSPECT_ARQUIVOS_RESPOSTA");

            migrationBuilder.DropTable(
                name: "QUEM_ENTROU");

            migrationBuilder.DropTable(
                name: "REANALISE_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "REANALISE_CADASTRO");

            migrationBuilder.DropTable(
                name: "REANALISE_CHECKLIST");

            migrationBuilder.DropTable(
                name: "RELACAO_EMAILS_VIVO_MAIS");

            migrationBuilder.DropTable(
                name: "RELATORIO_SIGTM");

            migrationBuilder.DropTable(
                name: "RELATORIO_SIGTM_SUL");

            migrationBuilder.DropTable(
                name: "REPOSITORIO_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "RESET_SENHA_SISTEMAS");

            migrationBuilder.DropTable(
                name: "ROTAS_GNV");

            migrationBuilder.DropTable(
                name: "SAGRE_REAL_COBERTURA_GPON");

            migrationBuilder.DropTable(
                name: "SAVING_2");

            migrationBuilder.DropTable(
                name: "SAVING_ARQUIVO_LAYOUT");

            migrationBuilder.DropTable(
                name: "SAVING_BKP");

            migrationBuilder.DropTable(
                name: "SAVING_EVIDENCIAS");

            migrationBuilder.DropTable(
                name: "SAVING_EVIDENCIAS_BKP");

            migrationBuilder.DropTable(
                name: "SOLICITACAO");

            migrationBuilder.DropTable(
                name: "SOLICITACAO_APARELHO_CHIP");

            migrationBuilder.DropTable(
                name: "TAB_PESSOAS_SUPORTE");

            migrationBuilder.DropTable(
                name: "TABELA DE PRECOS");

            migrationBuilder.DropTable(
                name: "TABELA_QUALIDADE_FPD_FIXA_STATUS");

            migrationBuilder.DropTable(
                name: "TABELA_QUALIDADE_FPD_MOVEL_STATUS");

            migrationBuilder.DropTable(
                name: "TABELA_VALORES_COMISSIONAMENTO");

            migrationBuilder.DropTable(
                name: "TABELAO");

            migrationBuilder.DropTable(
                name: "TABELAO_NOMES_FIXA");

            migrationBuilder.DropTable(
                name: "TABELAO_SERVICO_FIXA");

            migrationBuilder.DropTable(
                name: "TESTE_NEW");

            migrationBuilder.DropTable(
                name: "TRAJETOS_PRESTACAO_KM");

            migrationBuilder.DropTable(
                name: "VALIDACAO_HC");

            migrationBuilder.DropTable(
                name: "VALOR_SAVING");

            migrationBuilder.DropTable(
                name: "VENDA_BOLETA");

            migrationBuilder.DropTable(
                name: "VISAO_GERENCIAL_BOLETA");

            migrationBuilder.DropTable(
                name: "VISAO_LOJA_BOLETA");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA_EVIDENCIAS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_ESTRUTURAS_OPERACAO");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_INDICADORES");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_PESSOAS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_PROCESSOS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_EVIDENCIAS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_GERENTE_GERAL_ESTRUTURA_OPERACAO");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_GERENTE_GERAL_EVIDENCIAS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_GERENTE_GERAL_PESSOAS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_GERENTE_GERAL_PROCESSOS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_GERENTE_GERAL_RESULTADO");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_ABERTURA");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_ABERTURA_EVIDENCIAS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_CAIXA");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_ESTOQUE");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_ESTRUTURA_PROCESSOS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_PESSOAS");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_POSITIVACAO");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_PASSAGEM_LOJA_VAGAS");

            migrationBuilder.DropTable(
                name: "ACAO_CADASTRO");

            migrationBuilder.DropTable(
                name: "ALTA_SEM_TRAFEGO");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PDR_EXTERNO");

            migrationBuilder.DropTable(
                name: "CHECKLIST_PEX_LLPP");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DEMANDAS_CADASTRO");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_RESPOSTA");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_RELACAO_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "DEMANDA_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CHAMADO_RESPOSTA",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_CAMPOS_FILA");

            migrationBuilder.DropTable(
                name: "DESCREDENCIAMENTO_CADASTRO");

            migrationBuilder.DropTable(
                name: "QUALIDADE_BD_MANUAL_AUDIT");

            migrationBuilder.DropTable(
                name: "LINHA_TESTE");

            migrationBuilder.DropTable(
                name: "TRIAGEM_CLIENTE_BOLETA");

            migrationBuilder.DropTable(
                name: "PROSPECT_RESPOSTA");

            migrationBuilder.DropTable(
                name: "RESET_SENHA");

            migrationBuilder.DropTable(
                name: "SAVING_CADASTRO");

            migrationBuilder.DropTable(
                name: "SAVING_CADASTRO_BKP");

            migrationBuilder.DropTable(
                name: "TABELA_QUALIDADE_FPD_FIXA");

            migrationBuilder.DropTable(
                name: "TABELA_QUALIDADE_FPD_MOVEL");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_CANAL_TERRITORIO_ABERTURA");

            migrationBuilder.DropTable(
                name: "VIVO_VISITA_GERENTE_GERAL");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_CHAMADO");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO");

            migrationBuilder.DropTable(
                name: "DEMANDA_PARQUE",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_RELACAO_CHAMADO",
                schema: "Demandas");

            migrationBuilder.DropTable(
                name: "DEMANDA_SUB_FILA");

            migrationBuilder.DropTable(
                name: "ACESSO");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_CAMPOS_CHAMADO");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_FILA");

            migrationBuilder.DropTable(
                name: "CONTROLE_DE_DEMANDAS_STATUS_CHAMADO");

            migrationBuilder.DropTable(
                name: "CREDENCIAMENTO_PROSPECT");

            migrationBuilder.DropTable(
                name: "ACESSOS_MOBILE",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DEMANDA_TIPO_FILA");
        }
    }
}
