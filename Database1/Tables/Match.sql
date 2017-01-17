CREATE TABLE [dbo].[Match]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Team1] INT NOT NULL, 
    [Team2] INT NOT NULL, 
    [MatchDay] DATETIME NULL, 
    [Location] NCHAR(10) NULL, 
    [SeasonId] INT NULL, 
    [Status] SMALLINT NULL, 
    CONSTRAINT [FK_Schedule_Team_1] FOREIGN KEY ([Team1]) REFERENCES [Team]([Id]),
	CONSTRAINT [FK_Schedule_Team_2] FOREIGN KEY ([Team2]) REFERENCES [Team]([Id]),
	CONSTRAINT [FK_Schedule_Season] FOREIGN KEY ([SeasonId]) REFERENCES [Season]([Id])
)
