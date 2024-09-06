/**----------------------------------------------------------

INSERÇÃO DE USUÁRIO NO VIVO +

-----------------------------------------------------------**/
--select ID,CARGO from JORNADA_BD_CARGOS_CANAL
--GROUP BY ID,CARGO
--select ID_CANAL, CANAL from JORNADA_BD_CARGOS_CANAL
--GROUP BY ID_CANAL,CANAL

--delete Demandas.DEMANDA_CHAMADO_RESPOSTA where ID_RELACAO in (select ID_RELACAO from Demandas.DEMANDA_RELACAO_CHAMADO where Sequence in  (99,100,102,103))
--delete Demandas.DEMANDA_RELACAO_CHAMADO where Sequence in  (99,100,102,103)

--delete DEMANDA_RESPONSAVEL_FILA WHERE MATRICULA_RESPONSAVEL NOT IN 
--(
--select DISTINCT(MATRICULA) from DEMANDA_BD_OPERADORES 
--)
--insert into DEMANDA_BD_OPERADORES 
select * from DEMANDA_SUB_FILA  where regional = 'MG' order by Nome_sub_fila asc
select * from JORNADA_BD_QUESTION_HISTORICO WHERE TP_FORMS = 'Jornada' and CADERNO = 42

select UserAvatar from ACESSOS_MOBILE WHERE MATRICULA = 151191
select * from ACESSO WHERE Login = '165372'
select TOP 1 Imagem from Cardapio.PRODUTOS_CARDAPIO_IMAGENS 

select * from CNS_BASE_TERCEIROS_SAP_GT

select * from Demandas.DEMANDA_RELACAO_CHAMADO where ID_RELACAO = 'bfedf1b8-b320-4ffa-4bb4-08dcc8f06bcb'
select * from Demandas.DEMANDA_CHAMADO where ID_RELACAO = 'bfedf1b8-b320-4ffa-4bb4-08dcc8f06bcb'

--SELECT * FROM CARTEIRA_NE WHERE ANOMES = '202407'
--AND Vendedor in 
--(
--'CED0623-022',  
--'CED0623-023', 
--'CED0623-024', 
--'CED0623-025', 
--'CED0623-027', 
--'CED0623-028', 
--'CED0623-030', 
--'CED0623-033', 
--'CED0623-034'
--)

--select NOME_SUB_FILA,NOME_TIPO_FILA from DEMANDA_SUB_FILA A 
--INNER JOIN DEMANDA_TIPO_FILA B ON A.ID_TIPO_FILA = B.ID_TIPO_FILA
--WHERE A.REGIONAL = 'MG'

select * from PERFIL_USUARIO WHERE MATRICULA = '43812'
--insert into PERFIL_USUARIO values
--(43812,10,'2023-10-06 00:00:00.000',151191),
--(43812,14,'2023-10-06 00:00:00.000',151191),
--(43812,16,'2023-10-06 00:00:00.000',151191)

select * from ACESSOS_mobile WHERE MATRICULA = '427700'

select * from carteira_ne where Vendedor = 'BAD0622-005'

select * from ACESSOS_MOBILE where EMAIL = 'kenya.costa@telefonica.com'
select COUNT(*) from ACESSOS_MOBILE WHERE REGIONAL = 'MG'
select * from ACESSOS_MOBILE WHERE REGIONAL = 'MG'

select * from CONTROLE_DE_DEMANDAS_OPERADORES
--insert into CONTROLE_DE_DEMANDAS_OPERADORES 
--values ('40418413','Pedro Henrique Amorim Da Silva','Analista','NE') 
--insert into DEMANDA_BD_OPERADORES
--values (40418413,'NE',1,'2024-01-02 18:55:47.580',151191) 
select * from DEMANDA_SUB_FILA WHERE ID_SUB_FILA = 386
select * from DEMANDA_CAMPOS_FILA WHERE ID_SUB_FILA = 386
select * from CONTROLE_DE_DEMANDAS_CAMPOS_FILA WHERE ID_FILA = 481
select * from CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA WHERE ID_FILA = 481

--delete JORNADA_BD_AVALIACAO_RETORNO where RE_AVALIADO = 22121 and CADERNO = 41
--delete JORNADA_BD_ANSWER_AVALIACAO where RE_AVALIADO = 22121  and CADERNO = 41


select * from PERFIL_PLATAFORMAS_VIVO
select * from JORNADA_BD_CARGOS_CANAL

