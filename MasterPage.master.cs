using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.User.IsInRole("Admin"))
        {
            UpdateUsers.Visible = true;
        } else if (Page.User.IsInRole("Editor"))
        {
            AddNews.Visible = true;
        }
    }
    protected void BSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewsSearch.aspx?q=" + Server.UrlEncode(TBSearch.Text));
    }
}
