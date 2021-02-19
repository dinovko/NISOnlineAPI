SET IDENTITY_INSERT [dbo].[NSITestTypes] ON 
GO 

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(1, N'Тест', N'Тест kk', 'Standart', '2021-08-01')

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(2, N'Сортировка', N'Сортировка kk', 'Sort', '2021-08-01')

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(3, N'Drag&drop', N'Drag&drop kk', 'Drag', '2021-08-01')

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(4, N'Ввод в ячейку', N'Ввод в ячейку kk', 'Input', '2021-08-01')

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(5, N'Select', N'Select kk', 'Select', '2021-08-01')

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(6, N'Найди пару', N'Найди пару kk', 'Search', '2021-08-01')

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(7, N'Пазл', N'Пазл kk', 'Puzzle', '2021-08-01')

insert into NSITestTypes(ID, NameRU, NameKZ, PublicCode, BeginDate)
values(8, N'Соответствие (match)', N'Соответствие (match) kk', 'Match', '2021-08-01')

SET IDENTITY_INSERT [dbo].[NSITestTypes] OFF 
GO 