--UPDATE PERFIL_PLATAFORMAS_VIVO 
--SET CARGO = '13;14;15'
--where ID_PERFIL = 20
/*
1	Vendedor PAP ; 2	Gerente Parceiros ; 3	Gerente Geral ; 4	Supervisor PAP ;
5	Vendedor de Revenda ; 6	Gerente de Revenda ; 7	Gerente de Área ; 8	Gerente de Operações ;
9	Consultor de Negócios ; 10	Consultor Tecnológico ; 11	Gerente Vendas B2C ;
12	Gerente Senior Territorial ; 13	Coordenador Suporte Vendas ; 14	Gerente Suporte Vendas ;
15	Diretora ; 16	Consultor Gestão Vendas ; 17	Analista Suporte Vendas Senior ;
18	Analista Suporte Vendas Pleno ; 19	Analista Suporte Vendas Junior ; 20	Estagiário ;
21	Gerente Senior Gestão Vendas ; 22	Analista de Suporte Comercial ; 
*/

select * from PERFIL_USUARIO

select * from PERFIL_USUARIO where MATRICULA = 16279
select * from ACESSOS_MOBILE WHERE NOME LIKE '%Luciana%'

--insert into PERFIL_USUARIO values 
--(16279, 10, '2023-10-06 00:00:00.000',151191)
--select * from PERFIL_PLATAFORMAS_VIVO

--update Demandas.DEMANDA_RELACAO_CHAMADO set REGIONAL = 'NE'
--update Demandas.DEMANDA_RELACAO_CHAMADO set REGIONAL = 'MG' where MATRICULA_SOLICITANTE = '155251'

--select * from DEMANDA_CAMPOS_FILA where CAMPO_SUSPENSO = true
--select * from CONTROLE_DE_DEMANDAS_FILA
--SELECT top 100 * FROM CONTROLE_DE_DEMANDAS_RELACAO_ITENS_CAMPO_COMBOBOX_FILA
--SELECT top 100 * FROM CONTROLE_DE_DEMANDAS_CAMPO_COMBOBOX_FILA
--SELECT top  100 * FROM CONTROLE_DE_DEMANDAS_CAMPOS_FILA


select * from Demandas.DEMANDA_RELACAO_CHAMADO where MATRICULA_SOLICITANTE = 155251
select * from Demandas.DEMANDA_CHAMADO where MATRICULA_SOLICITANTE = 155251
select * from DEMANDA_SUB_FILA where REGIONAL = 'MG'

--delete DEMANDA_TIPO_FILA where REGIONAL = 'MG'

--delete DEMANDA_SUB_FILA where REGIONAL = 'MG'

--delete DEMANDA_RESPONSAVEL_FILA where ID_SUB_FILA IN (select ID_SUB_FILA from DEMANDA_SUB_FILA where REGIONAL = 'MG')

select * from ACESSO where REGIONAL = 'MG' 
select TOP 1 * from ACESSOS_MOBILE
select * FROM [Vivo_MAIS].[Cardapio].[PRODUTOS_CARDAPIO]
select * FROM Cardapio.PRODUTOS_CARDAPIO_FICHA_TECNICA

select * from JORNADA_BD_QUESTION_HISTORICO WHERE caderno = 40 and TP_FORMS = 'Jornada'
select ANOMES from CARTEIRA_NE WHERE REDE like '%MY%' 
    
select * from Demandas.DEMANDA_CHAMADO where ID = 43
select * from Demandas.DEMANDA_RELACAO_CHAMADO where Sequence = 43
SELECT * FROM Demandas.DEMANDA_STATUS_CHAMADO where ID_RELACAO = '735220B7-CB05-4191-8BE2-08DC741E41DD'
SELECT * FROM Demandas.DEMANDA_CHAMADO_RESPOSTA where ID_RELACAO = '735220B7-CB05-4191-8BE2-08DC741E41DD'
select * from CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA where FILA like '%retenção%'

--insert into CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA
--select '143940',ID from CONTROLE_DE_DEMANDAS_FILA WHERE TIPO_CHAMADO = 'Prioriza Fixa'

--update ACESSO 
--set REGIONAL = 'NE'
--WHERE Email = 'marco.guerra@telefonica.com'

SELECT * from ACESSO WHERE Login = '143940'

--update ACESSO_TERCEIROS set IdAcesso = '4541'
--where Id in (
--20039,
--20040,
--20041,
--20047,
--20048
--)

SELECT * from ACESSO_TERCEIROS where IdAcesso = '0'

