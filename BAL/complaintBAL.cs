using Product.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Product.BAL
{
    public class complaintBAL
    {
        DAL.complaintDAL cDAL= new DAL.complaintDAL();

        private int complaint_id, product_id, user_id;
        private string complaint,complaint_date,complaint_status,from_date,to_date,reply;


        public int cId
        {
            get 
            { 
                return complaint_id;
            }
            set 
            {
              complaint_id= value;
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

        public string Complaint
        {
            get
            {
                return complaint;
            }
            set
            { 
                complaint = value;
            }
        }

        public string Reply
        {
            get
            {
                return reply;
            }
            set
            {
                reply = value;
            }
        }

        public string Complaint_date
        {
            get
            {
                return complaint_date;
            }
            set
            {
                complaint_date = value;
            }
        }
        public string Complaint_status
        {
            get
            {
                return complaint_status;    
            }
            set 
            {
                 complaint_status = value;
            }
        }
        public string Complaint_from_date
        {
            get 
            {
                return from_date;
            }
            set
            {
                from_date = value;
            }
        }
        public string Complaint_to_date
        {
            get
            {
                return to_date;
            }
            set
            {
                to_date = value;
            }
        }

        //Insert Complaints
        public int insertcomplaint()
        {
            return cDAL.complaintinsert(this);
        }

        public DataTable viewcomplaint() 
        {
            return cDAL.complaintview(this);
        }

        public DataTable viewallcomplaints()
        {
            return cDAL.complaintviewall(this);
        }

        public DataTable viewdatecomplaints()
        {
            return cDAL.complaintviewdate(this);
        }

        public DataTable viewusercomplaints()
        {
            return cDAL.complaintviewuser(this);
        }

        public int updatecomplaint()
        {
            return cDAL.complaintupdate(this);
        }
    }
}