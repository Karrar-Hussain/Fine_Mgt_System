CREATE TABLE [dbo].[WardenTbl] (
    [Id]             INT          NOT NULL,
    [RoomId]         INT          NOT NULL,
    [LoginId]        VARCHAR (15) NOT NULL,
    [Designation]    VARCHAR (20) NULL,
    [OfficeLocation] VARCHAR (20) NOT NULL,
    [Password]       VARCHAR (12) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[PersonTbl] ([Id]) ON DELETE CASCADE,
    FOREIGN KEY ([RoomId]) REFERENCES [dbo].[RoomTbl] ([Id]) ON DELETE CASCADE
);

