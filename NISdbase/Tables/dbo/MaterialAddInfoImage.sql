CREATE TABLE [dbo].[MaterialAddInfoImage]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,	
    [MaterialAddInfoID] INT NULL, 	
    [ImageBacketRU] NVARCHAR(50) NULL, 	
    [ImageRUGUID] NVARCHAR(50) NULL, 
    [ImageBacketKZ] NVARCHAR(50) NULL, 	
    [ImageKZGUID] NVARCHAR(50) NULL, 	
    [ImageBacketEN] NVARCHAR(50) NULL, 	
    [ImageENGUID] NVARCHAR(50) NULL, 	
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialAddInfoImage] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialAddInfoImage_MaterialAdditionalInformation] FOREIGN KEY ([MaterialAddInfoID]) REFERENCES [dbo].[MaterialAdditionalInformation] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Материал дополнительная информация картинки', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MaterialAdditionalInformation'
