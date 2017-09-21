using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Test_S
{
    struct AccountData
    {
        string account;
        string password;
        string username;
    }
    class AccountOP
    {
        private AccountData[] aList = new AccountData[256];
        int inedex = 0;
        void SetUp()
        {
             
        }
    }
}