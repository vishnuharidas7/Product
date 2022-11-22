using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Guest
{
    public partial class Customer : System.Web.UI.Page
    {
        BAL.pdBAL objpdl = new BAL.pdBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objpdl.pdName = txt_name.Text;
            objpdl.pdEmail= txt_email.Text;
            objpdl.pdGender = RadioButtonList1.SelectedValue;
            objpdl.pdAddress=address.Text;

           object ob= objpdl.insertcustomer();
            if(ob != null ) 
            {
                objpdl.pdUsername = username.Text;
                objpdl.pdPassword = password.Text;
                objpdl.pdUser_id = ob.ToString();
                objpdl.insertlogin();
                Response.Write("<script>alert('Registered Successfully. Please wait till the Admin approve your registration to login...');</script>");
                Server.Transfer("../Guest/Guest_Home.aspx");
            }

        }
    }
}