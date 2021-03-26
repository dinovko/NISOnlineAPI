CREATE TABLE [dbo].[CloseTestAnswer]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [CloseTestID] INT NULL, 
    [AnswerRU] NVARCHAR(MAX) NULL, 
    [AnswerKZ] NVARCHAR(MAX) NULL, 
    [AnswerImageRU] NVARCHAR(MAX) NULL, 
    [AnswerImageKZ] NVARCHAR(MAX) NULL, 
    [IsTrue] BIT NULL, 
    [IsAnswerStr] BIT NULL, 
    [IsAnswerImage] BIT NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_CloseTestAnswer] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_CloseTestAnswer_CloseTest] FOREIGN KEY ([CloseTestID]) REFERENCES [dbo].[CloseTest] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Закрытый тест(ответы)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'CloseTestAnswer';
