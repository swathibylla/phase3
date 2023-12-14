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
    
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\asp.net\Online Pizza\Online Pizza\App_Data\pizzadata.mdf;Integrated Security=True");
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "insert into Feadback values ('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Feedback Send  Sucessfully')</script>");
            }
            catch (Exception ex)
            {
                // Response.Write("<script>alert('Registration Sucessfully')</script>");
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}