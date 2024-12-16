select * from JORNADA_BD_HIERARQUIA
select * from acessos_mobile where matricula in (168024)

--UPDATE A
--set A.ID_PERFIL = 13
--from PERFIL_USUARIO A
--left join acessos_mobile B on A.MATRICULA = B.MATRICULA
--where B.REGIONAL = 'MG' AND A.ID_PERFIL = 23

--select * from DEMANDA_BD_OPERADORES where MATRICULA = 29381
select * from PERFIL_USUARIO WHERE MATRICULA = 168024
select * from PERFIL_PLATAFORMAS_VIVO

select * from ACESSOS_MOBILE WHERE MATRICULA IN  (165751,163355,156226)
select * from ACESSOS_MOBILE WHERE NOME_SOCIAL iS null

--alter table ACESSOS_MOBILE 
--add NOME_SOCIAL varchar(50) NOT NULL default '-'

--alter table ACESSOS_MOBILE_PENDENTE
--add NOME_SOCIAL varchar(50) NOT NULL default '-'

select String from ACESSOS_MOBILE

select * from ACESSO A
LEFT JOIN CONTROLE_DE_DEMANDAS_CHAMADO B ON A.Login = B.MATRICULA_SOLICITANTE

select * from JORNADA_BD_CARGOS_CANAL

select CAMPO,STATUS_CAMPOS_FILA STATUS from DEMANDA_CAMPOS_FILA WHERE ID_SUB_FILA = 408
 
select 
A.ID	,
A.EMAIL	,
A.MATRICULA	,
A.SENHA	,
A.REGIONAL	,
B.CARGO	,
B.CANAL	,
A.PDV	,
A.CPF	,
A.NOME	,
A.UF	,
A.STATUS	,
A.FIXA	,
A.TP_AFASTAMENTO	,
A.OBS	,
A.UserAvatar	,
A.LOGIN_MOD	,
A.DT_MOD	,
A.ELEGIVEL	,
A.DDD	,
A.TP_STATUS	,
A.TELEFONE
from ACESSOS_MOBILE A 
LEFT JOIN  JORNADA_BD_CARGOS_CANAL B ON A.CARGO = B.ID
WHERE REGIONAL = 'MG'


--select * from Demandas.DEMANDA_RELACAO_CHAMADO where Sequence = 200

--select * from Demandas.DEMANDA_CHAMADO where ID = 343

--select * from Demandas.DEMANDA_CAMPOS_CHAMADO WHERE ID_CHAMADO = 343
--INSERT INTO Demandas.DEMANDA_CAMPOS_CHAMADO 
--VALUES(343,'UF','PE')

--delete Demandas.DEMANDA_CAMPOS_CHAMADO
--WHERE ID_CHAMADO = 343
--and CAMPO IN ('Uf','ADABÁS DA LOJA')

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

--delete ACESSOS_MOBILE WHERE MATRICULA = 3213213
--delete ACESSOS_MOBILE_PENDENTE WHERE MATRICULA = 3213213

--UPDATE ACESSOS_MOBILE SET TELEFONE = '(99) 99999-9999'

--delete Demandas.DEMANDA_CHAMADO_RESPOSTA WHERE ID_RELACAO IN ( select ID_RELACAO from Demandas.DEMANDA_RELACAO_CHAMADO where DATA_ABERTURA < '2024-10-01') 
--delete Demandas.CHAMADO_HISTORICO_PRIORIDADE WHERE ID_RELACAO IN ( select ID_RELACAO from Demandas.DEMANDA_RELACAO_CHAMADO where DATA_ABERTURA < '2024-10-01') 
--delete Demandas.DEMANDA_RELACAO_CHAMADO where DATA_ABERTURA < '2024-10-01'

--ALTER TABLE [Fórum].[FORUM_AVALIACAO_PUBLICACAO] ADD CONSTRAINT [FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO] 
--FOREIGN KEY ([ID_PUBLICACAO]) REFERENCES [Fórum].[FORUM_PUBLICACAO] ([ID_SOLICITACAO_PUBLICACAO]);

----drop index [AK_FORUM_PUBLICACAO_ID_SOLICITACAO_PUBLICACAO] on 

--DROP INDEX AK_FORUM_PUBLICACAO_ID_SOLICITACAO_PUBLICACAO ON Fórum.FORUM_PUBLICACAO;

--ALTER TABLE Fórum.FORUM_PUBLICACAO
--DROP CONSTRAINT FK_FORUM_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_SOLICITACAO_PUBLICACAO;

--ALTER TABLE [Fórum].[FORUM_PUBLICACAO]
--DROP CONSTRAINT [AK_FORUM_PUBLICACAO_ID_SOLICITACAO_PUBLICACAO];

--ALTER TABLE [Fórum].[FORUM_AVALIACAO_PUBLICACAO] DROP CONSTRAINT [FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO] 




--SELECT 
--*
--FROM 
--    sys.objects AS c
--JOIN 
--    sys.tables AS t ON c.parent_object_id = t.object_id
--WHERE 
--t.schema_id = SCHEMA_ID('Fórum');

    
    --delete ACESSOS_MOBILE_PENDENTE WHERE MATRICULA = 163794
    --insert into Demandas.DEMANDA_ACESSO_RESPONSAVEL_UF
    --values
    ----Omar
    --(159706,'BA'),
    --(159706,'SE'),
    --(159706,'AL'),
    --(40418413,'BA'),
    --(40418413,'SE'),
    --(40418413,'AL'),
    ----Julia
    --(163794,'PB'),
    --(163794,'PI'),
    --(163794,'PE'),
    --(163794,'RN'),
    --(163794,'SE')

    select * from DEMANDA_SUB_FILA WHERE ID_TIPO_FILA = 1 AND STATUS_SUB_FILA =1
    AND NOME_SUB_FILA like '%PE/PB/RN/CE/PI - %'

        select * from DEMANDA_RESPONSAVEL_FILA WHERE ID_SUB_FILA IN 
        (    select ID_SUB_FILA from DEMANDA_SUB_FILA WHERE ID_TIPO_FILA = 1 AND STATUS_SUB_FILA =1
    AND NOME_SUB_FILA like '%PE/PB/RN/CE/PI - %')

    
        select * from DEMANDA_CAMPOS_FILA WHERE ID_SUB_FILA IN 
        (    select ID_SUB_FILA from DEMANDA_SUB_FILA WHERE ID_TIPO_FILA = 1 AND STATUS_SUB_FILA =1
    AND NOME_SUB_FILA like '%PE/PB/RN/CE/PI - %')

    delete DEMANDA_SUB_FILA
    WHERE ID_TIPO_FILA = 1 
    AND STATUS_SUB_FILA = 1 
    AND NOME_SUB_FILA like '%PE/PB/RN/CE/PI - %'

    --update DEMANDA_SUB_FILA SET NOME_SUB_FILA = 'BA/SE/AL - ' + NOME_SUB_FILA
    --WHERE ID_TIPO_FILA = 1 AND STATUS_SUB_FILA =1

    --update DEMANDA_SUB_FILA SET NOME_SUB_FILA = REPLACE(NOME_SUB_FILA, 'BA/SE/AL', '')
    --WHERE ID_TIPO_FILA = 1 AND STATUS_SUB_FILA =1

    select * from Demandas.DEMANDA_RELACAo_CHAMADO where ID_RELACAO = 'f72765bd-c30f-42c5-3595-08dd07e5ba31'
        select * from Demandas.DEMANDA_STATUS_CHAMADO where ID_RELACAO = 'f72765bd-c30f-42c5-3595-08dd07e5ba31'

            update Demandas.DEMANDA_RELACAo_CHAMADO SET DATA_ULTIMA_INTERACAO = '2024-11-10 16:27:11.5950937' where ID_RELACAO = 'f72765bd-c30f-42c5-3595-08dd07e5ba31'
        update Demandas.DEMANDA_STATUS_CHAMADO SET DATA = '2024-11-10 16:27:10.493' where id = 956
        --select * from Demandas.DEMANDA_CHAMADO wheRE ID = 203
        --DELETE Demandas.DEMANDA_STATUS_CHAMADO where ID = '660'

        select A.MATRICULA_SOLICITANTE,C.NOME,CASE WHEN B.CAMPO = 'DDD' THEN B.VALOR END AS DDD , COUNT(*) AS 'COUNT BY USUÁRIO' from Demandas.DEMANDA_CHAMADO A    LEFT JOIN Demandas.DEMANDA_CAMPOS_CHAMADO B    ON A.ID = B.ID_CHAMADO    LEFT JOIN ACESSOS_MOBILE C    ON A.MATRICULA_SOLICITANTE = C.MATRICULA    where B.CAMPO LIKE '%DDD%' AND A.MATRICULA_SOLICITANTE <> 151191    GROUP BY A.MATRICULA_SOLICITANTE,C.NOME, B.CAMPO,B.VALOR    ORDER BY DDD desc , C.NOME Desc


--EXEC sp_fkeys @pktable_name = 'FORUM_RESPOSTA_PUBLICACAO', @pktable_owner = 'Fórum'

--SELECT  obj.name AS FK_NAME,
--    sch.name AS [schema_name],
--    tab1.name AS [table],
--    col1.name AS [column],
--    tab2.name AS [referenced_table],
--    col2.name AS [referenced_column]
--FROM sys.foreign_key_columns fkc
--INNER JOIN sys.objects obj
--    ON obj.object_id = fkc.constraint_object_id
--INNER JOIN sys.tables tab1
--    ON tab1.object_id = fkc.parent_object_id
--INNER JOIN sys.schemas sch
--    ON tab1.schema_id = sch.schema_id
--INNER JOIN sys.columns col1
--    ON col1.column_id = parent_column_id AND col1.object_id = tab1.object_id
--INNER JOIN sys.tables tab2
--    ON tab2.object_id = fkc.referenced_object_id
--INNER JOIN sys.columns col2
--    ON col2.column_id = referenced_column_id AND col2.object_id = tab2.object_id
--    order by schema_name
    
    


ALTER TABLE [Fórum].[FORUM_AVALIACAO_PUBLICACAO] ADD CONSTRAINT [FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO] FOREIGN KEY ([ID_PUBLICACAO]) REFERENCES [Fórum].[FORUM_PUBLICACAO] ([ID_PUBLICACAO]);

alter table Fórum.FORUM_PUBLICACAO DROP CONSTRAINT [FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO]
alter table Fórum.FORUM_RESPOSTA_PUBLICACAO DROP CONSTRAINT [FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_AVALIACAO]


select * from DEMANDA_BD_OPERADORES WHERE REGIONAL = 'NE'
select MATRICULA_RESPONSAVEL,COUNT(MATRICULA_RESPONSAVEL) AS COOUNT from Fórum.FORUM_RESPONSAVEL_TEMA
where MATRICULA_RESPONSAVEL IN (71114,
156114)
GROUP BY MATRICULA_RESPONSAVEL
ORDER BY COOUNT DESC

select * from Fórum.FORUM_RESPONSAVEL_TEMA
--insert into Fórum.FORUM_RESPONSAVEL_TEMA
--values (NEWID(),25183,7,'2024-10-15 10:29:52.7162834')



