using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.DAL
{
    public class productDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd= new SqlCommand();

        public productDAL() 
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

        public int productInsert(BAL.productBAL obj)
        {
            string qry = "insert into tbl_product values('" + obj.pdName + "');";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable productview()
        {
            string qry = "select * from tbl_product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter dda= new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            dda.Fill(dt);
            return dt; 
        }

        public int productupdate(BAL.productBAL obj)
        {
            string qry = "update tbl_product set p_name = '"+obj.pdName+"' where Id = '"+obj.pdId+"' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int productdelete(BAL.productBAL obj) 
        {
            string qry = "delete from tbl_product where Id='"+obj.pdId+"'";
            SqlCommand cmd= new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}