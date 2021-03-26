CREATE TABLE [dbo].[MaterialDataGlossary]
(
	[ID] INT IDENTITY (1, 1) NOT NULL,	
    [MaterialDataID] INT NULL, 
    [GlossaryID] INT NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MaterialDataGlossary] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_MaterialDataGlossary_MaterialData] FOREIGN KEY ([MaterialDataID]) REFERENCES [dbo].[MaterialData] ([ID]),
    CONSTRAINT [FK_MaterialDataGlossary_NSIGlossary] FOREIGN KEY ([GlossaryID]) REFERENCES [dbo].[NSIGlossary] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Материал Глоссарий', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MaterialDataGlossary';