SELECT * FROM Fórum.FORUM_PUBLICACAO_SOLICITACAO
SELECT * FROM Fórum.FORUM_PUBLICACAO
SELECT * FROM Fórum.FORUM_AVALIACAO_PUBLICACAO
SELECT * FROM Fórum.FORUM_RESPONSAVEL_TEMA where SUB_TEMA = 121

select * from PERFIL_PLATAFORMAS_VIVO

--insert into PERFIL_USUARIO
--Values(151191,1,'2024-10-22 00:00:00.000',151191 )
--WHEre MATRICULA <> 73559

select * from ACESSOS_MOBILE WHERE MATRICULA = 60742
select * from JORNADA_BD_TEMAS_SUB_TEMAS where ID_SUB_TEMAS in 
(
108,
3,
91
)

select * from JORNADA_BD_QUESTION_HISTORICO WHERE ID_PROVA in
(
6724,
6791,
6584
)



select * from Cardapio.PRODUTOS_CARDAPIO_AVALIACAO
select * from Cardapio.PRODUTOS_CARDAPIO

select * from JORNADA_BD_HIERARQUIA

SELECT * FROM PERFIL_USUARIO where MATRICULA = 427700

select * from PERFIL_PLATAFORMAS_VIVO

--insert into PERFIL_PLATAFORMAS_VIVO
--values (
--'VIVOX_FORUM_GIROV_USER','Tem acesso as publicações do Fórum Giro V',null
--)

--insert into PERFIL_PLATAFORMAS_VIVO
--values (
--'VIVOX_FORUM_GIROV_ADM','Resposável por analisar/responder e enviar novas publicações dentro do Fórum Giro V',null
--)

--insert into PERFIL_USUARIO
--(151191,1,'2024-09-16 16:33:57.640',151191),
--(151191,2,'2024-09-16 16:33:57.640',151191),
--(151191,4,'2024-09-16 16:33:57.640',151191),
--(151191,5,'2024-09-16 16:33:57.640',151191),
--(151191,7,'2024-09-16 16:33:57.640',151191),
--(151191,8,'2024-09-16 16:33:57.640',151191)





select * from Cardapio.PRODUTOS_CARDAPIO

select * from ACESSOS_MOBILE_PENDENTE where ID = 6089

select DISTINCT(MATRICULA_RESPONSAVEL), NOME from Demandas.DEMANDA_RELACAO_CHAMADO  
LEFT JOIN ACESSOS_MOBILE ON MATRICULA = MATRICULA_RESPONSAVEL

select *  from ACESSOS_MOBILE WHERE MATRICULA = 79902790

select * from PERFIL_USUARIO WHERE ID_ACESSO_PENDENTE = 6015
--INSERT INTO PERFIL_USUARIO 
--VALUES
--(166018,2,'2023-10-06 00:00:00.000',151191),
--(166018,4,'2023-10-06 00:00:00.000',151191),
--(166018,5,'2023-10-06 00:00:00.000',151191),
--(166018,7,'2023-10-06 00:00:00.000',151191),
--(166018,8,'2023-10-06 00:00:00.000',151191),
--(166018,13,'2023-10-06 00:00:00.000',151191)


select * from ACESSOS_MOBILE_PENDENTE WHERE MATRICULA = 80968611
select * from ACESSOS_MOBILE WHERE MATRICULA = 80545213

--update PERFIL_PLATAFORMAS_VIVO
--set CARGO  = NULL
--where id_perfil = 3 

--update ACESSOS_MOBILE 
--set Useravatar = null
--WHERE 
--MATRICULA = 80960568 

SELECT DISTINCT ID_QUESTION FROM JORNADA_BD_QUESTION_HISTORICO WHERE ID_PROVA = 6016
and ID_QUESTION IN 
(SELECT * FROM JORNADA_BD_AVALIACAO_RETORNO 
where 
RE_AVALIADO = 30722
and CADERNO = 45 
AND TP_FORMS LIKE '%Jornada%' AND STATUS_RESPOSTA = 1)


SELECT * FROM JORNADA_BD_AVALIACAO_RETORNO 
where 
RE_AVALIADO = 30722
and CADERNO = 45 
AND TP_FORMS LIKE '%Jornada%'
--and ID_QUESTION  IN (SELECT ID_QUESTION FROM JORNADA_BD_QUESTION_HISTORICO WHERE ID_PROVA = 6016)

SELECT * FROM JORNADA_BD_ANSWER_AVALIACAO 
where 
RE_AVALIADO = 30722
and CADERNO = 45  
AND TP_FORMS LIKE '%Jornada%'

--update ACESSOS_MOBILE set status = 1 
--WHERE MATRICULA = 151191   
--update ACESSOS_MOBILE_PENDENTE set TELEFONE = '(99) 99999-9999'

select * from JORNADA_BD_HIERARQUIA WHERE RE_DIVISAO = 46142

select * from JORNADA_BD_CARGOS_CANAL
--insert into JORNADA_BD_CARGOS_CANAL values (24,'Gerente de Área - PAP',5,'Canal Vendas')



--SELECT * FROM JORNADA_BD_QUESTION WHERE ID_QUESTION = 7970

--update JORNADA_BD_QUESTION 
--SET CANAL = 6
--WHERE ID_QUESTION IN (
--SELECT ID_QUESTION FROM JORNADA_BD_QUESTION_HISTORICO WHERE ID_PROVA = 5926)

select * from DEMANDA_SUB_FILA  where regional = 'MG' order by Nome_sub_fila asc
select * from JORNADA_BD_QUESTION_HISTORICO WHERE TP_FORMS = 'Jornada' and CADERNO = 42

select * from DEMANDA_CAMPOS_FILA where ID_CAMPOS IS NULL OR ID_CAMPOS = NULL 

select * from Cardapio.PRODUTOS_CARDAPIO
select * from JORNADA_BD_QUESTION
--insert into JORNADA_BD_CARGOS_CANAL
--values(23,'Representante de Vendas',6,'Distribuição')

--update ACESSO_PERMISSAO_MENU
--set DescricaoMenu = 'GERENTE GERAL - LLPP'
--where IdAcesso =
--(select IdAcesso from ACESSO where Login = '66359')



select * from Cardapio.PRODUTOS_CARDAPIO 

--delete ACESSOS_MOBILE_PENDENTE where ID IN(
--select TOP 4 ID from ACESSOS_MOBILE_PENDENTE ORDER BY ID desc
--)
select * from ACESSOS_MOBILE 
--WHERE EMAIL = '1@1.com.br'
ORDER BY ID desc

select top 1 * from CNS_CONTROLE_DEMANDAS_NE

select * from JORNADA_BD_QUESTION_HISTORICO WHERE ID_CRIADOR = 3511507 and TP_FORMS = 'Jornada Gestor'
AND DT_CRIACAO > '2024-09-26 00:00:00'

select * from JORNADA_BD_ANSWER_AVALIACAO WHERE RE_AVALIADO = 3511507  
select * from JORNADA_BD_AVALIACAO_RETORNO WHERE RE_AVALIADO = 3511507 

--select top 10 * from  JORNADA_BD_QUESTION_HISTORICO 
--WHERE ID_CRIADOR  = 3511507  and TP_FORMS = 'Jornada' and caderno = 45

--delete PERFIL_USUARIO 
--where MATRICULA = 3511507
--AND ID_PERFIL = 10
--(,10,GETDATE(),151191)

--UPDATE ACESSOS_MOBILE SET 
--UserAvatar = null
--WHERE MATRICULA  IN (
--11507
--)

--UPDATE ACESSOS_MOBILE
--SET EMAIL = 'SUELEN.ARAUJO@TELEFONICA.COM',
--NOME = 'SUELEN ARAUJO'
--WHERE MATRICULA  = 158125


--insert into PERFIL_USUARIO

--select 165088 as MATRICULA,id_Perfil,DT_MOD,151191 as MATRICULA_MOD from PERFIL_USUARIO WHERE MATRICULA = 151191   

--update ACESSOS_MOBILE 
--set UserAvatar = null
--WHERE MATRICULA  = 80928156



select 
--SOLICITANTE,COUNT(MATRICULA_SOLICITANTE)
DISTINCT(ID), MATRICULA_SOLICITANTE,ADABAS, SOLICITANTE, COUNT(*) as QTD
--AS QTD
from CNS_CONTROLE_DEMANDAS_NE
where 
ADABAS IN 
(SELECT DISTINCT Vendedor FROM Carteira_NE AS A
WHERE ANOMES = (SELECT MAX(ANOMES) FROM CARTEIRA_NE)
AND A.DDD_LOCALIDADE_PDV IN ( '85','81','71'))
--AND ID = '138748'
GROUP BY MATRICULA_SOLICITANTE, ID,ADABAS, SOLICITANTE
ORDER BY QTD DESC

select * from Cardapio.PRODUTOS_CARDAPIO_FICHA_TECNICA
select * from Cardapio.PRODUTOS_CARDAPIO_IMAGENS
select * from Cardapio.PRODUTOS_CARDAPIO_AVALIACAO

select * from Cardapio.CARDAPIO_ARGUMENTACAO_OURO
select * from Cardapio.CARDAPIO_AVALIACAO_ARGUMENTACAO
select * from Cardapio.PRODUTOS_CARDAPIO_AVALIACAO



--delete CONTROLE_DE_DEMANDAS_OPERADORES where LOGIN = '89082'

--ALTER TABLE ACESSOS_MOBILE_PENDENTE
--ADD TELEFONE varchar(15) NULL Default N'(00) 00000-0000';

--ALTER TABLE ACESSOS_MOBILE_PENDENTE
--DROP CONSTRAINT DF__ACESSOS_M__TELEF__7EA4354F

--ALTER TABLE ACESSOS_MOBILE
--DROP column TELEFONE 
--ALTER TABLE ACESSOS_MOBILE_PENDENTE
--DROP column TELEFONE 

select SLA * 24 from DEMANDA_SUB_FILA
--UPDATE DEMANDA_SUB_FILA SET SLA = SLA * 24

select * from ACESSOS_MOBILE_PENDENTE WHERE MATRICULA = 151191

select * from ACESSO WHERE Login = '118549'

select * from ACESSOS_MOBILE  WHERE MATRICULA = 165088

--insert into PERFIL_USUARIO 

--select 165088,id_perfil, DT_MOD,LOGIN_MOD from PERFIL_USUARIO WHERE MATRICULA = 151191

select * from CASO_NAO

--insert into CASO_NAO
--select B.Vendedor,'118549' from carteira_demais_canais_rede_colaborador A
--LEFT JOIN ( SELECT * FROM CARTEIRA_NE WHERE ANOMES = (SELECT MAX(ANOMES) FROM CARTEIRA_NE)) B
--ON A.REDE = b.REDE 
--where b.Vendedor IS NOT NULL


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

--SELECT * FROM CARTEIRA_NE
--WHERE [GA / GG]

