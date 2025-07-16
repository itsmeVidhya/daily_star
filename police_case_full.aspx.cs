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
    SqlConnection cd= new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

    string s1 = "", s2 = "";

    int count = 100;
    protected void Page_Load(object sender, EventArgs e)
    {
      Label2.Text = Session["po2"].ToString();
        c.Open();

        string s11 = "select * from usercase where cid='"+Session["po2"].ToString()+"' order by cid desc";// where sid='"+Session["sid"].ToString()+"'";// where status='" + dd.ToString() + "'";// where grp='" + DropDownList1.SelectedItem.Text + "'";// order by pid desc";// where au='" + TextBox1.Text + "' ";

        SqlDataAdapter daa = new SqlDataAdapter(s11, c);
        DataSet dss1 = new DataSet();
        daa.Fill(dss1);
        DataList1.DataSource = dss1;
        DataList1.DataBind();
        c.Close();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton1_Command(object sender, CommandEventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void Button4_Command(object sender, CommandEventArgs e)
    {

        string gf = "YES";
        cd.Open();

        string sdw = "update usercase set st2='" + gf.ToString() + "' where cid='" + Session["po2"].ToString() + "'";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();
        Response.Redirect("police_file.aspx");
    }
    protected void Button41_Command(object sender, CommandEventArgs e)
    {
        string gf = "YOUR NEWS REJECTED BY THE ADMIN";
        cd.Open();

        string sdw = "update usercase set stat='" + gf.ToString() + "' where cid='" + Session["po2"].ToString() + "'";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();
        Response.Redirect("police_file.aspx");
    }
}