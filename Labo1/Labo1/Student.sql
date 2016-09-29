CREATE TABLE [dbo].[Student]
		(
			[Id] BIGINT NOT NULL PRIMARY KEY,
			[Birthdate] DATE NOT NULL,
			[FullName] VARCHAR(60) NOT NULL,
			[Remark] VARCHAR(60) NOT NULL
		)