insert into PERFIL_USUARIO
select LOGIN, 13 ,'2023-10-06 00:00:00.000',151191 from ACESSO WHEre Login  IN (
'67746',
'32431',
'62197',
'36318',
'33431',
'163355',
'109296',
'35929',
'25208',
'25222',
'65821',
'133819',
'75387',
'147312',
'45371',
'148232',
'165802',
'87379',
'153078',
'162063',
'156165',
'99659',
'94755',
'93487',
'61662',
'165134',
'161173',
'160751',
'46800',
'131489',
'63808',
'148378',
'130303',
'23930',
'62609',
'160166',
'78035',
'96663',
'90013',
'160181',
'156226',
'151981',
'46198',
'85972',
'160835',
'49888',
'126028',
'166120',
'145542',
'160841',
'31179',
'145544',
'94163',
'49540',
'148516',
'98054',
'109326',
'86599',
'120706',
'165751',
'160449',
'60802',
'35028',
'29919'
)


select * from PERFIL_USUARIO WHERE MATRICULA = 25183
--delete PERFIL_USUARIO WHERE MATRICULA = 70365 and Id_Perfil = 18
--insert into PERFIL_USUARIO values
--(70365,19,'2023-10-06 00:00:00.000',151191),
--(43812,14,'2023-10-06 00:00:00.000',151191),
--(43812,16,'2023-10-06 00:00:00.000',151191)

SELECT * FROM JORNADA_BD_HIERARQUIA WHERE adabas = 'PBLP035-001'

select * from ACESSOS_MOBILE_PENDENTE WHERE MATRICULA = 159209

select * from ACESSOS_mobile WHERE MATRICULA = 70365

select * FROM jornada_bd_question_historico where id_prova = 5933

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
select * from PERFIL_USUARIO
--insert into PERFIL_USUARIO
--select MATRICULA,13,'2024-12-09 00:00:00.000',151191 from ACESSOS_MOBILE WHERE CARGO IN (3,7,8,2)

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

select * from ACESSO where Login = '81753'
select * from ACESSO_PERMISSAO_MENU WHERE idAcesso = 'o'
select * from ACESSO_PERMISSAO_MENU WHERE idAcesso = '1274'
--update ACESSO_PERMISSAO_MENU 
--SET DescricaoMenu = '', TipoAcesso = ''
--WHERE idAcesso = '3953'
select * from ACESSO where login = '43301'
select * from ACESSO_PERMISSAO_MENU where idAcesso in (SELECT IdAcesso from ACESSO WHERE Login = '43301')
--update ACESSO_PERMISSAO_MENU set DescricaoMenu = 'GERENTE GERAL - LLPP' where idAcesso in (SELECT IdAcesso from ACESSO WHERE Login = '43301')


Insert into ACESSO VALUES('81753','LUCAS DA SILVA MUNIZ DOS SANTOS','LUCAS.SSANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',0)
Insert into ACESSO_PERMISSAO_MENU VALUES ((SELECT IdAcesso from ACESSO WHERE Login = '81753'),  'GERENTE GERAL - LLPP','LOJA')

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

    select * from Demandas.DEMANDA_CHAMADO

    select A.MATRICULA_SOLICITANTE,C.NOME,CASE WHEN B.CAMPO = 'DDD' THEN B.VALOR END AS DDD , COUNT(*) AS 'COUNT BY USUÁRIO' from Demandas.DEMANDA_CHAMADO A
    LEFT JOIN Demandas.DEMANDA_CAMPOS_CHAMADO B
    ON A.ID = B.ID_CHAMADO
    LEFT JOIN ACESSOS_MOBILE C
    ON A.MATRICULA_SOLICITANTE = C.MATRICULA
    where B.CAMPO LIKE '%DDD%' AND A.MATRICULA_SOLICITANTE <> 151191 AND A.REGIONAL = 'NE'
    GROUP BY A.MATRICULA_SOLICITANTE,C.NOME, B.CAMPO,B.VALOR
    ORDER BY DDD desc , C.NOME Desc 

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

insert into ACESSOS_MOBILE 
values
(
'joao.malmeida@telefonica.com'
,'166933'
,'80039AE51A10925FDF69FD2BA996315B'
,'NE'
,4
,1	
,'NERECIFE01'
,'000.000.000-00'
,'João Matheus De Brito Almeida'
,'PE'
,1
,1	
,NULL	
,'OK'
,NULL	
,151191	
,'2024-06-28 12:40:55.163'
,NULL	
,81	
,NULL
)

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

select distinct LastStatus from Demandas.DEMANDA_RELACAO_CHAMADO 
select distinct Status from Demandas.DEMANDA_STATUS_CHAMADO 
select * from DEMANDA_SUB_FILA where NOME_SUB_FILA like '%Fibrasil%'
select * from DEMANDA_TIPO_FILA where ID_TIPO_FILA = 18

--DATA_FINALIZACAO
--DATA_ULTIMA_INTERACAO


--SELECT *
--FROM Demandas.DEMANDA_RELACAO_CHAMADO A
--WHERE LastStatus IN ('CANCELADO','CONCLUIDO', 'DEMANDA INDEVIDA', 'REPROVADO')

--SELECT A.DATA_FINALIZACAO,B.STATUS ,B.DATA
--FROM Demandas.DEMANDA_RELACAO_CHAMADO A
--LEFT JOIN (
--    SELECT B.ID_RELACAO, B.DATA, STATUS,
--           ROW_NUMBER() OVER (PARTITION BY B.ID_RELACAO ORDER BY B.DATA DESC) AS rn
--    FROM Demandas.DEMANDA_STATUS_CHAMADO B
--    WHERE STATUS IN ('CANCELADO','CONCLUIDO', 'DEMANDA INDEVIDA', 'REPROVADO')
--) B ON A.ID_RELACAO = B.ID_RELACAO AND B.rn = 1
--WHERE LastStatus IN ('CANCELADO','CONCLUIDO', 'DEMANDA INDEVIDA', 'REPROVADO')

--update A
--set A.DATA_FINALIZACAO = B.DATA
--FROM Demandas.DEMANDA_RELACAO_CHAMADO A
--LEFT JOIN (
--    SELECT B.ID_RELACAO, B.DATA, STATUS,
--           ROW_NUMBER() OVER (PARTITION BY B.ID_RELACAO ORDER BY B.DATA DESC) AS rn
--    FROM Demandas.DEMANDA_STATUS_CHAMADO B
--    WHERE STATUS IN ('CANCELADO','CONCLUIDO', 'DEMANDA INDEVIDA', 'REPROVADO')
--) B ON A.ID_RELACAO = B.ID_RELACAO AND B.rn = 1
--WHERE LastStatus IN ('CANCELADO','CONCLUIDO', 'DEMANDA INDEVIDA', 'REPROVADO')

--update A
--set A.DATA_ULTIMA_INTERACAO = B.DATA
--FROM Demandas.DEMANDA_RELACAO_CHAMADO as A
--LEFT JOIN (
--    SELECT B.ID_RELACAO, B.DATA, STATUS,
--           ROW_NUMBER() OVER (PARTITION BY B.ID_RELACAO ORDER BY B.DATA DESC) AS rn
--    FROM Demandas.DEMANDA_STATUS_CHAMADO B
--) B ON A.ID_RELACAO = B.ID_RELACAO AND B.rn = 1



--update Demandas.DEMANDA_RELACAO_CHAMADO set LastStatus = 'CONCLUIDO' where LastStatus = 'CANCELADO'
--update Demandas.DEMANDA_STATUS_CHAMADO set Status = 'CONCLUIDO' where Status = 'CANCELADO'
--update JORNADA_BD_QUESTION 
--set  STATUS_QUESTION = 0
--where REGIONAL = 'MG' AND STATUS_QUESTION = 1
--SELECT * FROM JORNADA_BD_ANSWER_ALTERNATIVAS where STATUS_ALTERNATIVA = 0
--update JORNADA_BD_ANSWER_ALTERNATIVAS  SET STATUS_ALTERNATIVA = 1

--delete DEMANDA_RESPONSAVEL_FILA WHERE ID_sub_FILA IN (select * FROM DEMANDA_SUB_FILA WHERE ID_TIPO_FILA = 33)
--delete demanda_tipo_fila WHERE ID_TIPO_FILA = 33

select * from ACESSOS_MOBILE WHERE UserAvatar = null


select * from DEMANDA_TIPO_FILA 

--update DEMANDA_TIPO_FILA 
--set DESCRICAO = 'Demandas referentes ao time de Acessos da regional Nordeste'
--where ID_TIPO_FILA = 1

--update DEMANDA_TIPO_FILA 
--set DESCRICAO = 'Demandas referentes ao time de Suporte de Processos da regional Nordeste'
--where ID_TIPO_FILA = 18

--update DEMANDA_TIPO_FILA 
--set DESCRICAO = 'Demandas referentes ao time de Cadastro e Credenciamento de Parceiros da regional Nordeste'
--where ID_TIPO_FILA = 27

--Acessos: Demandas referentes ao time de Acessos da regional Nordeste
--Suporte Processos: Demandas referentes ao time de Suporte de Processos da regional Nordeste
--Cadastro e Credenciamento de Parceiros: Demandas referentes ao time de Cadastro e Credenciamento de Parceiros da regional Nordeste

--CREATE FUNCTION dbo.SplitString
--(
--    @Input NVARCHAR(MAX),
--    @Delimiter CHAR(1)
--)
--RETURNS @Output TABLE (Value NVARCHAR(MAX))
--AS
--BEGIN
--    DECLARE @Start INT, @End INT
--    SET @Start = 1
--    SET @End = CHARINDEX(@Delimiter, @Input)

--    WHILE @Start < LEN(@Input) + 1
--    BEGIN
--        IF @End = 0 
--            SET @End = LEN(@Input) + 1

--        INSERT INTO @Output (Value)
--        VALUES (SUBSTRING(@Input, @Start, @End - @Start))

--        SET @Start = @End + 1
--        SET @End = CHARINDEX(@Delimiter, @Input, @Start)
--    END

--    RETURN
--END

WITH Palavras AS (
    SELECT 
        NOME,
        value AS Palavra,
        ROW_NUMBER() OVER (PARTITION BY NOME ORDER BY (SELECT NULL)) AS Posicao
    FROM 
        ACESSOS_MOBILE
        CROSS APPLY dbo.SplitString(NOME, ' ')
    WHERE 
        value NOT IN ('da', 'de', 'do', 'das', 'dos', 'e', 'a', 'o', 'as', 'os')
),

PalavrasValidas AS (
    SELECT 
        NOME,
        COUNT(*) OVER (PARTITION BY NOME) AS TotalPalavras,
        Palavra,
        Posicao
    FROM 
        Palavras
)
SELECT 
    NOME,
    CASE 
        WHEN TotalPalavras >= 3 THEN 
            (SELECT Palavra FROM PalavrasValidas WHERE NOME = p.NOME AND Posicao = 1) + ' ' +
            (SELECT Palavra FROM PalavrasValidas WHERE NOME = p.NOME AND Posicao = TotalPalavras)
        ELSE ''
    END AS DisplayName
FROM 
    PalavrasValidas p
GROUP BY 
    NOME, TotalPalavras;


            SELECT 
        MATRICULA,NOME,
