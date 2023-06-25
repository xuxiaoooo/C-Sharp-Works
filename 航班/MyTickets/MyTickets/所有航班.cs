using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MyTickets
{
    public partial class 所有航班 : Form
    {
        public 所有航班()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //从数据库导入所有航班信息
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select flightNo,airways,leaveTime,landTime,price
                                        from flightInfo,airwaysInfo");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "flightInfo");
            this.dataGridView1.DataSource = ds.Tables["flightInfo"];
        }
        static DataTable dt = new DataTable();
        DataTable DistTable = new DataTable();

        public static DataTable ReadExcel(string filePath)//这是打开excel表格的函数内容
        {
            IWorkbook iwkX;
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                iwkX = WorkbookFactory.Create(fs);
                fs.Close();
            }
            //sheet

            for (int h = 0; h < iwkX.NumberOfSheets; h++)
            {
                ISheet sheet = iwkX.GetSheetAt(h);
                var rows = sheet.GetRowEnumerator();
                bool isMove = rows.MoveNext();
                //循环sheet
                if (isMove)
                {
                    var Cols = (IRow)rows.Current;
                    dt.TableName = sheet.SheetName;
                    for (int i = 0; i < Cols.LastCellNum; i++)
                    {
                        string str = Cols.GetCell(i).ToString();
                        dt.Columns.Add(Cols.GetCell(i).ToString());
                    }
                    while (rows.MoveNext())
                    {
                        var row = (IRow)rows.Current;
                        var dr = dt.NewRow();
                        for (int i = 0; i < row.LastCellNum; i++)
                        {
                            var cell = row.GetCell(i);
                            if (cell == null)
                            {
                                dr[i] = "";
                            }
                            else
                            {
                                string strdr = cell.ToString();
                                dr[i] = cell.ToString();
                            }
                        }
                        dt.Rows.Add(dr);//循环读取excel表格内容存储到datatable中
                    }
                }
            }

            return dt;
        }//读取表格

        private void button2_Click(object sender, EventArgs e)//打开excel按钮函数，调用了上面的函数
        {
            //dataGridView1.Rows.Clear();
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            string s = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)//选取文件界面的函数
            {
                s = openFileDialog.FileName;
                DataTable dt = ReadExcel(s);//获取上面的datatable
                dataGridView1.DataSource = dt.DefaultView;//把datatable值放进datagridview中
            }
            else if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel文件|*.xlsx|Excel(2003文件)|*.xls";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                Excel.Application application = new Excel.Application();
                Excel.Workbooks workbooks = application.Workbooks;
                Excel.Workbook workbook = workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet worksheet = workbook.Worksheets[1];//初始化excel对象
                worksheet.PageSetup.CenterHeader = "报表演示";//设置页眉
                worksheet.PageSetup.CenterFooter = "第&P页---------共(&N)页";//设置页脚
                int colIndex = 0;
                //导出DataGridView中的标题
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.Columns[i].Visible)//做同于不导出隐藏列
                    {
                        colIndex++;
                        worksheet.Cells[1, colIndex] = dataGridView1.Columns[i].HeaderText;
                    }
                }
                //导出DataGridView中的数据
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    colIndex = 0;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Columns[j].Visible)
                        {
                            colIndex++;
                            worksheet.Cells[i + 2, colIndex] = "'" + dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                }
                //保存文件
                workbook.SaveAs(fileDialog.FileName);//保存对话框
                application.Quit();
                MessageBox.Show("导出成功");//成功了提示
            }
        }
    }
}
