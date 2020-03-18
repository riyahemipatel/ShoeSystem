CREATE PROCEDURE sproc_tblOrder_Delete
--this stored procedure is used to delete a single record in the table tblOrder
--it accepts a single parameter @OrderNo and returns no value

	--declare the parameter
	@OrderNo int
AS
--delete the record in tblOrder specified by the value of @OrderNo
delete from tblOrder where OrderNo = @OrderNo

RETURN 0

