/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
--  INSERT INTO CT_TCC_SN_MAC ([series bar], [MAC_Bar], [MAC_Print])
--SELECT [series bar], [MAC_Bar], [MAC_Print]
--FROM dbo.[PO144_Z123-50_100K_CKD_20201013-1]

use fas
-- SELECT  rt.[ID],rt.sn,[series bar],[MAC_Bar],[MAC_Print],[PrintStationID],[IsPrinted],[IsPacked],[PrintDate],reg.id,p.PackingDate
--FROM [FAS].[dbo].[CT_TCC_SN_MAC] as Rt 
--left join Ct_FASSN_reg as Reg On Reg.SN = Rt.[series bar]
--left join Ct_PackingTable as P On P.SNID = reg.id
-- where [IsPrinted] = 0 --p.PackingDate is not null
-- order by rt.id
 --ALTER TABLE [FAS].[dbo].[CT_TCC_SN_MAC]   ADD CONSTRAINT PK_TCC_SN_ID PRIMARY KEY CLUSTERED (ID)
 --ALTER TABLE [FAS].[dbo].[CT_TCC_SN_MAC]  ADD SN AS (Right([series bar],9));
 --update [FAS].[dbo].[CT_TCC_SN_MAC] set [IsPrinted] =1,[IsPacked]=1, [PrintDate] = '2020-10-14' where id in(

 use fas SELECT [ID],[SN],[series bar],[MAC_Bar],[MAC_Print],[PrintStationID],[IsPrinted],[IsPacked],[PrintDate]
FROM [FAS].[dbo].[CT_TCC_SN_MAC] --where [series bar] = 'Z12300502032010009448212'
--SELECT top 1 [series bar] FROM [FAS].[dbo].[CT_TCC_SN_MAC] where IsPrinted = 0
--use FAS  
--declare @SerialNumber nvarchar(24)  
--select @SerialNumber = (SELECT top 1 [series bar] FROM [FAS].[dbo].[CT_TCC_SN_MAC] where IsPrinted = 0)  
--Update [FAS].[dbo].[CT_TCC_SN_MAC] Set  IsPrinted  = 1, PrintStationID = 1,[PrintDate] = CURRENT_TIMESTAMP  where [series bar] = @SerialNumber
--WAITFOR delay '00:00:00:100'
--select [ID],[SN],[series bar],[MAC_Bar],[MAC_Print],[PrintStationID],[IsPrinted],[IsPacked],[PrintDate] 
--from [FAS].[dbo].[CT_TCC_SN_MAC] where [series bar] = @SerialNumber and PrintStationID = 1
--Update [FAS].[dbo].[CT_TCC_SN_MAC] Set  IsPrinted  = 0, PrintStationID = NULL,[PrintDate] = NULL  where [series bar] = 'Z12300502032010009448212'
--Update [FAS].[dbo].[CT_TCC_SN_MAC] Set  IsPrinted  = 0, PrintStationID = NULL,[PrintDate] = NULL  where [series bar] = 'Z12300502032010009448254'
--Update [FAS].[dbo].[CT_TCC_SN_MAC] Set  IsPrinted  = 0, PrintStationID = NULL,[PrintDate] = NULL  where [series bar] = 'Z12300502032010009448255'
--Update [FAS].[dbo].[CT_TCC_SN_MAC] Set  IsPrinted  = 0, PrintStationID = NULL,[PrintDate] = NULL  where [series bar] = 'Z12300502032010009448287'
