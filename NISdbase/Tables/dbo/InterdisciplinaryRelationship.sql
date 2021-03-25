CREATE TABLE [dbo].[InterdisciplinaryRelationship]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [InfoMaterialID] INT NULL, 
    [ClassID] INT NULL, 
    [SubjectNameID] INT NULL, 
    [UserID] INT NULL, 
    [SectionNameID] INT NULL, 
    [ThemeNameID] INT NULL, 
    CONSTRAINT [PK_InterdisciplinaryRelationship] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_InterdisciplinaryRelationship_InfoMaterialAdd] FOREIGN KEY ([InfoMaterialID]) REFERENCES [dbo].[InfoMaterialAdd] ([ID]),
    CONSTRAINT [FK_InterdisciplinaryRelationship_NSIClassName] FOREIGN KEY ([ClassID]) REFERENCES [dbo].[NSIClassName] ([ID]),
    CONSTRAINT [FK_InterdisciplinaryRelationship_NSISubjectName] FOREIGN KEY ([SubjectNameID]) REFERENCES [dbo].[NSISubjectName] ([ID]),
    CONSTRAINT [FK_InterdisciplinaryRelationship_NSISectionName] FOREIGN KEY ([SectionNameID]) REFERENCES [dbo].[NSISectionName] ([ID]),
    CONSTRAINT [FK_InterdisciplinaryRelationship_NSIThemeName] FOREIGN KEY ([ThemeNameID]) REFERENCES [dbo].[NSIThemeName] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Межпредметная связь', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'InterdisciplinaryRelationship';

