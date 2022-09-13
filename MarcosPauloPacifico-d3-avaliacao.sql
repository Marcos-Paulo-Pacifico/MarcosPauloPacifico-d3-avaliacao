-- Define qual banco de dados será utilizado
USE [db_17];
GO

-- Cria a tabela Users
CREATE TABLE Users(
	IdUser		    VARCHAR(255) NOT NULL UNIQUE,
	[Name]			VARCHAR(255) NOT NULL,
	[Email]			VARCHAR(255) NOT NULL,
	[Password]		VARCHAR(255) NOT NULL
);
GO

-- Lista os dados da tabela
SELECT * FROM Users;
GO

INSERT INTO Users(IdUser, [Name], [Email], [Password])
VALUES				 ('46773450829', 'Marcos Paulo Pacifico', 'admin@email.com', 'admin123');
GO