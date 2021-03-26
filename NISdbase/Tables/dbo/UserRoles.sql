CREATE TABLE [dbo].[UserRoles]
(
	[ID] INT            IDENTITY (1, 1) NOT NULL,
    [UserID] INT NULL, 
    [RoleID] INT NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID]),
    CONSTRAINT [FK_UserRoles_NSIRoles] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[NSIRoles] ([ID])
)
