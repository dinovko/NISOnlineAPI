CREATE TABLE [dbo].[MaterialData]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [InfoMaterialID] INT NULL, 
    [MaterialNameRU] NVARCHAR(MAX) NULL, 
    [MaterialNameKZ] NVARCHAR(MAX) NULL, 
    [MaterialNameEN] NVARCHAR(MAX) NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialData] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialData_InfoMaterialAdd] FOREIGN KEY ([InfoMaterialID]) REFERENCES [dbo].[InfoMaterialAdd] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Текстовые значения материала', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MaterialData';

