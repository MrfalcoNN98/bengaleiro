CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Primeiro_Nome] NCHAR(30) NOT NULL, 
    [Ultimo_Nome] NCHAR(30) NOT NULL, 
    [Numero_de_peças] INT NOT NULL, 
    [Detalhe_de_pecas] TEXT NULL, 
    [Contacto] INT NOT NULL
)
