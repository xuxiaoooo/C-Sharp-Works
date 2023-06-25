using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 图书管理系统
{
    class DBHelper
    {
        public static string a;
        public string connString = @"server=.;database=db_library_Data; integrated security=SSPI";
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
