CREATE TABLE [dbo].[AnswerTest]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,
	[AnswerRU] NVARCHAR(250) NOT NULL, 
    [AnswerKZ] NVARCHAR(250) NULL, 
    [QuestionTestID] INT NOT NULL, 
    [IsTrue] BIT NOT NULL, 
    [LastModifiedDate] DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_AnswerTest] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_AnswerTest_To_QuestionTest_QuestionTestID] FOREIGN KEY ([QuestionTestID]) REFERENCES [dbo].[QuestionTest] ([ID])
)
