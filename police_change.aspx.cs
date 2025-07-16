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
    SqlConnection cd = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

    string s1 = "", s2 = "";

    int count = 100;
    protected void Page_Load(object sender, EventArgs e)
    {
       // Label2.Text = Session["uname"].ToString();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        cd.Open();

        string sdw = "update police1 set pwd='" + TextBox5.Text + "' where pid='"+Session["poid"].ToString()+"'";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();

        Response.Redirect("POLICELOGIN.aspx");
    }
}