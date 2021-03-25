CREATE TABLE [dbo].[NSIUsersTypes]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [NameRU]           NVARCHAR (250) NOT NULL,
    [NameKZ]           NVARCHAR (250) NULL,
    [PublicCode]       NVARCHAR (20)  NOT NULL,
    [BeginDate]        DATETIME       NOT NULL,
    [EndDate]          DATETIME       NULL,
    [LastModifiedDate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [IsDel] BIT NULL, 
    CONSTRAINT [PK_NSIUsersTypese] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90)
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Тип пользователя', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'NSIUsersTypes';

