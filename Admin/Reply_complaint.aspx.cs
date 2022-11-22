using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Admin
{
    public partial class Reply_complaint : System.Web.UI.Page
    {
        BAL.complaintBAL ob = new BAL.complaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int cid = Convert.ToInt32(Request.QueryString["Id"]);
                Session["ComplaintId"] = cid;
                ob.cId = cid;
                DataTable dt = ob.viewusercomplaints();
                if (dt != null) ;
                {
                    txtproduct.Text = dt.Rows[0]["p_name"].ToString();
                    txtcomplaint.Text = dt.Rows[0]["complaint"].ToString();
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ob.Reply = txtreply.Text;
            int complaint_id = Convert.ToInt32(Session["ComplaintId"]);
            ob.cId = complaint_id;
            int i = ob.updatecomplaint();
            if (1 == i)
            {
                Response.Write("<script>alert('Updated to the user complaint');</script>");
                Server.Transfer("View_All_complaints.aspx");
            }
        }
    }
}