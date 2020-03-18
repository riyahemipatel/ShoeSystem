using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Delete : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the text box txtCustomerID
        OrderNo = Convert.ToInt32(Request.QueryString["OrderNo"]);
    }

    void DeleteOrder()
    {
        //function to delete the record
        //create a new instance of the order book 
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to delete
        OrderBook.ThisOrder.Find(OrderNo);
        //delete the record
        OrderBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrder();
        //redirect back to the main page
        Response.Redirect("DefaultPL.aspx");
    }



    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultPL.aspx");
    }
}