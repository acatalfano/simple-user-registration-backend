CREATE TABLE [dbo].[appUser] (
		id				UNIQUEIDENTIFIER	PRIMARY KEY
	,	nameId			UNIQUEIDENTIFIER	REFERENCES [Name]([Id])
	,	contactId		UNIQUEIDENTIFIER	REFERENCES [Contact]([Id])
	,	addressId		UNIQUEIDENTIFIER	REFERENCES [Address]([Id])
	,	username		VARCHAR(50)			NOT NULL
	,	salt			CHAR(10)			NOT NULL
	,	passwordHash	VARCHAR(50)			NOT NULL
);
GO
