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
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

    string s1 = "", s2 = "";

    int count = 100;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Label2.Text = Session["poname"].ToString();
       // ImageButton3.ImageUrl = "pol.ashx?id=" +Session["poid"].ToString();
        c.Open();
        String s11a = "select * from usercase where cid='" + Session["ad1"].ToString() + "'";
        SqlCommand cmd11a = new SqlCommand(s11a, c);
        SqlDataReader r11a = cmd11a.ExecuteReader();

        if (r11a.Read() == true)
        {
            Label2.Text = r11a["cid"].ToString() + "," + r11a["uname"].ToString(); ;
   
            Label9.Text = r11a["ad"].ToString();
            //Label11.Text = r11a["cono"].ToString();
            Label8.Text = r11a["dat"].ToString();
            Label12.Text = r11a["msg"].ToString();
            Label13.Text = r11a["stat"].ToString();
            ImageButton3.ImageUrl = "user.ashx?id=" + r11a["uid"].ToString();
            ImageButton4.ImageUrl = "user1.ashx?id=" + r11a["cid"].ToString();

        }
        r11a.Close();
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
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton1_Command1(object sender, CommandEventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        Session["po2"] = e.CommandArgument.ToString();
        Response.Redirect("police_case_full.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        cd.Open();

        string sdw = "update usercase set stat ='" + TextBox8.Text + "' where cid='" + Session["ad1"].ToString() + "'";// where pwd='" + f.ToString() + "' and pwd='" + TextBox1.Text + "' ";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();

        Response.Redirect("admin_case.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        string gp = "police";
        cd.Open();

        string sdw = "update usercase set st2 ='" + gp.ToString() + "' where cid='" + Session["ad1"].ToString() + "'";// where pwd='" + f.ToString() + "' and pwd='" + TextBox1.Text + "' ";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();

        Response.Redirect("admin_case.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        cd.Open();

        string sdw = "delete from usercase where cid='" + Session["ad1"].ToString() + "'";// where aid='" + Session["aid"].ToString() + "'";// where pwd='" + f.ToString() + "' and pwd='" + TextBox1.Text + "' ";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();

        Response.Redirect("admin_case.aspx");
    }
}