CREATE TABLE [dbo].[Address] (
		id			BIGINT		IDENTITY(1,1)	PRIMARY KEY
	,	street		VARCHAR(50)
	,	city		VARCHAR(50)
	,	[state]		VARCHAR(50)
	,	zipCode		INT
);
GO
