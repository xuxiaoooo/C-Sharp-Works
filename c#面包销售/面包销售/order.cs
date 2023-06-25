using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 面包销售
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            labeldate.Text = "单据日期：" + DBHelper.b4;
            labelid.Text = "订单编号：" + DBHelper.b1;
            labelname.Text = DBHelper.b2;
            labelnum.Text = DBHelper.b3;
            labeltotal.Text = DBHelper.b6;
            labelyingshou.Text= "应收金额：" + DBHelper.b6;
            labelshishou.Text = "实收金额："+ DBHelper.b6;
            label11.Text= DBHelper.b6;
        }
    }
}
