CREATE TABLE [dbo].[AppUser] (
		id				BIGINT		IDENTITY(1,1)	PRIMARY KEY
	,	nameId			BIGINT						REFERENCES [Name]([Id])
	,	contactId		BIGINT						REFERENCES [Contact]([Id])
	,	addressId		BIGINT						REFERENCES [Address]([Id])
	,	username		VARCHAR(50)	NOT NULL
	,	salt			CHAR(10)	NOT NULL
	,	passwordHash	VARCHAR(50)	NOT NULL
);
GO
