using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Admin
{
    public partial class Customer_confirmation : System.Web.UI.Page
    {
        BAL.confirmBAL pro = new BAL.confirmBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = pro.viewcustomer();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            pro.pdId = id;
            int i = pro.confrimcustomer();


            GridView1.EditIndex = -1;
            GridView1.DataSource = pro.viewcustomer();
            GridView1.DataBind();
        }
    }
}