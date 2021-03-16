CREATE TABLE [dbo].[SortTest]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [TestDataTypeID] INT NULL, 
    [SortTypeID] INT NULL, 
    [QuestionRU] NVARCHAR(MAX) NULL, 
    [QuestionKZ] NVARCHAR(MAX) NULL, 
    [IsQuestionStr] BIT NULL, 
    [QuestionImageRU] NVARCHAR(MAX) NULL,  
    [QuestionImageKZ] NVARCHAR(MAX) NULL,  
    [IsQuestionImage] BIT NULL, 
    [QuestionVideoRU] NVARCHAR(MAX) NULL,  
    [QuestionVideoKZ] NVARCHAR(MAX) NULL,  
    [IsQuestionVideo] BIT NULL, 
    [SkillsNameID] INT NULL, 
    [FeedbackTestID] INT NULL, 
    CONSTRAINT [PK_SortTest] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SortTest_TestData] FOREIGN KEY ([TestDataTypeID]) REFERENCES [dbo].[TestData] ([ID]),
    CONSTRAINT [FK_SortTest_NSISkillsName] FOREIGN KEY ([SkillsNameID]) REFERENCES [dbo].[NSISkillsName] ([ID]),
    CONSTRAINT [FK_SortTest_NSISortTypes] FOREIGN KEY ([SortTypeID]) REFERENCES [dbo].[NSISortTypes] ([ID]),
    CONSTRAINT [FK_SortTest_FeedbackTest] FOREIGN KEY ([FeedbackTestID]) REFERENCES [dbo].[FeedbackTest] ([ID])
)
