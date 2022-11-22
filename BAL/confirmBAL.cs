using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Product.BAL
{
    public class confirmBAL
    {
        DAL.confirmDAL obj = new DAL.confirmDAL();

        private int id;
        /*private string product_name;
        private int p_id;

        public string pdName
        {
            get
            {
                return product_name;
            }
            set
            {
                product_name = value;
            }
        }

        public int pdId
        {
            get
            {
                return p_id;
            }
            set
            {
                p_id = value;
            }
        }


        public int insertproduct()
        {
            return obj.productInsert(this);
        }
        */

        public int pdId
        { 
            get
            {
                return id;
            } 
            set 
            { 
                id= value; 
            }
        }
        public DataTable viewcustomer()
        {
            return obj.customerview();
        }

        public int confrimcustomer()
        {
            return obj.customerconfirm(this);
        }


      /*  public int updateproduct()
        {
            return obj.productupdate(this);
        }
      */
    }
}