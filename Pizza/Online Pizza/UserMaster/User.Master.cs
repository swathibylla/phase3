using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Login;

namespace Online_Pizza.UserMaster
{
    public partial class User : System.Web.UI.MasterPage
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\asp.net\Online Pizza\Online Pizza\App_Data\pizzadata.mdf;Integrated Security=True");
        //SqlCommand cmd;
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            // con.Open();
        }
        // protected void Button1_Click(object sender,EventArgs e)
        //{
        //string userType = DropDownListLogin.SelectedValues;
        //string username = Txtname.Text;
        //string password = txtpass.Text;
        //LoginService loginService = new LoginService();
        // if(loginService.AuthenticateUser(userType,username,password))
        //{
        // Response.Redirect("~/PizzaOrder.aspx");
        //}
        //else
        //{
        //  Response.Write("Invalid credentials.Please try again.");

    }
}

    
