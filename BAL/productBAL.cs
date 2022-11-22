using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Product.BAL
{
    public class productBAL
    {
        DAL.productDAL obj = new DAL.productDAL();
        private string product_name;
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

        public DataTable viewproduct()
        {
            return obj.productview();
        }

        public int updateproduct()
        {
            return obj.productupdate(this);
        }


        public int deleteproduct()
        {
            return obj.productdelete(this);
        }




    }
}