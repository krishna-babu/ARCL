CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [CreatedDate] DATETIME NULL, 
    [Picture] IMAGE NULL
)
