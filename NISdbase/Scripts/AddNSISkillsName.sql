SET IDENTITY_INSERT [dbo].[NSISkillsName] ON 
GO 

insert into NSISkillsName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(1, N'навык 1', N'навык 1 kk', '100', '2021-08-01')

insert into NSISkillsName(NameRU, NameKZ, PublicCode, BeginDate)
values(2, N'навык 2', N'навык 2 kk', '200', '2021-08-01')

SET IDENTITY_INSERT [dbo].[NSISkillsName] OFF 
GO 