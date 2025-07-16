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
    SqlConnection cd = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

    string s1 = "", s2 = "";

    int count = 100;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            c.Open();
            String s11a = "select * from police1 where pid='" + Session["p1"].ToString() + "'";
            SqlCommand cmd11a = new SqlCommand(s11a, c);
            SqlDataReader r11a = cmd11a.ExecuteReader();

            if (r11a.Read() == true)
            {
                
                TextBox1.Text = r11a[1].ToString();
                TextBox17.Text = r11a[2].ToString();
                TextBox13.Text = r11a[3].ToString();
                TextBox3.Text = r11a[4].ToString();
                TextBox14.Text = r11a[5].ToString();
                TextBox15.Text = r11a[6].ToString();
                TextBox16.Text = r11a[7].ToString();
                Label1.Text = r11a[0].ToString();
               Image1.ImageUrl = "pol.ashx?id=" + r11a[0].ToString();

            }
            r11a.Close();
            c.Close();
        }
       
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        cd.Open();

        string sdw = "update police1 set pname ='" + TextBox1.Text + "',loc='" + TextBox17.Text + "',ad='" + TextBox15.Text + "',email='" + TextBox16.Text + "',ph='" + TextBox13.Text + "',staf='" + TextBox3.Text + "',stafno='" + TextBox14.Text + "' where pid='" + Session["p1"].ToString() + "'";// where pwd='" + f.ToString() + "' and pwd='" + TextBox1.Text + "' ";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();

        Response.Redirect("admin_view_police1.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        cd.Open();

        string sdw = "update police1 set pic= @img where pid='" + Session["p1"].ToString() + "'";
        SqlCommand cmdw = new SqlCommand(sdw, cd);

   
        byte[] img = new byte[FileUpload1.PostedFile.ContentLength];
        FileUpload1.PostedFile.InputStream.Read(img, 0, FileUpload1.PostedFile.ContentLength);
        cmdw.Parameters.Add("@img", SqlDbType.Image).Value = img;

        cmdw.ExecuteNonQuery();

        cd.Close();
        Response.Redirect("admin_view_police1.aspx");
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
}