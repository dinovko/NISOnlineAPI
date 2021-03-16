SET IDENTITY_INSERT [dbo].[NSISortTypes] ON 
GO 

insert into NSISortTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(1, N'Вертикально', N'Вертикально kk', '100', '2021-08-01')

insert into NSISortTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(2, N'Горизонтально', N'Горизонтально kk', '200', '2021-08-01')

SET IDENTITY_INSERT [dbo].[NSISortTypes] OFF 
GO 