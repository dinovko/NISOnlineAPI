CREATE TABLE [dbo].[CloseTestAnswer]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [CloseTestID] INT NULL, 
    [AnswerRU] NVARCHAR(MAX) NULL, 
    [AnswerKZ] NVARCHAR(MAX) NULL, 
    [AnswerImage] NVARCHAR(MAX) NULL, 
    [IsTrue] BIT NULL, 
    [IsAnswerStr] BIT NULL, 
    [IsAnswerImage] BIT NULL, 
    CONSTRAINT [PK_CloseTestAnswer] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_CloseTestAnswer_CloseTest] FOREIGN KEY ([CloseTestID]) REFERENCES [dbo].[CloseTest] ([ID])
)
