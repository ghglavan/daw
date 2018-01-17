using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Search_Category(object sender, EventArgs e)
    {
        LinkButton b = (sender as LinkButton);
        String command = b.CommandArgument;
        Response.Redirect("NewsSearch.aspx?cat=" + command);
    }
}