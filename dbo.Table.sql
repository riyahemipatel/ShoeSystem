CREATE TABLE [dbo].[tblOrder] (
    [OrderNo]  INT           IDENTITY (1, 1) NOT NULL,
    [CustomerID]   INT  NULL,
    [CustomerName]    NVARCHAR (50) NULL,
    [OrderDate]     DATETIME  NULL,
    [PaymentAmount] INT NULL,
    [Active] BIT NULL,
    
    PRIMARY KEY CLUSTERED ([OrderNo] ASC)
);