CASE 
        WHEN NOME IS NULL OR LEN(LTRIM(RTRIM(NOME))) = 0 THEN '-'
        ELSE LEFT(LTRIM(RTRIM(NOME)), CHARINDEX(' ', LTRIM(RTRIM(NOME)) + ' ') - 1) + ' ' + 
             REVERSE(LEFT(REVERSE(LTRIM(RTRIM(NOME))), CHARINDEX(' ', REVERSE(LTRIM(RTRIM(NOME))) + ' ') - 1))
    END
    FROM 
        ACESSOS_MOBILE;

        SELECT 
    NOME,
    LEN(LEFT(NOME, CHARINDEX(' ', NOME + ' ') - 1) + ' ' + 
        REVERSE(LEFT(REVERSE(NOME), CHARINDEX(' ', REVERSE(NOME) + ' ') - 1))) AS NewLength
FROM 
    ACESSOS_MOBILE
    order by NewLength desc;

--UPDATE ACESSOS_MOBILE
--SET 
--    NOME_SOCIAL = 
--    CASE 
--        WHEN NOME IS NULL OR LEN(LTRIM(RTRIM(NOME))) = 0 THEN '-'
--        ELSE LEFT(LTRIM(RTRIM(NOME)), CHARINDEX(' ', LTRIM(RTRIM(NOME)) + ' ') - 1) + ' ' + 
--             REVERSE(LEFT(REVERSE(LTRIM(RTRIM(NOME))), CHARINDEX(' ', REVERSE(LTRIM(RTRIM(NOME))) + ' ') - 1))
--    END
--    where MATRICULA != 0 


--select * from ACESSOS_MOBILE WHERE NOME 
--in(
--'suzi.souza@telefonica.com',
--'ApenasUmTesteMassivo'
--)

--delete ACESSOS_MOBILE WHERE NOME 
--in(
--'suzi.souza@telefonica.com',
--'ApenasUmTesteMassivo'
--)
with matriculas_demanda as(
SELECT DISTINCT(MATRICULA_SOLICITANTE) as MATRICULA_SOLICITANTE FROM CNS_CONTROLE_DEMANDAS_NE
where STATUS <> 'FECHADO'),
matriculas_acessos as(
select DISTINCT(B.Login) from ACESSO_TERCEIROS A
join ACESSO B ON A.IdAcesso = B.IdAcesso
where 
A.DataMatricula is NULL and A.DataExtracao is null and A.obs is null and A.DataStatus is null and A.Regional = 'NE'
),
matriculas_operadores as(
select MATRICULA from DEMANDA_BD_OPERADORES where REGIONAL = 'NE'
)

select TOP 1 * from ACESSO
--delete VIVO_VISITA_CANAL_TERRITORIO_ESTRUTURAS_OPERACAO
--delete VIVO_VISITA_CANAL_TERRITORIO_ABERTURA

--select * from CONTROLE_DEMANDAS_CADASTRO
--delete CONTROLE_DEMANDAS_CADASTRO
--select * from CONTROLE_DEMANDAS_EVIDENCIAS
--delete CONTROLE_DEMANDAS_EVIDENCIAS

--select * from LOJA_CONTESTACAO_FATURA
--delete LOJA_CONTESTACAO_FATURA

select * from acesso where Regional <> 'NE'

delete ACESSO
where 
Regional = 'NE' and
Login not in (
'64960'
,'151191'
,'25183'
,'16279'
,'25183'
,'94842'
,'25677'
,'156305'
,'152001'
,'80900909'
,'160624'
,'80796597'
,'80904800'
,'40416900'
,'156727'
,'159706'
,'30722'
,'40417113'
,'156114'
,'51336'
,'3511507'
,'71114'
,'69372'
,'3458749'
,'40418413'
,'47333'
,'163794'
,'80886919'
,'157239'
,'16005'
,'123456'
,'150939'
,'22416'
,'27121'
,'30460'
,'31705'
,'32815'
,'33433'
,'38087'
,'40497'
,'40742'
,'47856'
,'49589'
,'50125'
,'62197'
,'65244'
,'65523'
,'74600'
,'93484'
,'109428'
,'110229'
,'112324'
,'118567'
,'118678'
,'126028'
,'129311'
,'130220'
,'133819'
,'134816'
,'137872'
,'145542'
,'148516'
,'150939'
,'150987'
,'151191'
,'151981'
,'154268'
,'154315'
,'156165'
,'156559'
,'156752'
,'160776'
,'160835'
,'160987'
,'161248'
,'161310'
,'161784'
,'163637'
,'163728'
,'165372'
,'165691'
,'166018'
,'166103'
,'18095'
,'22110'
,'22385'
,'23930'
,'25194'
,'25208'
,'26868'
,'29919'
,'32815'
,'33173'
,'33431'
,'35028'
,'35929'
,'36318'
,'36392'
,'37710'
,'39013'
,'40414390'
,'40416870'
,'40497'
,'43606'
,'44374'
,'46198'
,'46897'
,'47333'
,'49589'
,'62197'
,'62604'
,'62609'
,'64966'
,'65244'
,'65821'
,'66359'
,'67379'
,'70365'
,'70650'
,'70835'
,'71114'
,'71940'
,'72136'
,'72215'
,'72521'
,'72565'
,'73202'
,'73204'
,'75546'
,'78035'
,'80663'
,'81880'
,'89987'
,'94163'
,'94778'
,'96039'
,'97937'
,'99659'
,'99671'
)

--delete DESLIGAMENTOS
--insert into [DESLIGAMENTOS_BACKUP]
--select 
--UF	,
--DDD	,
--NOME_FUNCIONARIO	,
--MATRICULA_FUNCIONARIO	,
--LOGIN_FUNCIONARIO	,
--DATA_CADASTRO_DESLIGAMENTO	,
--CONFIRMA_DESLIGAMENTO	,
--DATA_CONFIRMA_DESLIGAMENTO	,
--idAcesso	,
--USUARIO	,
--CPF	,
--ADABAS	,
--MOTIVO	,
--REGIONAL
--from DESLIGAMENTOS
--join ACESSO B ON A.IdAcesso = B.IdAcesso

select * from acesso where Regional = 'MG'


