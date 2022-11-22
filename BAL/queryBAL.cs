using Product.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Product.BAL
{
    public class queryBAL
    {
        DAL.queryDAL qDAL = new DAL.queryDAL();

        private int query_id, product_id, user_id;
        private string query,query_reply;


        public int qId
        {
            get
            {
                return query_id;
            }
            set
            {
                query_id = value;
            }
        }

        public int pId
        {
            get
            {
                return product_id;
            }
            set
            {
                product_id = value;
            }
        }

        public int UserId
        {
            get
            {
                return user_id;
            }
            set
            {
                user_id = value;
            }
        }

        public string Query
        {
            get
            {
                return query;
            }
            set
            {
                query = value;
            }
        }
        public string Reply_query
        {
            get
            {
                return query_reply;
            }
            set
            {
                query_reply = value;
            }
        }

        public int insertquery()
        {
            return qDAL.queryinsert(this);
        }

        public DataTable viewquery()
        {
            return qDAL.queryview(this);
        }

        public DataTable viewallquery()
        {
            return qDAL.queryviewall(this);
        }

        public DataTable replyquery()
        {
             return qDAL.queryreply(this);
        }

        public int give_reply()
        {
            return qDAL.GiveReplyDetails(this);
        }

    }
}