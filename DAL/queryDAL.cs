using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.DAL
{
    public class queryDAL
    {

        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public queryDAL()
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

        public int queryinsert(BAL.queryBAL ob)
        {
            string qry = "insert into tbl_query values('" + ob.UserId + "','" + ob.pId + "','" + ob.Query + "','Not processed')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }


        public DataTable queryview(BAL.queryBAL ob)
        {
            string qry = "select a.*,b.* from tbl_query a inner join tbl_product b on a.product_id=b.Id where a.user_id='" + ob.UserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        public DataTable queryviewall(BAL.queryBAL ob)
        {
            string qry = "select * from tbl_query a inner join tbl_product b on a.product_id = b.Id inner join tbl_registration c on a.user_id=c.user_id";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

       public DataTable queryreply(BAL.queryBAL ob)
        {
            string qry = "select * from tbl_query a inner join tbl_product b on a.product_id = b.Id where a.Id='"+ob.qId+"'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public int GiveReplyDetails(BAL.queryBAL ob)
        {
            string qry = "UPDATE  tbl_query SET reply = '" +ob.Reply_query+ "' where Id = '" + ob.qId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}