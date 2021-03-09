CREATE TABLE [dbo].[TestDataTypes]
(
	[ID]               INT            IDENTITY (1, 1) NOT NULL,
    [TestDataID] INT NULL, 
    [TestTypeID] INT NULL, 
    CONSTRAINT [PK_TestDataTypes] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_TestDataTypes_TestData] FOREIGN KEY ([TestDataID]) REFERENCES [dbo].[TestData] ([ID]),
    CONSTRAINT [FK_TestDataTypes_NSITestTypes] FOREIGN KEY ([TestTypeID]) REFERENCES [dbo].[NSITestTypes] ([ID])
)
