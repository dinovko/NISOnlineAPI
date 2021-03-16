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
    CONSTRAINT [PK_SortTestAnswer] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SortTestAnswer_SortTest] FOREIGN KEY ([SortTestID]) REFERENCES [dbo].[SortTest] ([ID])
)
