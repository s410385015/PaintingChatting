using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Test_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Server test = new Server();
            test.Setup();

            Console.WriteLine("伺服器架設成功!");
            while (true) { };
        }
    }
    class UserData
    {
        public Socket Sk;
        public Byte[] Data = new Byte[1024*1024];
        public String name="User";
        public void SetSk(Socket s) { Sk = s; }
    }
    class Server
    {
        private Socket Sr;
        private int Port = 777;
        int index = 0;
        byte[] newdata = new byte[1024 * 1024];
        private List<UserData> UserList = new List<UserData>();
        public void Setup()
        {
            Sr = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint Ep = new IPEndPoint(IPAddress.Any, Port);
            Sr.Bind(Ep);
            Sr.Listen(10);
            Sr.BeginAccept(StartConnect, null);

        }
        private String GetAllUser()
        {
            String temp = "/nu";
     
            foreach (UserData x in UserList)
            {
                if(x.name!="User"&&x.name!=" ")
                    temp += "."+x.name ;
            }
            
                return temp;
           
        }
        private void StartConnect(IAsyncResult r)
        {
            Socket newSock = Sr.EndAccept(r);
            
            Sr.BeginAccept(StartConnect, null);

            UserData client = new UserData();
            //Console.WriteLine("Here" + GetAllUser());
            if (UserList.Count > 0)
            {
                Console.WriteLine("Get");
                Send(newSock, GetAllUser());
            }
            else
            {
                Console.WriteLine("Get");
                 Send(newSock, "/nu.User");
            
            }
            client.SetSk(newSock);
            UserList.Add(client);
            client.Sk.BeginReceive(client.Data, 0, 1024*8, SocketFlags.None, EndRecv, client);

        }

        private void SetImg(byte[] by,int len)
        {
            for (int i = 3; i < len; i++)
                newdata[index + i - 3] = by[i];
            index += len - 3;
        }
        private void SendImg()
        {
            int len = 0;
            while (len < index)
            {
              
                int j;
                if (index - len < 4096)
                {
                    j = index - len;
                }
                else
                {
                    j = 4096;
                }
                byte[] data = new byte[j + 3];
                data[0] = Convert.ToByte('/');
                data[1] = Convert.ToByte('i');
                data[2] = Convert.ToByte('.');
                for (int i = 0; i < j; i++)
                {
                    data[i + 3] = newdata[index + i];
                }
                foreach (UserData x in UserList)
                {

                    Send(x.Sk,data);

                }
               
                index += j;
                Thread.Sleep(100);
            }


            foreach (UserData x in UserList)
            {

                Send(x.Sk, "/f.");

            }
          
        }

        private void EndRecv(IAsyncResult r)
        {
            UserData client = (UserData)r.AsyncState;
            try{
                 int len = client.Sk.EndReceive(r);
                 if (len > 0)
                 {
                    bool flag = true;
                    String str = Encoding.UTF8.GetString(client.Data, 0, len);
                    String[] Words = str.Split('.');
                    //Console.WriteLine(str);
                    //Console.WriteLine(len.ToString());
                    if (Words[0] == "e")
                    {
                        //str = str.Substring(2, str.Length - 1);
                        UserList.Remove(client);
                     
                    }
                    else if(Words[0]=="/i"||Words[0]=="/f")
                    {
                       
                        byte[] temp = new byte[len];
                       
                        Console.WriteLine(temp.Length);


                        for (int i = 0; i < len; i++)
                             temp[i] = client.Data[i];
                      
                        
                        foreach (UserData x in UserList)
                        {
                           
                              Send(x.Sk,temp);
                            
                        }
                        
                        flag = false;
                        //Thread.Sleep(100);
                    }
                    else if (Words[0]=="/nu")
                    {
                 
                        String[] n = str.Split('.');
                        client.name = n[1];
        
                       
                    }
                    else if(Words[0]=="/s"||Words[0]=="/r"||Words[0]=="5p")
                    {
                        foreach (UserData x in UserList)
                        {
                            if(x.name==Words[1]){
                                Console.WriteLine(client.name+" give: "+x.name+" " + str);
                                Send(x.Sk, str);
                            }
                        }
                        flag=false;
                    }
                    if (flag == true)
                    {
                        foreach (UserData x in UserList)
                        {
                            //Console.WriteLine("T");
                            Console.WriteLine(x.name+":"+ str);
                            Send(x.Sk, str);
                        }
                    }

                    client.Sk.BeginReceive(client.Data, 0, 1024 * 8, SocketFlags.None, EndRecv, client);
                }
                
            }
            catch
            {
           
                UserList.Remove(client); 
                client.Sk.Close();
                Console.WriteLine("Lost"); 
                //foreach (UserData x in UserList)
                //{
                //    Send(x.Sk, "有人結束連線了!");
               // }

            }
        }
        private void Send(Socket Sk, String str)
        {
            Byte[] buffer = Encoding.UTF8.GetBytes(str);
            Sk.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, EndSend, Sk);
        }

        private void Send(Socket Sk, byte[] b)
        {
            
            Sk.BeginSend(b, 0, b.Length, SocketFlags.None, EndSend, Sk);
        }
        private void EndSend(IAsyncResult r)
        {
            ((Socket)r.AsyncState).EndSend(r);
        }

    }

}
