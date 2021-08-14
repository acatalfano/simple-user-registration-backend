CREATE TABLE [dbo].[Address] (
		id			UNIQUEIDENTIFIER	PRIMARY KEY
	,	street		VARCHAR(50)
	,	city		VARCHAR(50)
	,	[state]		VARCHAR(50)
	,	zipCode		INT
);
GO
