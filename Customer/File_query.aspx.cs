using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Customer
{
    public partial class View_query : System.Web.UI.Page
    {
        BAL.productBAL pro = new BAL.productBAL();
        BAL.queryBAL query = new BAL.queryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = pro.viewproduct();
                DropDownList1.DataTextField = "p_name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            query.pId = Convert.ToInt32(DropDownList1.SelectedValue);
            query.UserId = Convert.ToInt32(Session["user_id"].ToString());
            query.Query = TextBox1.Text;
            int i = query.insertquery();
            if (i == 1)
            {
                Response.Write("<script>alert('Registered Successfully.');</script>");
                Server.Transfer("../Customer/View_query.aspx");
            }
        }
    }
}