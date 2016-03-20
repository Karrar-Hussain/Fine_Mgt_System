CREATE TABLE [dbo].[RoomTbl] (
    [Id]          INT PRIMARY KEY identity(1,1),
    [Beds]        INT NULL,
    [Vacancy]     INT NULL,
    [FloorNumber] INT DEFAULT ((1)) NULL,
    
);

