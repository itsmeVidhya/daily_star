﻿using System;
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
       // Label2.Text = Session["uname"].ToString();
        c.Open();

        string s11 = "select * from editor order by eid desc";// where sid='"+Session["sid"].ToString()+"'";// where status='" + dd.ToString() + "'";// where grp='" + DropDownList1.SelectedItem.Text + "'";// order by pid desc";// where au='" + TextBox1.Text + "' ";

        SqlDataAdapter daa = new SqlDataAdapter(s11, c);
        DataSet dss1 = new DataSet();
        daa.Fill(dss1);
        DataList1.DataSource = dss1;
        DataList1.DataBind();
        c.Close();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
   
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
        //Session["p1"] = e.CommandArgument.ToString();
        //Response.Redirect("admin_view_police1.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        cd.Open();

        string sdw = "delete from reporter where rid='" + e.CommandArgument.ToString() + "'";// where uid='" + Session["uid"].ToString() + "'";// where pwd='" + f.ToString() + "' and pwd='" + TextBox1.Text + "' ";
        SqlCommand cmdw = new SqlCommand(sdw, cd);
        cmdw.ExecuteNonQuery();

        cd.Close();

        Response.Redirect("admin_editor.aspx");
    }
}