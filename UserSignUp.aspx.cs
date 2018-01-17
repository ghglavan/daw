using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
  
    }

    protected void CreateUserWizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        try
        {
            Profile.FirstName = TBFirstName.Text;
            Profile.LastName = TBLastName.Text;
            Profile.Birthday = DateTime.Parse(TBBirthday.Text);
            Profile.Gender = int.Parse(RBLGender.SelectedValue);

            int user_type = int.Parse(RBLUType.SelectedValue);
            if (user_type == 0)
            {
                if (!Roles.RoleExists("User"))
                {
                    Roles.CreateRole("User");
                }

                 Roles.AddUserToRole(CreateUserWizard1.UserName, "User");

                Response.Write("This is a user!!");
            }else if (user_type == 1)
            {
                if (!Roles.RoleExists("Editor"))
                {
                    Roles.CreateRole("Editor");
                }
                Response.Write("this is an editor");
                Roles.AddUserToRole(CreateUserWizard1.UserName, "Editor");


            }else if (user_type == 2)
            {
                if (!Roles.RoleExists("Admin"))
                {
                    Roles.CreateRole("Admin");
                }
                Response.Write("This is an admin");
                 Roles.AddUserToRole(CreateUserWizard1.UserName, "Admin");
               
            }
        }
        catch (Exception ex)
        {
            
        }
    }

    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}