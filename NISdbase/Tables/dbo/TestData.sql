CREATE TABLE [dbo].[TestData]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [ClassID] INT NULL, 
    [SubjectNameID] INT NULL, 
    [UserID] INT NULL, 
    CONSTRAINT [PK_TestData] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_TestData_NSIClassName] FOREIGN KEY ([ClassID]) REFERENCES [dbo].[NSIClassName] ([ID]),
    CONSTRAINT [FK_TestData_NSISubjectName] FOREIGN KEY ([SubjectNameID]) REFERENCES [dbo].[NSISubjectName] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Классификация теста', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TestData';
