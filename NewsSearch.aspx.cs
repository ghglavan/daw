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
        if (!Page.IsPostBack && Request.Params["q"] != null)
        {
            string query = Server.UrlDecode(Request.Params["q"]);

            SDSSearch.SelectCommand = "SELECT * FROM News_v"
                + " WHERE title LIKE @q";

            SDSSearch.SelectParameters.Clear();
            SDSSearch.SelectParameters.Add("q", "%" + query + "%");
            SDSSearch.DataBind();
        } else if (!Page.IsPostBack && Request.Params["cat"] != null)
        {
            string query = Server.UrlDecode(Request.Params["cat"]);

            SDSSearch.SelectCommand = "SELECT * FROM News_v"
                + " WHERE category LIKE @q";

            SDSSearch.SelectParameters.Clear();
            SDSSearch.SelectParameters.Add("q", query);
            SDSSearch.DataBind();
        }
    }

    protected void Search_Category(object sender, EventArgs e)
    {
        LinkButton b = (sender as LinkButton);
        String command = b.CommandArgument;
        Response.Redirect("NewsSearch.aspx?cat=" + command);
    }
}