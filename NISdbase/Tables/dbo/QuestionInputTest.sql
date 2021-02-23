CREATE TABLE [dbo].[QuestionInputTest]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,
    [QuestionBeginRU] NVARCHAR(250) NULL, 
    [QuestionEndRU] NVARCHAR(250) NULL, 
    [QuestionBeginKZ] NVARCHAR(250) NULL, 
    [QuestionEndKZ] NVARCHAR(250) NULL,
    [AnswerInputRU] NVARCHAR(250) NULL,
    [AnswerInputKZ] NVARCHAR(250) NULL,
    [StudySubjectNameID] INT NOT NULL,
    [TestTypeID] INT NOT NULL, 
    [LastModifiedDate] DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PKQuestionInputTest] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_QuestionInputTest_To_NSIStudySubjectName_StudySubjectNameID] FOREIGN KEY ([StudySubjectNameID]) REFERENCES [dbo].[NSIStudySubjectName] ([ID]),
    CONSTRAINT [FK_QuestionInputTest_To_NSITestTypes_TestTypeID] FOREIGN KEY ([TestTypeID]) REFERENCES [dbo].[NSITestTypes] ([ID])
)
