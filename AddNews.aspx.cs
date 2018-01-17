using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void AddButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                string title = TitleBox.Text;
                string content = ContentBox.Text;
                string category = CategoryBox.Text;
                
                DateTime pub_date = DateTime.Now;

                var currentUser = Membership.GetUser(User.Identity.Name);
                Guid userID = (Guid)currentUser.ProviderUserKey;

                string query = "INSERT INTO News (title, content, author_id, category, pub_date)"
                    + " VALUES (@title, @content, @user_id, @category, @pub_date)";

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\mssqllocaldb;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

                con.Open();

                try
                {
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("title", title);
                    com.Parameters.AddWithValue("content", content);
                    com.Parameters.AddWithValue("user_id", userID);
                    com.Parameters.AddWithValue("category", category);
                    com.Parameters.AddWithValue("pub_date", pub_date);

                    com.ExecuteNonQuery();

                    // Do this only if insert works:
                    LAnswer.Text = "News added successfully!";

                    TitleBox.Text = "";
                    ContentBox.Text = "";
                }
                catch (Exception ex)
                {
                    LAnswer.Text = "Database insert error : " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (SqlException se)
            {
                LAnswer.Text = "Database connexion error : " + se.Message;
            }
            catch (Exception ex)
            {
                LAnswer.Text = "Data conversion error : " + ex.Message;
            }
        }
    }
}