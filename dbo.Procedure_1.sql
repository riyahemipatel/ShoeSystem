CREATE PROCEDURE sproc_tblOrder_Update
--create the parameters for the stored procedure
@CustomerName char (15),
@OrderDate char (10),
@OrderNo int,
@PaymentAmount int,
@CustomerID int,

AS
--update the record as specified by @OrderNo value
update tblOrder 
set CustomerName=@CustomerName,
OrderDate=@OrderDate,
OrderNo=@OrderNo,
PaymentAmount=@PaymentAmount
CustomerID=@CustomerID

where OrderNo=@OrderNo 
	
