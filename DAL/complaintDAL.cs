using Product.BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.DAL
{
    public class complaintDAL
    {

            public SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            public complaintDAL()
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

            public int complaintinsert(BAL.complaintBAL ob)
            {
                string qry = "insert into tbl_complaint values('"+DateTime.Now.ToString("yyyy-MM-dd")+"','"+ob.UserId+"','"+ob.pId+"','"+ob.Complaint+"','Not Processed','')";
                SqlCommand cmd = new SqlCommand(qry, Getcon());
                return cmd.ExecuteNonQuery();
            }

        public DataTable complaintview(BAL.complaintBAL ob)
        {
            string qry = "select a.*,b.* from tbl_complaint a inner join tbl_product b on a.product_id=b.Id where a.user_id='"+ob.UserId+"'";
            SqlCommand cmd= new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable complaintviewall(BAL.complaintBAL ob)
        {
            string qry = "select * from tbl_complaint a inner join tbl_product b on a.product_id = b.Id inner join tbl_registration c on a.user_id=c.user_id";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable complaintviewdate(BAL.complaintBAL ob)
        {
            string qry = "select a.*,b.*,c.* from tbl_complaint a inner join tbl_product b on a.product_id = b.Id inner join tbl_registration c on a.user_id=c.user_id WHERE a.date BETWEEN '" + ob.Complaint_from_date + "'  AND '" + ob.Complaint_to_date + "' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        public DataTable complaintviewuser(BAL.complaintBAL ob)
        {
            string qry = "select a.*,b.*,c.* from tbl_complaint a inner join tbl_product b on a.product_id = b.Id inner join tbl_registration c on a.user_id=c.user_id WHERE a.Id='"+ ob.cId +"' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        public int complaintupdate(BAL.complaintBAL ob)
        {
            string qry = "update tbl_complaint set status = 'Processed', reply='" + ob.Reply+ "' where Id = '" + ob.cId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}