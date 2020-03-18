CREATE PROCEDURE [dbo].sproc_tblOrder_Delete
--this stored procedure is situated in the data layer (App_Data folder)
--this stored procedure is used to delete a single record in the table tblOrder
--it accpets a single parameter @OrderNo and returns no value
--declare the parameter
@OrderNo int
AS
--delete the record in tblOrder specified by the value of @OrderNo
delete from tblOrder where OrderNo = @OrderNo 
	
