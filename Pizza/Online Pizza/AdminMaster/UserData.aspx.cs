using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Online_Pizza.AdminMaster
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\asp.net\Online Pizza\Online Pizza\App_Data\pizzadata.mdf;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            if (!IsPostBack)
            {
                userdata();
            }

            void userdata()
            {
                try
                {
                    string str = "select * from Sign_up";
                    da = new SqlDataAdapter(str, con);
                    da.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }

            }
        }
    }
}