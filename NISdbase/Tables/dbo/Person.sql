CREATE TABLE [dbo].[Person]
(
	[ID] INT            IDENTITY (1, 1) NOT NULL,
    [LastName] NVARCHAR(50) NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [SecondName] NVARCHAR(50) NULL, 
    [IIN] NCHAR(10) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Foto] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90)
)
