using NPOI.SS.UserModel;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace forecast
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region 数据装载
        static int state = 0;
        static DataTable dt = new DataTable();
        DataTable DistTable = new DataTable();

        static DataTable dt1 = new DataTable();
        DataTable DistTable1 = new DataTable();

        public static DataTable ReadExcel(string filePath)
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
                        dt.Rows.Add(dr);
                    }
                }
            }

            return dt;
        }//读取表格
        public static DataTable ReadExcel1(string filePath)
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
                    dt1.TableName = sheet.SheetName;
                    for (int i = 0; i < Cols.LastCellNum; i++)
                    {
                        string str = Cols.GetCell(i).ToString();
                        dt1.Columns.Add(Cols.GetCell(i).ToString());
                    }
                    while (rows.MoveNext())
                    {
                        var row = (IRow)rows.Current;
                        var dr = dt1.NewRow();
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
                        dt1.Rows.Add(dr);
                    }
                }
            }

            return dt1;
        }
        private void btnzhuangzai_Click(object sender, RoutedEventArgs e)//实现装在
        {
            datagridshuju.Items.Clear();
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            string s = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s = openFileDialog.FileName;
                DataTable dt = ReadExcel(s);
                datagridshuju.ItemsSource = dt.DefaultView;
                state = 1;
            }
            else if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {

            }
            show.Content = "当前数据总行数：" + datagridshuju.Items.Count + "行";
        }
        #endregion

        #region 数据清洗
        private void btnqingxi_Click(object sender, RoutedEventArgs e)//数据清洗实现
        {
            if (state == 0)
            {
                MessageBoxX.Show("请先装载数据！", "提示");
            }
            else if (state == 2)
            {
                MessageBoxX.Show("已完成数据清洗！", "提示");
            }
            else if (state == 1)
            {
                state = 2;
                DataView dv = dt.DefaultView;
                DistTable = dv.ToTable(true, "ID", "Contract", "Dependents", "DeviceProtection", "InternetService", "MonthlyCharges", "MultipleLines", "Partner", "PaymentMethod", "PhoneService", "SeniorCitizen", "TVProgram", "TotalCharges", "gender", "tenure", "Label");
                datagridshuju.ItemsSource = DistTable.DefaultView;
                show.Content = "当前数据总行数：" + datagridshuju.Items.Count + "行";
            }
        }
        #endregion

        #region 数据归一化
        private void btnguiyihua_Click(object sender, RoutedEventArgs e)
        {
            if (state == 0)
            {
                MessageBoxX.Show("请先装载数据！", "提示");
            }
            if (state == 1)
            {
                MessageBoxX.Show("请先进行数据清洗！", "提示");
            }
            if (state == 2)
            {
                for (int i = 0; i < DistTable.Rows.Count; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (DistTable.Rows[i][j].ToString() == "Month-to-month")
                        {
                            DistTable.Rows[i][j] = 0;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "One year")
                        {
                            DistTable.Rows[i][j] = 1;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Two year")
                        {
                            DistTable.Rows[i][j] = 2;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "No")
                        {
                            DistTable.Rows[i][j] = 0;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Yes")
                        {
                            DistTable.Rows[i][j] = 1;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "No internet service")
                        {
                            DistTable.Rows[i][j] = 2;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Fiber optic")
                        {
                            DistTable.Rows[i][j] = 1;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "DSL")
                        {
                            DistTable.Rows[i][j] = 2;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "No phone service")
                        {
                            DistTable.Rows[i][j] = 2;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Bank transfer (automatic)")
                        {
                            DistTable.Rows[i][j] = 0;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Credit card (automatic)")
                        {
                            DistTable.Rows[i][j] = 1;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Electronic check")
                        {
                            DistTable.Rows[i][j] = 2;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Mailed check")
                        {
                            DistTable.Rows[i][j] = 3;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Male")
                        {
                            DistTable.Rows[i][j] = 1;
                        }
                        else if (DistTable.Rows[i][j].ToString() == "Female")
                        {
                            DistTable.Rows[i][j] = 0;
                        }
                    }
                }
            }
        }
        #endregion

        #region 模型优化得出结果
        private void btnyouhua_Click(object sender, RoutedEventArgs e)
        {
            double[] kpercent = new double[19];//数组存每个K值得正确率，K值只从1-19取。
            for (int x = 1; x < 20; x++)
            {
                show.Content = "当前K值为：" + x.ToString();
                var data = new List<double[]>();//存属性的数组
                for (int i = 0; i < datagridshuju.Items.Count-1; i++)
                {
                    var l = new double[14];
                    for (int j = 1; j < 15; j++)
                    {
                        l[j-1] = Convert.ToDouble(DistTable.Rows[i][j-1]);
                    }
                    data.Add(l);
                }
                var labels = new List<int>();//存结果分类的数组
                for (int i = 0; i < datagridshuju.Items.Count-1; i++)
                {
                    labels.Add(Convert.ToInt32(DistTable.Rows[i][15]));
                }
                var knn = new KNN(k: x, labels: labels, features: data);//调用KNN.CS的功能获取返回值
                double suc = 0;//正确错误个数计量
                double fail = 0;
                for (int i = 0; i < DistTable1.Rows.Count; i++)
                {
                    double[] a = new double[14];
                    for (int j = 1; j < 15; j++)
                    {
                        a[j-1] = Convert.ToDouble(DistTable1.Rows[i][j-1]);
                    }
                    knn.Classify(new double[][] { a });//knn算法计算
                    int res = knn.Display();//KNN算法结果返回
                    if(res== Convert.ToInt32(DistTable1.Rows[i][15]))
                    {
                        suc++;
                    }
                    else if(res!= Convert.ToInt32(DistTable1.Rows[i][15]))
                    {
                        fail++;
                    }//判断正确和错误个数
                }
                kpercent[x - 1] = suc /(suc+fail);
                //show.Content = "当K值为" + x.ToString() + "时,正确率为" + (kpercent[x - 1] * 100).ToString("0.00") + "%";
            }
            double[] ad= new double[19];
            ad=sort(kpercent);//排序得到最高正确率及K值
            int kres=0;
            for(int i = 0; i < 19; i++)
            {
                if (ad[18] == kpercent[i])
                {
                    kres = i+1;
                    break;
                }
            }
            show.Content = "当K值=" + kres.ToString() + "时，正确率最高为：" + (ad[18]*100).ToString("0.00")+"%";
        }
        double[] sort(double[] a)//排序算法冒泡
        {
            double temp;
            for(int i = 0; i < 19; i++)
            {
                for(int j = i + 1; j < 19; j++)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            return a;
        }
        #endregion

        #region 测试数据的装入，和上面训练集一样
        private void btnceshi_Click(object sender, RoutedEventArgs e)
        {
            datagridshuju1.Items.Clear();
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            string s = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s = openFileDialog.FileName;
                DataTable dt1 = ReadExcel1(s);
                datagridshuju1.ItemsSource = dt1.DefaultView;
            }
            else if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {

            }
            DataView dv = dt1.DefaultView;
            DistTable1 = dv.ToTable(true, "ID", "Contract", "Dependents", "DeviceProtection", "InternetService", "MonthlyCharges", "MultipleLines", "Partner", "PaymentMethod", "PhoneService", "SeniorCitizen", "TVProgram", "TotalCharges", "gender", "tenure", "Label");
            datagridshuju1.ItemsSource = DistTable1.DefaultView;
            for (int i = 0; i < DistTable1.Rows.Count; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (DistTable1.Rows[i][j].ToString() == "Month-to-month")
                    {
                        DistTable1.Rows[i][j] = 0;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "One year")
                    {
                        DistTable1.Rows[i][j] = 1;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Two year")
                    {
                        DistTable1.Rows[i][j] = 2;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "No")
                    {
                        DistTable1.Rows[i][j] = 0;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Yes")
                    {
                        DistTable1.Rows[i][j] = 1;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "No internet service")
                    {
                        DistTable1.Rows[i][j] = 2;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Fiber optic")
                    {
                        DistTable1.Rows[i][j] = 1;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "DSL")
                    {
                        DistTable1.Rows[i][j] = 2;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "No phone service")
                    {
                        DistTable1.Rows[i][j] = 2;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Bank transfer (automatic)")
                    {
                        DistTable1.Rows[i][j] = 0;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Credit card (automatic)")
                    {
                        DistTable1.Rows[i][j] = 1;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Electronic check")
                    {
                        DistTable1.Rows[i][j] = 2;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Mailed check")
                    {
                        DistTable1.Rows[i][j] = 3;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Male")
                    {
                        DistTable1.Rows[i][j] = 1;
                    }
                    else if (DistTable1.Rows[i][j].ToString() == "Female")
                    {
                        DistTable1.Rows[i][j] = 0;
                    }
                }
            }
        }
        #endregion
        
    }
}
