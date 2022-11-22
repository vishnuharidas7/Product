using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.DAL
{
    public class pdDAL
    {

        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public pdDAL()
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

        public object customerInsert(BAL.pdBAL obj)
        {
            string qry = "insert into tbl_registration values('" + obj.pdName + "','" + obj.pdEmail + "','" + obj.pdGender + "','" + obj.pdAddress + "');select @@IDENTITY";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            object ob= cmd.ExecuteScalar();
            return ob;
        }


        public int logininsert(BAL.pdBAL obj)
        {
            string qry = "Insert into tbl_login values('"+ obj.pdUser_id +"','customer','"+ obj.pdUsername +"','"+ obj.pdPassword +"',0)";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

       /* public SqlDataReader logincustomer(BAL.pdBAL obj)
        {
            string qry = "Select * from tbl_login where username='" + obj.pdUsername + "' AND password='" + obj.pdPassword + "' AND status=1";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataReader ob = cmd.ExecuteReader();
            return ob;
        }*/

        public DataTable logincustomer(BAL.pdBAL obj)
        {
            string qry = "SELECT * FROM tbl_login where username='" + obj.pdUsername + "' AND password='" + obj.pdPassword + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}