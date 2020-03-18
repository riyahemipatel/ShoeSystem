CREATE PROCEDURE sproc_tblOrder_Update
--create the parameters for the stored procedure
	@OrderNo int,
	@CustomerID int,
	@OrderDate datetime,
	@PaymentAmount int,
	@CustomerName nvarchar (50)

AS
	--update the record as a specified by @OrderID value
	update tblOrder
	set OrderNo=@OrderNo,
	OrderDate=@OrderDate
	





