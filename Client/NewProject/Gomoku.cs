using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Gomoku : Form
    {
        private Form1 _main;
        private int bw,bl,bd,ww,wl,wd;
        public List<Label>pbList = new List<Label>();
        public Label[] piece;
        public const int n = 19;
        public bool BorW = true;
        public bool[] piece_click = new bool[n * n];
        public int[,] board = new int[n, n];
        private int time=60;
        private bool StartFlag = false;
        public int ReadyStart = 0;
        private String Bname, Wname;
        private String Mname, Oname;
        private bool bwflag;
        private bool PutFlag;
        private int DrawFlag = 3;
        private int totalp = 19 * 19;
        private int GameTime = 0;
        public Gomoku(bool temp)
        {
            

            bwflag = temp;
            InitializeComponent();
            this.ControlBox = false;
            SetLabel();
            Wtime.Location = WReady.Location;
            Btime.Location = BReady.Location;
            //Wtime.Text = "等待白子連線......";
            //WReady.Hide();
            
        }
        public void SetName(string n,int mode)
        {
            if (mode == 1)
            {
                this.Text = this.Text+"/黑子";
                WReady.Hide();
                pictureBox3.Hide();
                Wtime.Text = "等待白子準備......";
            }
            else
            {
                this.Text = this.Text + "/白子";
                BReady.Hide();
                pictureBox1.Hide();
                Btime.Text = "等待黑子準備......";
            }
            this.Text = n + "-" + this.Text;
            Mname = n;
        }
        public void SetReady(int mode)
        {
            ReadyStart++;
            if(mode==1)
            {
                Btime.Text = "黑子準備完成";
            }
            else
            {
                Wtime.Text = "白子準備完成";
            }
            if (ReadyStart == 2)
                GameStart();
        }
        private void SetLabel()
        {

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    board[i, j] = 0;

            for (int i = 0; i < 19 * 19; i++)
                pbList.Add(new Label());
            piece = pbList.ToArray();
            for (int i = 0; i < piece.Length; i++)
            {
                //piece_click[i] = false;
                piece[i].Location = new System.Drawing.Point(26+23*(i%19),30+24*(i/19));
                piece[i].Name = i.ToString();
                piece[i].Size = new System.Drawing.Size(22, 22);
                piece[i].TabIndex = i + 1;
                //piece[i].Parent = pictureBox1;
                piece[i].Click += new EventHandler(piece_Click);
       
                piece[i].BackColor = Color.Transparent;
                
                //pictureBox1.Controls.Add(piece[i]);
                piece[i].BringToFront();
            }
            BLabel.Text = "?";
            Board.Controls.AddRange(piece);
            
        }
        public bool check(int num)
        {
            int x = num % n;
            int y = num / n;
            int[] path = new int[9];
            int len;

            len = 1;
            while (true)
            {
                if (x - len < 0 || y - len < 0)
                    break;
                if (board[y, x] == board[y - len, x - len])
                    len++;
                else
                    break;

            }
            path[1] = len - 1;

            len = 1;
            while (true)
            {
                if (y - len < 0)
                    break;
                if (board[y, x] == board[y - len, x])
                    len++;
                else
                    break;

            }
            path[2] = len - 1;

            len = 1;
            while (true)
            {
                if (x + len >= n || y - len < 0)
                    break;
                if (board[y, x] == board[y - len, x + len])
                    len++;
                else
                    break;

            }
            path[3] = len - 1;

            len = 1;
            while (true)
            {
                if (x - len < 0)
                    break;
                if (board[y, x] == board[y, x - len])
                    len++;
                else
                    break;

            }
            path[4] = len - 1;

            len = 1;
            while (true)
            {
                if (x + len >= n)
                    break;
                if (board[y, x] == board[y, x + len])
                    len++;
                else
                    break;

            }
            path[5] = len - 1;

            len = 1;
            while (true)
            {
                if (x - len < 0 || y + len >= n)
                    break;
                if (board[y, x] == board[y + len, x - len])
                    len++;
                else
                    break;

            }
            path[6] = len - 1;

            len = 1;
            while (true)
            {
                if (y + len >= n)
                    break;
                if (board[y, x] == board[y + len, x])
                    len++;
                else
                    break;

            }
            path[7] = len - 1;

            len = 1;
            while (true)
            {
                if (y + len >= n || x + len >= n)
                    break;
                if (board[y, x] == board[y + len, x + len])
                    len++;
                else
                    break;

            }
            path[8] = len - 1;
            //MessageBox.Show("" + path[1] + path[2] + path[3] + path[4] + path[5] + path[6] + path[7] + path[8]);
            if (path[1] + path[8] > 3)
                return true;
            if (path[2] + path[7] > 3)
                return true;
            if (path[3] + path[6] > 3)
                return true;
            if (path[4] + path[5] > 3)
                return true;
            return false;
            
        }
        
        protected void piece_Click(object sender, EventArgs e)
        {
            if ((StartFlag&&bwflag==BorW)||PutFlag)
            {
                time = 60;

                Label temp = (Label)sender;
                if (piece_click[Int32.Parse(temp.Name)] == false)
                {

                    if (BorW == true)
                    {
                        if(bwflag)
                             _main.GomokuSend("5p." + Wname + ".put."+temp.Name);
                        board[Int32.Parse(temp.Name) / n, Int32.Parse(temp.Name) % n] = 1;
                        temp.BackgroundImage = Resource1.black;
                        if (check(Int32.Parse(temp.Name)))
                        {
                            MessageBox.Show("黑子獲勝！");
                            StartFlag = false;
                            GameEnd();
                            return;
                        }
                    }
                    else
                    {
                        if (!bwflag)
                            _main.GomokuSend("5p." + Bname + ".put." + temp.Name);
                        board[Int32.Parse(temp.Name) / n, Int32.Parse(temp.Name) % n] = 2;
                        temp.BackgroundImage = Resource1.white;
                        if (check(Int32.Parse(temp.Name)))
                        {
                            MessageBox.Show("白子獲勝");
                            StartFlag = false;
                            GameEnd();
                            return;
                        }
                    }
                    BorW = !BorW;
                    if(BorW)
                    { 
                        WLabel.BackColor=Color.Transparent;
                        BLabel.BackColor = Color.Blue;
                    }
                    else
                    {
                        BLabel.BackColor = Color.Transparent;
                        WLabel.BackColor = Color.Blue;
                    }
                    PutFlag = false;
                    totalp--;
                    if (totalp == 0)
                        GameDraw();
                }
                piece_click[Int32.Parse(temp.Name)] = true;
            }
        }
        private void ShowTime()
        {
            int m=0, s=0, h=0;
            if(GameTime>=3600)
            {
                h += GameTime / 3600;
                GameTime %= 3600;
                this.Text += " " + h.ToString() + "時";
            }
            if(GameTime>=60)
            {
                m += GameTime / 60;
                GameTime %= 60;
                this.Text += " " + m.ToString() + "分";
            }
            this.Text += " " + m.ToString() + "秒";
            
        }
        private void TimeOut()
        {
            timer1.Stop();
            ShowTime();
            if (BorW)
            {
                Wtime.Hide();
                Btime.Text = "黑棋思考時間到，白棋獲勝！";
                WLabel.BackColor = Color.Red;
                BLabel.BackColor = Color.Transparent;
                SetInfo(1, bw, bl+1, bd, Bname);
                SetInfo(2, ww+1, wl, wd, Wname);
            }
            else
            {
                Btime.Hide();
                Wtime.Text = "白棋思考時間到，黑棋獲勝！！";
                BLabel.BackColor = Color.Red;
                WLabel.BackColor = Color.Transparent;
                SetInfo(1, bw+1, bl, bd, Bname);
                SetInfo(2, ww, wl+1, wd, Bname);
            }
            if (BorW == bwflag)
                _main._5pL++;
            else
                _main._5pD++;

            StartFlag = false;
            PutFlag = false;
        }
        private void GameEnd()
        {
            
            timer1.Stop();
            ShowTime();
            if (BorW)
            {
                Wtime.Hide();
                Btime.Text = "黑子獲勝！";
                BLabel.BackColor = Color.Red;
                WLabel.BackColor = Color.Transparent;
                SetInfo(1, bw+1, bl, bd, Bname);
                SetInfo(2, ww, wl+1, wd, Wname);
            }
            else
            {
                Btime.Hide();
                Wtime.Text = "白子獲勝！";
                WLabel.BackColor = Color.Red;
                BLabel.BackColor = Color.Transparent;
                SetInfo(1, bw, bl+1, bd, Bname);
                SetInfo(2, ww+1, wl, wd, Bname);
            }
            if (BorW == bwflag)
                _main._5pW++;
            else
                _main._5pL++;

            StartFlag = false;
            PutFlag = false;
        }

        public void GameStart()
        {
            timer1.Start();
            WReady.Hide();
            BReady.Hide();
            StartFlag = true;
            this.Text = this.Text + "-遊戲開始";
            BLabel.BackColor = Color.Blue;
        }
        private void Gomoku_Load(object sender, EventArgs e)
        {
            
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Board_Click(object sender, EventArgs e)
        {
            
        }
        public void SetInfo(int mode,int win,int lose,int draw,string name)
        {
            if(mode==1)
            {
                bw = win;
                bl = lose;
                bd = draw;
                BLabel.Text = "黑子: " + name + " 勝:" + win.ToString() + "場 負:" + lose.ToString() + "場 平手:" + draw.ToString() + "場";
                Bname = name;
                if (!bwflag)
                    Oname = name;
            }
            else
            {
                ww = win;
                wl = lose;
                wd = draw;
                WLabel.Text = "白子: " + name + " 勝:" + win.ToString() + "場 負:" + lose.ToString() + "場 平手:" + draw.ToString() + "場";
                Wname = name;
                if (bwflag)
                    Oname = name;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text = "";
            if(str!=null)
            {
                if (bwflag)
                    _main.GomokuSend("5p." + Wname + ".w." + Bname + ":" + str);
                else
                    _main.GomokuSend("5p." + Bname + ".w." + Wname + ":" + str);
                richTextBox1.AppendText(Mname+":"+str + "\n");
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (StartFlag)
            {
                if (DrawFlag > 0)
                {
                    if (MessageBox.Show("確定要求和嗎?", "求和", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        _main.GomokuSend("5p." + Oname + ".ad");
                    }
                }
                else
                {
                    MessageBox.Show("已經求和太多次了！");
                }
            }
        }
        public void OppAskDraw()
        {
            if (MessageBox.Show("對手要求和局!", "求和", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _main.GomokuSend("5p." + Oname + ".ady");
                GameDraw();
            }
            else
            {
                _main.GomokuSend("5p." + Oname + ".adn");
            }
        }

        public void DrawReject()
        {
            MessageBox.Show("對手拒絕與你和局！");
            DrawFlag--;
            DrawButton.Text = DrawButton.Text.Substring(0, 2) + "(" + DrawFlag.ToString() + ")";
        }
        public void GameDraw()
        {
            timer1.Stop();
            ShowTime();
            if (bwflag)
            {
                Wtime.Hide();
                Btime.Show();
                Btime.Text = "雙方平手！";
            }
            else
            {
                Btime.Hide();
                Wtime.Show();
                Wtime.Text = "雙方平手！";
            }
            BLabel.BackColor = Color.Green;
            WLabel.BackColor = Color.Green;
            SetInfo(1, bw , bl, bd+1, Bname);
            SetInfo(2, ww, wl , wd+1, Wname);
           
            _main._5pD++;
          

            StartFlag = false;
        }

        private void LoseButton_Click(object sender, EventArgs e)
        {
            if (StartFlag == true)
            {
                if (MessageBox.Show("確定要投降嗎?", "投降", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _main.GomokuSend("5p." + Oname + ".al");
                    if (BorW == bwflag)
                        BorW = !BorW;
                    GameEnd();
                }
            }
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            if (!StartFlag)
            {
                if (MessageBox.Show("確定要離開嗎?", "離開", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _main.GomokuSend("5p." + Oname + ".l");
                    _main.p5flag = true; 
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("確定要中途離開嗎，會算一敗唷！", "離開", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _main.GomokuSend("5p." + Oname + ".l");
                    _main._5pL++;
                    _main.p5flag = true; 
                    this.Close();
                }
            }
            
        }
        public void OppAskLose()
        {
            MessageBox.Show("你的對手投降了,恭喜你獲勝!");
            if (bwflag != BorW)
                BorW = !BorW;
            GameEnd();
        }
        public void OppLeave()
        {
            if (StartFlag == true)
            {
                MessageBox.Show("你的對手中離了,恭喜你獲勝!");
                if (bwflag!=BorW)
                    BorW=!BorW;
                GameEnd();
            }
            else
            {
                MessageBox.Show("你的對手離開了！");
            }
            if (bwflag)
                Wtime.Text = "玩家已經離開！";
            else
                Btime.Text = "玩家已經離開！";
        }
        private void Wtime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameTime++;
            if(BorW)
            {
                Wtime.Hide();
                Btime.Show();
                if (time < 0)
                {
                    timer1.Enabled = false;
                    StartFlag = false;
                    //MessageBox.Show("黑子輸了");
                    TimeOut();
                    return;
                }
                else
                {
                    Btime.Text = "剩餘思考時間:" + time.ToString();
                    time--;
                }
            }
            else
            {
                Btime.Hide();
                Wtime.Show();
                if (time < 0)
                {
                    timer1.Enabled = false;
                    StartFlag = false;
                   // MessageBox.Show("白子輸了");
                    TimeOut();
                    return;
                    
                }
                else
                {
                    Wtime.Text = "剩餘思考時間:" + time.ToString();
                    time--;
                }
            }
        }
        public void SetOwner()
        {
            _main = (Form1)this.Owner;
        }
        private void WReady_Click(object sender, EventArgs e)
        {
            ReadyStart++;
            _main.GomokuSend("5p." + Bname + ".s.2");
            if(ReadyStart==2)
                GameStart();
            WReady.Hide();
        }

        private void BReady_Click(object sender, EventArgs e)
        {
            ReadyStart++;
            _main.GomokuSend("5p." + Wname + ".s.1");
            if (ReadyStart == 2)
                GameStart();
            BReady.Hide();
        }
        /*
        public class MyLabel : Label
        {
            public void PerformClick()
            {
                OnClick(new EventArgs());
            }
        }
        */
        public void OnClickLabel(int i)
        {
            PutFlag = true;
            piece_Click(piece[i], new EventArgs());
        }
        public void PutStr(String str)
        {
            richTextBox1.AppendText(str+"\n");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='\r')
            {
                SendButton.PerformClick();
            }
        }
    }
}
