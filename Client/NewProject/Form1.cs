using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace NewProject
{
    public delegate void Img(byte[] by,int mode);
    public partial class Form1 : Form
    {
       
        delegate String CallbyUi(String str);
        private SolidBrush myBrush;
        private Graphics myGraphic;
        public int _5pW, _5pL, _5pD;
        private String Username = "使用者";
        private String Marquee = "This is just for test!";
        private String Marquee_temp = "";
        private String Marquee_test = "";
        private bool isDraw = false, onDraw = false,flag=true,systemflag=false;
        private int x, y, Bsize = 10,count=0,second=0;
        private int num=10;
        private String DrawInfo="";
        private Color Bcolor = Color.Black;
        private List<int> px=new List<int>();
        private List<int> py=new List<int>();
        private BindingList<String> UserList = new BindingList<String>();
        private bool recFlag,sendFlag=true;
        private bool pokeflag, drawflag, imgflag, whsflag;
        public bool p5flag;
        private List<String> blacklist = new List<String>();
        private Gomoku _5pGame;

        Client c = new Client();
        StrHandler msgHandler;
        StrHandler dwHandler;
        Img imgHandler;
        PicShow p = new PicShow();
        SetPage s = new SetPage();
        BlackList b = new BlackList();
        public Form1()
        {

            _5pW = _5pL = _5pD = 0;
            p5flag = drawflag = imgflag = whsflag = true;
            this.Hide();
            this.Location = new Point(150, 150);
            //this.ShowInTaskbar = true;
            InitializeComponent();


            //Gomoku a = new Gomoku();
            //a.ShowDialog(); 

            this.ShowInTaskbar = true;
            
            trackBar1.Hide();
            ColorBox.Hide();
            button2.Hide();
            
            Login log = new Login();
            log.ShowDialog();
            if (log.DialogResult == DialogResult.Cancel)
            {
                this.Close();

            }
            else
            {
                this.Show();
                //this.ShowInTaskbar = true;
                SetUpData init = log.Get();
                Username = init.UserName;


                MLabel.Hide();
                //Box.ForeColor = Bcolor;
                UserBox.DataSource = UserList;
                myGraphic = DrawBox.CreateGraphics();
                DrawBox.BringToFront();

                c.Setup(init.IP, init.Port);


                //addMsg("2.成功連線");

                msgHandler = this.addMsg;
                dwHandler = this.addDw;
                imgHandler = this.ShowPic;
                c.Recv(processMsgComeIn, processDwComeIn, processImgComeIn);

                //MessageBox.Show("歡迎加入~");
            }
        }

       
        public String addImg(string temp)
        {
            return "ok";
        }
       public void sendMsg()
        {
            if (GetStr().Length > 0)
            {
                c.Send(GetStr());
                textBox1.Clear();
            }
        }
        public string GetStr()
       {
           if (textBox1.Text == "/Bear")
           {
               pic p = new pic();
               return "3.Bear." + Username + ":." + p.Bear;
           }
           else
           {
               String temp = System.Drawing.ColorTranslator.ToHtml(Bcolor);
               return "2." +temp+"."+ Username + ":" + textBox1.Text;
           }
       }

        private void button1_Click(object sender, EventArgs e)
        {
            
            c.Send(GetStr());
            textBox1.Clear();
        }
        public String addDw(String str)
        {
            
             DrawBox.BringToFront();
             myGraphic = DrawBox.CreateGraphics();
            
             String[] Words = str.Split('.');
             int Nsize = Int32.Parse(Words[1]);
             Color Ncolor = System.Drawing.ColorTranslator.FromHtml(Words[2]);
             SolidBrush NBrush = new SolidBrush(Ncolor);
             int i=0;
             try
             {
                 for (i = 3; Words[i] != "!"; i += 2)
                 {
                     if (i < Words.Length)
                     {
                         try
                         {
                             x = Int32.Parse(Words[i + 1]);
                             y = Int32.Parse(Words[i]);
                             px.Add(x);
                             py.Add(y);
                             if (onDraw == true)
                             {
                                 myGraphic.FillEllipse(NBrush, y, x, Nsize, Nsize);
                             }
                         }
                         catch
                         {
                             MessageBox.Show(Words[i + 1]);
                         }
                     }
                 }
             }
             catch
             {
                 MessageBox.Show("畫太多了唷！");
             }
             return "OK";
        }
        public void addSystemMsg(String[] Word)
        {
            
            String temp ="";
            int i;
            for (i = 1; i < Word.Length; i++)
            {
                if (Word[i] == "/cd")
                {
                    i++;
                    Box.AppendText(temp);
                    Color nc = System.Drawing.ColorTranslator.FromHtml(Word[i++]);
                    Box.SelectionColor = nc;
                    Box.AppendText(Word[i]);
                    temp = "";
                    //break;
                }
                else
                {
                    temp += Word[i];
                }
            }


            Box.AppendText(temp + '\n');
        }
        public void CheckName()
        {
            if (flag == true)
            {

                if (UserList.Contains(Username))
                {
                    String temp;
                    for (int i = 1; ; i++)
                    {
                        temp = Username + i;
                        if (UserList.Contains(temp))
                        {

                        }
                        else
                        {
                            break;
                        }
                    }
                    Username = temp;
                    MessageBox.Show("名字已有人用過，更改名字為:" + temp);
                }

                c.Send("/nu." + Username);
                this.Text = Username +"-"+this.Text;
                
                flag = false;
            }
            systemflag = true;
        }
        public void AddUser(String[] Word)
        { 
            //Box.AppendText(Word[2]+'\n');
            foreach(String x in Word)
            {
                if (x != Word[0])
                {
                    //Box.AppendText("Y"+x + '\n');
                    if(x!="User")
                        UserList.Add(x);
                }
            }
            PTotal.Text = "總人數:" + UserList.Count + "人";
            if (flag == true)
            {
                CheckName();
            }
            //if(systemflag==true)
            //{
                  //c.Send("0.系統公告:." + Username + ".已成功連線");
                  //systemflag = false;
                
            //}
            //UserBox.DataSource = UserList; 
        }
        private void SetRunHorse()
        {
            Marquee_temp = "";
            for (int i = 0; i < Marquee.Length; i++)
            {
                //String temp = ""+Marquee[i];
                if (string.Format("{0:X}", Convert.ToInt32(Marquee[i])).Length == 4)
                {
                    Marquee_temp += "　";
                }
                else
                {
                    Marquee_temp += " ";

                }
            }
            RunHorse();
        }
        public String addMsg(String str)
        {
            if(systemflag==true)
            {
                systemflag = false;
                c.Send("/t.系統公告: " + Username + "已成功連線");
            }
            //Box.AppendText(str + '\n');
            //DrawBox.Parent.Invalidate(new Rectangle(DrawBox.Location, DrawBox.Size), true);
            String[] Word = str.Split('.');

            if ( Word[0] == "0"||Word[0]=="e")
            {
                if(Word[0]=="e")
                {
                    if (UserList.Contains(Word[2]))
                    {
                        UserList.Remove(Word[2]); 
                        PTotal.Text = "總人數:" + UserList.Count + "人";
                    }
                }
                String temp="";
                foreach(String x in Word)
                {
                    if(x!=Word[0])
                    {
                        temp += x;
                    }
                }
                if (Word[0]=="e")
                {
                    Marquee = temp;
                    SetRunHorse();
                }
                else
                 addSystemMsg(Word);
            }
            else if (Word[0]=="/t")
            {
               
                Marquee = Word[1]; 
                //Box.AppendText(Marquee + '\n');
                SetRunHorse();
              
            }
      
            else if(Word[0]=="/nu")
            {
                AddUser(Word);
            }
            else if(Word[0]=="/r")
            {
                if (Word[2] != Username)
                {
                    if (Word[2] == "\reject")
                    {
                        Box.AppendText(Word[3] + "\n");
                    }
                    else
                    {
                        if (whsflag == true && !b.CheckList(Word[2]))
                        {
                            WhisperComeIn(Word[2], Word[3]);
                        }
                        else
                        {

                            c.Send("/r." + Word[2] + ".\reject." + Username + "拒絕你的密語");
                        }
                    }
                }
                else
                {
                    
                }
            }
            else if(Word[0] == "2" )
            {
                Color Ncolor = System.Drawing.ColorTranslator.FromHtml(Word[1]);
                Box.SelectionColor = Ncolor;
                String temp = "";
                string t = Word[2].Substring(0,Word[2].Length-2);
                if (!b.CheckList(t))
                {
                    for (int i = 2; i < Word.Length; i++)
                    {
                        temp += Word[i];
                    }
                    Box.AppendText(temp + '\n');
                }
            }
            else if(Word[0]=="3")
            {
                if(Word[1]=="Bear")
                {
                    for (int i = 2; i < Word.Length; i++)
                    {
                        Box.AppendText(Word[i] + '\n');
                    }
                }
            }
            else if(Word[0]=="/s")
            {
                if (pokeflag&&!b.CheckList(Word[2]))
                {
                    if (Word[2] == Username)
                        Box.AppendText("戳了自己一下！" + '\n');
                    else
                        Box.AppendText(Word[2] + "戳了你一下！" + '\n');
                    Shake();
                }
            }
            else if(Word[0]=="5p")
            {
                if (Word[2] == "0")
                {
                    if (p5flag == true)
                    {
                        if (MessageBox.Show("玩家" + Word[3] + "向你提出五子棋挑戰！", "五子棋", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            c.Send("5p." + Word[3] + ".y." + Username + "." + _5pW + "." + _5pL + "." + _5pD);
                            _5pGame = new Gomoku(false);
                            _5pGame.Owner = this;
                            _5pGame.SetOwner();
                            _5pGame.SetInfo(2, _5pW, _5pL, _5pD, Username);
                            _5pGame.SetInfo(1, Int32.Parse(Word[4]), Int32.Parse(Word[5]), Int32.Parse(Word[6]), Word[3]);
                            _5pGame.SetName(Username, 2);
                            _5pGame.Show();

                            p5flag = false;
                        }
                        else
                        {
                            c.Send("5p." + Word[3] + ".r." + Username);
                        }
                    }
                    else
                    {
                        c.Send("5p." + Word[3] + ".r." + Username);
                    }
                }
                else if (Word[2] == "r")
                {
                    MessageBox.Show("玩家" + Word[3] + "拒絕你的五子棋挑戰！");
                }
                else if (Word[2] == "y")
                {
                    _5pGame = new Gomoku(true);
                    _5pGame.Owner = this;
                    _5pGame.SetOwner();
                    _5pGame.Show();
                    _5pGame.SetName(Username, 1);
                    _5pGame.SetInfo(1, _5pW, _5pL, _5pD, Username);
                    _5pGame.SetInfo(2, Int32.Parse(Word[4]), Int32.Parse(Word[5]), Int32.Parse(Word[6]), Word[3]);
                    p5flag = false;
                }
                else if (Word[2] == "s")
                {
                    _5pGame.SetReady(Int32.Parse(Word[3]));
                }
                else if (Word[2] == "put")
                {
                    _5pGame.OnClickLabel(Int32.Parse(Word[3]));
                }
                else if (Word[2] == "w")
                {
                    String strtemp = "";
                    for (int i = 3; i < Word.Length; i++)
                    {
                        strtemp += Word[i];
                    }
                    _5pGame.PutStr(strtemp);
                }
                else if (Word[2] == "l")
                {
                    if(p5flag==false)
                    _5pGame.OppLeave();
                }
                else if(Word[2]=="al")
                {
                    if (p5flag == false)
                        _5pGame.OppAskLose();
                }

                else if (Word[2] == "ad")
                {
                    if (p5flag == false)
                        _5pGame.OppAskDraw();
                }
                else if (Word[2] == "adn")
                {
                    if (p5flag == false)
                        _5pGame.DrawReject();
                }
                else if (Word[2] == "ady")
                {
                    if (p5flag == false)
                        _5pGame.GameDraw();
                }
            }
            //DrawBox.Update();
            //if (systemflag==true)
           
            //if (flag == true)
            //{
            //   CheckName();
            //}
    
            textBox1.Focus();
            //for (int i = 0; i < px.Count; i++)
            //{
              //  myGraphic.FillEllipse(myBrush, py[i], px[i], Bsize, Bsize);
            //}
            DrawBox.BringToFront();
            return "ok";
        }

       
      
        public String processDwComeIn(String str)
        {
            this.Invoke(dwHandler, new Object[] { str });
            return "OK";
        }
        public String processMsgComeIn(String msg)
        {
            this.Invoke(msgHandler, new Object[] { msg });
            return "OK";
        }

       

       

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            String temp = System.Drawing.ColorTranslator.ToHtml(Bcolor);
            c.Send("e.系統公告:."+Username + ".離開了!");
           
            c.Ct.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (count < 300)
            {
                if (isDraw == true && onDraw == true)
                {
                    count++;
                    DrawInfo = DrawInfo + "." + e.X + "." + e.Y;
                    myGraphic.FillEllipse(myBrush, e.X, e.Y, Bsize, Bsize);

                }
            }
        }



        private void DrawBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                DrawBox.Parent.Invalidate(new Rectangle(DrawBox.Location, DrawBox.Size), true);
                px.Clear();
                py.Clear();
            }
            if (e.KeyCode == Keys.F2)
            {
                Box.Clear();
            }
            

        }

        

        private void DrawBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (onDraw == true)
            {
                isDraw = false;
                DrawInfo = DrawInfo + ".!.!.!";
                c.Send(DrawInfo);
                DrawInfo = "";
                count = 0;
            }
           
        }

        private void DrawBox_MouseDown(object sender, MouseEventArgs e)
        {

            if (onDraw == true)
            {
                isDraw = true;
                myBrush = new SolidBrush(Bcolor);
                String temp = System.Drawing.ColorTranslator.ToHtml(Bcolor);
                DrawInfo = "1" + "." + Bsize + "." + temp;
                //Bcolor = Color.Black;
            }
            else
            {
                Box.BringToFront();
            }
        }
        private void DrawBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                textBox1.Focus();
            }
        }
        private void ColorBox_MouseClick(object sender, MouseEventArgs e)
        {
            ChooseColor.ShowDialog();
            ColorBox.BackColor = ChooseColor.Color;
            Bcolor = ChooseColor.Color;
            textBox1.ForeColor = Bcolor;
            String temp = System.Drawing.ColorTranslator.ToHtml(Bcolor);
            c.Send("0." + Username + "已更改顏色為./cd." + temp+"."+Bcolor);
        }

    

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Bsize = trackBar1.Value;
            
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            Box.SelectionStart = Box.TextLength;
            Box.ScrollToCaret();
        }

        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
           
                textBox1.Focus();
            }
        }

        

        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                
                textBox1.Focus();
            }
        }

        private void Box_MouseClick(object sender, MouseEventArgs e)
        {
            //DrawBox.BringToFront();
            textBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
            onDraw = !onDraw;
            if (onDraw == true)
            {
                DrawBox.BringToFront();
                DrawBox.Focus();
                //for (int i = 0; i < px.Count; i++)
                //{
                  //  myGraphic.FillEllipse(myBrush, py[i], px[i], Bsize, Bsize);
                //}
                
            }
            else
            {
                DrawBox.Parent.Invalidate(new Rectangle(DrawBox.Location, DrawBox.Size), true);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            String temp = System.Drawing.ColorTranslator.ToHtml(Bcolor);
            c.Send("e.系統公告:." + Username + ".離開了!");
            c.Ct.Close();
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                textBox1.Clear();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                sendMsg();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("/nu"))
            {
                MessageBox.Show("內含非法指令!");
                textBox1.Clear();
            }
        }
        private void Shake()
        {

            for (int i = 0; i < 3; i++)
            {
                this.Top += 10;
                Thread.Sleep(50);
                this.Top -= 10;
                Thread.Sleep(50);
                this.Left += 10;
                Thread.Sleep(50);
                this.Left -= 10;
                Thread.Sleep(50);
            }
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            foreach (Object obj in UserBox.SelectedItems)
            {
                c.Send("/s." + obj.ToString()+"."+Username);
            }
        }*/

        private void UserBox_Click(object sender, EventArgs e)
        {
            //foreach(Object obj in UserBox.SelectedItems)
            //{
             //   c.Send("/s." + obj.ToString());
            //}
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void 戳一下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Object obj in UserBox.SelectedItems)
            {
                c.Send("/s." + obj.ToString() + "." + Username);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MLabel.Show();
            if (second == 50)
            {
                second = 0;
                MLabel.Hide();
                timer1.Stop();
            }
            else
            {
                
                second++;
                String temp = Marquee.Substring(0, 1);
                Marquee = Marquee.Substring(1, Marquee.Length - 1) + Marquee_temp.Substring(0, 1);
                Marquee_temp = Marquee_temp.Substring(1, Marquee_temp.Length - 1) + temp;
                
              
                MLabel.Text = Marquee;
            }
        }
        private void RunHorse()
        {
            timer1.Stop();
            MLabel.Text = "";
            //Box.AppendText(Marquee_test);
            timer1.Start();
        }

        private void 跑馬燈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input _in = new Input();
            _in.ShowDialog();
            if (_in.click == true)
            {
                c.Send("/t."+Username+": "+_in.GetStr());
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Object obj in UserBox.SelectedItems)
            {
                WF w = new WF(obj.ToString());
                w.ShowDialog();
                if(w.click==true)
                {
                    c.Send("/r." + obj.ToString()+"."+Username + "." + w.str);
                }
            }
        }
        private void WhisperComeIn(String n,String m)
        {
            Reply r = new Reply(n, m);
            r.ShowDialog();
            if(r.click==true)
            {
                WF w = new WF(n);
                w.ShowDialog();
                if (w.click == true)
                {
                    c.Send("/r." + n +"."+Username+ "." + w.str);
                }
            }
        }

        private void ColorBox_Click(object sender, EventArgs e)
        {

        }

        private void DrawBox_Load(object sender, EventArgs e)
        {

        }


               
        private void button2_Click(object sender, EventArgs e)
        {
            if (imgflag)
            {
                OpenFileDialog imageloader = new OpenFileDialog();
                imageloader.Title = "請選擇一張圖片";
                imageloader.Filter = "|*.jpg";
                if (imageloader.ShowDialog() == DialogResult.OK)
                {
                    data = ReadImageFile(imageloader.FileName);
                    WorkerToSend.RunWorkerAsync();
                }
            }
        }

       
        private static byte[] ReadImageFile(string img)
        {
            FileInfo fileinfo =new FileInfo(img);
            //byte[] buf=new byte[fileinfo.Length];
            byte[] buf=new byte[fileinfo.Length];
            
            FileStream fs=new FileStream (img,FileMode.Open,FileAccess.Read);
             
            fs.Read(buf,0,buf.Length);
            fs.Close();
            
            GC.ReRegisterForFinalize(fileinfo);
            GC.ReRegisterForFinalize(fs);



            return buf;
        }

        int countl = 0;

        private void ShowPic(byte[] by,int mode)
        {
            if (imgflag == true)
            {
                countl++;
                if (mode == 1)
                {
                    //p.Show();
                    p.setImg(by);

                }
                else
                {

                    
                    String str = Encoding.UTF8.GetString(by);
                    String[] word = str.Split('.');
                    if (!b.CheckList(word[1]))
                    {
                        Console.Beep();
                        p.ShowName(word[1]);
                        p.ShowImg(num);

                        p.ShowDialog();
                        p.Dispose();
                        num++;
                    }
                    p = new PicShow();


                }
            }
            //button2.Text = countl.ToString();
        }


         public void processImgComeIn(byte[] img,int mode)
        {
            this.Invoke(imgHandler, new Object[] { img ,mode});
         }



         byte[] data;
         private void WorkerToSend_DoWork(object sender, DoWorkEventArgs e)
         {
             //byte[] data = ReadImageFile(Application.StartupPath + "\\1.jpg");
             //utton2.Text = data.Length.ToString();
             int dot = 1;
             int index = 0;
          
             //System.Threading.Thread sf = new System.Threading.Thread(SetSendFlag);

             while (index < data.Length)
             {

                 sendFlag = false;

                 int j;
                 if (data.Length - index < 8000)
                 {
                     j = data.Length - index;
                 }
                 else
                 {
                     j = 8000;
                 }
                 byte[] newdata = new byte[j + 3];
                 newdata[0] = Convert.ToByte('/');
                 newdata[1] = Convert.ToByte('i');
                 newdata[2] = Convert.ToByte('.');
                 for (int i = 0; i < j; i++)
                 {
                     newdata[i + 3] = data[index + i];
                 }
                 c.Send(newdata);
                 index += j;
                 string temp="";
                 for (int i = 0; i < dot;i++ )
                 {
                     temp += ".";
                 }
                 this.Invoke(new MethodInvoker(delegate() { this.Text = "圖片傳送中"+temp; }));
                 dot++;
                 if (dot == 4)
                     dot = 0;
                 Thread.Sleep(50);
             }



             c.Send("/f."+Username);
             this.Invoke(new MethodInvoker(delegate() { this.Text = Username+"-塗鴉聊天室"; }));
             sendFlag = true;
             WorkerToSend.WorkerSupportsCancellation = true;
             WorkerToSend.CancelAsync();
         }

         private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
         {
              if(  s.ShowDialog()==DialogResult.OK)
              {

                  if (Bcolor != s.C)
                  {
                      Bcolor = s.C;
                      textBox1.ForeColor = Bcolor;
                      String temp = System.Drawing.ColorTranslator.ToHtml(Bcolor);
                      c.Send("0." + Username + "已更改顏色為./cd." + temp + "." + Bcolor);
                  }
                  Bsize = s.size;
                  imgflag = s.TFImg;
                  p5flag = s.TFGame;             
                  whsflag = s.TFWsp;
                  pokeflag = s.TFPk;
                  //onDraw = s.TFDraw;
                  
              }
         }

         private void toolStripDropDownButton1_Click(object sender, EventArgs e)
         {
             

         }

         private void UserBox_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void 傳送圖片ToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (imgflag)
             {
                 OpenFileDialog imageloader = new OpenFileDialog();
                 imageloader.Title = "請選擇一張圖片";
                 imageloader.Filter = "|*.jpg";
                 if (imageloader.ShowDialog() == DialogResult.OK)
                 {
                     data = ReadImageFile(imageloader.FileName);
                     WorkerToSend.RunWorkerAsync();
                 }
             }
             else
             {
                 MessageBox.Show("尚有圖片傳送中!");
             }
         }

         private void MLabel_Click(object sender, EventArgs e)
         {

         }

         private void 黑名單ToolStripMenuItem_Click(object sender, EventArgs e)
         {
             foreach (Object obj in UserBox.SelectedItems)
             {
                 if(!b.Black.Contains(obj.ToString()))
                 {
                     if (obj.ToString() != Username)
                     {
                         b.Black.Add(obj.ToString());
                         MessageBox.Show("將" + obj.ToString() + "加入黑名單!");
                     }
                 }
             }
         }

         private void toolStripMenuItem2_Click(object sender, EventArgs e)
         {
             b.ShowList();
             b.ShowDialog();
         }

         private void 解除黑名單ToolStripMenuItem_Click(object sender, EventArgs e)
         {
             foreach (Object obj in UserBox.SelectedItems)
             {
                 if (b.Black.Contains(obj.ToString()))
                 {
                     if (obj.ToString() != Username)
                     {
                         b.Black.Remove(obj.ToString());
                         MessageBox.Show("將" + obj.ToString() + "解除黑名單!");
                     }
                 }
             }
         }

         private void 邀請下棋ToolStripMenuItem_Click(object sender, EventArgs e)
         {

             foreach (Object obj in UserBox.SelectedItems)
             {
                 if (obj.ToString() != Username)
                 {
                     if (MessageBox.Show("確定要向玩家" + obj.ToString() + "發出挑戰", "五子棋", MessageBoxButtons.OKCancel) == DialogResult.OK)
                     {
                         c.Send("5p." + obj.ToString() + ".0." + Username + "." + _5pW.ToString() + "." + _5pL.ToString() + "." + _5pD.ToString() + ".");
                     }
                 }
                 else
                 {
                     MessageBox.Show("無法跟自己下棋！");
                 }
             }
             
         }
         public void GomokuSend(String temp)
         {
             c.Send(temp);
         }
         private void Game5p_DoWork(object sender, DoWorkEventArgs e)
         {
             //_5pGame = new Gomoku();
         }
         


        


        

      

      
       
      
    }
}
