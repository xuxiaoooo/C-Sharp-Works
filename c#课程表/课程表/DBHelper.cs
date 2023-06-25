using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 课程表
{
    class DBHelper
    {
        public static int a,b;
        public string connString = @"server=.;database=timetable; integrated security=SSPI";
        private SqlConnection connction;
        public SqlConnection Connction
        {
            get
            {
                if (connction == null)
                {
                    connction = new SqlConnection(connString);
                }
                return connction;
            }
        }
        public void OpenConnection()
        {
            if (connction.State == ConnectionState.Closed)
            {
                Connction.Open();
            }
            else if (connction.State == ConnectionState.Broken)
            {
                Connction.Close();
                Connction.Open();
            }

        }
        public void CloseConnection()
        {
            if (connction.State == ConnectionState.Open || connction.State == ConnectionState.Broken)
            {
                Connction.Close();
            }
        }
    }
}
