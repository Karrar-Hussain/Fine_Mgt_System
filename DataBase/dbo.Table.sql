CREATE TABLE [PersonTbl]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [First Name] NCHAR(15) NOT NULL, 
    [Last Name] NCHAR(15) NULL, 
    [Contact] VARCHAR(15) NULL, 
    [Address] NCHAR(80) NULL, 
    [PType] TINYINT NOT NULL DEFAULT 0, 
    [CNIC] NCHAR(15) NOT NULL
)
