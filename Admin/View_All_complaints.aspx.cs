using Product.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Admin
{
    public partial class View_All_complaints : System.Web.UI.Page
    {
        BAL.complaintBAL ob = new BAL.complaintBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateRange.Visible = false;
                GridView1.DataSource = ob.viewallcomplaints();
                GridView1.DataBind();

                for (int i = 1; i <= 31; i++)
                {
                    from_day.Items.Add(i.ToString());
                    to_day.Items.Add(i.ToString());

                }
                for (int i = 1; i <= 12; i++)
                {
                    from_month.Items.Add(i.ToString());
                    to_month.Items.Add(i.ToString());

                }

                for (int i = DateTime.Now.Year; i >= 2000; i--)
                {
                    from_year.Items.Add(i.ToString());
                    to_year.Items.Add(i.ToString());

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateRange.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ob.Complaint_from_date = from_year.SelectedValue + "-" + from_month.SelectedValue + "-" + from_day.SelectedValue;
            ob.Complaint_to_date = to_year.SelectedValue + "-" + to_month.SelectedValue + "-" + to_day.SelectedValue;
            GridView1.DataSource = ob.viewdatecomplaints();
            GridView1.DataBind();
            DateRange.Visible = false;
        }

    
    }
}