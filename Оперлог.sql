--Use FAS select tt.PCBID,L.Content, tt.SNID, Rg.SN, tt.StepID,tt.TestResultID 
--from  (SELECT *, ROW_NUMBER() over(partition by pcbid order by stepdate desc) num FROM [FAS].[dbo].[Ct_OperLog]) tt
--left join Ct_FASSN_reg Rg On Rg.ID = tt.SNID
--Left join SMDCOMPONETS.dbo.LazerBase L On L.IDLaser = tt.PCBID
--where tt.LOTID = 20083 and  tt.num = 1 and Content in (
--'3004258GSB62200060565'
--)

Use FAS select tt.PCBID,L.Content, tt.SNID, Rg.SN, tt.StepID,tt.TestResultID ,tt.num
from  (SELECT *, ROW_NUMBER() over(partition by pcbid order by stepdate desc) num FROM [FAS].[dbo].[Ct_OperLog]) tt
left join Ct_FASSN_reg Rg On Rg.ID = tt.SNID
Left join SMDCOMPONETS.dbo.LazerBase L On L.IDLaser = tt.PCBID
left join Ct_FASSN_reg R On R.ID = tt.SNID 
where tt.LOTID = 20083 and R.SN in 
(
'Z12300502043010009764346',
'Z12300502043010009764374',
'Z12300502043010009764373',
'Z12300502043010009764372',
'Z12300502043010009764350',
'Z12300502043010009764470',
'Z12300502043010009764352',
'Z12300502043010009764377',
'Z12300502043010009764348',
'Z12300502043010009764376',
'Z12300502043010009764369',
'Z12300502043010009764472',
'Z12300502043010009764353',
'Z12300502043010009764367',
'Z12300502043010009764351',
'Z12300502043010009764471',
'Z12300502043010009764347',
'Z12300502043010009764369',
'Z12300502043010009764375',
'Z12300502043010009764349')

--delete  [FAS].[dbo].[Ct_OperLog] where PCBID in (3156078,
--3156083,
--3156074,
--3156077,
--3156071,
--3156070,
--3156066,
--3156068,
--3156081,
--3156072,
--3156082,
--3156069,
--3156065,
--3156067,
--3156076,
--3156073,
--3156080,
--3156084,
--3156075,
--3156085)