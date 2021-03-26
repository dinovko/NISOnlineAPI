CREATE TABLE [dbo].[RoleRights]
(
	[ID] INT            IDENTITY (1, 1) NOT NULL,
    [RoleID] INT NULL, 
    [RightID] INT NULL, 
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_RoleRights] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_RoleRights_NSIRoles] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[NSIRoles] ([ID]),
    CONSTRAINT [FK_RoleRights_NSIRights] FOREIGN KEY ([RightID]) REFERENCES [dbo].[NSIRights] ([ID])
)
