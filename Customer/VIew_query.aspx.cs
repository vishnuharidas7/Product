using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Customer
{
    public partial class VIew_query : System.Web.UI.Page
    {
        BAL.queryBAL ob = new BAL.queryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

            ob.UserId = Convert.ToInt32(Session["user_id"].ToString());
            GridView1.DataSource = ob.viewquery();
            GridView1.DataBind();
        }
    }
}