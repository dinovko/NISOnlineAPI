SET IDENTITY_INSERT [dbo].[NSISubjectName] ON 
GO 

insert into NSISubjectName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(1, N'Физика', N'Физика kk', 'Physics', '2021-08-01')

insert into NSISubjectName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(2, N'Химия', N'Химия kk', 'Chemistry', '2021-08-01')

insert into NSISubjectName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(3, N'Биология', N'Биология kk', 'Biology', '2021-08-01')

SET IDENTITY_INSERT [dbo].[NSISubjectName] OFF 
GO 