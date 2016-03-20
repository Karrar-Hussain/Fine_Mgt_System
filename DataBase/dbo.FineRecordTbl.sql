CREATE TABLE [dbo].[FineRecordTbl] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [StudentId]  INT      NOT NULL,
    [WardenId]   INT      NOT NULL,
    [Amount]     INT      DEFAULT ((0)) NOT NULL,
    [FineDate]   DATETIME NOT NULL,
    [DueDate]    DATETIME NOT NULL,
    [FineDetail] TEXT     NOT NULL,
    [Charges]    INT      DEFAULT ((0)) NOT NULL,
    [SMSsent]    TINYINT  DEFAULT ((1)) NOT NULL,
    [IsPaid]     TINYINT  DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([StudentId]) REFERENCES [dbo].[StudentTbl] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([WardenId]) REFERENCES [dbo].[WardenTbl] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
CREATE TRIGGER [Trigger]
	ON [dbo].[FineRecordTbl]
	FOR  INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON
	END