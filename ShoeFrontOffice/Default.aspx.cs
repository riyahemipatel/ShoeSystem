using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private object lstOrder;

    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrder();
        }

    }

    private void DisplayOrder()
        //create an instance of the county collection
        Class_Library.clsOrderCollection OrderCollection = new Class_Library.clsOrderCollection();
    //set the data source to the list of counties in the collection
    lstOrder.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrder.DataValueField = "OrderNo";
        //set the data field to display
        lstOrder.DataTextField = "CustomerID";
        //bind the data to the list
        lstOrder.DataBind();



    public void DisplayOrder()
    {
        throw new NotImplementedException();
    }
}