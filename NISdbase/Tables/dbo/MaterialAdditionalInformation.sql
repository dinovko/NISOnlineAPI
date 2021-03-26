CREATE TABLE [dbo].[MaterialAdditionalInformation]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [InfoMaterialID] INT NULL, 
    [MaterialNameRU] NVARCHAR(MAX) NULL, 
    [MaterialNameKZ] NVARCHAR(MAX) NULL, 
    [MaterialNameEN] NVARCHAR(MAX) NULL, 
    [Link] NVARCHAR(50) NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialAdditionalInformation] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialAdditionalInformation_InfoMaterialAdd] FOREIGN KEY ([InfoMaterialID]) REFERENCES [dbo].[InfoMaterialAdd] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Материал дополнительная информация', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MaterialAdditionalInformation'