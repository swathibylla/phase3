using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Online_Pizza.UserMaster
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\asp.net\Online Pizza\Online Pizza\App_Data\pizzadata.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                if (DropDownListLogin.SelectedValue.ToString() == "User")
                {
                    if(Txtname.Text=="User" && txtpass.Text=="123456")
                    {
                        Response.Redirect("PizzaOrder.aspx");
                    }
                    else
                    {
                        Response.Redirect("PizzaOrder.aspx");
                    }
                    //string str = "select * from Sign_up where UserName='" + Txtname.Text + "' and Password='" + txtpass.Text + "'";
                    //da = new SqlDataAdapter(str, con);
                    //DataSet ds = new DataSet();
                    //da.Fill(ds);

                    //if (dt.Rows.Count > 0)
                    //{
                    //    Response.Redirect("MyOrder.aspx");
                    //}
                }else if(DropDownListLogin.SelectedValue.ToString()=="Admin")
                {
                    if(Txtname.Text=="ADMIN" && txtpass.Text=="123456")
                    {
                        Response.Redirect("../AdminMaster/Home.aspx");
                    }
                    //string str = "select * from Admin where UserName='" + Txtname.Text + "' and Password='" + txtpass.Text + "'";
                    //da = new SqlDataAdapter(str, con);
                    //DataSet ds = new DataSet();
                    //da.Fill(ds);

                    //if (dt.Rows.Count > 0)
                    //{
                    //    Response.Redirect("../Admin/Home.aspx");
                    //}
                }

            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}