select * from ACESSO where Login = '160835'
select * from ACESSO_PERMISSAO_MENU WHERE idAcesso = 'o'
select * from ACESSO_PERMISSAO_MENU WHERE idAcesso = '1274'
--update ACESSO_PERMISSAO_MENU 
--SET DescricaoMenu = '', TipoAcesso = ''
--WHERE idAcesso = '3953'

Insert into ACESSO VALUES('160835','Kamilla Maria Castelo Branco Da Cruz','kamilla.cruz@telefonica.com','NE',null,null,'ATIVO',0)
Insert into ACESSO_PERMISSAO_MENU VALUES ((SELECT IdAcesso from ACESSO WHERE Login = '160835'),  'GERENTE GERAL - LLPP','LOJA')

--insert into CONTROLE_DE_DEMANDAS_RESPONSAVEL_FILA
--select '162551',ID from CONTROLE_DE_DEMANDAS_FILA WHERE REGIONAL = 'MG' and FILA <> '-' and FILA NOT LIKE '%FILA DESATIVADA%'

--insert into CONTROLE_DE_DEMANDAS_OPERADORES
--values ('143940','LENIZE MARIA DE OLIVEIRA','Analista','`NE')


select * from CARTEIRA_NE WHERE ANOMES =  (select MAX(ANOMES) from CARTEIRA_NE)
select * from CARTEIRA_NE WHERE RE_GA = '163864' 
OR RE_GGP = '163864' 
OR RE_GV = '163864' 

select * from CARTEIRA_NE WHERE ANOMES = '202408'
and (RE_GA = '163864' 
OR RE_GGP = '163864' 
OR RE_GV = '163864' )

SELECT * FROM CASO_NAO WHERE Login = '163864' 

select * from carteira_demais_canais_rede_colaborador 
where 
MATRICULA_1 = '163864' OR
MATRICULA_2 = '163864' OR
MATRICULA_3 = '163864' OR
MATRICULA_4 = '163864' OR
MATRICULA_5 = '163864' OR
MATRICULA_6 = '163864' OR
MATRICULA_7 = '163864' OR
MATRICULA_8 = '163864' OR
MATRICULA_9 = '163864' OR
MATRICULA_10 = '163864' OR
MATRICULA_11 = '163864' OR
MATRICULA_12 = '163864' OR
MATRICULA_13 = '163864' OR
MATRICULA_14 = '163864' OR
MATRICULA_15 = '163864' 





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
--insert into CARTEIRA_NE
--select 
--[Cnpj],
--[RazaoSocial],
--[NomeFantasia],
--[Uf],
--[GA / GG],
--[RE_GA],
--[GGP],
--[RE_GGP],
--[StatusCallidus],
--[Vendedor],
--[REDE],
--[Canal],
--[DDD_LOCALIDADE_PDV],
--[Atividade],
--[AREA ATUAÇÃO DDD],
--[GV],
--[RE_GV],
--[LoginSiebel],
--[Cidade],
--[Bairro],
--[Cep],
--[Endereco],
--[Numero],
--[Complemento],
--[Data Credenciamento],
--[Data Descredenciamento],
--[Modelo Loja],
--[Tipo Loja],
--[Local Loja],
--[GSS],
--[Qt de PA],
--[Metragem],
--[SEGMENTAÇÃO],
--[Estrelagem],
--[MT],
--'202408',
--[NO_VIVO360],
--[NO_VIVONEXT],
--[NO_GSS],
--[DT_MOD_CAD],
--[LOGIN_MOD_CAD],
--[DataInicioContrato],
--[DataFimContrato],
--[InscriçãoEstadual],
--[OptanteSimples],
--[Contato],
--[Telefone],
--[EmailFinanceiro],
--[EmailComercial],
--[EmailDivulgação],
--[CodigoBanco],
--[Banco],
--[Agencia],
--[NumeroConta],
--[DigitoVerificador],
--[SetorAtividade],
--[PontoVenda],
--[Genero],
--[CodigoCliente],
--[CodigoFornecedor],
--[Area],
--Ixos
--from CARTEIRA_NE
--WHERE ANOMES = '202407'

/* Insert na carteira baseado nos dados da carteira anterior*/


select * from JORNADA_BD_QUESTION WHERE ID_QUESTION = 9883

--update JORNADA_BD_QUESTION 
--set  STATUS_QUESTION = 0
--where REGIONAL = 'MG' AND STATUS_QUESTION = 1
--SELECT * FROM JORNADA_BD_ANSWER_ALTERNATIVAS where STATUS_ALTERNATIVA = 0
--update JORNADA_BD_ANSWER_ALTERNATIVAS  SET STATUS_ALTERNATIVA = 1

