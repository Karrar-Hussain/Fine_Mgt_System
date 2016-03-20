CREATE TABLE [dbo].[RoomTbl] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [Beds]        INT NULL,
    [Vacancy]     INT NULL,
    [FloorNumber] INT DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

