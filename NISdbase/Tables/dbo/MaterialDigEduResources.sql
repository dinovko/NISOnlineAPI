﻿CREATE TABLE [dbo].[MaterialDigEduResources]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,
    [InfoMaterialID] INT NULL, 
    [NameRU] NVARCHAR(50) NULL,
    [NameKZ] NVARCHAR(50) NULL,
    [NameEN] NVARCHAR(50) NULL,
    [Link] NVARCHAR(50) NULL,
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialDigEduResources] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialDigEduResources_InfoMaterialAdd] FOREIGN KEY ([InfoMaterialID]) REFERENCES [dbo].[InfoMaterialAdd] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Материал ЦОР', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MaterialDigEduResources';
