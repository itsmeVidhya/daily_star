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
        string ss = "select max(pid) from police1";
        SqlCommand cmd = new SqlCommand(ss, cd);
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read() == true)
        {
            s1 = r[0].ToString();
            if (s1 == "")
            {
                s2 = "PO" + count;
            }
            else
            {
                s2 = s1.Remove(0, 2);
                int i = Convert.ToInt32(s2);
                i++;
                s2 = "PO" + i;
            }

        }
        r.Close();
        cd.Close();


        cd.Open();

        string sss = "insert into police1 values('" + s2.ToString() + "','" + TextBox1.Text + "','" + TextBox17.Text + "','" + TextBox13.Text + "','" + TextBox3.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + TextBox5.Text + "',@img1)";

        SqlCommand cmd11 = new SqlCommand(sss, cd);

        byte[] img1 = new byte[FileUpload1.PostedFile.ContentLength];
        FileUpload1.PostedFile.InputStream.Read(img1, 0, FileUpload1.PostedFile.ContentLength);
        cmd11.Parameters.Add("@img1", SqlDbType.Image).Value = img1;



        cmd11.ExecuteNonQuery();
        cd.Close();
        Response.Redirect("admin_police_view.aspx");
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
}