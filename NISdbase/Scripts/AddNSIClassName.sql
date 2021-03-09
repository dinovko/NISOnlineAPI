SET IDENTITY_INSERT [dbo].[NSIClassName] ON 
GO 

insert into NSIClassName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(1, N'7 класс', N'7 сынып', '100', '2021-08-01')

insert into NSIClassName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(2, N'8 класс', N'8 сынып', '100', '2021-08-01')

SET IDENTITY_INSERT [dbo].[NSIClassName] OFF 
GO 