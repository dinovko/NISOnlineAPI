CREATE TABLE [dbo].[Users]
(
	[ID] INT            IDENTITY (1, 1) NOT NULL,
    [Password] NVARCHAR(50) NULL, 
    [UserTypeID] INT NULL, 
    [PersonID] INT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Users_NSIUsersTypes] FOREIGN KEY ([UserTypeID]) REFERENCES [dbo].[NSIUsersTypes] ([ID]),
    CONSTRAINT [FK_Users_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([ID])
)
