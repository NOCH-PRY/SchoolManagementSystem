using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolMengerment
{
    internal class myOper
    {
        public static SqlConnection conn;
        public static void myConnection()
        {
            string conStr;
            conStr = conn.ConnectionString;
        }
    }
}
