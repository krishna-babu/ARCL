CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
	[LastName] NVARCHAR(50) NULL, 
    [CreatedDate] DATETIME NULL, 
    [FullPhotoUrl] NVARCHAR(MAX) NULL, 
    [Address1] NVARCHAR(MAX) NULL, 
    [Address2] NVARCHAR(MAX) NULL, 
    [City] NCHAR(10) NULL, 
    [State] NCHAR(10) NULL, 
    [Mobile] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [FederationIdentifier] NVARCHAR(50) NULL, 
	[Password] NVARCHAR(MAX) NULL,
    [IsActive] BIT NULL, 
    [LastLoginDate] DATETIME NULL
)
