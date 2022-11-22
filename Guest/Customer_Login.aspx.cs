using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Guest
{
    public partial class Customer_Login : System.Web.UI.Page
    {
        BAL.pdBAL objpdl = new BAL.pdBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objpdl.pdUsername = txtusername.Text;
            objpdl.pdPassword = txtpassword.Text;
            /* SqlDataReader i = objpdl.customerlogin();

             if (i.Read())
             {
                 if(txtusername.Text=="admin")
                 {
                     Response.Redirect("../Admin/Admin_Home.aspx");
                 }
                 else
                 {
                     Response.Redirect("../Customer/Customer_Home.aspx");
                 }

             }
             else
             {
                 Response.Write("Incorrect username or password");
             }*/

            DataTable dt = objpdl.customerlogin();

            if(dt.Rows.Count > 0 )
            {
                if (dt.Rows[0][3].ToString()=="admin")
                {
                    Response.Redirect("../Admin/Admin_Home.aspx");
                }
                else if (dt.Rows[0][1].ToString()=="customer" && Convert.ToInt32(dt.Rows[0][4])==1)
                {
                    Session["user_id"] = dt.Rows[0][0].ToString();
                    string msg = "login sccess";
                    txtusername.Text = msg;
                    Response.Redirect("../Customer/Customer_Home.aspx");
                }
                else if (dt.Rows[0][1].ToString() == "customer" && Convert.ToInt32(dt.Rows[0][4]) == 0)
                {
                    Response.Write("<script>alert('Please wait till admin confirmation');</script>");
                    Server.Transfer("../Guest/Customer_Login.aspx");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid username/password');</script>");
            }
        }
    }
}