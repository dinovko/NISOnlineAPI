CREATE TABLE [dbo].[FeedbackTest]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [NameFTRU] NVARCHAR(MAX) NULL, 
    [NameFTKZ] NVARCHAR(MAX) NULL, 
    [ImageFT] NVARCHAR(50) NULL, 
    [VideoFT] NVARCHAR(50) NULL, 
    [LinkFT] NVARCHAR(50) NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_FeedbackTest] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90)
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Обратная связь', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FeedbackTest';
