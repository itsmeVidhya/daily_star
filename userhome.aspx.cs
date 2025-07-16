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
        Label2.Text = Session["uname"].ToString();// +" " + Session["uname1"].ToString(); ;
        Image1.ImageUrl = "re.ashx?id=" + Session["uid"].ToString();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        cd.Open();
        string ss = "select max(cid) from usercase";
        SqlCommand cmd = new SqlCommand(ss, cd);
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read() == true)
        {
            s1 = r[0].ToString();
            if (s1 == "")
            {
                s2 = "GR1" + count;
            }
            else
            {
                s2 = s1.Remove(0,3);
                int i = Convert.ToInt32(s2);
                i++;
                s2 = "GR1" + i;
            }

        }
        r.Close();
        cd.Close();

        string p1 = Session["uid"].ToString();

        string p2 = Session["uname"].ToString();
        string st2 = "NOT";
        string statp = "Your News Submitted..Will Published Soon";
        cd.Open();

        string sss = "insert into usercase values('" + s2.ToString() + "','" + p1.ToString() + "','" + p2.ToString() + "','" + TextBox16.Text + "','" + TextBox16.Text + "','" + TextBox15.Text + "','" + TextBox15.Text + "','" + System.DateTime.Today.ToString("dd/MM/yyyy") + "',@img1,'" + statp.ToString() + "','" + st2.ToString() + "')";

        SqlCommand cmd11 = new SqlCommand(sss, cd);

        byte[] img1 = new byte[FileUpload1.PostedFile.ContentLength];
        FileUpload1.PostedFile.InputStream.Read(img1, 0, FileUpload1.PostedFile.ContentLength);
        cmd11.Parameters.Add("@img1", SqlDbType.Image).Value = img1;


        cmd11.ExecuteNonQuery();
        cd.Close();
        Response.Redirect("user_complaint.aspx");
    }
}