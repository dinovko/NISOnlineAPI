CREATE TABLE [dbo].[MaterialAddInfoVideo]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,	
    [MaterialAddInfoID] INT NULL, 	
    [VideoBacketRU] NVARCHAR(50) NULL, 	
    [VideoRUGUID] NVARCHAR(50) NULL, 
    [VideoBacketKZ] NVARCHAR(50) NULL, 	
    [VideoKZGUID] NVARCHAR(50) NULL, 	
    [VideoBacketEN] NVARCHAR(50) NULL, 	
    [VideoENGUID] NVARCHAR(50) NULL, 	
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialAddInfoVideo] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialAddInfoVideo_MaterialAdditionalInformation] FOREIGN KEY ([MaterialAddInfoID]) REFERENCES [dbo].[MaterialAdditionalInformation] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Материал дополнительная информация видео', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MaterialAdditionalInformation'
