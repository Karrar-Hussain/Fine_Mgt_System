CREATE TABLE [dbo].[PersonTbl] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [First Name] NCHAR (15)   NOT NULL,
    [Last Name]  NCHAR (15)   NULL,
    [CNIC]       NCHAR (15)   NOT NULL,
    [Contact]    VARCHAR (15) NULL,
    [Email]      VARCHAR (50) NOT NULL,
    [Address]    NCHAR (80)   NULL,
    [PType]      TINYINT      DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

