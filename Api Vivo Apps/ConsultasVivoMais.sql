/**-----------------------------------------------------------

INSERÇÃO DE USUÁRIO NO VIVO +

-----------------------------------------------------------**/
select * from ACESSO WHERE Login = '163661'
select * from ACESSO_PERMISSAO_MENU WHERE idAcesso = '4536'
	Insert into ACESSO VALUES('163661','GEANE SOUZA PANCHO DIAS','GEANE.DIAS@TELEFONICA.COM','NE',null,null,'ATIVO',0)
Insert into ACESSO_PERMISSAO_MENU VALUES ((SELECT IdAcesso from ACESSO WHERE Login = '163661'),  'GERENTE GERAL - LLPP','LOJA')

/*-----------------------------------------------------------

INSERÇÃO DE USUÁRIO NO VIVO +

-----------------------------------------------------------*/

--select * from ACESSOS_MOBILE where MATRICULA IN (
--select DISTINCT(MATRICULA_SOLICITANTE) from [Vivo_MAIS].Demandas.DEMANDA_RELACAO_CHAMADO )

--update DEMANDA_TIPO_FILA
--set DESCRICAO = 'Apenas um teste, Apenas um teste, Apenas um teste, Apenas um teste, Apenas um teste, Apenas um teste, Apenas um teste, Apenas um teste, Apenas um teste.'

select * from JORNADA_BD_CARGOS_CANAL

select * from DEMANDA_CAMPOS_FILA

--select A.CARGO,A.ID_PROVA ,A.ID_QUESTION,A.FIXA from  JORNADA_BD_QUESTION_HISTORICO A
--JOIN JORNADA_BD_QUESTION B on A.ID_QUESTION = B.ID_QUESTION
--where A.CADERNO = 36 
--and A.TP_FORMS = 'Jornada'
--and B.STATUS_QUESTION = 0

--delete JORNADA_BD_QUESTION_HISTORICO where ID_PROVA = 5785


select * from acesso where nome like '%Braian Araujo Ribeiro%'

--update acesso 
--set regional = 'MG'
--where nome like '%Braian Araujo Ribeiro%'

select * from CASO_NAO WHERE Login = '129294'

select * from CNS_BASE_TERCEIROS_SAP_GT
--insert into Caso_NAO values
--('PER0437-001','129294'),
--('ALR0437-002','129294'),
--('PER0437-003','129294')

--select * from carteira_demais_canais_rede_colaborador
--where rede like '%log%'



select * from DEMANDA_TIPO_FILA
select TOP 1 * from ACESSO where Login = '151191'
select top 100 * from ACESSO_PERMISSAO_MENU

 --DROP index IX_DEMANDA_OBSERVACOES_ANALISTAS_MAT_ANALISTA on Demandas.DEMANDA_OBSERVACOES_ANALISTAS;
delete Demandas.DEMANDA_OBSERVACOES_ANALISTAS


select top 1 * from CARTEIRA_NE A
where a.ANOMES = '202404'

select COUNT(*) from CARTEIRA_NE A
right join (select * from CARTEIRA_NE where anomes = '202406') B 
ON A.Cnpj = B.Cnpj
where a.ANOMES = '202404'

select COUNT(*) from CARTEIRA_NE A
left join (select * from CARTEIRA_NE where anomes = '202406') B 
ON A.Cnpj = B.Cnpj
where a.ANOMES = '202404'

select COUNT(*) from CARTEIRA_NE A
 join (select * from CARTEIRA_NE where anomes = '202406') B 
ON A.Cnpj = B.Cnpj
where a.ANOMES = '202404'



