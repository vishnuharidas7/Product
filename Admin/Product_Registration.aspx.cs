using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product.Admin
{
    public partial class Product_Registration : System.Web.UI.Page
    {
        BAL.productBAL obj = new BAL.productBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.pdName = product.Text;
            int i=obj.insertproduct();
            if(i==1) 
            {
                //Response.Write("Successfully added");
                //product.Text = null;
                Response.Redirect("../Admin/View_product.aspx");
            }
            else 
            {
                Response.Write("Failed");
            }
        }
    }
}