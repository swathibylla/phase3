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
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\asp.net\Online Pizza\Online Pizza\App_Data\pizzadata.mdf;Integrated Security=True");
        SqlCommand cmd;
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        int id1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string str = "select max(oid) as oid from Orders";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            id1 = 1;
            id1 = int.Parse(ds.Tables[0].Rows[0]["oid"].ToString());
            if(id1>0)
            {
                id1++;

            }
            else
            {
                id1 = 1;
            }
            Label1.Text = id1.ToString();
        }

        protected void txtorder_TextChanged(object sender, EventArgs e)
        {
           // txtorder.Text = DateTime.Now.ToString ("dd/mm/yyyy");
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {

                string srt1 = "insert into Orders values(" + Label1.Text + ",'" + txtname.Text + "','" + DropDownList1.SelectedValue.ToString() + "','" + txtorder.Text + "','" + txtaddress.Text + "','" + txtdes.Text + "')";
                  cmd = new SqlCommand(srt1, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>Alert('Order Confirm')<script/>");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}