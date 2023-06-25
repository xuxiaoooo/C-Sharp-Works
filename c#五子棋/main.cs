using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace 五子棋2
{
    public partial class main : Form
    {
        int[,] chessArr;    //存储棋格中棋子的状态，列如chessArr[4,5]=0;表示第5行，第6列的交叉点是黑子。此外1代表白子，2代表空。
        bool black = true;  //是否到黑子下棋。
        int num = 15;   //棋盘的大小：num*num
        ControlInternet CI = new ControlInternet(); //实例化的联网对战类。
        bool over = true;   //是否结束，结束则定制落子。
        bool internetFight = false; //该值为true时则为联网对战，此时black变量是固定的，一方为黑，一方为白。
        List<PictureBox> picBoxList = new List<PictureBox>();   //使用PictureBox作为棋格。
        bool put=true;   //单机游戏时该值永远为true，联网时接收到数据设为true，发送数据后设为false。


        public main()
        {
            InitializeComponent();
        }

        //棋格初始化
        private void main_Load(object sender, EventArgs e)
        {
            drawCheckerboar();
        }
        public bool pingju()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (chessArr[i, j] == 2)
                    {
                        return false;
                    } 
                }
            }
            return true;
        }
        //画棋格
        public void drawCheckerboar()
        {
            chessArr = new int[num, num];
            int currentPoint = 0;
            int chessLength = 30;
            int initX = 10;
            int initY = 10;
            int _x = initX;
            int _y = initY;
            PictureBox tmpBox;
            for (int x = 0; x < num * num; x++)
            {
                if (currentPoint % num == 0)
                {
                    _x = initX;
                    _y = ((int)currentPoint / num) * chessLength + initY;
                }
                else
                {
                    _x += chessLength;
                }
                tmpBox = new PictureBox();
                tmpBox.Left = _x;
                tmpBox.Top = _y;
                tmpBox.Width = chessLength;
                tmpBox.Height = chessLength;
                tmpBox.Image = global::五子棋2.Properties.Resources.gezi;
                tmpBox.Name = (currentPoint % num).ToString() + "-" + ((int)currentPoint / num).ToString(); //x-y
                chessArr[currentPoint % num, (int)currentPoint / num] = 2;
                tmpBox.Click += new EventHandler(pic_click);
                picBoxList.Add(tmpBox);
                this.Controls.Add(tmpBox);
                tmpBox = null;
                currentPoint++;
            }
        }

        //单击棋格
        private void pic_click(object sender,EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string[] stringArr = pb.Name.Split('-');
            int[] intArr = new int[] { int.Parse(stringArr[0]),int.Parse(stringArr[1])};
            if (chessArr[intArr[0],intArr[1]]==2&&!over&&put)
            {
                if (black)
                {
                    pb.Image = global::五子棋2.Properties.Resources.black;
                    chessArr[intArr[0], intArr[1]] = 0;
                    if (!internetFight)
                        black = false;
                    else
                    {
                        CI.sendMsg(00,0,(intArr[0]+intArr[1]*num).ToString());
                        put = false;
                    }
                    if (win(0))
                    {
                        over = true;
                        MessageBox.Show("黑棋获胜");

                    }
                    else if (pingju())
                    {
                        over = true;
                        MessageBox.Show("平局");
                    }
                }
                else
                {
                    pb.Image = global::五子棋2.Properties.Resources.white;
                    chessArr[intArr[0], intArr[1]] = 1;
                    if (!internetFight)
                        black = true;
                    else
                    {
                        CI.sendMsg(00, 1, (intArr[0] + intArr[1] * num).ToString());
                        put = false;
                    }
                    if (win(1))
                    {
                        over = true;
                        MessageBox.Show("白棋获胜");
                    }
                    else if (pingju())
                    {
                        over = true;
                        MessageBox.Show("平局");
                    }
                }
            }
        }

        //是否胜利。
        private bool win(int flag)
        {
            int checkPoint = 0;
            int _x = 0;
            int _y = 0;
            //横着检查。
            for (int x = 0; x < num*num;x++ )
            {
                int consecutive = 0;
                checkPoint = x;
                for (int y = 0; y < 5; y++)
                {
                    _x = (checkPoint +y)% num;
                    _y = (int)checkPoint / num;
                    if (checkPoint > (num * num - 1) || _x > num-1)
                        break;
                    if(chessArr[_x,_y]==flag)
                    {
                        consecutive++;
                    }
                    //checkPoint++;
                }
                if (consecutive == 5)
                    return true;
            }
            //竖着检查
            for (int x = 0; x < num * num; x++)
            {
                int consecutive = 0;
                checkPoint = x;
                for (int y = 0; y < 5; y++)
                {
                    _x = (checkPoint +y)% num;
                    _y = (int)checkPoint/ num;
                    if (checkPoint > (num * num - 1) || _x > num - 1)
                        break;
                    if (chessArr[ _y,_x] == flag)
                    {
                        consecutive++;
                    }
                    //checkPoint++;
                }
                if (consecutive == 5)
                    return true;
            }
            //正斜
            for (int x = 0; x < num * num; x++)
            { 
                int consecutive = 0;
                checkPoint = x;
                for (int y = 0; y < 5; y++)
                {
                    _x = checkPoint % num + y;
                    _y = ((int)checkPoint / num) + y;
                    if (_x > num - 1 || _y > num-1)
                        break;
                    if (chessArr[_x, _y] == flag)
                    {
                        consecutive++;
                    }
                }
                if (consecutive == 5)
                    return true;
            }
            //反斜
            for (int x = 0; x < num * num; x++)
            {
                int consecutive = 0;
                checkPoint = x;
                for (int y = 0; y < 5; y++)
                {
                    _x = checkPoint % num - y;
                    _y = (int)checkPoint / num +y;
                    if (_x > num - 1 || _x < 0 || _y > num - 1 || _y < 0)
                        break;
                    if (chessArr[_x, _y] == flag)
                    {
                        consecutive++;
                    }
                }
                if (consecutive == 5)
                    return true;
            }
            return false;
        }

        //监听按钮
        private void btn_listen_Click(object sender, EventArgs e)
        {
            Thread listenThread = new Thread(new ThreadStart(listen));
            listenThread.Start();
        }
        //监听函数
        private void listen()
        {
            bool i = true;
            try
            {
                Thread.CurrentThread.IsBackground = true;
                Control.CheckForIllegalCrossThreadCalls = false;
                btn_connect.Enabled = false;
                btn_listen.Enabled = false;
                btn_stopConnect.Enabled = true;
                txt_ip.Enabled = false;
                CI.listen();
                over = false;   //连接后才允许落子。
                internetFight = true;
                CI.OnReceiveMsg += new ChessEventHander(manageChessEvent);
            }
            catch (Exception ex)
            {
                txt_talk.Text += "listen:\r\n" + ex.Message+"\r\n";
                i = false;
            }
            if (i == true)
            {
                MessageBox.Show("连接成功");
                btn_restart.Enabled = true;
            }
            else
            {
                MessageBox.Show("连接失败,请关闭重试");
            }
        }

        //连接
        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool i = true;
            try
            {
                CI.connect(txt_ip.Text);
                over = false;
                black = false;
                internetFight = true;
                CI.OnReceiveMsg += new ChessEventHander(manageChessEvent);
                btn_connect.Enabled = false;
                btn_listen.Enabled = false;
                btn_stopConnect.Enabled = true;
                txt_ip.Enabled = false;
            }
            catch (Exception ex)
            {
                txt_talk.Text +="btn_connect_Click:\r\n"+ ex.Message + "\r\n";
                i = false;
            }
            if (i == true)
            {
                MessageBox.Show("连接成功");
                btn_restart.Enabled = true;
            }
            else
            {
                MessageBox.Show("连接失败，请关闭重试");
            }
        }

        //发送消息
        private void btn_sendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string player;
                if (black == true)
                    player = "黑子玩家：\r\n";
                else
                    player = "白子玩家：\r\n";
                CI.sendMsg(1, 0, player + txt_send.Text);
                txt_talk.Text += player + txt_send.Text + "\r\n";
                txt_send.Text = "";
            }
            catch (Exception ex)
            {
                txt_talk.Text += "btn_sendMsg_Click:\r\n" + ex.Message+"\r\n";
            }
        }

        //处理接收信息事件。
        public void manageChessEvent(object sender, ChessEvent e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            switch (e.Iclass)
            {
                case "0":   //棋子信息。
                    int _x = int.Parse(e.content) % num;
                    int _y = (int)(int.Parse(e.content) / num);
                    chessArr[_x, _y] = int.Parse(e.flag);
                    if (e.flag == "0")
                    {
                        picBoxList[int.Parse(e.content)].Image = global::五子棋2.Properties.Resources.black;
                        if (win(0))
                        {
                            over = true;
                            MessageBox.Show("黑棋获胜");
                        }
                        else if(pingju())
                        {
                            over = true;
                            MessageBox.Show("平局");
                        }
                    }
                    else
                    {
                        picBoxList[int.Parse(e.content)].Image = global::五子棋2.Properties.Resources.white;
                        if (win(1))
                        {
                            over = true;
                            MessageBox.Show("白棋获胜");
                        }
                        else if (pingju())
                        {
                            over = true;
                            MessageBox.Show("平局");
                        }
                    }
                    put = true;
                    break;
                case "1":   //聊天
                    txt_talk.Text += e.content + "\r\n";
                    break;
                case "2":   //重新开始。
                    restartGmae();
                    break;
                case"5":
                    stopConnect();
                    break;
            }
        }

        private void btn_stopConnect_Click(object sender, EventArgs e)
        {
            CI.sendMsg(5, 0, "000");
            CI = new ControlInternet();
            stopConnect();
        }

        //断开连接。
        private void stopConnect()
        {
            CI.close();
            CI = new ControlInternet();
            btn_listen.Enabled = true;
            btn_connect.Enabled = true;
            btn_stopConnect.Enabled = false;
            txt_ip.Enabled = true;
        }

        //单机
        private void btn_localGame_Click(object sender, EventArgs e)
        {
            over = false;
            btn_restart.Enabled = true;
            btn_localGame .Enabled= false;
            btn_internetGmae.Enabled = false;
            btn_return.Enabled = true;
        }

        //联网
        private void btn_internetGmae_Click(object sender, EventArgs e)
        {

            btn_connect.Enabled = true;
            btn_internetGmae.Enabled = false;
            btn_localGame.Enabled = false;
            btn_listen.Enabled = true;
            btn_sendMsg.Enabled = true;
            txt_ip.Enabled = true;
            btn_restart.Enabled = false;
            btn_return.Enabled = true;
        }

        //按钮-重新开始游戏。
        private void btn_restart_Click(object sender, EventArgs e)
        {
            CI.sendMsg(2, 0, "000");
            restartGmae();
        }
        //重新开始游戏执行函数
        private void restartGmae()
        {
            over = false;
            //black = true;
            for (int m = 0; m < num; m++)
            {
                for (int n = 0; n < num; n++)
                {
                    chessArr[m, n] = 2;
                }
            }
            foreach (PictureBox pc in picBoxList)
            {
                pc.Image = global::五子棋2.Properties.Resources.gezi;
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }
    }

    //自定义消息函数
    public class ChessEvent : EventArgs
    {
        public string Iclass;
        public string content;
        public string flag;
        public ChessEvent(string _class, string _flag, string _content)
        {
            Iclass = _class;
            content = _content;
            flag = _flag;
        }
    }

    //委托
    public delegate void ChessEventHander(object sender,ChessEvent e);

    //联网对战接口。
    public interface ISocket
    {
        void listen();
        void connect(string ipStr);
        void sendMsg(byte @class,byte flag,string content);
        void receiveMsg(object obj);
        void close();
        //event OnReceiveMsg();
    }

    //联网对战类。
    public class ControlInternet:ISocket
    {
        private Socket skRec = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private IPEndPoint ipeRec;
        private Socket skSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private IPEndPoint ipeSend;
        public event ChessEventHander OnReceiveMsg;

        public ControlInternet()
        { 
            
        }

        public void listen()
        {
            try
            {
                IPAddress myIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1];
                skRec.Bind(new IPEndPoint(IPAddress.Parse(myIp.ToString()), 8880));
                skRec.Listen(0);
                Socket clientRec = skRec.Accept();
                Thread receiveMsgThread = new Thread(new ParameterizedThreadStart(receiveMsg));
                receiveMsgThread.Start(clientRec);
                skSend.Bind(new IPEndPoint(IPAddress.Parse(myIp.ToString()), 8881));
                skSend.Listen(0);
                skSend = skSend.Accept();
            }
            catch (Exception ex)
            {
                MessageBox.Show("listen:"+ex.Message);
            }
        }

        public void connect(string ipStr)
        {
            ipeSend = new IPEndPoint(IPAddress.Parse(ipStr), 8880);
            skSend.Connect(ipeSend);
            ipeRec = new IPEndPoint(IPAddress.Parse(ipStr), 8881);
            skRec.Connect(ipeRec);
            Thread receiveMsgThread = new Thread(new ParameterizedThreadStart(receiveMsg));
            receiveMsgThread.Start(skRec);
        }

        public void sendMsg(byte @class,byte flag,string  content)
        {
            try
            {
                byte[] tmpBytes = Encoding.Default.GetBytes(content);
                MessageControl.Message msg = new MessageControl.Message(@class, flag, tmpBytes);
                byte[] sendeBytes = msg.ToBytes();
                skSend.Send(sendeBytes);
            }
            catch (Exception ex)
            { 
                
            }
        }

        public void receiveMsg(object obj)
        {
            Thread.CurrentThread.IsBackground = true;
            Socket clientRec = (Socket)obj;
            MessageControl.Message msg = new MessageControl.Message();
            MessageControl.MessageStream mst = new MessageControl.MessageStream();
            int revb;
            try
            {
                while (clientRec.Connected)
                {
                    byte[] recBytes = new byte[512];
                    revb = clientRec.Receive(recBytes);
                    mst.Write(recBytes, 0, revb);
                    if (mst.Read(out msg))
                    {
                        OnReceiveMsg(this, new ChessEvent(msg.Class.ToString(), msg.Flag.ToString(), Encoding.Default.GetString(msg.Content)));
                    }
                }
            }
            catch (Exception ex)
            {
                //skRec.Close();
                //skSend.Close();
                //clientRec.Close();
            }
        }

        public void close()
        {
            skRec.Close();
            skSend.Close();
        //    //skRec = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    //skSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        ~ControlInternet()
        {
            skRec.Close();
            skSend.Close();
        }
    }
}