using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyTickets
{
    public class DBHelper
    {
        //数据库连接字符串
        public string connString = @"server=localhost;database=MyTicket; integrated security=SSPI";
        /// <summary>
        /// 数据库连接对象
        /// </summary>
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
        /// <summary>
        /// 打开数据库连接
        /// </summary>
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
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if(connction.State==ConnectionState.Open|| connction.State == ConnectionState.Broken)
            {
                Connction.Close();
            }
        }

    }
}
