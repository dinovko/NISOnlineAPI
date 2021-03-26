CREATE TABLE [dbo].[BaseTheme]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [InfoMaterialID] INT NULL, 
    [ClassID] INT NULL, 
    [UserID] INT NULL, 
    [SectionNameID] INT NULL, 
    [ThemeNameID] INT NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_BaseTheme] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_BaseTheme_InfoMaterialAdd] FOREIGN KEY ([InfoMaterialID]) REFERENCES [dbo].[InfoMaterialAdd] ([ID]),
    CONSTRAINT [FK_BaseTheme_NSIClassName] FOREIGN KEY ([ClassID]) REFERENCES [dbo].[NSIClassName] ([ID]),
    CONSTRAINT [FK_BaseTheme_NSISectionName] FOREIGN KEY ([SectionNameID]) REFERENCES [dbo].[NSISectionName] ([ID]),
    CONSTRAINT [FK_BaseTheme_NSIThemeName] FOREIGN KEY ([ThemeNameID]) REFERENCES [dbo].[NSIThemeName] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Базовая тема', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BaseTheme';

