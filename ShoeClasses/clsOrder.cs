using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCustomers
/// </summary>

public class clsOrder
{

    clsDataConnection DataConnection = new clsDataConnection(); //create a connection to the database
    clsOrder mThisOrder = new clsOrder();

    //JerseyID Private member variable 
    private Int32 mOrderNo;
    //JerseyID public property
    public Int32 OrderNo
    {
        get
        {
            //this line of code send data out of the property 
            return mOrderNo;
        }
        set
        {
            //this line of code allows data into the property
            mOrderNo = value;
        }

    }

    //OrderNo Private member variable 
    private string mCustomerName;
    //OrderNo public property
    public string CustomerName
    {
        get
        {
            //this line of code send data out of the property 
            return mCustomerName;
        }
        set
        {
            //this line of code allows data into the property
            mCustomerName = value;
        }

    }

    //FirstName Private member variable 
    private Int32 mCustomerID;
    //FirstName public property
    public Int32 CustomerID
    {
        get
        {
            //this line of code send data out of the property 
            return mCustomerID;
        }
        set
        {
            //this line of code allows data into the property
            mCustomerID = value;
        }


    }

    //SureName private memeber variable
    private Int32 mPaymentAmount;
    //SureName public property
    public Int32 PaymentAmount
    {
        get
        {
            //this line of code send data out of the property 
            return mPaymentAmount;
        }
        set
        {
            //this line of code allows data into the property
            mPaymentAmount = value;
        }


    }


    //Conference private memeber variable
    private DateTime mOrderDate;
    //Confernce public property
    public DateTime OrderDate
    {
        get
        {
            //this line of code send data out of the property 
            return mOrderDate;
        }
        set
        {
            //this line of code allows data into the property
            mOrderDate = value;
        }


    }

    //Team private memeber variable
    private Boolean mActive;
    //Team public property
    public Boolean Active
    {
        get
        {
            //this line of code send data out of the property 
            return mActive;
        }
        set
        {
            //this line of code allows data into the property
            mActive = value;
        }


    }

    public DateTime DateAdded { get; set; }



    public string Valid(
        Int32 CustomerID,
           DateTime OrderDate,
           Int32 OrderNo,
           Int32 PaymentAmount,
           String CustomerName,
           Boolean Active)

           

    ///this function is used to validate the data in a new order
    /// it accpets six parameter and returns a string containing th etext of the errors (if any)
    /// otherwise of no errors it returns a bkank string
    {

        //string ErrorMsg; //var to store any error message
        //ErrorMsg = ""; //initialise the var with a blank string
        //if the string is less than 1 char or more than 15

        //if (CustomerID.Length < 1 | CustomerID.Length > 15)
        //{

        //    //record an error
        //    ErrorMsg = ErrorMsg + "The player name must be between 1 and 15 characters";
        //}
        ////return any error messaages generated
        //return ErrorMsg;


        //var to store the error message
        string ErrMsg = "";
        //check the min length of the CustomerID
        if (CustomerID == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "CustomerID is blank. ";
        }
        //check the max length of the CustomerName
        if (CustomerName.Length > 16)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Customer Name must be less than 16 characters. ";
        }
        
        
        //check the max length of the OrderNo
        if (OrderNo > 50)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Order No  must be less than 50 characters. ";
        }
        //check the min length for the PaymentAmount
        if (PaymentAmount == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Payment Amount is blank. ";
        }
        

        //test if the date is valid
        
        //if there were no errors
        if (ErrMsg == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors : " + ErrMsg;
        }
    }

    




    //function for the find public method
    public Boolean Find(Int32 OrderNo)
    {
        //initialise the data connection
        DataConnection = new clsDataConnection();
        //add the Jersey no parameter
        DataConnection.AddParameter("@OrderNo", OrderNo);
        //execute the query
        DataConnection.Execute("sproc_tblOrder_FilterByOrderNo");
        //if the record was found
        if (DataConnection.Count == 1)
        {
            //get the OrderNo
            mCustomerID = Convert.ToInt32(DataConnection.DataTable.Rows[0]["CustomerID"]);
            mOrderNo = Convert.ToInt32(DataConnection.DataTable.Rows[0]["OrderNo"]);
            mCustomerName = Convert.ToString(DataConnection.DataTable.Rows[0]["CustomerName"]);
            mOrderDate = Convert.ToDateTime(DataConnection.DataTable.Rows[0]["OrderDate"]);
            mPaymentAmount = Convert.ToInt32(DataConnection.DataTable.Rows[0]["PaymentAmount"]);
            mActive = Convert.ToBoolean(DataConnection.DataTable.Rows[0]["Active"]);


            //return success
            return true;
        }
        else
        {
            //return failure
            return false;
        }
    }

    public bool Find(string customerName)
    {
        throw new NotImplementedException();
    }

    public bool Valid(int customerID, DateTime orderDate, int orderNo, int paymentAmount, string customerName)
    {
        throw new NotImplementedException();
    }
}







