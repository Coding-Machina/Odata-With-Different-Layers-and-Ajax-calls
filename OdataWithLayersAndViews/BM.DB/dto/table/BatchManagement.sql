CREATE TABLE [dbo].[BatchManagement]
(
	[BatchId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [BatchName] VARCHAR(10) NULL, 
    [TotalHours] INT NULL, 
    [HoursTaken] INT NULL
)
