SET IDENTITY_INSERT [dbo].[NSIStudySubjectName] ON 
GO 

insert into NSIStudySubjectName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(1, N'Физика', N'Физика kk', 'Physics', '2021-08-01')

insert into NSIStudySubjectName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(2, N'Химия', N'Химия kk', 'Chemistry', '2021-08-01')

insert into NSIStudySubjectName(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(3, N'Биология', N'Биология kk', 'Biology', '2021-08-01')

SET IDENTITY_INSERT [dbo].[NSIStudySubjectName] OFF 
GO 