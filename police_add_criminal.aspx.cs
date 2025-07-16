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
        Label2.Text = Session["poname"].ToString();
        Image1.ImageUrl = "pol.ashx?id=" +Session["poid"].ToString();
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        cd.Open();
        string ss = "select max(crid) from criminal";
        SqlCommand cmd = new SqlCommand(ss, cd);
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read() == true)
        {
            s1 = r[0].ToString();
            if (s1 == "")
            {
                s2 = "CR" + count;
            }
            else
            {
                s2 = s1.Remove(0, 2);
                int i = Convert.ToInt32(s2);
                i++;
                s2 = "CR" + i;
            }

        }
        r.Close();
        cd.Close();


        cd.Open();

        string sss = "insert into criminal values('" + s2.ToString() + "','" + TextBox12.Text + "','" + TextBox14.Text + "','" + TextBox1.Text + "',@img1)";

        SqlCommand cmd11 = new SqlCommand(sss, cd);

        byte[] img1 = new byte[FileUpload1.PostedFile.ContentLength];
        FileUpload1.PostedFile.InputStream.Read(img1, 0, FileUpload1.PostedFile.ContentLength);
        cmd11.Parameters.Add("@img1", SqlDbType.Image).Value = img1;



        cmd11.ExecuteNonQuery();
        cd.Close();
        Response.Redirect("police_criminal.aspx");
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
}