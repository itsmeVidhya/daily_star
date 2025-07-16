using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class ABOUT : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

    string s1 = "", s2 = "";

    int count = 100;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        c.Open();
        String s11a = "select * from donor where em='" + TextBox12.Text + "' and pwd='" + TextBox13.Text + "'";
        SqlCommand cmd11a = new SqlCommand(s11a, c);
        SqlDataReader r11a = cmd11a.ExecuteReader();

        if (r11a.Read() == true)
        {
            Session["uid"] = r11a[0].ToString();
            Session["uname"] = r11a[2].ToString();
            // Session["name123"] = r11a[2].ToString();

            Response.Redirect("userhome.aspx");
        }
        else
        {
            Label1.Visible = true;
        }
        r11a.Close();
        c.Close();
    }
}