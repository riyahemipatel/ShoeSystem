using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCustomerNameCollection
/// </summary>

public class clsOrderCollection
{

    List<clsOrder> mOrderList = new List<clsOrder>();
    clsOrder mThisOrder = new clsOrder();

    public List<clsOrder> OrderList
    {


        get
        {
            //return the private data
            return mOrderList;
        }
        set
        {
            //set the private data
            mOrderList = value;
        }
    }
    public int Count
    //public read only property for the count of records found
    {
        get
        {

            return mOrderList.Count;
        }
        set
        {
            //we shall worry about this later
        }
    }

    public clsOrder ThisOrder
    {
        get
        {
            return mThisOrder;
        }
        set
        {
            mThisOrder = value;
        }

    }


    public clsOrderCollection()
    {
        //DataConnection = new clsDataConnection();
        //DataConnection.AddParameter("@OrderNo", "");//send a surename filter to the query
        //DataConnection.Execute("sproc_tblOrder_FilterByOrderNo");//execute the query

        //object for data connection
        clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure
        DB.Execute("sproc_tblOrder_SelectAll");
        //populate the array
        PopulateArray(DB);

    }


    public Int32 Add()
    ///this function will add a new customer to the database
    ///it accepts a single parameter an object of type clscustomers
    ///once the record is added the function returns the primary key value of the new record
    ///                ///
    ///Insert INTO tblCustomers
    // (OrderNo, CustomerName, CustomerID, PaymentAmount, OrderDate, Active)
    //SELECT
    // @OrderNo, @CustomerName, @CustomerID, @PaymentAmount, @OrderDate, @Active

    {

        //connect to the database
        clsDataConnection NewOrderDB = new clsDataConnection();
        //add the parameters
        NewOrderDB.AddParameter("@OrderNo", mThisOrder.OrderNo);
        NewOrderDB.AddParameter("@CustomerID", mThisOrder.CustomerID);
        NewOrderDB.AddParameter("@CustomerName", mThisOrder.CustomerName);
        NewOrderDB.AddParameter("@PaymentAmount", mThisOrder.PaymentAmount);
        NewOrderDB.AddParameter("@OrderDate", mThisOrder.OrderDate);
        NewOrderDB.AddParameter("@Active", mThisOrder.Active);

        //execute the stored porcedure returning the primary key value of the new record
        return NewOrderDB.Execute("sproc_tblOrder_Insert");
    }


    public void Update()
    {
        
        //--where the CustomerID matches the value of @CustomerID passed as the parameter 
        //WHERE CustomerID=@CustomerID;       {
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //add the parameters
        DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
        DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
        DB.AddParameter("@PaymentAmount", mThisOrder.PaymentAmount);
        DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
        DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
        DB.AddParameter("@Active", mThisOrder.Active);
        //execute the query 
        DB.Execute("sproc_tblOrder_Update");
    }


    void PopulateArray(clsDataConnection DB)
    {
        Int32 RecordCount;  //var to store the count of records
        //public read only property for the count of records found
         Int32 Index = 0; //var to store the index for the loop
        RecordCount = DB.Count;
        mOrderList = new List<clsOrder>();
        
      
        while (Index < RecordCount) //keep looping till all records are processed
        {
        //create a blank page
        clsOrder NewOrder = new clsOrder();
        //copy the data from the table to the RAM
        NewOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
            NewOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
            NewOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
            NewOrder.PaymentAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentAmount"]);
            NewOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
            NewOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
            //add the record to the private data member
            OrderList.Add(NewOrder);
            //point at the next record
            
            Index++;
        }
    }

    public void ReportByOrderNo(string OrderNo)
    {
        //create an instance of the class containing unfiltered results
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create an instance of the filtered data
        clsOrderCollection FilteredOrder = new clsOrderCollection();
        FilteredOrder.ReportByOrderNo("");
        //test to see that the two values are the same
        //Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);

    }

    public void ReportByCustomerID (int CustomerID)
    {
        //filters the records based ona full or partial customerID
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //send the CustomerId parameter to the database
        DB.AddParameter("@CustomerID", CustomerID);
        //execute the stored procedure
        DB.Execute("sproc_tblOrder_FilterByOrderNo");
        //populate the array list with the data table
        PopulateArray(DB);
    }


    public void Delete()
    {
        ///this public funciton provides the functionality for the delete method

        //create an instance of the data connection class called OrderNo
        clsDataConnection MyDatabase = new clsDataConnection();
        //add the PlayerNo parameter passed  to this function to the list of parameters to use in the database
        MyDatabase.AddParameter("@CustomerID", mThisOrder.OrderNo);
        //execute the stored procedure in the database
        MyDatabase.Execute("sproc_tblOrder_Delete");
        //set the return value for the function

    }







}





