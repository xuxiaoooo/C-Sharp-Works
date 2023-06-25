using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大学生课程学习管理与成绩评价系统
{
    internal class DBHelper
    {
        public static string a;//存储登录用户id的全局变量
        public string connString = @"server=.;database=stuChooseClassSys; integrated security=SSPI";//数据库连接，数据库名叫stuChooseClassSys
        private SqlConnection connction;
        public SqlConnection Connction//声明连接类
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
        public void OpenConnection()//打开连接函数
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
        public void CloseConnection()//关闭连接函数
        {
            if (connction.State == ConnectionState.Open || connction.State == ConnectionState.Broken)
            {
                Connction.Close();
            }
        }
    }
}
