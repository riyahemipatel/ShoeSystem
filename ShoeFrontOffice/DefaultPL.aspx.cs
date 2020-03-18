using System;
using System.Linq;
using System.Web.UI.WebControls;

public partial class DefaultPL : System.Web.UI.Page
{
    //var to store the OrderNo
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //var to store the variable
        //copy the data from the query string to the text box txtJerseyID
        OrderNo = Convert.ToInt32(Request.QueryString["OrderNo"]);

        if (OrderNo != -1)
        {
            if (IsPostBack == false)

                //display all order
                DisplayOrder("");
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //redirect to the add new page
        Response.Redirect("ShoeAdded.aspx?OrderNo=-1");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (ListBoxOrder.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            OrderNo = Convert.ToInt32(ListBoxOrder.SelectedValue);
            //redirect to the editing page
            Response.Redirect("Delete.aspx?OrderNo=" + OrderNo);
        }
        else
        {
            //display an error
            //lblError.Text = "You must select name on the list first to delete it.";
        }

    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        //check the list has been clicked first 

        if (ListBoxOrder.SelectedIndex != -1)
        {

            //get the primary key value from the list box
            OrderNo = Convert.ToInt32(ListBoxOrder.SelectedValue);
            //redirect to the editing page
            Response.Redirect("Edit.aspx?OrderNo=" + OrderNo);
        }
        else
        {
            //display an error
            //lblError.Text = "You must select a name on the list first to edit it.";
        }

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        {
            //display all orders
            DisplayOrder("");
        }
    }

    Int32 DisplayOrder(String SureNameFilter)
    {
        Int32 OrderNo;
        string CustomerName;//var to store the customer name
        DateTime OrderDate;//var to store the order date
        //create an instance of the customer name collection
        clsOrderCollection Order = new clsOrderCollection();
        //Order.ReportByOrderNo(OrderNoFilter);
        Int32 RecordCount;//var to store the count of records
        Int32 Index = 0;//var to store teh index for the loop
        RecordCount = Order.Count;//get the count of records
        ListBoxOrder.Items.Clear();
        while (Index < RecordCount)//while there are records to process
        {

            OrderNo = Order.OrderList[Index].OrderNo;//get the primary key
            CustomerName = Order.OrderList[Index].CustomerName;//get the customer name
            OrderDate = Order.OrderList[Index].OrderDate;//get the order date
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(OrderNo + "" + CustomerName, OrderDate.ToString());
            ListBoxOrder.Items.Add(NewEntry);//add the address to the list                                   
            Index++;//move the index to the next record
        }
        return RecordCount;//return the count of records found


    }

    protected void btnDeleteShoe_Click(object sender, EventArgs e)
    {

    }
}

