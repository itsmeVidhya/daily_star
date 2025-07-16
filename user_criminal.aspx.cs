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
        //Label2.Text = Session["uname"].ToString();
        if (!IsPostBack)
        {

            cd.Open();
            String s11a = "select * from reporter where rid='" + Session["uid"].ToString() + "'";
            SqlCommand cmd11a = new SqlCommand(s11a, cd);
            SqlDataReader r11a = cmd11a.ExecuteReader();

            if (r11a.Read() == true)
            {

                TextBox1.Text = r11a[1].ToString();
                TextBox11.Text = r11a[2].ToString();
                TextBox8.Text = r11a[3].ToString();
                TextBox3.Text = r11a[4].ToString();
                TextBox2.Text = r11a["email"].ToString();
                
                //Label1.Text = r11a[0].ToString();
                Image1.ImageUrl = "re.ashx?id=" + r11a[0].ToString();

            }
            r11a.Close();
            cd.Close();
        }
       
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        cd.Open();

        string sdw = "update reporter set rname ='" + TextBox1.Text + "',ad='" + TextBox11.Text + "',cno='" + TextBox8.Text + "',desi='" + TextBox3.Text + "',email='" + TextBox2.Text + "' where rid='" + Session["uid"].ToString() + "'";// where pwd='" + f.ToString() + "' and pwd='" + TextBox1.Text + "' ";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();

        Response.Redirect("user_criminal.aspx");
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
    protected void Button69_Click(object sender, EventArgs e)
    {
        cd.Open();

        string sdw = "update reporter set pic= @img where rid='" + Session["uid"].ToString() + "'";
        SqlCommand cmdw = new SqlCommand(sdw, cd);


        byte[] img = new byte[FileUpload1.PostedFile.ContentLength];
        FileUpload1.PostedFile.InputStream.Read(img, 0, FileUpload1.PostedFile.ContentLength);
        cmdw.Parameters.Add("@img", SqlDbType.Image).Value = img;

        cmdw.ExecuteNonQuery();

        cd.Close();
        Response.Redirect("user_criminal.aspx");
    }
}