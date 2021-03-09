SET IDENTITY_INSERT [dbo].[NSISchool] ON 
GO 

insert into NSISchool(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(1, N'школа №1 ', N'мектеп №1', '100', '2021-08-01')

insert into NSISchool(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(2, N'школа №2 ', N'мектеп №2', '200', '2021-08-01')

SET IDENTITY_INSERT [dbo].[NSISchool] OFF 
GO 