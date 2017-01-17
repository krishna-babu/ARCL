CREATE TABLE [dbo].[Players]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[UserId] INT NOT NULL,
    [DOB] DATETIME NULL, 
	[BirthPlace] nvarchar(50) NULL,
    [Role] INT NULL, 
    [BattingStyle] SMALLINT NULL, 
    [BowlineStyle] SMALLINT NULL, 
    [Profile] NVARCHAR(MAX) NULL, 
    [ProfilePic] NVARCHAR(MAX) NULL, 
    [Nickname] NVARCHAR(50) NULL, 
    [Height] INT NULL, 
    [Weight] INT NULL, 
    CONSTRAINT [FK_Players_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
