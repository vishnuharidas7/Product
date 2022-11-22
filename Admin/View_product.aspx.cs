using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Admin
{
    public partial class View_product : System.Web.UI.Page
    {
        BAL.productBAL pro = new BAL.productBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = pro.viewproduct();
                GridView1.DataBind();
            }

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = pro.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox p_id = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox productname = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];

            pro.pdId = id;
            pro.pdName = productname.Text;
            int i = pro.updateproduct();


            GridView1.EditIndex = -1;
            GridView1.DataSource = pro.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = pro.viewproduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            pro.pdId = id;
            int i = pro.deleteproduct();


            GridView1.EditIndex = -1;
            GridView1.DataSource = pro.viewproduct();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/Product_Registration.aspx");
        }
    }
}