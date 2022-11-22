using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Customer
{
    public partial class View_complaints : System.Web.UI.Page
    {
        BAL.complaintBAL ob = new BAL.complaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ob.UserId = Convert.ToInt32(Session["user_id"].ToString());
                GridView1.DataSource = ob.viewcomplaint();
                GridView1.DataBind();
            }
        }
    }
}