CREATE TABLE [dbo].[NSIThemeName]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [NameRU]           NVARCHAR (250) NOT NULL,
    [NameKZ]           NVARCHAR (250) NULL,
    [PublicCode]       NVARCHAR (20)  NOT NULL,
    [BeginDate]        DATETIME       NOT NULL,
    [EndDate]          DATETIME       NULL,
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [IsDel] BIT NULL, 
    [SectionNameID] INT NULL, 
    CONSTRAINT [PK_NSIThemeName] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_NSIThemeName_NSISectionName] FOREIGN KEY ([SectionNameID]) REFERENCES [dbo].[NSISectionName] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Темы', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NSIThemeName';
