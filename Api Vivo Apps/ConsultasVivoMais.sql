select * from PERFIL_PLATAFORMAS_VIVO

select * from Demandas.DEMANDA_RELACAO_CHAMADO 
WHERE MATRICULA_SOLICITANTE = 67379

select * from ACESSO A 
LEFT JOIN CONTROLE_DE_DEMANDAS_CHAMADO B 
ON A.Login = B.MATRICULA_SOLICITANTE

select * from JORNADA_BD_CARGOS_CANAL

select CAMPO,STATUS_CAMPOS_FILA STATUS from DEMANDA_CAMPOS_FILA WHERE ID_SUB_FILA = 408

select * from JORNADA_BD_HIERARQUIA where canal is null

select DISTINCT(CANAL) from JORNADA_BD_HIERARQUIA 

--update JORNADA_BD_HIERARQUIA set CANAL = 'REVENDA' WHERE CANAL is null
--update DEMANDA_BD_OPERADORES set MATRICULA = 3529381 where MATRICULA = 29381
--update DEMANDA_RESPONSAVEL_FILA set MATRICULA_RESPONSAVEL = 3529381 where MATRICULA_RESPONSAVEL = 29381

select * from DEMANDA_SUB_FILA A
LEFT JOIN DEMANDA_CAMPOS_FILA B
ON A.ID_SUB_FILA = B.ID_SUB_FILA
WHERE B.STATUS_CAMPOS_FILA = 0 and A.STATUS_SUB_FILA = 1

select * from ACESSOS_MOBILE where matricula = 161310

select * from Demandas.__EFMigrationsHistory

--ALTER TABLE ACESSOS_MOBILE
--DROP CONSTRAINT DF__ACESSOS_M__NOME___61D2EC77;

--Alter table ACESSOS_MOBILE DROP COLUMN NOME_SOCIAL



--UPDATE ACESSOS_MOBILE
--SET NOME_SOCIAL = 
--    LEFT(NOME, CHARINDEX(' ', NOME + ' ') - 1) + ' ' + 
--    RIGHT(NOME, LEN(NOME) - CHARINDEX(' ', REVERSE(NOME)))
--WHERE NOME IS NOT NULL AND CHARINDEX(' ', NOME) > 0;




--delete ACESSOS_MOBILE WHERE ID = 4930
--update ACESSOS_MOBILE SET NOME_SOCIAL = '-' 
--WHERE NOME_SOCIAL IS NULL OR NOME_SOCIAL = NULL