select * from CONTROLE_DE_DEMANDAS_CAMPOS_FILA where ID_FILA IN (573,574)

    --B.CAMPO,
    --B.VALOR
    --E.RESPOSTA

    select COUNT(*) from CONTROLE_DE_DEMANDAS_CHAMADO where ID_FILA_CHAMADO in (573,574)

    
    SELECT A.ID,
    F.FILA,
    C.STATUS,
    D.Nome,
    A.DATA_ABERTURA,
    E.DATA_RESPOSTA,
    /*
    Seleção de Campos baseado na tabela CONTROLE_DE_DEMANDAS_CAMPOS_FILA WHERE ID = fila que estamos filtrando
    */
    MAX(CASE WHEN B.CAMPO = 'ADABAS' THEN B.VALOR END) AS ADABAS,
    MAX(CASE WHEN B.CAMPO = 'CPF Do Cliente' THEN B.VALOR END) AS CPF_Do_Cliente,
    MAX(CASE WHEN B.CAMPO = 'Nome Do Cliente' THEN B.VALOR END) AS Nome_Do_Cliente,
    MAX(CASE WHEN B.CAMPO = 'Valor Contestado' THEN B.VALOR END) AS Valor_Contestado,
    MAX(CASE WHEN B.CAMPO = 'Valor Total' THEN B.VALOR END) AS Valor_Total,
    MAX(CASE WHEN B.CAMPO = 'Houve movimento de alta, migra e/ou troca na conta financeira contestada nos últimos 90 dias?' THEN B.VALOR END) AS Houve_Movimento,
    E.RESPOSTA AS Ultima_Resposta,
    MAX(CASE WHEN B.CAMPO = 'Problema' THEN B.VALOR END) AS Primeira_Resposta
FROM CONTROLE_DE_DEMANDAS_CHAMADO A

inner JOIN (SELECT * FROM CONTROLE_DE_DEMANDAS_RELACAO_CAMPOS_CHAMADO B WHERE B.CAMPO IN ('ADABAS'
, 'Nome Do Cliente','CPF Do Cliente','Houve movimento de alta, migra e/ou troca na conta financeira contestada nos últimos 90 dias?','Valor Contestado','Valor Total','Problema'
)) B ON A.ID_CAMPOS_CHAMADO = B.ID_CAMPOS_CHAMADO

LEFT JOIN (
    SELECT ID,ID_STATUS_CHAMADO,STATUS,ROW_NUMBER() OVER (PARTITION BY ID_STATUS_CHAMADO ORDER BY ID desc) AS rn
    FROM CONTROLE_DE_DEMANDAS_RELACAO_STATUS_CHAMADO
) C ON A.ID_STATUS_CHAMADO = C.ID_STATUS_CHAMADO AND C.rn = 1

LEFT JOIN ACESSO D ON A.MATRICULA_SOLICITANTE = D.Login

left JOIN (
    SELECT ID,RESPOSTA,ID_CHAMADO,DATA_RESPOSTA,ROW_NUMBER() OVER (PARTITION BY ID_CHAMADO ORDER BY ID desc) AS rn
    FROM CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTA
) E ON A.ID = E.ID_CHAMADO AND E.rn = 1

LEFT JOIN CONTROLE_DE_DEMANDAS_FILA F ON A.ID_FILA_CHAMADO = F.ID

WHERE A.ID_FILA_CHAMADO IN (573, 574)
GROUP BY A.ID, F.FILA, C.STATUS, D.Nome, A.DATA_ABERTURA, E.DATA_RESPOSTA,E.RESPOSTA;

--select TOP 10 * from CONTROLE_DE_DEMANDAS_

    SELECT ID,ID_CHAMADO,DATA_RESPOSTA,ROW_NUMBER() OVER (PARTITION BY ID_CHAMADO ORDER BY ID desc) AS rn
    FROM CONTROLE_DE_DEMANDAS_CHAMADO_RESPOSTA

--Status
--Solicitante
--Data Abertura
--Data Ult. Alteração 
--ADABAS
--Nome Da Loja
--Login
--delete ACESSOS_MOBILE_PENDENTE WHERE MATRICULA = 165088
--delete PERFIL_USUARIO_PENDENTE where ID_ACESSO_PENDENTE = 5221
--delete HISTORICO_ACESSOS_MOBILE_PENDENTE where ID_ACESSOS_PENDENTE = 5221

