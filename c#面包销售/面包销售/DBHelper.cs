using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace 面包销售
{
    class DBHelper
    {
        public static string a;
        public static string b1, b2, b3, b4, b5, b6;
        public string connString = @"server=.;database=breadsale; integrated security=SSPI";
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
