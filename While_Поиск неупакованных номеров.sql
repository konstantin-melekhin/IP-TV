--/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
--SELECT  [ID]
--      ,[SN]
--      ,[series bar]
--      ,[MAC_Bar]
--      ,[MAC_Print]
--      ,[PrintStationID]
--      ,[IsPrinted]
--      ,[IsPacked]
--      ,[PrintDate]
--      ,[AssemblyWith]
--      ,[LOTID]
--  FROM [FAS].[dbo].[CT_TCC_SN_MAC]
--  where IsPrinted = 0

--  Declare @i int = 90001
--  declare @SN as nvarchar (50)
--  Declare @SNID as int

--while @i <= 99000
--begin
--	select @SN = (select [series bar]  FROM [FAS].[dbo].[CT_TCC_SN_MAC] where ID = @i)
--	select @SNID = (select [ID]  FROM [FAS].[dbo].[Ct_FASSN_reg] where SN = @SN)
		
--	if (select SNID from [FAS].[dbo].[Ct_PackingTable] where LOTID = 20083 and SNID = @SNID) = @SNID
--			begin
--			print 'OK'
--			end;
--			else
--			begin
--			print @SN
--			end;
--	set @i += 1
--end;




--update FAS_SerialNumbers set IsPacked = 1, IsUsed =1, IsUploaded = 1, IsWeighted = 1 where LOTID = 32 and SerialNumber = @i