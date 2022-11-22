using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.BAL
{
    public class pdBAL
    {
        
        //create obj of data access layer
        DAL.pdDAL objstddl = new DAL.pdDAL();

        private string name, email, address, gender,username,password,user_id;
        //public string Id;
        public string pdName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string pdEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string pdAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string pdGender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string pdUsername
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string pdPassword
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string pdUser_id
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


        public object insertcustomer()
        {
            return objstddl.customerInsert(this);
        }

        public int insertlogin()
        {
            return objstddl.logininsert(this);
        }

     



       /* public SqlDataReader customerlogin()
        {
            return objstddl.logincustomer(this);
        }
      */

        public DataTable customerlogin()
        {
            return objstddl.logincustomer(this);
        }

    }
}