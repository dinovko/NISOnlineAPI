CREATE TABLE [dbo].[SchoolboyUsers]
(
	[ID] INT            IDENTITY (1, 1) NOT NULL,
    [UserID] INT NULL, 
    [ClassID] INT NULL, 
    [LanguageLearningID] INT NULL, 
    [SchoolID] INT NULL, 
    CONSTRAINT [PK_SchoolboyUsers] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SchoolboyUsers_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID]),
    CONSTRAINT [FK_SchoolboyUsers_NSIClassName] FOREIGN KEY ([ClassID]) REFERENCES [dbo].[NSIClassName] ([ID]),
    CONSTRAINT [FK_SchoolboyUsers_NSILanguageLearning] FOREIGN KEY ([LanguageLearningID]) REFERENCES [dbo].[NSILanguageLearning] ([ID]),
    CONSTRAINT [FK_SchoolboyUsers_NSISchool] FOREIGN KEY ([SchoolID]) REFERENCES [dbo].[NSISchool] ([ID])
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Школьники(юзеры)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SchoolboyUsers';
