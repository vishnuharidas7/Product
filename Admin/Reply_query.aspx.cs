using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Admin
{
    public partial class Reply_query : System.Web.UI.Page
    {
        BAL.queryBAL ob = new BAL.queryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int qid = Convert.ToInt32(Request.QueryString["Id"]);
                Session["QueryId"]=qid;
                ob.qId= qid;
                DataTable dt = ob.replyquery();
                if(dt!=null);
                {
                    txtproduct.Text = dt.Rows[0]["p_name"].ToString();
                    txtquery.Text = dt.Rows[0]["query"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ob.Reply_query = reply.Text;
            int query_id = Convert.ToInt32(Session["QueryId"]);
            ob.qId = query_id;
            int i=ob.give_reply();
            if(1== i)
            {
                Response.Write("<script>alert('Replied to the user query');</script>");
                Server.Transfer("View_All_query.aspx");
            }
        }
    }
}