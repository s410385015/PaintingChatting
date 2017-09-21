using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace NewProject
{
    
    public delegate String StrHandler(String str);
    class UserData
    {
        public Socket Sk;
        public Byte[] Data=new Byte[1024*1024];
        public void SetSk(Socket s){Sk=s;}
    }
    class Server
    {
        private Socket Sr;
        private int Port = 777;
        private List<UserData> UserList=new List<UserData>();
        public void Setup()
        {
            Sr = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint Ep = new IPEndPoint(IPAddress.Any, Port);
            Sr.Bind(Ep);
            Sr.Listen(10);
            Sr.BeginAccept(StartConnect, null);

        }
        private void StartConnect(IAsyncResult r)
        {
            Socket newSock=Sr.EndAccept(r);
            Sr.BeginAccept(StartConnect,null);
            UserData client=new UserData();
            client.SetSk(newSock);
            UserList.Add(client);
            client.Sk.BeginReceive(client.Data, 0, 2048 * 4, SocketFlags.None, EndRecv, client);

        }
        private void EndRecv(IAsyncResult r)
        {
            UserData client = (UserData)r.AsyncState;
            int len = client.Sk.EndReceive(r);
            
            if(len>0)
            {
                
                String str = Encoding.UTF8.GetString(client.Data, 0, len);
                foreach (UserData x in UserList)
                {
                    Send(x.Sk, str);
                }
            }
            else
            {
                UserList.Remove(client);
                //foreach (UserData x in UserList)
                //{
                  //  Send(x.Sk, "有人結束連線了!");
                //}
               
            }
        }
        private void Send(Socket Sk,String str)
        {
            Byte[] buffer = Encoding.UTF8.GetBytes(str);
            Sk.BeginSend(buffer,0,buffer.Length,SocketFlags.None,EndSend,Sk);
        }
        private void EndSend(IAsyncResult r)
        {
            ((Socket)r.AsyncState) . EndSend(r);
        }

    }

    class Client
    {
        public Socket Ct;
        private Byte[] Data=new Byte[2048*4];
        private StrHandler inHandler;
        private StrHandler inControl;
        private Img inImg;
        private List<String> UserName = new List<String>();

         //public delegate void Img(byte[] by);
        public void Setup(String ip,int port)
        {
            Ct=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            try
            {
                Ct.Connect(ip, port);
                
            }
            catch
            {
                //MessageBox.Show("連線異常！");
               
            }
        }
        public void Recv(StrHandler h,StrHandler c,Img i)
        {
            inHandler = h;
            inControl = c;
            inImg = i;
            try
            {
                Ct.BeginReceive(Data, 0, 1024*8, SocketFlags.None, EndRecv, null);
            }
            catch
            {
                
            }
        }
        private void EndRecv(IAsyncResult r)
        {   

            try
            {
                int len = Ct.EndReceive(r);
                String temp = Encoding.UTF8.GetString(Data, 0, len);
                String[] Word = temp.Split('.');
                if(Word[0]=="1")
                {
                    inControl(temp);
                    Ct.BeginReceive(Data, 0, 1024 * 8, SocketFlags.None, EndRecv, null);
                }
                else if (Word[0] == "/i" || Word[0] == "/f")
                {
                    //Ct.BeginReceive(Data, 0, 1024 * 8, SocketFlags.None, EndRecv, null);
                    //MessageBox.Show(len.ToString());
                    byte[] newdata = new byte[len];

                    for (int i = 0; i < len; i++)
                        newdata[i] = Data[i];
                    Ct.BeginReceive(Data, 0, 1024 * 8, SocketFlags.None, EndRecv, null);
                   if(Word[0]=="/i")
                       inImg(newdata,1);
                   else
                       inImg(newdata, 2);
                   
                   
                }
                else{
                    inHandler(temp);
                    Ct.BeginReceive(Data, 0, 1024 * 8, SocketFlags.None, EndRecv, null);
                }
                
            }
            catch { 
                
            }

        }
       
        public void Send(String str)
        {
            Byte[] buffer = Encoding.UTF8.GetBytes(str);
            try
            {
                Ct.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, EndSend, Ct);
            }
            catch
            {

            }
            //Ct.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }
        public void Send(byte[] b)
        {
            try
            {
                Ct.BeginSend(b, 0, b.Length, SocketFlags.None, EndSend, Ct);
            }
            catch
            {

            }
        }
        private void EndSend(IAsyncResult r)
        {
            try
            {
                Ct.EndSend(r);
            }
            catch
            {

            }
        }
    }
    
}
