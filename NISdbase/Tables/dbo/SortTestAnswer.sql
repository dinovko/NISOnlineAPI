CREATE TABLE [dbo].[SortTestAnswer]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,	
	[SortTestID] INT NULL, 
    [AnswerRU] NVARCHAR(MAX) NULL, 
    [AnswerKZ] NVARCHAR(MAX) NULL, 
    [AnswerImageRU] NVARCHAR(MAX) NULL, 
    [AnswerImageKZ] NVARCHAR(MAX) NULL, 
    [IsTrue] BIT NULL, 
    [KeyNumber] INT NULL,
    [IsAnswerStr] BIT NULL,  
    [IsAnswerImage] BIT NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_SortTestAnswer] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SortTestAnswer_SortTest] FOREIGN KEY ([SortTestID]) REFERENCES [dbo].[SortTest] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Тест Сортировка(ответы)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SortTestAnswer';
