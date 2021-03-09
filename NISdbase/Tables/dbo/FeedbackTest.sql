CREATE TABLE [dbo].[FeedbackTest]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [NameFTRU] NVARCHAR(MAX) NULL, 
    [NameFTKZ] NVARCHAR(MAX) NULL, 
    [ImageFT] NVARCHAR(50) NULL, 
    [VideoFT] NVARCHAR(50) NULL, 
    [LinkFT] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_FeedbackTest] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90)
)
