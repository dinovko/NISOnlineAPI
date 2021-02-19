CREATE TABLE [dbo].[StandartTest]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,
    [QuestionRU] NVARCHAR(MAX) NOT NULL, 
    [QuestionKZ] NVARCHAR(MAX) NULL, 
    [Answer_1] NVARCHAR(250) NOT NULL, 
    [Answer_2] NVARCHAR(250) NOT NULL, 
    [Answer_3] NVARCHAR(250) NOT NULL, 
    [Answer_4] NVARCHAR(250) NOT NULL, 
    [StudySubjectNameID] INT NOT NULL, 
    [LastModifiedDate] DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_StandartTest] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_StandartTest_To_NSIStudySubjectName_StudySubjectNameID] FOREIGN KEY ([StudySubjectNameID]) REFERENCES [dbo].[NSIStudySubjectName] ([ID])
)
