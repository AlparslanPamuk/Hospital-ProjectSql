using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Hospital_Project
{
    class Sqlconn
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection ("Data Source=DESKTOP-EK0C6DR\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}   