--insert into acesso values
--('43812','ADRIANA PIMENTA FAGUNDES','adriana.fagundes@telefonica.com','MG',null,null,'ATIVO',1)
--,('64423','JOSIANE PEREIRA DE ARAUJO','josiane.paraujo@telefonica.com','MG',null,null,'ATIVO',1)
--,('64936','WESLEY ZEFERINO DE ALMEIDA','wesley.almeida@telefonica.com','MG',null,null,'ATIVO',1)
--,('17211','GEISA MARIA VILACA ALVIM PEREIRA','GEISA.ALVIM@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('418270','VIVIANE CRISTINA PINTO DIAS','VIVIANE.PDIAS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('442960','ALESKA IDALO MACIEIRA','ALESKA.MACIEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('44708','LUCIO SANTANA JUNIOR','LUCIO.SANTANA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('64913','EDGAR ROLANDO GUZMAN ZUNIGA','EDGAR.RZUNIGA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('458200','TIAGO MENEZES LOPES','TIAGO.MENEZES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('465250','LUIS GUSTAVO SANTOS GOMES','LUIS.SGOMES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('36309','CARLOS HENRIQUE COSTA FONSECA','CARLOS.CFONSECA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('410530','LILIAN LEAL LIMA DINIZ','LILIAN.LIMA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('422360','THIAGO SILVEIRA DE FREITAS','THIAGO.FREITAS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('48522','ROBSON DE VASCONCELOS','ROBSON.VASCONCELOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('65666','FERNANDA ALVES PEREIRA','FERNANDAA.PEREIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('419930','LETICIA CAMPOS TEIXEIRA','LETICIA.CTEIXEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('452940','AMANDA AMARAL CAETANO','AMANDA.CAETANO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('972850','LUDMILA PAROPATO CAMARGO BRAGA','LUDMILA.BRAGA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('999900','CLAUDIA LOUREIRO VASCONCELLOS DE PAULA','CLAUDIA.VASCONCELLOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('48519','LEANDRO BARBOSA COELHO','LEANDRO.BCOELHO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('81554','MARCO TULIO GOMES RODRIGUES','MARCO.TRODRIGUES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('435880','RICARDO CORREIA DOS REIS','RICARDO.CREIS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('444210','LUIZ FERNANDO DE FREITAS REIS','LUIZ.FREIS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('452580','BRUNO RODRIGUES DE OLIVEIRA','BRUNO.ROLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('461770','MARCUS VINICIUS OTONI CAMARGOS','MARCUS.CAMARGOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('465390','SAMUEL GOMES DA SILVA','SAMUEL.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('30660','LORRAINNE HELEN ALVES BORGES','LORRAINNH.BORGES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('48761','JULIANE MATIAS DE PAULA OLIVEIRA','JULIANE.MATIAS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('463900','MARIANA DUARTE GUERRA','MARIANA.DGUERRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('26416','THIAGO ANDRADE MOTA DE ABREU','THIAGO.MABREU@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('36878','EDILANE DE FATIMA PEREIRA','EDILANE.PEREIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('64384','GABRIELA FERREIRA GOMES','GABRIELA.FGOMES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('36920','HELBERT MOREIRA SOARES','HELBERT.SOARES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('421130','JAQUELINE SILVA TEIXEIRA','JAQUELINE.TEIXEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('46881','CARLOS LUIZ MIRANDA','CARLOS.MIRANDA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('48728','RENATO MOREIRA MAGALHAES','RENATO.MAGALHAES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('68307','LEONAM ALVES BATISTA','LEONAM.BATISTA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('70663','LUIZ CARLOS RODRIGUES ALMEIDA JUNIOR','LUIZ.RJUNIOR@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('453640','GUSTAVO FERREIRA DE OLIVEIRA','GUSTAVO.FOLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('41192','JOSIANE VARGAS DE SOUZA','JOSIANE.DSOUZA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('60595','POLIANA BELTRAME SILVA','POLIANA.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('78928','GRACIELY GONCALVES MARTINS','GRACIELY.MARTINS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('421330','GRAWBER DIEGO LOPES PONTES','GRAWBER.PONTES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('425380','ARTUR EDUARDO ELBERT BRANDAO','ARTUR.EDUARDO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('434160','DOUGLAS DE LIMA ALBUQUERQUE PINA','DOUGLAS.PINA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('442880','GUILHERME ALUIZIO SALAZAR SOARES','GUILHERME.SOARES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('39526','THAIS DORALICE RESENDE COSTA','THAIS.RCOSTA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('27853','LUIS GUSTAVO TEODORO','LUIS.TEODORO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('41164','DENNIS DE CASTRO PINTO','DENNIS.PINTO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('41307','LUIZ FERNANDO VERTA MACEDO','LUIZ.VMACEDO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('81813','WANDERSON DE OLIVEIRA','WANDERSON.OLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('86799','EDMARCIO ALMEIDA DOS SANTOS','EDMARCIO.SANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('87797','FERNANDA BARBOSA RODRIGUES DE OLIVEIRA','FERNANDAB.OLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('435510','TALES ROSA LIMA','TALES.LIMA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('455920','ODAIR SANTOS DE LIMA','ODAIR.LIMA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('37865','RENATO GONCALVES CARDOSO','RENATO.CARDOSO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('39423','WERISSON CESAR DA SILVA','WERISSON.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('28011','BRUNO CUNHA COSTA','BRUNO.CCOSTA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('73950','VANESSA DE CASSIA TEIXEIRA','VANESSA.TEIXEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('36695','POLLIANA APARECIDA DE OLIVEIRA SOUSA','POLLIANA.OLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('69940','DAYSA DE FATIMA ZANIN','DAYSA.ZANIN@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('40727','LENISE ALVES DA SILVA','LENISE.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('43182','TAMIRES CRISTINA FAVARETTO','TAMIRES.FAVARETTO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('28194','CHARLES SOARES RODRIGUES','CHARLES.RODRIGUES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('40070','ANDRE BATISTA ZUBA','ANDRE.ZUBA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('60649','VICTOR ETIENE DOS SANTOS','VICTOR.ESANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('415340','CYNTHIA EVANGELISTA ANTUNES','CYNTHIA.ANTUNES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('72543','CASSIA APARECIDA RIBEIRO','CASSIA.RIBEIRO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('74654','GENIVALDO ARAUJO DE AZEVEDO JUNIOR','GENIVALDO.AJUNIOR@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('48745','CARLA DA SILVA CANDIDO','CARLA.CANDIDO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('457960','LUDMYLLA SILVA OLIVEIRA','LUDMYLLA.OLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('460930','FABRICIO TOLENTINO SANTANA','F.SANTANA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('43837','ROGERIO DE PAIVA MEDEIROS JUNIOR','ROGERIOP.JUNIOR@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('44695','GUSTAVO HENRIQUE MEDEIROS LEMOS','GUSTAVO.LEMOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('49053','WILLIAM JONATAS ARTIGAS','WILLIAM.ARTIGAS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('61651','MARCOS PAULO SILVA LIMA','MARCOSP.LIMA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('425370','RAQUEL DIAS DUARTE','RAQUEL.DUARTE@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('35394','GLAUCIA MARTINS DE OLIVEIRA','GLAUCIA.OLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('455780','SIMONE DO COUTO SILVA','S.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('45585','ELBERT DE OLIVEIRA FONSECA JUNIOR','ELBERT.JUNIOR@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('31673','LIERTANE FERNANDES DE CAMPOS VIANA','LIERTANE.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('43955','RODRIGO SILVA DA COSTA','RODRIGO.SCOSTA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('61463','WYSLANN STERFANIN FONSECA DA SILVA','WYSLANN.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('28223','ILTON RODRIGUES DE MATOS JUNIOR','ILTON.JUNIOR@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('29888','RAFAEL HENRIQUE DE ALMEIDA SANTANA','RAFAEL.ASANTANA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('40418','THIAGO RODRIGUES DOS REIS','THIAGO.DREIS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('31743','RAISA RODRIGUES PINHEIRO','RAISA.PINHEIRO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('32968','RAPHAEL MARTINS DA ROCHA','RAPHAEL.ROCHA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('39398','VICTOR SPINDOLA DA SILVA','VICTOR.SSILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('25089','RAFAEL MITRAUD FALCONE PAIVA','RAFAEL.FALCONE@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('49395','JUSILENE DE ASSIS DOS SANTOS','JUSILENE.SANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('44658','ELIANE SILVA DE OLIVEIRA','ELIANE.OLIVEIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('445990','CINTIA MARIA RIBEIRO','CINTIA.RIBEIRO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('35975','BRUNA MARA DOS SANTOS','BRUNA.DSANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('991460','MICHELLE NOGUEIRA BAETA','MICHELLE.BAETA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('27349','WELDER DANIEL QUIRINO','WELDER.QUIRINO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('32764','ADRIANA FLORIETA FONSECA FERREIRA','ADRIANA.FFERREIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('49708','PAULO ROBERTO MORAIS','PAULO.MORAIS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('69087','DIEGO FABIO SILVA GONCALVES','DIEGO.FGONCALVES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('456010','JUNIA GRACIELE SOARES DA SILVA','JUNIA.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('31635','THATIANE BARBOSA DE MATOS','THATIANE.MATOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('72551','GRACIELE APARECIDA DE SALES','GRACIELE.VALGAS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('43106','YURI GABRIEL PEREIRA TONGO','YURI.TONGO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('424970','VINICIUS ADOLFO SANTOS DA SILVA','VINICIUS.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('41048','VINICIUS BRANDAO BARBOSA','VINICIUS.BARBOSA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('50371','ARIANE SILVA BRUZZI CORTES','ARIANE.CORTES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('27237','JULIANA PEREIRA DA COSTA','JULIANA.COSTA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('28542','HIGOR PEDROSO BERNARDES','HIGOR.BERNARDES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('457900','KARLA APARECIDA RODRIGUES RIBEIRO','KARLA.RIBEIRO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('45017','INGRID ISABELA GONCALVES DA SILVA','INGRID.ISILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('70441','MARCELA QUEIROZ TOUSSAINT','MARCELA.TOUSSAINT@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('463790','LUDMILA DARTANHAN DA SILVA','LUDMILA.SILVA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('29249','BARBARA PAULA LOPES','BARBARA.LOPES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('36710','ANDREIA SIQUEIRA LOPES','ANDREIA.LOPES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('50532','RAFAEL AUGUSTO SILVA NASCIMENTO','RAFAEL.ANASCIMENTO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('37862','JOANITA PAPALINI ROCHA','JOANITA.ROCHA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('47872','DAYANE FERNANDA REIS','DAYANE.REIS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('76336','ANA CAROLINA CALDEIRA BENFICA','ANA.BENFICA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('76306','MATHEUS HENRIQUE FREITAS SANTOS','MATHEUS.SANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('29381','PRISCILA RODRIGUES GONZAGA RIBEIRO','PRISCILA.RRIBEIRO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('40476','ERIC LEITE DE OLIVEIRA CAETANO','ERIC.CAETANO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('35273','ALINE AGATA ROCHA CORREA','ALINE.ROCHA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('89710','MICHELE ELAINE PEREIRA','michele.epereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('449740','LEANDRO MATOS SOARES','leandrom.soares@telefonica.com','MG',null,null,'ATIVO',1)
--,('49576','MARIA ANGELICA DIVINO BARROS','maria.divino@telefonica.com','MG',null,null,'ATIVO',1)
--,('89191','DIEGO SOARES CARVALHO','diego.scarvalho@telefonica.com','MG',null,null,'ATIVO',1)
--,('91016','LUCIANA CRISTINA DO ROSARIO','luciana.rosario@telefonica.com','MG',null,null,'ATIVO',1)
--,('31664','LEONARDO RODRIGUES PORTO','leonardo.rporto@telefonica.com','MG',null,null,'ATIVO',1)
--,('29464','CLAUDIO MARCIO DE LACERDA','Claudio.Lacerda@telefonica.com','MG',null,null,'ATIVO',1)
--,('3458719','EDVALDO PEREIRA MATEUS','edvaldo.mateus@telefonica.com','MG',null,null,'ATIVO',1)
--,('459090','DANIEL GOMES DA SILVA ','daniel.gsilva@telefonica.com','MG',null,null,'ATIVO',1)
--,('463660','EDUARDO BAHIA ALVES RIBEIRO','eduardob.ribeiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('70410','BRUNO CESAR NOGUEIRA DE SENA','BRUNO.SENA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('19024','HELENA DE SOUZA NOGUEIRA AMOROSO','helena.nogueira@telefonica.com','MG',null,null,'ATIVO',1)
--,('67727','JOHNY DALAMORA CORREA','johny.correa@telefonica.com','MG',null,null,'ATIVO',1)
--,('43291','LEIDIANE NASCIMENTO DE JESUS','leidiane.tavares@telefonica.com','MG',null,null,'ATIVO',1)
--,('46801','LARA AMORIM DE OLIVEIRA','lara.oliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('48701','CINTIA RODRIGUES ANTUNES','cintia.sousa@telefonica.com','MG',null,null,'ATIVO',1)
--,('49069','STELLA RODRIGUES SILVA','stella.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('49984','RENATA BOAVENTURA DE ALMEIDA','renata.balmeida@telefonica.com','MG',null,null,'ATIVO',1)
--,('67024','ANDRE DA SILVA USUAL DOS SANTOS','andre.usantos@telefonica.com','MG',null,null,'ATIVO',1)
--,('69839','GISELY MARIA PEREIRA LACERDA','gisely.lacerda@telefonica.com','MG',null,null,'ATIVO',1)
--,('72498','DEIVILANE CAMPOS RIBEIRO','deivilane.ribeiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('74520','ALINE DE FREITAS FERREIRA','aline.fferreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('75496','KATIANE APARECIDA CONCORDIA','katiane.concordia@telefonica.com','MG',null,null,'ATIVO',1)
--,('76924','CAROLINE SABINO COSTA','caroline.sabino@telefonica.com','MG',null,null,'ATIVO',1)
--,('78002','MARDONIELE DA CONCEICAO DOS SANTOS','mardoniele.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('79817','KARINE PEREIRA DA SILVA','karine.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('79869','CAMILA DA CONCEICAO DUARTE','camila.duarte@telefonica.com','MG',null,null,'ATIVO',1)
--,('80820','ROSELENA FERREIRA','roselena.ferreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('87625','DINAURA MATTOZO MEDEIROS','dinaura.medeiros@telefonica.com','MG',null,null,'ATIVO',1)
--,('87731','RAYANE TAMARA ARAUJO VIEIRA','rayane.vieira@telefonica.com','MG',null,null,'ATIVO',1)
--,('87838','MATHEUS HENRIQUE NASCIMENTO LAIA','matheus.laia@telefonica.com','MG',null,null,'ATIVO',1)
--,('89746','TADEU GOMES BRITO','tadeu.gbrito@telefonica.com','MG',null,null,'ATIVO',1)
--,('92286','ANA LUIZA RODRIGUES DE SOUSA','anal.sousa@telefonica.com','MG',null,null,'ATIVO',1)
--,('93476','PRISCILA MENDES DE OLIVEIRA','priscila.oliveira2@telefonica.com','MG',null,null,'ATIVO',1)
--,('420770','THAIS GONCALVES VERARDO','thais.verardo@telefonica.com','MG',null,null,'ATIVO',1)
--,('423610','BEATRIZ APARECIDA FERREIRA DE SOUSA','beatriz.ferreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('426400','WITER CESAR DE MATOS','witer.matos@telefonica.com','MG',null,null,'ATIVO',1)
--,('435480','CLAUDIA GOMES ORNELAS DE CASTRO','claudia.gornelas@telefonica.com','MG',null,null,'ATIVO',1)
--,('458100','ESTER RODRIGUES DA SILVA','ester.rsilva@telefonica.com','MG',null,null,'ATIVO',1)
--,('97311','ANDRE TIAGO DE OLIVEIRA','andre.toliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('988090','MARIANO  CABALZAR AMARAL','mariano.cabalzar@telefonica.com','MG',null,null,'ATIVO',1)
--,('50525','TIAGO MENDES PEREIRA','tiago.mpereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('425200','JULIANA ARAUJO FAGUNDES FIGUEIROA','JULIANA.FAGUNDES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('156644','TAYANA KATHERINE MARINHO MACHADO','tayana.machado@telefonica.com','MG',null,null,'ATIVO',1)
--,('100770','RAQUEL BRANDÃO CARVALHO','raquel.bcarvalho@telefonica.com','MG',null,null,'ATIVO',1)
--,('99652','DIOGO DIAS VARGAS','diogo.vargas@telefonica.com','MG',null,null,'ATIVO',1)
--,('99640','MARCELA NASCIMENTO','marcela.nascimento@telefonica.com','MG',null,null,'ATIVO',1)
--,('99650','KATIA PRISCILA MEDIS ROSARIO','KATIA.KPM@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('100783','FELIPE ALVES FRANÇA CAMPOS','felipe.acampos@telefonica.com','MG',null,null,'ATIVO',1)
--,('50355','WEMERSON FERNANDES OLIVEIRA','wemerson.oliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('73888','EMANUELA PRATES DOS SANTOS COELHO','emanuela.coelho@telefonica.com','MG',null,null,'ATIVO',1)
--,('42538','ARTUR BRANDAO','artur.brandao@telefonica.com','MG',null,null,'ATIVO',1)
--,('50268','ANA PAULA ALVES MELLO','ana.pmello@telefonica.com','MG',null,null,'ATIVO',1)
--,('106371','ALEXANDRE FRANCESCO DE SOUZA','alexandref.souza@telefonica.com','MG',null,null,'ATIVO',1)
--,('106484','ROBSON NATANAEL DOS SANTOS','robson.nsantos@telefonica.com','MG',null,null,'ATIVO',1)
--,('70560','BERNARDO DUTRA MACHADO','bernardo.machado@telefonica.com','MG',null,null,'ATIVO',1)
--,('108310','ERICK DE MOURA GUIMARAES','erick.guimaraes@telefonica.com','MG',null,null,'ATIVO',1)
--,('46111','FILIPE ALVARO SILVEIRA DE PAULA','filipe.paula@telefonica.com','MG',null,null,'ATIVO',1)
--,('109668','RENAN OTÁVIO SOARES VIEIRA','renan.vieira@telefonica.com','MG',null,null,'ATIVO',1)
--,('48477','BRUNA RAIANE ALVES DE SOUZA','bruna.souza@telefonica.com','MG',null,null,'ATIVO',1)
--,('50017','BRUNA RAFAELLA ARAÚJO FARIA','bruna.faria@telefonica.com','MG',null,null,'ATIVO',1)
--,('45944','ANA FLAVIA APARECIDA BARBOZA','ana.barboza@telefonica.com','MG',null,null,'ATIVO',1)
--,('64081','ANA PAULA DOS SANTOS MANGUEIRA','ana.mangueira@telefonica.com','MG',null,null,'ATIVO',1)
--,('111148','LEANDRO DE OLIVEIRA ROCHA','leandro.orocha@telefonica.com','MG',null,null,'ATIVO',1)
--,('99219','MARCIO DOS SANTOS DA SILVA','marcio.silva4@telefonica.com','MG',null,null,'ATIVO',1)
--,('111128','ANNE BORGES FONSECA ROSALEM','anne.rosalem@telefonica.com','MG',null,null,'ATIVO',1)
--,('136855','AUGUSTO GONCALVES','goncalves.augusto@telefonica.com','MG',null,null,'ATIVO',1)
--,('113409','LAYLA FABIANNA GUIMARAES CARIBE','layla.caribe@telefonica.com','MG',null,null,'ATIVO',1)
--,('978980','FLAVIANA COELHO SIMOES PACHECO','flaviana.simoes@telefonica.com','MG',null,null,'ATIVO',1)
--,('3458683','URSULA ASSIS CAMPOS','ursula.campos@telefonica.com','MG',null,null,'ATIVO',1)
--,('427700','KENYA ALVES DA COSTA','kenya.costa@telefonica.com','MG',null,null,'ATIVO',1)
--,('429120','ANA  PAULA CASTRO DINIZ','ana.diniz@telefonica.com','MG',null,null,'ATIVO',1)
--,('51195','FABRICIO XAVIER DIAS','fabricio.dias@telefonica.com','MG',null,null,'ATIVO',1)
--,('117424','MARCELLE ALVIM MENDONCA','marcelle.mendonca@telefonica.com','MG',null,null,'ATIVO',1)
--,('67632','MOACIR DE PAULA MARTINS','moacir.neto@telefonica.com','MG',null,null,'ATIVO',1)
--,('120538','LETICIA PIMENTA SANT ANA','leticia.ana@telefonica.com','MG',null,null,'ATIVO',1)
--,('78329','PATRICK JONATHAN BHERING CARVALHAIS','patrick.carvalhais@telefonica.com','MG',null,null,'ATIVO',1)
--,('415060','ROBERTA FURTADO ARAUJO','roberta.araujo@telefonica.com','MG',null,null,'ATIVO',1)
--,('120210','ALCIONE DE OLIVEIRA DE CASTRO','alcione.castro@telefonica.com','MG',null,null,'ATIVO',1)
--,('988070','CYNTHIA RODRIGUES PINTO','cyntia.pinto@telefonica.com','MG',null,null,'ATIVO',1)
--,('A0044969','CINTHIA ARF DE SOUZA','cinthia.souza@telefonica.com','MG',null,null,'ATIVO',1)
--,('41159','MARIANNA  THEREZA DA SILVA DOMINGOS','marianna.domingos@telefonica.com','MG',null,null,'ATIVO',1)
--,('44854','MARCIA  CRISTINA MOREIRA GUEDES COSTA','marcia.moreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('465320','NAGELA BRUNA PINTO','nagela.pinto@telefonica.com','MG',null,null,'ATIVO',1)
--,('131361','KARINE MARI REZENDE','karine.rezende@telefonica.com','MG',null,null,'ATIVO',1)
--,('45784','CARLOS EDUARDO CARVALHAIS PEREIRA','carlose.pereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('45584','MONIZY STEFANY ROSA MACHADO','monizy.machado@telefonica.com','MG',null,null,'ATIVO',1)
--,('89082','EDER DA SILVA REGINATO','eder.reginato@telefonica.com','MG',null,null,'ATIVO',1)
--,('47498','DAVID  HENRIQUE DE FREITAS BARBOSA','david.barbosa@telefonica.com','MG',null,null,'ATIVO',1)
--,('38078','JULIANA CRISTINA ANGELO','juliana.angelo@telefonica.com','MG',null,null,'ATIVO',1)
--,('980270','DANIELE NORONHA MARON ','daniele.noronha@telefonica.com','MG',null,null,'ATIVO',1)
--,('0453640','GUSTAVO FERREIRA DE OLIVEIRA','gustavo.foliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('117429','PEDRO HENRIQUE DE REZENDE PERTENCE','pedro.pertence@telefonica.com','MG',null,null,'ATIVO',1)
--,('76207','CAMILA EDVIRGENS FONSECA','camila.efonseca@telefonica.com','MG',null,null,'ATIVO',1)
--,('70422','RODRIGO SOARES RIBEIRO','rodrigo.sribeiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('136883','JOSE WILLIAM SILVA JUNIOR','jose.wjunior@telefonica.com','MG',null,null,'ATIVO',1)
--,('136878','PAULO HENRIQUE RIBEIRO SILVA','paulo.henrique@telefonica.com','MG',null,null,'ATIVO',1)
--,('64490','SABRINA CAROLINE DE SOUZA DOS SANTOS','SABRINA.CSANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('136969','RAPHAEL LIMA MARTINS PEREIRA','raphael.lpereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('110121','GUSTAVO MENDES BUENO DE CARVALHO','gustavom.carvalho@telefonica.com','MG',null,null,'ATIVO',1)
--,('80658','MATHEUS AUGUSTO TOMAZ','matheus.tomaz@telefonica.com','MG',null,null,'ATIVO',1)
--,('138021','GLAUBER TIRADENTES DA SILVA','glauber.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('137832','CASSIO GIOVANNI DOS SANTOS ARAUJO','cassio.araujo@telefonica.com','MG',null,null,'ATIVO',1)
--,('137999','IZABELLA PACHECO ABRANTES','izabella.abrantes@telefonica.com','MG',null,null,'ATIVO',1)
--,('46977','GABRIELA CAROLINA CAMPOS REZENDE','gabriela.rezende@telefonica.com','MG',null,null,'ATIVO',1)
--,('138952','MARCEL ALVES DE OLIVEIRA','marcel.oliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('37863','LIDIANA CRISTINA DO NASCIMENTO','lidiana.nascimento@telefonica.com','MG',null,null,'ATIVO',1)
--,('973635','ERICA RACHE PORTELA','erica.portela@telefonica.com','MG',null,null,'ATIVO',1)
--,('71907','MARCOS ALBERTO ALVES DOS ANJOS','marcos.anjos@telefonica.com','MG',null,null,'ATIVO',1)
--,('73880','GUILHERME FRANCISCO MOREIRA DOS ANJOS','guilherme.anjos@telefonica.com','MG',null,null,'ATIVO',1)
--,('71072','ADRIAN CHRISTINA VIEIRA','adrian.vieira@telefonica.com','MG',null,null,'ATIVO',1)
--,('141046','NATALIA NETTO BASILIO DIAS','natalia.ndias@telefonica.com','MG',null,null,'ATIVO',1)
--,('141052','PAULO HENRIQUE MARQUES RIOS','paulo.rios@telefonica.com','MG',null,null,'ATIVO',1)
--,('89121','LARISSA MUNIZ JUNGER DA CRUZ','larissa.cruz@telefonica.com','MG',null,null,'ATIVO',1)
--,('143803','RODRIGO SANTHIAGO PIRES MURCA','rodrigo.murca@telefonica.com','MG',null,null,'ATIVO',1)
--,('142735','PAULO ROBERTO CARDEAL DIAS','paulo.dias@telefonica.com','MG',null,null,'ATIVO',1)
--,('143356','FARLLEY LUIS VIEIRA DE SA','farlley.sa@telefonica.com','MG',null,null,'ATIVO',1)
--,('144868','RODRIGO LIMA DE SOUSA','rodrigo.sousa@telefonica.com','MG',null,null,'ATIVO',1)
--,('69853','LAIS DOS SANTOS ESTEVES','lais.esteves@telefonica.com','MG',null,null,'ATIVO',1)
--,('71095','MATHEUS TOMAZ MOREIRA SANTOS','matheust.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('28064',' MARCIO ROMUALDO MARTINS','marcio.martins@telefonica.com','MG',null,null,'ATIVO',1)
--,('94539','CLEBER PEREIRA DOS SANTOS','CLEBER.PSANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('39581','TATIANA CRISTINA DA SILVA','tatianad.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('48716','LETÍCIA FRANSCIELE DE ALMEIDA SANTOS','leticia.fsantos@telefonica.com','MG',null,null,'ATIVO',1)
--,('146521','VINICIUS CRISTOVAO CORREA','vinicius.correa@telefonica.com','MG',null,null,'ATIVO',1)
--,('80492594','FABIO BASTOS MOREIRA','jf.shoppingindependencia@redeinovacel.com.br','MG',null,null,'ATIVO',1)
--,('69057','YASMINE FERNANDES DE ALMEIDA SANTOS','yasmine.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('146685','JULIA PERES PLACIDO','julia.placido@telefonica.com','MG',null,null,'ATIVO',1)
--,('147201','TATIANA ELISA FERRAZ','tatiana.ferraz@telefonica.com','MG',null,null,'ATIVO',1)
--,('40414110','CATHARINE OLIVEIRA DA SILVA','catharine.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('63850','LUCIANA SILVA ARAUJO','luciana.saraujo@telefonica.com','MG',null,null,'ATIVO',1)
--,('148621','BENVINDA LAMARAO VILAS BOAS DE MEDEIROS','benvinda.medeiros@telefonica.com','MG',null,null,'ATIVO',1)
--,('70969','ALINNE LOPES DA SILVA ','alinne.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('92362','ANA PAULA MARTINS SARMENTO FREITAS','ana.pfreitas@telefonica.com','MG',null,null,'ATIVO',1)
--,('40415005','ANA ALICE DE CASTRO SANTOS','ana.asantos@telefonica.com','MG',null,null,'ATIVO',1)
--,('87789','PEDRO HENRIQUE SERNIZON VIEIRA','pedro.hvieira@telefonica.com','MG',null,null,'ATIVO',1)
--,('98461','GABRIELA NERES DANIEL','gabriela.daniel@telefonica.com','MG',null,null,'ATIVO',1)
--,('86913','GRAZIELE OLIVEIRA SANTOS','graziele.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('40414308','ADRYELLE CAROLINE SILVA BRITO','adryelle.brito@telefonica.com','MG',null,null,'ATIVO',1)
--,('71879','MARCUS VINICIUS PIRES DOS SANTOS','marcusv.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('151138','LUIS PAULO RIGAMONTE','luis.rigamonte@telefonica.com','MG',null,null,'ATIVO',1)
--,('40414192','MATEUS MATSUMOTO DA SILVA','mateus.msilva@telefonica.com','MG',null,null,'ATIVO',1)
--,('80023','NAYARA RIBEIRO DOS REIS','nayara.rreis@telefonica.com','MG',null,null,'ATIVO',1)
--,('94502','LETICIA ANGELICA NOGUEIRA DE PAIVA','leticia.paiva@telefonica.com','MG',null,null,'ATIVO',1)
--,('150964','DANIEL NILSON VIEIRA','daniel.nvieira@telefonica.com','MG',null,null,'ATIVO',1)
--,('81746','YASMIN PINHEIRO LIMA','yasmin.lima@telefonica.com','MG',null,null,'ATIVO',1)
--,('152390','JULIANO FIDELIS DE OLIVEIRA','juliano.foliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('90192','ROSEMEIRE SOARES DE SOUZA','rosemeire.souza@telefonica.com','MG',null,null,'ATIVO',1)
--,('40414335','WAGNER JUNIO FERREIRA ANDRADE','wagner.jandrade@telefonica.com','MG',null,null,'ATIVO',1)
--,('118682','TARYKE CRISTIANO MARTINS FERREIRA','TARYKE.FERREIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('152655','VAGNER DE SOUSA COIMBRA JUNIOR','vagner.sjunior@telefonica.com','MG',null,null,'ATIVO',1)
--,('45152','BRUNA GABRIELE BARBARA','bruna.barbara@telefonica.com','MG',null,null,'ATIVO',1)
--,('45186','DANIELA DE OLIVEIRA RAMOS','daniela.oramos@telefonica.com','MG',null,null,'ATIVO',1)
--,('153505','KLEYTON OLIVEIRA JORGE','kleyton.jorge@telefonica.com','MG',null,null,'ATIVO',1)
--,('153550','RENAN WESLEY DE OLIVEIRA','renan.woliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('80452','GERSON FIORAVANTI JUNIOR','GERSON.FJUNIOR@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('20591','MARIA DE LOURDES RODRIGUES FERREIRA','MARIA.RODRIGUESFERREIRA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('97334','ELIANE APARECIDA DE JESUS','ELIANE.JESUS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('154598','BRUNA ISABEL ANTUNES FOGACA','bruna.fogaca@telefonica.com','MG',null,null,'ATIVO',1)
--,('445130','MARCELO DE OLIVEIRA SOARES','marcelo.soares@telefonica.com','MG',null,null,'ATIVO',1)
--,('155245','FABRICIO DANTAS CORREIA','FABRICIO.CORREIA@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('155459','JESSICA POLIANE MOREIRA DA CRUZ VICENTE','jessicap.moreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('78901','WADSON RIBEIRO CESAR','wadson.cesar@telefonica.com','MG',null,null,'ATIVO',1)
--,('67217','GRACIENE HELENA PEREIRA','graciene.pereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('35403','MILLANE CANDIDA DE SOUZA','millane.souza@telefonica.com','MG',null,null,'ATIVO',1)
--,('155741','JOAO GABRIEL TEIXEIRA','joao.teixeira@telefonica.com','MG',null,null,'ATIVO',1)
--,('156135','JOAO PAULO MORAES DA CRUZ','joao.pcruz@telefonica.com','MG',null,null,'ATIVO',1)
--,('147468','HAMILCAR CHIARINI DE FARIA','hamilcar.faria@telefonica.com','MG',null,null,'ATIVO',1)
--,('156167','DANIELA FARIA LIMA','daniela.flima@telefonica.com','MG',null,null,'ATIVO',1)
--,('78322','MARCIO VALERIO REZENDE DE SOUSA','marcio.sousa@telefonica.com','MG',null,null,'ATIVO',1)
--,('93939','ERIKA DE OLIVEIRA GUIMARAES','erika.oguimaraes@telefonica.com','MG',null,null,'ATIVO',1)
--,('87792','YGOR AUGUSTO VASCONCELOS MACIEL','ygor.maciel@telefonica.com','MG',null,null,'ATIVO',1)
--,('156552','ARNALDO LUCIANO FERREIRA','arnaldo.ferreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('156533','FERNANDA DE ARAUJO PINTO','fernanda.apinto@telefonica.com','MG',null,null,'ATIVO',1)
--,('87630','NATALIA MATOS COSTA','natalia.costa@telefonica.com','MG',null,null,'ATIVO',1)
--,('40416296','VINICIUS FERNANDES MORAIS','vinicius.fmorais@telefonica.com','MG',null,null,'ATIVO',1)
--,('69869','GUSTAVO MAGNO MOURA CARDOSO','gustavo.mcardoso@telefonica.com','MG',null,null,'ATIVO',1)
--,('99118','PAULO HENRIQUE MARTINS','pauloh.martins@telefonica.com','MG',null,null,'ATIVO',1)
--,('71906','YOHANA DOS SANTOS CERQUEIRA','yohana.cerqueira@telefonica.com','MG',null,null,'ATIVO',1)
--,('156735','GUSTAVO BUZINARI MACHADO','gustavo.machado@telefonica.com','MG',null,null,'ATIVO',1)
--,('69104','MAIGUEL SANTOS PEREIRA','maiguel.pereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('98515','PAULO HENRIQUE VALERIANO SOUZA DOS SANTOS','pauloh.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('156202','AMERICO LEITE SOUZA SALGADO','americo.salgado@telefonica.com','MG',null,null,'ATIVO',1)
--,('157558','BIANCA DE OLIVEIRA FERREIRA','bianca.oferreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('92173','KAMILA VIEIRA DE MELO','kamila.melo@telefonica.com','MG',null,null,'ATIVO',1)
--,('24835','THAMARA DE PAULA DOS SANTOS LEANDRO','thamara.psantos@telefonica.com','MG',null,null,'ATIVO',1)
--,('72520','AMANDA MOREIRA PIRES','amanda.pires@telefonica.com','MG',null,null,'ATIVO',1)
--,('79010','JOCIELI DA SILVA SANTOS','jocieli.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('39422','THAYS FERREIRA QUEIROZ BRAGA','thays.queiroz@telefonica.com','MG',null,null,'ATIVO',1)
--,('157693','TATIANA APARECIDA DA SILVA RIBEIRO','tatiana.aribeiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('158148','KAMILA TACIANA PIO','kamila.pio@telefonica.com','MG',null,null,'ATIVO',1)
--,('158920','ELVIS REGO DE FREITAS','elvis.freitas@telefonica.com','MG',null,null,'ATIVO',1)
--,('159021','JACKSON JUNIO FERREIRA SOARES','jackson.soares@telefonica.com','MG',null,null,'ATIVO',1)
--,('158998','ALEXANDRE SILVA DE OLIVERIO','alexandre.oliverio@telefonica.com','MG',null,null,'ATIVO',1)
--,('66347','PATRICIA DA SILVA ALMEIDA','patricia.salmeida@telefonica.com','MG',null,null,'ATIVO',1)
--,('98683','ANGELICA APARECIDA VITOR','angelica.vitor@telefonica.com','MG',null,null,'ATIVO',1)
--,('99442','RAFAEL DE PINHO GONCALVES','rafael.pgoncalves@telefonica.com','MG',null,null,'ATIVO',1)
--,('159873','HENRIQUE GONCALVES GOMES','henrique.gomes@telefonica.com','MG',null,null,'ATIVO',1)
--,('159581','BRUNA HELLEN GOMES DOS SANTOS DESTEFANI','bruna.destefani@telefonica.com','MG',null,null,'ATIVO',1)
--,('160088','DJALMA FONSECA DOS SANTOS JUNIOR','djalma.fjunior@telefonica.com','MG',null,null,'ATIVO',1)
--,('160707','ANDREA FREITAS DE ALMEIDA BRAGA','andrea.braga@telefonica.com','MG',null,null,'ATIVO',1)
--,('160433','JADER RICARDO COSTA CARNEIRO','jader.carneiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('120944','LUCAS HENRIQUE TEIXEIRA GOTT','lucas.gott@telefonica.com','MG',null,null,'ATIVO',1)
--,('40417178','CHARLES GEOVANE DE OLIVEIRA','charles.oliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('78148','AMANDA MARTINS DE SOUZA','amanda.msouza@telefonica.com','MG',null,null,'ATIVO',1)
--,('130160','JAMES NEVES RIBEIRO','james.ribeiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('78866','AUGUSTO CESAR COELHO CHAVES','augusto.chaves@telefonica.com','MG',null,null,'ATIVO',1)
--,('161232','THIAGO DE SOUZA LUCIANO','thiago.luciano@telefonica.com','MG',null,null,'ATIVO',1)
--,('158198','ANYELE RAYANE MACHADO MENEZES','anyele.menezes@telefonica.com','MG',null,null,'ATIVO',1)
--,('158223','FRANCIELLI ALVES REZENDE','francielli.rezende@telefonica.com','MG',null,null,'ATIVO',1)
--,('147421','EDUARDA DE CASTRO NEVES SANTOS','eduarda.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('157597','FELIPE JARDIM DIAS','felipe.dias@telefonica.com','MG',null,null,'ATIVO',1)
--,('40417219','VINICIUS GONCALVES SILVA','vinicius.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('78283','MARCELO RUBENS SERAPIAO LEAL','marcelo.leal@telefonica.com','MG',null,null,'ATIVO',1)
--,('161542','ODANE REIS LIMA DA SILVA','odane.silva@telefonica.com','MG',null,null,'ATIVO',1)
--,('161345','POLLIANA RIBEIRO FERREIRA BRAZ','polliana.braz@telefonica.com','MG',null,null,'ATIVO',1)
--,('51271','AMANDA CRISTINA DE MORAIS','amanda.cmorais@telefonica.com','MG',null,null,'ATIVO',1)
--,('113422','ERIKA ROSIANE MOTA RIBEIRO','erika.ribeiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('157832','IORRANE MARIELE VIEIRA DE SOUZA','iorrane.souza@telefonica.com','MG',null,null,'ATIVO',1)
--,('114966','JUCIELLY ALVES DA SILVA SANTOS','jucielly.santos@telefonica.com','MG',null,null,'ATIVO',1)
--,('153711','ANA CAROLINA PEREIRA DE FREITAS','ana.cfreitas@telefonica.com','MG',null,null,'ATIVO',1)
--,('112115','NUBIA CAMILA SANTOS AVILA','nubia.cavila@telefonica.com','MG',null,null,'ATIVO',1)
--,('157077','CRISTIANE MARTINS PIRES','cristiane.pires@telefonica.com','MG',null,null,'ATIVO',1)
--,('161707','JULIANO TONYDDAN GOMES','juliano.tgomes@telefonica.com','MG',null,null,'ATIVO',1)
--,('153265','JEFERSON LEAL VIEIRA','jeferson.vieira@telefonica.com','MG',null,null,'ATIVO',1)
--,('63854','GESSICA FREITAS BONICONTRO','gessica.bonicontro@telefonica.com','MG',null,null,'ATIVO',1)
--,('63854','GESSICA FREITAS BONICONTRO','gessica.bonicontro@telefonica.com','MG',null,null,'ATIVO',1)
--,('120789','LEONIDAS JUNIOR OLIVEIRA MARQUES','leonidas.marques@telefonica.com','MG',null,null,'ATIVO',1)
--,('162407','DANIEL CONRADO GOMES DE ARAUJO','daniel.caraujo@telefonica.com','MG',null,null,'ATIVO',1)
--,('162093','MAIRA MALDONADO EVANGELISTA','maira.evangelista@telefonica.com','MG',null,null,'ATIVO',1)
--,('151275','MATHEUS AUGUSTO DE DEUS','matheus.deus@telefonica.com','MG',null,null,'ATIVO',1)
--,('162895','KETLEN MELINNY NAVES NASCIMENTO','ketlen.nascimento@telefonica.com','MG',null,null,'ATIVO',1)
--,('162873','MATHEUS MENDES SALVADOR E FREITAS','matheus.freitas@telefonica.com','MG',null,null,'ATIVO',1)
--,('162873','MATHEUS MENDES SALVADOR E FREITAS','matheus.freitas@telefonica.com','MG',null,null,'ATIVO',1)
--,('127211','JOAO MARCOS SOUZA AMORIM','joao.amorim@telefonica.com','MG',null,null,'ATIVO',1)
--,('154956','SAIMON DAVI SOARES FERREIRA','saimon.ferreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('163196','LUCAS MARTINS DE OLIVEIRA','lucas.oliveira2@telefonica.com','MG',null,null,'ATIVO',1)
--,('163223','JOHN ERICK LIMA DA SILVA','john.silvaerick@telefonica.com','MG',null,null,'ATIVO',1)
--,('162683','TIAGO HELBERT GOMES','tiago.hgomes@telefonica.com','MG',null,null,'ATIVO',1)
--,('146579','JEFFERSON DA SILVA ALVES RIBEIRO','jefferson.ribeiro@telefonica.com','MG',null,null,'ATIVO',1)
--,('163303','MARIA NICOLI RODRIGUES DE FREITAS','maria.nfreitas@telefonica.com','MG',null,null,'ATIVO',1)
--,('40417845','CAROLINA DA COSTA LUCAS','carolina.lucas@telefonica.com','MG',null,null,'ATIVO',1)
--,('99420','HUGO FRANCO ARRUDA','hugo.arruda@telefonica.com','MG',null,null,'ATIVO',1)
--,('148513','BRAIAN ARAUJO RIBEIRO','BRAIAN.RIBEIRO@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('96186','JOAO PAULO ALVES CAIXETA','joao.caixeta@telefonica.com','MG',null,null,'ATIVO',1)
--,('96186','JOAO PAULO ALVES CAIXETA','joao.caixeta@telefonica.com','MG',null,null,'ATIVO',1)
--,('94644','KARLA DANIELE PEREIRA','karla.pereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('164295','WELITON CORREA DE MACEDO','weliton.macedo@telefonica.com','MG',null,null,'ATIVO',1)
--,('50321','JUAN MARCEL SILVA VALADAO','juan.valadao@telefonica.com','MG',null,null,'ATIVO',1)
--,('50321','JUAN MARCEL SILVA VALADAO','juan.valadao@telefonica.com','MG',null,null,'ATIVO',1)
--,('162700','JOAO VICTOR GOMES FERREIRA','joaov.ferreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('153092','GABRIEL LIMA MATA','gabriel.mata@telefonica.com','MG',null,null,'ATIVO',1)
--,('165716','MARY JANE MARINHO MOREIRA','mary.moreira@telefonica.com','MG',null,null,'ATIVO',1)
--,('162551','ISABELA RIBEIRO LOPES','ISABELA.LOPES@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('89427','JOZAH SILVA ASSUNCAO','jozah.assuncao@telefonica.com','MG',null,null,'ATIVO',1)
--,('98877','RAFAEL OLIVEIRA DE JESUS','rafael.ojesus@telefonica.com','MG',null,null,'ATIVO',1)
--,('166195','FERNANDO MARTINS PATRICIO NETO','fernando.mneto@telefonica.com','MG',null,null,'ATIVO',1)
--,('162394','LAURA ALVARENGA DIBAI MARX','laura.marx@telefonica.com','MG',null,null,'ATIVO',1)
--,('38469','PAULA LIONELLA DE KASSIA CHAVES SOUZA','paula.souza @telefonica.com','MG',null,null,'ATIVO',1)
--,('73969','BRYAN DIMITRY SILVESTRE BALBINO MONTARROYOS SIMOURA','bryan.simoura@telefonica.com','MG',null,null,'ATIVO',1)
--,('87159','LAIZA DE PAULA DOMINGOS','laiza.domingos@telefonica.com','MG',null,null,'ATIVO',1)
--,('90897','ANNE ELISE SOUZA LEMES','anne.lemes@telefonica.com','MG',null,null,'ATIVO',1)
--,('120496','ROSALIA MARIA SILVA TROMBINI','rosalia.trombini@telefonica.com','MG',null,null,'ATIVO',1)
--,('166699','TUANNY CAMILA FREITAS RODRIGUES','tuanny.rodrigues@telefonica.com','MG',null,null,'ATIVO',1)
--,('166656','FERNANDA BARBOSA RODRIGUES DE OLIVEIRA','fernanda.boliveira@telefonica.com','MG',null,null,'ATIVO',1)
--,('166997','LUCAS FELIPE ARAUJO CASTRO','lucas.fcastro@telefonica.com','MG',null,null,'ATIVO',1)
--,('74465','LEONARDO PORTELA DE ALVARENGA','leonardo.alvarenga@telefonica.com','MG',null,null,'ATIVO',1)
--,('139169','THIAGO FERREIRA MARTINS ALVES','thiago.alves@telefonica.com','MG',null,null,'ATIVO',1)
--,('167430','JORGE LUIZ CARDEAL MELO','jorge.lmelo@telefonica.com','MG',null,null,'ATIVO',1)
--,('167297','LUCIANE BAHIA DAS NEVES ROCHA','luciane.rocha@telefonica.com','MG',null,null,'ATIVO',1)
--,('166219','TIAGO CALVET PEREIRA','tiago.cpereira@telefonica.com','MG',null,null,'ATIVO',1)
--,('166645','BERNARDO LUIZ GUIMARAES UMBELINO','bernardo.umbelino@telefonica.com','MG',null,null,'ATIVO',1)
--,('167122','WESLEY GONZAGA OLIMPIO','wesley.olimpio@telefonica.com','MG',null,null,'ATIVO',1)
--,('81753','LUCAS DA SILVA MUNIZ DOS SANTOS','LUCAS.SSANTOS@TELEFONICA.COM','MG',null,null,'ATIVO',1)
--,('167792','GIOVANNA ALVES SOUZA','giovanna.souza@telefonica.com','MG',null,null,'ATIVO',1)


--insert into ACESSO_PERMISSAO_MENU
--select idAcesso,'GERENTE GERAL - LLPP','LOJA' from ACESSO 
--WHERE Regional = 'MG'

--update ACESSO_PERMISSAO_MENU
---- Atualizando as matrículas selecionadas para perfil de suporte
--SET DescricaoMenu = 'SUPORTE', TipoAcesso = 'ADMINISTRATIVO'
--where idAcesso in (
---- Buscando todos os operadores de minas
--select A.IdAcesso from ACESSO A
--LEFT JOIN (select * from DEMANDA_BD_OPERADORES where REGIONAL = 'MG') B ON A.Login = B.MATRICULA
--)

select * from PERFIL_PLATAFORMAS_VIVO

--delete DEMANDA_TIPO_FILA
--WHERE ID_TIPO_FILA IN (162
--,163
--,164
--,165)

select * from DEMANDA_SUB_FILA 

select * from ACESSOS_MOBILE WHERE MATRICULA = 40476
select * from ACESSOS_MOBILE WHERE MATRICULA = 3540476

select * from Demandas.DEMANDA_RELACAO_CHAMADO where ID_RELACAO = '95006513-411e-4f17-af37-08dd1ac3b2dd'

update DEMANDA_RESPONSAVEL_FILA
set MATRICULA_RESPONSAVEL = 3540476 where MATRICULA_RESPONSAVEL = 40476

--update ACESSOS_MOBILE 
--SET REGIONAL = 'MG' , UF = 'MG'
--WHERE MATRICULA = 40476

select * from PERFIL_USUARIO WHERE MATRICULA = 155741
select * from Demandas.DEMANDA_RELACAO_CHAMADO WHERE MATRICULA_SOLICITANTE = 40476
select * from DEMANDA_BD_OPERADORES

--insert into DEMANDA_BD_OPERADORES
--values (168024,'NE',1,'2024-12-11 18:55:47.580', 151191)

select * from ACESSOS_MOBILE where nome like 'joao%' and nome like '%teixeira'

select * from Demandas.DEMANDA_RELACAO_CHAMADO WHERE MATRICULA_SOLICITANTE = 44374
