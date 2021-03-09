CREATE TABLE [dbo].[TestData]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [ClassID] INT NULL, 
    [SubjectNameID] INT NULL, 
    [SectionNameID] INT NULL, 
    [ThemeNameID] INT NULL, 
    CONSTRAINT [PK_TestData] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_TestData_NSIClassName] FOREIGN KEY ([ClassID]) REFERENCES [dbo].[NSIClassName] ([ID]),
    CONSTRAINT [FK_TestData_NSISubjectName] FOREIGN KEY ([SubjectNameID]) REFERENCES [dbo].[NSISubjectName] ([ID]),
    CONSTRAINT [FK_TestData_NSISectionName] FOREIGN KEY ([SectionNameID]) REFERENCES [dbo].[NSISectionName] ([ID]),
    CONSTRAINT [FK_TestData_NSIThemeName] FOREIGN KEY ([ThemeNameID]) REFERENCES [dbo].[NSIThemeName] ([ID])
)
