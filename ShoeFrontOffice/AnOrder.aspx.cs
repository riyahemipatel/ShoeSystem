using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    public int OrderNo { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            //populate the list of coutnies
            DisplayCounties();
        }
    }

    private void DisplayCounties()
    {
        throw new NotImplementedException();
    }
}