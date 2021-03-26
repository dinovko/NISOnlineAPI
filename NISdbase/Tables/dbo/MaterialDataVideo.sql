CREATE TABLE [dbo].[MaterialDataVideo]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,	
    [MaterialDataID] INT NULL, 	
    [VideoBacketRU] NVARCHAR(50) NULL, 	
    [VideoRUGUID] NVARCHAR(50) NULL, 
    [VideoBacketKZ] NVARCHAR(50) NULL, 	
    [VideoKZGUID] NVARCHAR(50) NULL, 	
    [VideoBacketEN] NVARCHAR(50) NULL, 	
    [VideoENGUID] NVARCHAR(50) NULL, 	
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialDataVideo] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialDataVideo_MaterialData] FOREIGN KEY ([MaterialDataID]) REFERENCES [dbo].[MaterialData] ([ID])
)