--select * from CONTROLE_DE_DEMANDAS_OPERADORES
--insert into  PERFIL_USUARIO
--values (165088,1,'2024-06-28 00:00:00.000', 151191 )

--insert into 
--CONTROLE_DE_DEMANDAS_OPERADORES
--values ('165088','João Matheus De Brito Almeida','Analista','NE') 

--select top 1 * fROM ACESSOS_MOBILE order by id desc

--insert into ACESSOS_MOBILE 
--values
--(
--'joao.malmeida@telefonica.com'
--,'165088'
--,'80039AE51A10925FDF69FD2BA996315B'
--,'NE'
--,4
--,1	
--,'NERECIFE01'
--,'000.000.000-00'
--,'João Matheus De Brito Almeida'
--,'PE'
--,1
--,1	
--,NULL	
--,'OK'
--,NULL	
--,151191	
--,'2024-06-28 12:40:55.163'
--,NULL	
--,81	
--,NULL
--)

--select * from CONTROLE_DE_DEMANDAS_FILA where fila like '%fixa%' and REGIONAL = 'MG'
--select * from Cardapio.PRODUTOS_CARDAPIO_FICHA_TECNICA
--select * from Cardapio.PRODUTOS_CARDAPIO_IMAGENS

--select * from Demandas.DEMANDA_RELACAO_TREINAMENTO_FINALIZADO	
--insert into CONTROLE_DE_DEMANDAS_FILA
--values
--('DELIBERAÇÃO COMERCIAL B2B',
--'Não',
--'151191',
--'Não',
--'FIXA - COMERCIAL/QUALIDADE',
--'MG',
--'Não')
/* Insert na carteira baseado nos dados da carteira anterior*/
insert into CARTEIRA_NE
select 
[Cnpj],
[RazaoSocial],
[NomeFantasia],
[Uf],
[GA / GG],
[RE_GA],
[GGP],
[RE_GGP],
[StatusCallidus],
[Vendedor],
[REDE],
[Canal],
[DDD_LOCALIDADE_PDV],
[Atividade],
[AREA ATUAÇÃO DDD],
[GV],
[RE_GV],
[LoginSiebel],
[Cidade],
[Bairro],
[Cep],
[Endereco],
[Numero],
[Complemento],
[Data Credenciamento],
[Data Descredenciamento],
[Modelo Loja],
[Tipo Loja],
[Local Loja],
[GSS],
[Qt de PA],
[Metragem],
[SEGMENTAÇÃO],
[Estrelagem],
[MT],
'202405',
[NO_VIVO360],
[NO_VIVONEXT],
[NO_GSS],
[DT_MOD_CAD],
[LOGIN_MOD_CAD],
[DataInicioContrato],
[DataFimContrato],
[InscriçãoEstadual],
[OptanteSimples],
[Contato],
[Telefone],
[EmailFinanceiro],
[EmailComercial],
[EmailDivulgação],
[CodigoBanco],
[Banco],
[Agencia],
[NumeroConta],
[DigitoVerificador],
[SetorAtividade],
[PontoVenda],
[Genero],
[CodigoCliente],
[CodigoFornecedor],
[Area],
Ixos
from CARTEIRA_NE

where ANOMES = '202404'
/* Insert na carteira baseado nos dados da carteira anterior*/


select * from JORNADA_BD_QUESTION WHERE ID_QUESTION = 9883

--update JORNADA_BD_QUESTION 
--set  STATUS_QUESTION = 0
--where REGIONAL = 'MG' AND STATUS_QUESTION = 1
--SELECT * FROM JORNADA_BD_ANSWER_ALTERNATIVAS where STATUS_ALTERNATIVA = 0
--update JORNADA_BD_ANSWER_ALTERNATIVAS  SET STATUS_ALTERNATIVA = 1

