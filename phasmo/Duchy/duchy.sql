CREATE TABLE [dbo].[duchy]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nazwa] NTEXT NOT NULL, 
    [Opis] NTEXT NOT NULL, 
    [Slabosc] NTEXT NOT NULL, 
    [Moc] NTEXT NOT NULL, 
    [Dowody] NTEXT NOT NULL
)
