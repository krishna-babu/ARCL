﻿CREATE TABLE [dbo].[Teams]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [BannerMessage] VARCHAR(MAX) NULL, 
    [Logo] IMAGE NULL, 
    [CreatedDate] DATETIME NULL
)
