CREATE TABLE [dbo].[StudentTbl] (
    [Id]              INT          NOT NULL,
    [RoomId]          INT          NULL,
    [RollNo]          VARCHAR (7)  NOT NULL,
    [GuardianName]    VARCHAR (50) NOT NULL,
    [GuardianContact] VARCHAR (15) NOT NULL,
    [GuardianEmail]   VARCHAR (50) NULL,
    [Relation]        VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([RollNo] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[PersonTbl] ([Id]),
    FOREIGN KEY ([RoomId]) REFERENCES [dbo].[RoomTbl] ([Id])
);

