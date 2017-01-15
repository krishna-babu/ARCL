CREATE TABLE [dbo].[Season]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [CreatedDate] DATETIME NULL
)
