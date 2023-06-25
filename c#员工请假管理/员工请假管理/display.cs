using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Course_Design
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }

        public display(string sql, string text)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            label1.Text = text;

        }

        private void display_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
