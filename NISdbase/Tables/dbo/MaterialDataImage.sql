CREATE TABLE [dbo].[MaterialDataImage]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,
    [MaterialDataID] INT NULL, 	
    [ImageBacketRU] NVARCHAR(50) NULL, 	
    [ImageRUGUID] NVARCHAR(50) NULL, 
    [ImageBacketKZ] NVARCHAR(50) NULL, 	
    [ImageKZGUID] NVARCHAR(50) NULL, 	
    [ImageBacketEN] NVARCHAR(50) NULL, 	
    [ImageENGUID] NVARCHAR(50) NULL, 	
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialDataImage] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialDataImage_MaterialData] FOREIGN KEY ([MaterialDataID]) REFERENCES [dbo].[MaterialData] ([ID])
)
