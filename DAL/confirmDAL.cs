using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.DAL
{
    public class confirmDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public confirmDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }

        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public DataTable customerview()
        {
            string qry = "select a.*,b.* from tbl_login a inner join tbl_registration b on a.user_id=b.user_id where a.status=0 ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter dda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dda.Fill(dt);
            return dt;
        }


        public int customerconfirm(BAL.confirmBAL obj)
        {
            string qry = "update tbl_login set status=1 where user_id='" + obj.pdId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}