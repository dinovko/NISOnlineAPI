CREATE TABLE [dbo].[QuestionTest]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,
    [QuestionRU] NVARCHAR(MAX) NOT NULL, 
    [QuestionKZ] NVARCHAR(MAX) NULL, 
    [StudySubjectNameID] INT NOT NULL,
    [TestTypeID] INT NOT NULL, 
    [LastModifiedDate] DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_QuestionTest] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_QuestionTest_To_NSIStudySubjectName_StudySubjectNameID] FOREIGN KEY ([StudySubjectNameID]) REFERENCES [dbo].[NSIStudySubjectName] ([ID]),
    CONSTRAINT [FK_QuestionTest_To_NSITestTypes_TestTypeID] FOREIGN KEY ([TestTypeID]) REFERENCES [dbo].[NSITestTypes] ([ID])
)
